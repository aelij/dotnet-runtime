// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.ComponentModel.Design
{
    /// <summary>
    /// Declares a callback function to create an instance of a service on demand.
    /// </summary>
    public delegate object ServiceCreatorCallback(IServiceContainer container, Type serviceType);
}
