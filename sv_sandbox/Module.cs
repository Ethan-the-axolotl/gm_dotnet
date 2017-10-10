﻿using GSharp;
using GSharp.Generated.NativeClasses;
using GSharp.GLuaNET;
using GSharp.Native;
using GSharp.Native.Classes;
using GSharp.Native.Classes.VCR;
using Libraria.Native;
using RGiesecke.DllExport;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace sv_sandbox
{
    public unsafe static class Module
    {
        [DllExport("gmod13_open", CallingConvention = CallingConvention.Cdecl)]
        public static int Open(lua_State L)
        {
            var luabase = JIT.ConvertInstance<ILuaBase>(L.luabase);
            luabase.ThrowError("error throwing");

            Console.WriteLine("DotNet loaded");
            return 0;
        }

        [DllExport("gmod13_close", CallingConvention = CallingConvention.Cdecl)]
        public static int Close(IntPtr L)
        {
            return 0;
        }
    }
}