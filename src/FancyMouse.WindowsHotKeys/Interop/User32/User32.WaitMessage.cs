﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

// ReSharper disable CheckNamespace
namespace FancyMouse.WindowsHotKeys.Interop;
// ReSharper restore CheckNamespace

internal static partial class User32
{

    /// <summary>
    /// Yields control to other threads when a thread has no other messages in its message queue.
    /// The WaitMessage function suspends the thread and does not return until a new message is placed in the thread's message queue.
    /// </summary>
    /// <returns>
    /// If the function succeeds, the return value is nonzero.
    /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
    /// </returns>
    /// <remarks>
    /// See https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-waitmessage
    /// </remarks>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [LibraryImport(Libraries.User32, SetLastError = true)]
    public static partial int WaitMessage();

}
