﻿using System.Diagnostics.CodeAnalysis;

// ReSharper disable CheckNamespace
namespace FancyMouse.WindowsHotKeys.Interop;
// ReSharper restore CheckNamespace

internal static partial class User32
{

    /// <summary>
    /// </summary>
    /// <remarks>
    /// See https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey
    /// </remarks>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [Flags]
    public enum RegisterHotKeyModifiers : uint
    {

        /// <summary>
        /// Either ALT key must be held down.
        /// </summary>
        MOD_ALT = 0x0001,

        /// <summary>
        /// Either CTRL key must be held down.
        /// </summary>
        MOD_CONTROL = 0x0002,

        /// <summary>
        /// Changes the hotkey behavior so that the keyboard auto-repeat does not yield multiple hotkey notifications.
        /// </summary>
        MOD_NOREPEAT = 0x4000,

        /// <summary>
        /// Either SHIFT key must be held down.
        /// </summary>
        MOD_SHIFT = 0x0004,

        /// <summary>
        /// Either WINDOWS key was held down.
        /// These keys are labeled with the Windows logo.
        /// Keyboard shortcuts that involve the WINDOWS key are reserved for use by the operating system.
        /// </summary>
        MOD_WIN = 0x0008


    }

}
