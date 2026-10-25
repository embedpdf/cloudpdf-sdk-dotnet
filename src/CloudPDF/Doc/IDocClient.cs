using CloudPDF.Doc;

namespace CloudPDF;

public partial interface IDocClient
{
    public IAnnotationsClient Annotations { get; }
    public IAttachmentsClient Attachments { get; }
    public IFormsClient Forms { get; }
    public IMetadataClient Metadata { get; }
    public IOutlineClient Outline { get; }
    public IPagesClient Pages { get; }
    public IRedactionsClient Redactions { get; }
    public ISignaturesClient Signatures { get; }
    public IVersionsClient Versions { get; }
    WithRawResponseTask<DocHead200Response> HeadAsync(
        HeadDocRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Each change stands on its own and names itself by `opId`: a refused change rolls back alone, and the answer lists every change in order, applied with its result or refused with its error. Asked again under its `opId`, a change gets the same answer, refusals included; a different change under an answered `opId` is refused (IdempotencyKeyReused). `{ opId, undoOf }` undoes an earlier change of the caller, here or in an earlier request; an undo leaves alone what was changed since, and the undo of an undo redoes. A redaction, a flatten, a form repair or a completed signature ends undo for the changes before it (UndoUnavailable). Each op is checked against its own capability: annotation ops need `doc.annotate.modify`, form values `doc.forms.fill`, form structure `doc.forms.modify`, metadata `doc.metadata.modify`, outline `doc.outline.modify`, pages `doc.pages.assemble`, embedded files `doc.attachments.modify`. Bytes (a stamp's drawing, an attached file, a signature's artwork, a PDF whose pages come in) travel as multipart: a JSON `body` part, each op naming its files by role as `resources: { &lt;role&gt;: '&lt;key&gt;' }`, and each file as the part `resource:&lt;key&gt;`. At most 64 changes per request and 512 ops per change.
    /// </summary>
    WithRawResponseTask<DocChanges200Response> ChangesAsync(
        DocChangesRequest request,
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
