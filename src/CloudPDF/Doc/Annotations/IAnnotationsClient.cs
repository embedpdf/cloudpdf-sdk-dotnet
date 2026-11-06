using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IAnnotationsClient
{
    /// <summary>
    /// Returns one entry per page plus the audit-log cursor for reconciling subsequent document events. Page order is unspecified; join by `page` (a `PageRef`) when display order matters.
    /// </summary>
    WithRawResponseTask<AnnotationList> ListAllAsync(
        ListAllAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AnnotationList> ListAsync(
        ListAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Doc JWTs may instead carry collab scopes (annotations:create:self, …) that refine per-annotation authorship rules; the API token is exempt from both.
    /// </summary>
    WithRawResponseTask<DocAnnotationsCreateResponse> CreateAsync(
        CreateAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsDeleteResponse> DeleteAsync(
        DeleteAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsUpdateResponse> UpdateAsync(
        UpdateAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> ReadAppearanceAsync(
        ReadAppearanceAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A file that decodes past the server's limit is refused (PayloadTooLarge).
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> ReadFileAsync(
        ReadFileAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> ExportAppearanceAsync(
        ExportAppearanceAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsFlattenResponse> FlattenAsync(
        FlattenAnnotationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocAnnotationsReorderResponse> ReorderAsync(
        DocAnnotationsReorderRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
