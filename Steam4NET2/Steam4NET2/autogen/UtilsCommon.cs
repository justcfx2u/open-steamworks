// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum ESteamAPICallFailure : int
	{
		k_ESteamAPICallFailureNone = -1,
		k_ESteamAPICallFailureSteamGone = 0,
		k_ESteamAPICallFailureNetworkFailure = 1,
		k_ESteamAPICallFailureInvalidHandle = 2,
		k_ESteamAPICallFailureMismatchedCallback = 3,
	};
	
	public enum EConfigStore : int
	{
		k_EConfigStoreInvalid = 0,
		k_EConfigStoreInstall = 1,
		k_EConfigStoreUserRoaming = 2,
		k_EConfigStoreUserLocal = 3,
		k_EConfigStoreMax = 4,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(701)]
	public struct IPCountry_t
	{
		public const int k_iCallback = 701;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(702)]
	public struct LowBatteryPower_t
	{
		public const int k_iCallback = 702;
		public Byte m_nMinutesBatteryLeft;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(703)]
	public struct SteamAPICallCompleted_t
	{
		public const int k_iCallback = 703;
		public UInt64 m_hAsyncCall;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(704)]
	public struct SteamShutdown_t
	{
		public const int k_iCallback = 704;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(711)]
	public struct SteamConfigStoreChanged_t
	{
		public const int k_iCallback = 711;
		public EConfigStore m_eConfigStore;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szRootOfChanges;
	};
	
	public enum ECheckFileSignature : int
	{
		k_ECheckFileSignatureInvalidSignature = 0,
		k_ECheckFileSignatureValidSignature = 1,
		k_ECheckFileSignatureFileNotFound = 2,
		k_ECheckFileSignatureNoSignaturesFoundForThisApp = 3,
		k_ECheckFileSignatureNoSignaturesFoundForThisFile = 4,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(705)]
	public struct CheckFileSignature_t
	{
		public const int k_iCallback = 705;
		public ECheckFileSignature m_eCheckFileSignature;
	};
	
}