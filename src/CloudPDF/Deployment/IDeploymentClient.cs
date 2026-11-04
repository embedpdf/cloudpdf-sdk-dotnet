namespace CloudPDF;

public partial interface IDeploymentClient
{
    WithRawResponseTask<DeploymentLicenseStatusResponse> LicenseStatusAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// What each module declares, for a dashboard or a script that lists modules, offers their permissions in its dialogs and shows their meters. Which tenants may use one is in their `features` (`tenants.get`); what it costs, if anything, is the operator's.
    /// </summary>
    WithRawResponseTask<DeploymentModulesResponse> ModulesAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
