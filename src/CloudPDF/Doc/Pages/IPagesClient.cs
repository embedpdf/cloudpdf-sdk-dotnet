using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IPagesClient
{
    WithRawResponseTask<DocPagesSetScale200Response> SetScaleAsync(
        DocPagesSetScaleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesViewports200Response> ViewportsAsync(
        ViewportsPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesDelete200Response> DeleteAsync(
        DeletePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A read, not a mutation: the source document is untouched and no event is published. Body is `{"pages": PageRef[]}`; the response body is the new PDF.
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> ExtractAsync(
        ExtractPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesFlatten200Response> FlattenAsync(
        FlattenPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Multipart: a JSON `body` part `{"position"?: PagePosition, "resources": {"source": "&lt;key&gt;"}}` (position omitted → the end), and the standalone PDF whose pages are copied in as the part `resource:&lt;key&gt;`. The inserted copies get fresh page object numbers, returned in insertion order.
    /// </summary>
    WithRawResponseTask<DocPagesInsert200Response> InsertAsync(
        InsertPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Body is `{"size": {"width", "height"}, "count"?, "position"?}` — size in PDF points, count in [1, 100], `position` a `PagePosition` (omitted → the end).
    /// </summary>
    WithRawResponseTask<DocPagesInsertBlank200Response> InsertBlankAsync(
        InsertBlankPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesSetName200Response> SetNameAsync(
        SetNamePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesRemoveName200Response> RemoveNameAsync(
        RemoveNamePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesReorder200Response> ReorderAsync(
        DocPagesReorderRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesRotate200Response> RotateAsync(
        RotatePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
