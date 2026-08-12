namespace CloudPDF;

public partial interface ISharesClient
{
    /// <summary>
    /// Unauthenticated, but requires a browser Origin header, checked against the grant allowlist. Unknown, revoked, and disabled tokens are indistinguishable (404). Passphrase-protected grants return 422 SharePasswordRequired until `password` is supplied. Mounted only when the deployment can sign (HS256 mode).
    /// </summary>
    WithRawResponseTask<SharesExchange200Response> ExchangeAsync(
        SharesExchangeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SharesList200Response> ListAsync(
        ListSharesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The returned share id IS the public share token. Mounted only when the deployment can sign (HS256 mode) — exchange mints session JWTs, so grants exist only where minting does.
    /// </summary>
    WithRawResponseTask<SharesCreate200Response> CreateAsync(
        SharesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SharesGet200Response> GetAsync(
        GetSharesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        DeleteSharesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SharesUpdate200Response> UpdateAsync(
        SharesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
