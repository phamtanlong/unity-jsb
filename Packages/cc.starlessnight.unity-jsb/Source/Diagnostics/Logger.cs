using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace QuickJS.Diagnostics
{
    public static class Logger
    {
        public static LogChannel Default => GetChannel("Default");
        public static LogChannel UI => GetChannel("UI");
        public static LogChannel Core => GetChannel("Core");

        private static ReaderWriterLockSlim _channelsLock = new ReaderWriterLockSlim();
        private static ELogSeverity _severity = ELogSeverity.All;
        private static Dictionary<string, LogChannel> _channels = new Dictionary<string, LogChannel>();
        private static ILogHandler _handler = new UnityLogHandler();

        public static ILogHandler handler { get => _handler; set => _handler = value; }

        public static bool GetSeverityEnabled(ELogSeverity severity) => (_severity | severity) != 0;

        public static void SetSeverityEnabled(ELogSeverity severity, bool state) => _severity = state ? _severity | severity : _severity & ~severity;

        public static LogChannel GetChannel<T>()
        {
            return GetChannel(typeof(T).Name);
        }

        public static LogChannel[] GetAllChannels()
        {
            _channelsLock.EnterReadLock();
            var buff = new LogChannel[_channels.Count];
            _channels.Values.CopyTo(buff, 0);
            _channelsLock.ExitReadLock();
            return buff;
        }

        public static LogChannel GetChannel(string name)
        {
            if (string.IsNullOrEmpty(name)) return Default;
            try
            {
                _channelsLock.EnterUpgradeableReadLock();
                if (_channels.TryGetValue(name, out var channel))
                {
                    return channel;
                }

                channel = new LogChannel(name);
                _channelsLock.EnterWriteLock();
                _channels.Add(name, channel);
                _channelsLock.ExitWriteLock();
                return channel;
            }
            finally
            {
                _channelsLock.ExitUpgradeableReadLock();
            }
        }

        public static void Write(ELogSeverity severity, string channel, string text)
        {
            if ((severity & _severity) == 0 || _handler == null) return;
            _handler.Write(severity, channel, text);
        }

        public static void Write(ELogSeverity severity, string channel, string fmt, params object[] args)
        {
            if ((severity & _severity) == 0 || _handler == null) return;
            _handler.Write(severity, channel, fmt, args);
        }
    }
}