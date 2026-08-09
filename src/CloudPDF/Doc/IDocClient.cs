using CloudPDF.Doc;

namespace CloudPDF;

public partial interface IDocClient
{
    public IAnnotationsClient Annotations { get; }
    public IFormsClient Forms { get; }
    public IMetadataClient Metadata { get; }
    public IPagesClient Pages { get; }
    public IRedactionsClient Redactions { get; }
    WithRawResponseTask<DocHead200Response> HeadAsync(
        HeadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> DownloadAsync(
        DownloadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocManifest200Response> ManifestAsync(
        ManifestDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render parameters (viewport, format) pass as flat dotted query keys, e.g. `?viewport.kind=width&viewport.width=800`; the full grammar is documented with the viewer.
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> RenderAsync(
        RenderDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocText200Response> TextAsync(
        TextDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
