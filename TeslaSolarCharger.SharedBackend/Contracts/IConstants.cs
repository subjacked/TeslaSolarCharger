﻿namespace TeslaSolarCharger.SharedBackend.Contracts;

public interface IConstants
{
    string CarStateKey { get; }
    string CarConfigurationKey { get; }
    int MinSocLimit { get; }
    int DefaultOverage { get; }
    /// <summary>
    /// Soc Difference needs to be higher than this value
    /// </summary>
    int MinimumSocDifference { get; }

    string InstallationIdKey { get; }
    string FleetApiTokenRequested { get; }
    string TokenRefreshUnauthorized { get; }
    string TokenMissingScopes { get; }
    string BackupZipBaseFileName { get; }
    string FleetApiProxyNeeded { get; }
}
