﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

// ReSharper disable CheckNamespace
namespace FancyMouse.WindowsHotKeys.Interop;
// ReSharper restore CheckNamespace

internal static partial class User32
{

    /// <summary>
    /// Posts a message to the message queue of the specified thread. It returns without waiting for the thread to process the message.
    /// </summary>
    /// <param name="idThread">The identifier of the thread to which the message is to be posted.</param>
    /// <param name="Msg">The type of message to be posted.</param>
    /// <param name="wParam">Additional message-specific information.</param>
    /// <param name="lParam">Additional message-specific information.</param>
    /// <returns>
    /// If the function succeeds, the return value is nonzero.
    /// If the function fails, the return value is zero.
    /// To get extended error information, call GetLastError.GetLastError returns ERROR_INVALID_THREAD_ID
    /// if idThread is not a valid thread identifier, or if the thread specified by idThread does not have
    /// a message queue.GetLastError returns ERROR_NOT_ENOUGH_QUOTA when the message limit is hit.
    /// </returns>
    /// <remarks>
    /// See https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-postmessagew
    /// </remarks>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [LibraryImport(Libraries.User32, StringMarshalling = StringMarshalling.Utf16, SetLastError = true)]
    public static partial int PostThreadMessageW(
        int idThread,
        WindowMessages Msg,
        IntPtr wParam,
        IntPtr lParam
    );

}
