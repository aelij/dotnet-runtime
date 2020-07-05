// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.ComponentModel.Composition.Extensibility
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class CustomImportAttribute : ImportAttribute
    {
        public CustomImportAttribute()
        {
        }

        public CustomImportAttribute(Type type)
            : base(type)
        {
        }
    }
}
