namespace CloudpdfApi;

public partial interface ICloudpdfApiClient
{
    public IDeploymentClient Deployment { get; }
    public IDocClient Doc { get; }
    public ITenantsClient Tenants { get; }
    public IDocumentsClient Documents { get; }
    public ITokensClient Tokens { get; }
}
