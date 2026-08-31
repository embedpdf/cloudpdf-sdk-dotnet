using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IAnnotationsClient
{
    /// <summary>
    /// Returns one entry per page plus the audit-log cursor for reconciling subsequent document events. Page order is unspecified; join by `pageState.pageObjectNumber` when display order matters.
    /// </summary>
    WithRawResponseTask<DocAnnotationsListAll200Response> ListAllAsync(
        ListAllAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsList200Response> ListAsync(
        ListAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Doc JWTs may instead carry collab scopes (annotations:create:self, …) that refine per-annotation authorship rules; the API token is exempt from both.
    /// </summary>
    WithRawResponseTask<DocAnnotationsCreate200Response> CreateAsync(
        CreateAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsDelete200Response> DeleteAsync(
        DeleteAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsUpdate200Response> UpdateAsync(
        UpdateAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
