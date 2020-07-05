// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//


using System;
using System.Runtime.CompilerServices;
public class BringUpTest
{
    const int Pass = 100;
    const int Fail = -1;

    [MethodImplAttribute(MethodImplOptions.NoInlining)]
    public static int Args4(int a, int b, int c, int d)
    {
        return a+b+c+d;
    }

    public static int Main()
    {
        int y = Args4(1,2,3,4);
        if (y == 10) return Pass;
        else return Fail;
    }
}
