namespace CloudPDF;

public partial interface ITokensClient
{
    /// <summary>
    /// kind "tenant" requires the API token — authority mints only downward. Mounted only when the deployment can sign (HS256 mode); asymmetric deployments mint with their own private key.
    /// </summary>
    WithRawResponseTask<TokensIssue200Response> IssueAsync(
        IssueTokensRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mounted only when the deployment enables token revocation.
    /// </summary>
    WithRawResponseTask RevokeAsync(
        TokensRevokeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
