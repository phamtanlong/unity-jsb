#pragma once

#include "QuickJSCompatible.h"

class WSServer
{
public:
	virtual void Update() = 0;
	virtual ~WSServer() {}

	static WSServer* CreateDebugServer(JSContext* ctx, int port);
};