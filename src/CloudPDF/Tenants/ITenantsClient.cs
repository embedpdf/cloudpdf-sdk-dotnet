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
}
