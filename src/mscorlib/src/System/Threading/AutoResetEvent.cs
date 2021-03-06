// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//
/*=============================================================================
**
**
**
** Purpose: An example of a WaitHandle class
**
**
=============================================================================*/
namespace System.Threading {
    
    using System;
    using System.Security.Permissions;
    using System.Runtime.InteropServices;

    [System.Runtime.InteropServices.ComVisible(true)]
    public sealed class AutoResetEvent : EventWaitHandle
    {
        public AutoResetEvent(bool initialState) : base(initialState,EventResetMode.AutoReset){ }
    }
}
    
