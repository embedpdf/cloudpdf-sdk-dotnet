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

    /// <summary>
    /// A read, not a mutation: the source document is untouched and no event is published. Body is `{"pages": PageRef[], "flatten"?: {"usage"?: "display" | "print"}, "includeAnnotations"?: boolean, "includeFormFields"?: boolean}`; the response body is the new PDF. With `flatten` the copy is the pages as they draw for `usage` (`"print"`: a print copy): the annotations and form fields painted in, nothing interactive left, layers in their state for the usage. A flattened copy takes `doc.download` or `doc.download.flattened`, and paints only what the caller may read; `includeAnnotations` and `includeFormFields` choose what it paints, and are refused without `flatten`.
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
}
