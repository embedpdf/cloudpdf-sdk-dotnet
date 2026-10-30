using CloudPDF.Grants;

namespace CloudPDF;

public partial interface IGrantsClient
{
    public IVisitorsClient Visitors { get; }

    /// <summary>
    /// Unauthenticated, but requires a browser Origin header, checked against the grant allowlist. Unknown, deleted, paused and archived grants are indistinguishable (404). Passphrase-protected grants return 422 GrantPassphraseRequired until `passphrase` is supplied. A grant that asks its visitors who they are on open returns 422 VisitorIdentityRequired until the required answers are given; `error.details` carries `fields` (what the grant asks), `missing`, `invalid`, `purpose` and `privacyUrl`. A grant that asks before the first change issues the session at once with `visitor.identityRequest`, and writes answer 403 VisitorIdentityRequired with the same details until the visitor exchanges again with their answers. Answers that can not be taken answer 422 on any grant. Mounted only when the deployment can sign (HS256 mode).
    /// </summary>
    WithRawResponseTask<GrantsExchange200Response> ExchangeAsync(
        GrantsExchangeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GrantsList200Response> ListAsync(
        ListGrantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The returned id is what a link page or an embed opens. Mounted only when the deployment can sign (HS256 mode) — exchange mints session JWTs, so grants exist only where minting does.
    /// </summary>
    WithRawResponseTask<GrantsCreate200Response> CreateAsync(
        GrantsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GrantsGet200Response> GetAsync(
        GetGrantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        DeleteGrantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GrantsUpdate200Response> UpdateAsync(
        GrantsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archiving is final: an archived grant never exchanges again, and to give access again you create a new grant. Pausing (`disabled`) is the reversible stop. An archived grant no longer counts as using its shared layer, so that layer can be deleted.
    /// </summary>
    WithRawResponseTask<GrantsArchive200Response> ArchiveAsync(
        ArchiveGrantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
