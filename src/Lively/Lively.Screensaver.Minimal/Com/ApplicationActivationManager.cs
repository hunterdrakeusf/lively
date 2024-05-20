﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Ref: https://github.com/microsoft/PowerToys/blob/main/src/modules/launcher/Plugins/Microsoft.Plugin.Program/Programs/ApplicationActivationManager.cs
namespace Lively.Screensaver.Minimal.Com
{
    [ComImport]
    [Guid("45BA127D-10A8-46EA-8AB7-56EA9078943C")]
    internal class ApplicationActivationManager : IApplicationActivationManager
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)/*, PreserveSig*/]
        public extern IntPtr ActivateApplication([In] string appUserModelId, [In] string arguments, [In] ActivateOptions options, [Out] out uint processId);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern IntPtr ActivateForFile([In] string appUserModelId, [In] IntPtr /*IShellItemArray* */ itemArray, [In] string verb, [Out] out uint processId);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern IntPtr ActivateForProtocol([In] string appUserModelId, [In] IntPtr /* IShellItemArray* */itemArray, [Out] out uint processId);
    }
}
