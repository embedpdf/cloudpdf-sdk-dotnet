using CloudPDF.Shares;

namespace CloudPDF;

public partial interface ISharesClient
{
    public IVisitorsClient Visitors { get; }

    /// <summary>
    /// Unauthenticated, but requires a browser Origin header, checked against the grant allowlist. Unknown, revoked, and disabled tokens are indistinguishable (404). Passphrase-protected grants return 422 SharePasswordRequired until `password` is supplied. A link that asks its visitors who they are on open returns 422 VisitorIdentityRequired until the required answers are given; `error.details` carries `fields` (what the link asks), `missing`, `invalid`, `purpose` and `privacyUrl`. A link that asks before the first change issues the session at once with `visitor.identityRequest`, and writes answer 403 VisitorIdentityRequired with the same details until the visitor exchanges again with their answers. Answers that can not be taken answer 422 on any link. Mounted only when the deployment can sign (HS256 mode).
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
    /// The returned share id is the public share token. Mounted only when the deployment can sign (HS256 mode) — exchange mints session JWTs, so grants exist only where minting does.
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

    /// <summary>
    /// Archiving is final: an archived link never exchanges again, and to share again you create a new link. Pausing (`disabled`) is the reversible stop. An archived link no longer counts as using its shared layer, so that layer can be deleted.
    /// </summary>
    WithRawResponseTask<SharesArchive200Response> ArchiveAsync(
        ArchiveSharesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
