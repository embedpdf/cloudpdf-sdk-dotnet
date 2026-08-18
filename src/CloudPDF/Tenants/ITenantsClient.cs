namespace CloudPDF;

public partial interface ITenantsClient
{
    WithRawResponseTask<TenantsList200Response> ListAsync(
        ListTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantsCreate200Response> CreateAsync(
        TenantsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantsGet200Response> GetAsync(
        GetTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Destroys the tenant and everything in its namespace — documents, layers, stored bytes, audit history. Irreversible.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask ResumeAsync(
        ResumeTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Instantly reversible with resume. The API token is exempt, so a suspended tenant can still be inspected, exported, resumed, or deleted.
    /// </summary>
    WithRawResponseTask SuspendAsync(
        TenantsSuspendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Facts only — no limits or billing state. Views count share exchanges plus authorized /v1/access grants, deduplicated across the two.
    /// </summary>
    WithRawResponseTask<TenantsUsage200Response> UsageAsync(
        UsageTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
