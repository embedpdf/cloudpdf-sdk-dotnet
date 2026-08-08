namespace CloudpdfApi;

public partial interface IDeploymentClient
{
    WithRawResponseTask<DeploymentLicenseStatusResponse> LicenseStatusAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
