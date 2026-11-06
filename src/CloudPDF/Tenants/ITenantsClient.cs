namespace CloudPDF;

public partial interface ITenantsClient
{
    WithRawResponseTask<TenantsListResponse> ListAsync(
        ListTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantsCreateResponse> CreateAsync(
        TenantsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TenantsGetResponse> GetAsync(
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

    /// <summary>
    /// A feature names an installed module; any other id is a 400. A module route answers a tenant without its feature 403 FeatureNotEnabled, and one whose feature is stopped 402 FeatureStopped (details.feature, details.stopped). Other replicas apply a change within 30 seconds.
    /// </summary>
    WithRawResponseTask<TenantsUpdateResponse> UpdateAsync(
        TenantsUpdateRequest request,
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
    /// Facts only — no limits or billing state. Views count grant exchanges plus authorized /v1/access requests, deduplicated across the two.
    /// </summary>
    WithRawResponseTask<TenantsUsageResponse> UsageAsync(
        UsageTenantsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
