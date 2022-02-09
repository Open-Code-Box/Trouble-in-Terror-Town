// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Function prototype definition for notifications that come from <see cref="SessionsInterface.AddNotifyJoinSessionAccepted" />
	/// <seealso cref="SessionsInterface.CopySessionHandleByUiEventId" />
	/// <seealso cref="SessionsInterface.JoinSession" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="JoinSessionAcceptedCallbackInfo" /> containing the output information and result
	/// @note The session for the join game must be joined.
	/// </param>
	public delegate void OnJoinSessionAcceptedCallback(JoinSessionAcceptedCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnJoinSessionAcceptedCallbackInternal(System.IntPtr data);
}