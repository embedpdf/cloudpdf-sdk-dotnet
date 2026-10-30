namespace CloudPDF;

public partial interface ICloudPDFClient
{
    public IDeploymentClient Deployment { get; }
    public IDocClient Doc { get; }
    public IGrantsClient Grants { get; }
    public ITenantsClient Tenants { get; }
    public IDocumentsClient Documents { get; }
    public IFoldersClient Folders { get; }
    public ITokensClient Tokens { get; }
}
