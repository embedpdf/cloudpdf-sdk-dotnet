namespace CloudPDF;

public partial interface ITokensClient
{
    /// <summary>
    /// Authority mints only downward: kind "doc" gives only document permissions the caller holds itself, kind "tenant" requires the API token, and kind "upload" requires docs.create instead of tokens.issue-doc, since an upload token can do only what docs.create allows. Mounted only when the deployment can sign (HS256 mode); asymmetric deployments mint with their own private key.
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
