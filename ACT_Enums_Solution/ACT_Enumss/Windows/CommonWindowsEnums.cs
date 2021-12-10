namespace ACT.Enums.Windows
{
    [Flags]
    public enum ScmAccessRights
    {
        Connect = 1,
        CreateService = 2,
        EnumerateService = 4,
        Lock = 8,
        QueryLockStatus = 16, // 0x00000010
        ModifyBootConfig = 32, // 0x00000020
        StandardRightsRequired = 983040, // 0x000F0000
        AllAccess = StandardRightsRequired | ModifyBootConfig | QueryLockStatus | Lock | EnumerateService | CreateService | Connect // 0x000F003F
    }

    /// The SECURITY_IMPERSONATION_LEVEL enumeration type contains values
    /// that specify security impersonation levels. Security impersonation
    /// levels govern the degree to which a server process can act on behalf
    /// of a client process.
    /// </summary>
    public enum SECURITY_IMPERSONATION_LEVEL
    {
        SecurityAnonymous,
        SecurityIdentification,
        SecurityImpersonation,
        SecurityDelegation,
    }

    public enum ServiceBootFlag
    {
        Start,
        SystemStart,
        AutoStart,
        DemandStart,
        Disabled,
    }

    public enum ServiceControl
    {
        Stop = 1,
        Pause = 2,
        Continue = 3,
        Interrogate = 4,
        Shutdown = 5,
        ParamChange = 6,
        NetBindAdd = 7,
        NetBindRemove = 8,
        NetBindEnable = 9,
        NetBindDisable = 10, // 0x0000000A
    }

    public enum ServiceError
    {
        Ignore,
        Normal,
        Severe,
        Critical,
    }

    public enum ServiceState
    {
        Unknown = -1, // 0xFFFFFFFF
        NotFound = 0,
        Stopped = 1,
        StartPending = 2,
        StopPending = 3,
        Running = 4,
        ContinuePending = 5,
        PausePending = 6,
        Paused = 7,
    }

    /// <summary>
    /// The TOKEN_ELEVATION_TYPE enumeration indicates the elevation type of
    /// token being queried by the GetTokenInformation function or set by
    /// the SetTokenInformation function.
    /// </summary>
    public enum TOKEN_ELEVATION_TYPE
    {
        TokenElevationTypeDefault = 1,
        TokenElevationTypeFull = 2,
        TokenElevationTypeLimited = 3,
    }

    /// <summary>
    /// The TOKEN_INFORMATION_CLASS enumeration type contains values that
    /// specify the type of information being assigned to or retrieved from
    /// an access token.
    /// </summary>
    public enum TOKEN_INFORMATION_CLASS
    {
        TokenUser = 1,
        TokenGroups = 2,
        TokenPrivileges = 3,
        TokenOwner = 4,
        TokenPrimaryGroup = 5,
        TokenDefaultDacl = 6,
        TokenSource = 7,
        TokenType = 8,
        TokenImpersonationLevel = 9,
        TokenStatistics = 10, // 0x0000000A
        TokenRestrictedSids = 11, // 0x0000000B
        TokenSessionId = 12, // 0x0000000C
        TokenGroupsAndPrivileges = 13, // 0x0000000D
        TokenSessionReference = 14, // 0x0000000E
        TokenSandBoxInert = 15, // 0x0000000F
        TokenAuditPolicy = 16, // 0x00000010
        TokenOrigin = 17, // 0x00000011
        TokenElevationType = 18, // 0x00000012
        TokenLinkedToken = 19, // 0x00000013
        TokenElevation = 20, // 0x00000014
        TokenHasRestrictions = 21, // 0x00000015
        TokenAccessInformation = 22, // 0x00000016
        TokenVirtualizationAllowed = 23, // 0x00000017
        TokenVirtualizationEnabled = 24, // 0x00000018
        TokenIntegrityLevel = 25, // 0x00000019
        TokenUIAccess = 26, // 0x0000001A
        TokenMandatoryPolicy = 27, // 0x0000001B
        TokenLogonSid = 28, // 0x0000001C
        MaxTokenInfoClass = 29, // 0x0000001D
    }

    /// <summary>
    /// The WELL_KNOWN_SID_TYPE enumeration type is a list of commonly used
    /// security identifiers (SIDs). Programs can pass these values to the
    /// CreateWellKnownSid function to create a SID from this list.
    /// </summary>
    public enum WELL_KNOWN_SID_TYPE
    {
        WinNullSid,
        WinWorldSid,
        WinLocalSid,
        WinCreatorOwnerSid,
        WinCreatorGroupSid,
        WinCreatorOwnerServerSid,
        WinCreatorGroupServerSid,
        WinNtAuthoritySid,
        WinDialupSid,
        WinNetworkSid,
        WinBatchSid,
        WinInteractiveSid,
        WinServiceSid,
        WinAnonymousSid,
        WinProxySid,
        WinEnterpriseControllersSid,
        WinSelfSid,
        WinAuthenticatedUserSid,
        WinRestrictedCodeSid,
        WinTerminalServerSid,
        WinRemoteLogonIdSid,
        WinLogonIdsSid,
        WinLocalSystemSid,
        WinLocalServiceSid,
        WinNetworkServiceSid,
        WinBuiltinDomainSid,
        WinBuiltinAdministratorsSid,
        WinBuiltinUsersSid,
        WinBuiltinGuestsSid,
        WinBuiltinPowerUsersSid,
        WinBuiltinAccountOperatorsSid,
        WinBuiltinSystemOperatorsSid,
        WinBuiltinPrintOperatorsSid,
        WinBuiltinBackupOperatorsSid,
        WinBuiltinReplicatorSid,
        WinBuiltinPreWindows2000CompatibleAccessSid,
        WinBuiltinRemoteDesktopUsersSid,
        WinBuiltinNetworkConfigurationOperatorsSid,
        WinAccountAdministratorSid,
        WinAccountGuestSid,
        WinAccountKrbtgtSid,
        WinAccountDomainAdminsSid,
        WinAccountDomainUsersSid,
        WinAccountDomainGuestsSid,
        WinAccountComputersSid,
        WinAccountControllersSid,
        WinAccountCertAdminsSid,
        WinAccountSchemaAdminsSid,
        WinAccountEnterpriseAdminsSid,
        WinAccountPolicyAdminsSid,
        WinAccountRasAndIasServersSid,
        WinNTLMAuthenticationSid,
        WinDigestAuthenticationSid,
        WinSChannelAuthenticationSid,
        WinThisOrganizationSid,
        WinOtherOrganizationSid,
        WinBuiltinIncomingForestTrustBuildersSid,
        WinBuiltinPerfMonitoringUsersSid,
        WinBuiltinPerfLoggingUsersSid,
        WinBuiltinAuthorizationAccessSid,
        WinBuiltinTerminalServerLicenseServersSid,
        WinBuiltinDCOMUsersSid,
        WinBuiltinIUsersSid,
        WinIUserSid,
        WinBuiltinCryptoOperatorsSid,
        WinUntrustedLabelSid,
        WinLowLabelSid,
        WinMediumLabelSid,
        WinHighLabelSid,
        WinSystemLabelSid,
        WinWriteRestrictedCodeSid,
        WinCreatorOwnerRightsSid,
        WinCacheablePrincipalsGroupSid,
        WinNonCacheablePrincipalsGroupSid,
        WinEnterpriseReadonlyControllersSid,
        WinAccountReadonlyControllersSid,
        WinBuiltinEventLogReadersGroup,
        WinNewEnterpriseReadonlyControllersSid,
        WinBuiltinCertSvcDComAccessGroup,
    }
}
