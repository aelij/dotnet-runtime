// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class SspiCli
    {
        internal enum KERB_LOGON_SUBMIT_TYPE : int
        {
            KerbS4ULogon = 12,
        }
    }
}
