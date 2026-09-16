using CloudPDF;

namespace CloudPDF.Doc;

public partial interface ISignaturesClient
{
    /// <summary>
    /// Describes the bytes the layer is over: the base version's signatures plus the layer's own edits as the last revision. Signed bytes (contents, digests, revision prefixes) are served per base version under /versions.
    /// </summary>
    WithRawResponseTask<DocSignaturesList200Response> ListAsync(
        ListSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocSignaturesAbort200Response> AbortAsync(
        AbortSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// `cms` is the detached CMS over the prepared digest, base64. `expectedVersion` must be what prepare returned. Idempotent by signing id: the same CMS again answers `already-completed`. Every layer of the document then sits over the new version; refetch the manifest after a completion.
    /// </summary>
    WithRawResponseTask<DocSignaturesComplete200Response> CompleteAsync(
        DocSignaturesCompleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Exactly one of `since.signature=&lt;index&gt;` or `since.revision=&lt;index&gt;`; the layer's pending edits are the end. `level=fill|annotate|lta|none` evaluates exploratorily and never becomes a verdict. For history between two base revisions use the version analysis.
    /// </summary>
    WithRawResponseTask<DocSignaturesAnalysis200Response> AnalysisAsync(
        AnalysisSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The multipart envelope: a JSON `body` part (field, subFilter, digest, contentsSize, signer, certify, lock, appearance) and an optional `resource:&lt;key&gt;` PDF part the body's `appearance.resource` names. A certification (`certify.permission`) additionally requires `doc.sign.certify`. The layer is read-only until the signing completes, is aborted, or expires (15 minutes). A layer behind the document head cannot sign (StaleBase).
    /// </summary>
    WithRawResponseTask<DocSignaturesPrepare200Response> PrepareAsync(
        PrepareSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
