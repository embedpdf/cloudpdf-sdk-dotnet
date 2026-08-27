using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IPagesClient
{
    WithRawResponseTask<DocPagesDelete200Response> DeleteAsync(
        DeletePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A read, not a mutation: the source document is untouched and no event is published. Body is `{"pageObjectNumbers": number[]}`; the response body is the new PDF.
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
    /// Multipart mutation envelope: a `body` field holding `{"destIndex"?: number}` (omitted → append) plus a `resource:source` file part carrying the standalone PDF whose pages are copied in. The inserted copies get fresh page object numbers, returned in insertion order.
    /// </summary>
    WithRawResponseTask<DocPagesInsert200Response> InsertAsync(
        InsertPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Body is `{"size": {"width", "height"}, "count"?, "destIndex"?}` — size in PDF points, count in [1, 100], destIndex omitted → append.
    /// </summary>
    WithRawResponseTask<DocPagesInsertBlank200Response> InsertBlankAsync(
        InsertBlankPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesMove200Response> MoveAsync(
        MovePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesRotate200Response> RotateAsync(
        RotatePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
