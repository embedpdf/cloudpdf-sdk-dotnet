namespace CloudPDF;

public partial interface ICloudPDFClient
{
    public IDeploymentClient Deployment { get; }
    public IDocClient Doc { get; }
    public ISharesClient Shares { get; }
    public ITenantsClient Tenants { get; }
    public IDocumentsClient Documents { get; }
    public ITokensClient Tokens { get; }
}
