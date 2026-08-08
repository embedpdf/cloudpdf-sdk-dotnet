using CloudpdfApi.Core;

namespace CloudpdfApi;

public partial class CloudpdfApiClient : ICloudpdfApiClient
{
    private readonly RawClient _client;

    public CloudpdfApiClient(string? token = null, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "CloudpdfApi" },
                { "X-Fern-SDK-Version", Version.Current },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>() { { "Authorization", $"Bearer {token ?? ""}" } }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Deployment = new DeploymentClient(_client);
        Doc = new DocClient(_client);
        Tenants = new TenantsClient(_client);
        Documents = new DocumentsClient(_client);
        Tokens = new TokensClient(_client);
    }

    public IDeploymentClient Deployment { get; }

    public IDocClient Doc { get; }

    public ITenantsClient Tenants { get; }

    public IDocumentsClient Documents { get; }

    public ITokensClient Tokens { get; }
}
