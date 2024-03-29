﻿namespace ACT.Core.Enums.Security

{
   ///// <summary>
   ///// Defines Basic Access Levels
   ///// </summary>
   //[Flags]
   //public enum Access_Level
   //{
   //    Read,
   //    Read_Others,
   //    Write,
   //    Write_Others,
   //    Modify,
   //    Modify_Others,
   //    Custom,
   //    Create,
   //    Delete,
   //    Delete_Others
   //}

   /// <summary>
   /// List of Available Hash Types
   /// </summary>
   public enum Hash_Type
   {
      SHA512,
      SHA384,
      SHA256,
      SHA1,
      MD5,
   }

   /// <summary>
   /// Defines Permission Levels Without Database Access.
   /// </summary>
   [Flags]
   public enum Permission_Level
   {
      Read,
      Write,
      Modify,
      Delete,
      ReadSelf,
      ModifySelf,
      DeleteSelf,
      ReadOther,
      ModifyOther,
      DeleteOther
      /*OLD CODE
            Read = 0,
      Write = 1,
      Modify = 2,
      Delete = Modify | Write, // 0x00000003
      ReadSelf = 4,
      ModifySelf = ReadSelf | Write, // 0x00000005
      DeleteSelf = ReadSelf | Modify, // 0x00000006
      ReadOther = DeleteSelf | Write, // 0x00000007
      ModifyOther = 8,
      DeleteOther = ModifyOther | Write, // 0x00000009
       */
   }

   /// <summary>
   /// The security Difficulty of the process    
   /// </summary>
   [Flags]
   public enum Security_Difficulty
   {
      Length_Easy,
      Length_Medium,
      Length_Hard,
      Length_Impossible,
      Length_GalaxySize,
      Length_UniverseSize,
      Characters_AlphaLower,
      Characters_AlphaUpper,
      Characters_AlphaLowerUpper,
      Characters_Special,
      Phrase_Dictionary,
      Phrase_Songs,
      Phrase_Nonsense

      /*OLD CODE
        Length_Easy = 0,
      Length_Medium = 1,
      Length_Hard = 2,
      Length_Impossible = Length_Hard | Length_Medium, // 0x00000003
      Length_GalaxySize = 4,
      Length_UniverseSize = Length_GalaxySize | Length_Medium, // 0x00000005
      Characters_AlphaLower = Length_GalaxySize | Length_Hard, // 0x00000006
      Characters_AlphaUpper = Characters_AlphaLower | Length_Medium, // 0x00000007
      Characters_AlphaLowerUpper = 8,
      Characters_Special = Characters_AlphaLowerUpper | Length_Medium, // 0x00000009
      Phrase_Dictionary = Characters_AlphaLowerUpper | Length_Hard, // 0x0000000A
      Phrase_Songs = Phrase_Dictionary | Length_Medium, // 0x0000000B
      Phrase_Nonsense = Characters_AlphaLowerUpper | Length_GalaxySize, // 0x0000000C
       */
   }

   /// <summary>
   /// Security Provider Generic Result
   /// </summary>    
   [Flags]
   public enum Security_Provider_Generic_Result
   {
      EmailAddressRegisteredAlready,
      UserNameTaken,
      PasswordComplexityInvalid,
      RegistrationOK,
      UnKnownError,
      InvalidAPIKey,
      ApplicationCantCreateUser,
      UserNotAssociatedToApp,
      ActionAlreadyExists,
      AccessDenied,
      Success,
   }

   /// <summary> 
   /// The TOKEN_INFORMATION_CLASS enumeration type contains values that  
   /// specify the type of information being assigned to or retrieved from  
   /// an access token. 
   /// </summary> 
   /// <summary>
   /// Enum TOKEN_INFORMATION_CLASS
   /// </summary>
   public enum Token_Information_Class
   {
      /// <summary>
      /// The token user
      /// </summary>
      TokenUser,
      /// <summary>
      /// The token groups
      /// </summary>
      TokenGroups,
      /// <summary>
      /// The token privileges
      /// </summary>
      TokenPrivileges,
      /// <summary>
      /// The token owner
      /// </summary>
      TokenOwner,
      /// <summary>
      /// The token primary group
      /// </summary>
      TokenPrimaryGroup,
      /// <summary>
      /// The token default dacl
      /// </summary>
      TokenDefaultDacl,
      /// <summary>
      /// The token source
      /// </summary>
      TokenSource,
      /// <summary>
      /// The token type
      /// </summary>
      TokenType,
      /// <summary>
      /// The token impersonation level
      /// </summary>
      TokenImpersonationLevel,
      /// <summary>
      /// The token statistics
      /// </summary>
      TokenStatistics,
      /// <summary>
      /// The token restricted sids
      /// </summary>
      TokenRestrictedSids,
      /// <summary>
      /// The token session identifier
      /// </summary>
      TokenSessionId,
      /// <summary>
      /// The token groups and privileges
      /// </summary>
      TokenGroupsAndPrivileges,
      /// <summary>
      /// The token session reference
      /// </summary>
      TokenSessionReference,
      /// <summary>
      /// The token sand box inert
      /// </summary>
      TokenSandBoxInert,
      /// <summary>
      /// The token audit policy
      /// </summary>
      TokenAuditPolicy,
      /// <summary>
      /// The token origin
      /// </summary>
      TokenOrigin,
      /// <summary>
      /// The token elevation type
      /// </summary>
      TokenElevationType,
      /// <summary>
      /// The token linked token
      /// </summary>
      TokenLinkedToken,
      /// <summary>
      /// The token elevation
      /// </summary>
      TokenElevation,
      /// <summary>
      /// The token has restrictions
      /// </summary>
      TokenHasRestrictions,
      /// <summary>
      /// The token access information
      /// </summary>
      TokenAccessInformation,
      /// <summary>
      /// The token virtualization allowed
      /// </summary>
      TokenVirtualizationAllowed,
      /// <summary>
      /// The token virtualization enabled
      /// </summary>
      TokenVirtualizationEnabled,
      /// <summary>
      /// The token integrity level
      /// </summary>
      TokenIntegrityLevel,
      /// <summary>
      /// The token UI access
      /// </summary>
      TokenUIAccess,
      /// <summary>
      /// The token mandatory policy
      /// </summary>
      TokenMandatoryPolicy,
      /// <summary>
      /// The token logon sid
      /// </summary>
      TokenLogonSid,
      /// <summary>
      /// The maximum token information class
      /// </summary>
      MaxTokenInfoClass
   }

   /// <summary> 
   /// The WELL_KNOWN_SID_TYPE enumeration type is a list of commonly used  
   /// security identifiers (SIDs). Programs can pass these values to the  
   /// CreateWellKnownSid function to create a SID from this list. 
   /// </summary> 
   /// <summary>
   /// Enum WELL_KNOWN_SID_TYPE
   /// </summary>
   public enum WELL_KNOWN_SID_TYPE
   {
      /// <summary>
      /// The win null sid
      /// </summary>
      WinNullSid = 0,
      /// <summary>
      /// The security impersonation
      /// </summary>
      WinWorldSid = 1,
      /// <summary>
      /// The win local sid
      /// </summary>
      WinLocalSid = 2,
      /// <summary>
      /// The win creator owner sid
      /// </summary>
      WinCreatorOwnerSid = 3,
      /// <summary>
      /// The win creator group sid
      /// </summary>
      WinCreatorGroupSid = 4,
      /// <summary>
      /// The win creator owner server sid
      /// </summary>
      WinCreatorOwnerServerSid = 5,
      /// <summary>
      /// The win creator group server sid
      /// </summary>
      WinCreatorGroupServerSid = 6,
      /// <summary>
      /// The win nt authority sid
      /// </summary>
      WinNtAuthoritySid = 7,
      /// <summary>
      /// The win dialup sid
      /// </summary>
      WinDialupSid = 8,
      /// <summary>
      /// The win network sid
      /// </summary>
      WinNetworkSid = 9,
      /// <summary>
      /// The win batch sid
      /// </summary>
      WinBatchSid = 10,
      /// <summary>
      /// The win interactive sid
      /// </summary>
      WinInteractiveSid = 11,
      /// <summary>
      /// The win service sid
      /// </summary>
      WinServiceSid = 12,
      /// <summary>
      /// The win anonymous sid
      /// </summary>
      WinAnonymousSid = 13,
      /// <summary>
      /// The win proxy sid
      /// </summary>
      WinProxySid = 14,
      /// <summary>
      /// The win enterprise controllers sid
      /// </summary>
      WinEnterpriseControllersSid = 15,
      /// <summary>
      /// The win self sid
      /// </summary>
      WinSelfSid = 16,
      /// <summary>
      /// The win authenticated user sid
      /// </summary>
      WinAuthenticatedUserSid = 17,
      /// <summary>
      /// The win restricted code sid
      /// </summary>
      WinRestrictedCodeSid = 18,
      /// <summary>
      /// The win terminal server sid
      /// </summary>
      WinTerminalServerSid = 19,
      /// <summary>
      /// The win remote logon identifier sid
      /// </summary>
      WinRemoteLogonIdSid = 20,
      /// <summary>
      /// The win logon ids sid
      /// </summary>
      WinLogonIdsSid = 21,
      /// <summary>
      /// The win local system sid
      /// </summary>
      WinLocalSystemSid = 22,
      /// <summary>
      /// The win local service sid
      /// </summary>
      WinLocalServiceSid = 23,
      /// <summary>
      /// The win network service sid
      /// </summary>
      WinNetworkServiceSid = 24,
      /// <summary>
      /// The win builtin domain sid
      /// </summary>
      WinBuiltinDomainSid = 25,
      /// <summary>
      /// The win builtin administrators sid
      /// </summary>
      WinBuiltinAdministratorsSid = 26,
      /// <summary>
      /// The win builtin users sid
      /// </summary>
      WinBuiltinUsersSid = 27,
      /// <summary>
      /// The win builtin guests sid
      /// </summary>
      WinBuiltinGuestsSid = 28,
      /// <summary>
      /// The win builtin power users sid
      /// </summary>
      WinBuiltinPowerUsersSid = 29,
      /// <summary>
      /// The win builtin account operators sid
      /// </summary>
      WinBuiltinAccountOperatorsSid = 30,
      /// <summary>
      /// The win builtin system operators sid
      /// </summary>
      WinBuiltinSystemOperatorsSid = 31,
      /// <summary>
      /// The win builtin print operators sid
      /// </summary>
      WinBuiltinPrintOperatorsSid = 32,
      /// <summary>
      /// The win builtin backup operators sid
      /// </summary>
      WinBuiltinBackupOperatorsSid = 33,
      /// <summary>
      /// The win builtin replicator sid
      /// </summary>
      WinBuiltinReplicatorSid = 34,
      /// <summary>
      /// The win builtin pre windows2000 compatible access sid
      /// </summary>
      WinBuiltinPreWindows2000CompatibleAccessSid = 35,
      /// <summary>
      /// The win builtin remote desktop users sid
      /// </summary>
      WinBuiltinRemoteDesktopUsersSid = 36,
      /// <summary>
      /// The win builtin network configuration operators sid
      /// </summary>
      WinBuiltinNetworkConfigurationOperatorsSid = 37,
      /// <summary>
      /// The win account administrator sid
      /// </summary>
      WinAccountAdministratorSid = 38,
      /// <summary>
      /// The win account guest sid
      /// </summary>
      WinAccountGuestSid = 39,
      /// <summary>
      /// The win account KRBTGT sid
      /// </summary>
      WinAccountKrbtgtSid = 40,
      /// <summary>
      /// The win account domain admins sid
      /// </summary>
      WinAccountDomainAdminsSid = 41,
      /// <summary>
      /// The win account domain users sid
      /// </summary>
      WinAccountDomainUsersSid = 42,
      /// <summary>
      /// The win account domain guests sid
      /// </summary>
      WinAccountDomainGuestsSid = 43,
      /// <summary>
      /// The win account computers sid
      /// </summary>
      WinAccountComputersSid = 44,
      /// <summary>
      /// The win account controllers sid
      /// </summary>
      WinAccountControllersSid = 45,
      /// <summary>
      /// The win account cert admins sid
      /// </summary>
      WinAccountCertAdminsSid = 46,
      /// <summary>
      /// The win account schema admins sid
      /// </summary>
      WinAccountSchemaAdminsSid = 47,
      /// <summary>
      /// The win account enterprise admins sid
      /// </summary>
      WinAccountEnterpriseAdminsSid = 48,
      /// <summary>
      /// The win account policy admins sid
      /// </summary>
      WinAccountPolicyAdminsSid = 49,
      /// <summary>
      /// The win account ras and ias servers sid
      /// </summary>
      WinAccountRasAndIasServersSid = 50,
      /// <summary>
      /// The win NTLM authentication sid
      /// </summary>
      WinNTLMAuthenticationSid = 51,
      /// <summary>
      /// The win digest authentication sid
      /// </summary>
      WinDigestAuthenticationSid = 52,
      /// <summary>
      /// The win s channel authentication sid
      /// </summary>
      WinSChannelAuthenticationSid = 53,
      /// <summary>
      /// The win this organization sid
      /// </summary>
      WinThisOrganizationSid = 54,
      /// <summary>
      /// The win other organization sid
      /// </summary>
      WinOtherOrganizationSid = 55,
      /// <summary>
      /// The win builtin incoming forest trust builders sid
      /// </summary>
      WinBuiltinIncomingForestTrustBuildersSid = 56,
      /// <summary>
      /// The win builtin perf monitoring users sid
      /// </summary>
      WinBuiltinPerfMonitoringUsersSid = 57,
      /// <summary>
      /// The win builtin perf logging users sid
      /// </summary>
      WinBuiltinPerfLoggingUsersSid = 58,
      /// <summary>
      /// The win builtin authorization access sid
      /// </summary>
      WinBuiltinAuthorizationAccessSid = 59,
      /// <summary>
      /// The win builtin terminal server license servers sid
      /// </summary>
      WinBuiltinTerminalServerLicenseServersSid = 60,
      /// <summary>
      /// The win builtin DCOM users sid
      /// </summary>
      WinBuiltinDCOMUsersSid = 61,
      /// <summary>
      /// The win builtin i users sid
      /// </summary>
      WinBuiltinIUsersSid = 62,
      /// <summary>
      /// The win i user sid
      /// </summary>
      WinIUserSid = 63,
      /// <summary>
      /// The win builtin crypto operators sid
      /// </summary>
      WinBuiltinCryptoOperatorsSid = 64,
      /// <summary>
      /// The win untrusted label sid
      /// </summary>
      WinUntrustedLabelSid = 65,
      /// <summary>
      /// The win low label sid
      /// </summary>
      WinLowLabelSid = 66,
      /// <summary>
      /// The win medium label sid
      /// </summary>
      WinMediumLabelSid = 67,
      /// <summary>
      /// The win high label sid
      /// </summary>
      WinHighLabelSid = 68,
      /// <summary>
      /// The win system label sid
      /// </summary>
      WinSystemLabelSid = 69,
      /// <summary>
      /// The win write restricted code sid
      /// </summary>
      WinWriteRestrictedCodeSid = 70,
      /// <summary>
      /// The win creator owner rights sid
      /// </summary>
      WinCreatorOwnerRightsSid = 71,
      /// <summary>
      /// The win cacheable principals group sid
      /// </summary>
      WinCacheablePrincipalsGroupSid = 72,
      /// <summary>
      /// The win non cacheable principals group sid
      /// </summary>
      WinNonCacheablePrincipalsGroupSid = 73,
      /// <summary>
      /// The win enterprise readonly controllers sid
      /// </summary>
      WinEnterpriseReadonlyControllersSid = 74,
      /// <summary>
      /// The win account readonly controllers sid
      /// </summary>
      WinAccountReadonlyControllersSid = 75,
      /// <summary>
      /// The win builtin event log readers group
      /// </summary>
      WinBuiltinEventLogReadersGroup = 76,
      /// <summary>
      /// The win new enterprise readonly controllers sid
      /// </summary>
      WinNewEnterpriseReadonlyControllersSid = 77,
      /// <summary>
      /// The win builtin cert SVC d COM access group
      /// </summary>
      WinBuiltinCertSvcDComAccessGroup = 78
   }

   /// <summary>
   /// The SECURITY_IMPERSONATION_LEVEL enumeration type contains values
   /// that specify security impersonation levels. Security impersonation
   /// levels govern the degree to which a server process can act on behalf
   /// of a client process.
   /// </summary>
   public enum SECURITY_IMPERSONATION_LEVEL
   {
      /// <summary>
      /// The security anonymous
      /// </summary>
      SecurityAnonymous,
      /// <summary>
      /// The security identification
      /// </summary>
      SecurityIdentification,
      /// <summary>
      /// The security impersonation
      /// </summary>
      SecurityImpersonation,
      /// <summary>
      /// The security delegation
      /// </summary>
      SecurityDelegation
   }

   /// <summary>
   /// The TOKEN_ELEVATION_TYPE enumeration indicates the elevation type of
   /// token being queried by the GetTokenInformation function or set by
   /// the SetTokenInformation function.
   /// </summary>
   public enum TOKEN_ELEVATION_TYPE
   {
      /// <summary>
      /// The token elevation type default
      /// </summary>
      TokenElevationTypeDefault = 1,
      /// <summary>
      /// The token elevation type full
      /// </summary>
      TokenElevationTypeFull,
      /// <summary>
      /// The token elevation type limited
      /// </summary>
      TokenElevationTypeLimited
   }

   /// <summary>
   /// Defines the Methods and ORder of Encryption
   /// </summary>
   [Flags()]
   public enum Encryption_Method
   {
      ProtectedData_UserMode = 1,
      ProtectedData_MachineMode = 2,
      UserProvidedPassword= 4,
      SystemInternalPassword= 8,
      ClientDynamicPassowrd = 16,
      Biometric_MethodA =32,
      Biometric_MethodB =64,
      Biometric_MethodC = 128,
      Defined_Plugin_Method = 256
   }

   /// <summary>
   /// Defines the Encoding Methods of the Encrypted Data
   /// </summary>   
   public enum Encryption_Final_Encoding_Method
   {
      Base64, Base16,

      
   }
}
