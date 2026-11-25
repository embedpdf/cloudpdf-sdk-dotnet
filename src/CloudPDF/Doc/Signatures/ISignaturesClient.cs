using CloudPDF;

namespace CloudPDF.Doc;

public partial interface ISignaturesClient
{
    /// <summary>
    /// Describes the bytes the layer is over: the base version's signatures plus the layer's own edits as the last revision. Signed bytes (contents, digests, revision prefixes) are served per base version under /versions.
    /// </summary>
    WithRawResponseTask<DocSignaturesListResponse> ListAsync(
        ListSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocSignaturesCancelResponse> CancelAsync(
        CancelSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// `cms` is the detached CMS over the prepared digest, base64. `expectedVersion` must be what prepare returned. Idempotent by signing id: the same CMS again answers `already-completed`. The new version is the layer's own: only this layer moves to it, and the document and every other layer stay as they were. Refetch the manifest after a completion.
    /// </summary>
    WithRawResponseTask<DocSignaturesCompleteResponse> CompleteAsync(
        DocSignaturesCompleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Exactly one of `since.signature=&lt;index&gt;` or `since.revision=&lt;index&gt;`; the layer's pending edits are the end. `level=fill|annotate|lta|none` evaluates exploratorily and never becomes a verdict. For history between two base revisions use the version analysis.
    /// </summary>
    WithRawResponseTask<DocSignaturesAnalysisResponse> AnalysisAsync(
        AnalysisSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Multipart: a JSON `body` part (field, subFilter, digest, contentsSize, signer, certify, lock), naming the appearance PDF it may carry as `resources: { appearance: '&lt;key&gt;' }`, and that PDF as the part `resource:&lt;key&gt;`. A certification (`certify.permission`) additionally requires `doc.sign.certify`. The layer is read-only until the signing completes, is cancelled, or expires (15 minutes). A document timestamp (`kind: 'timestamp'`) may leave `field` out, since 3.3: the engine then makes a field of no size for it, under a name no other field has, and the answer names it in `field`. That needs `doc.sign` for the document. The signature is made over the layer's own base: the upload, or the version its last signature made.
    /// </summary>
    WithRawResponseTask<DocSignaturesPrepareResponse> PrepareAsync(
        PrepareSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Each entry is one DER object, base64. It reads the layer as it is now, so entries stored and not yet sealed by a signature are among them. Arrived in 3.3.
    /// </summary>
    WithRawResponseTask<DocSignaturesValidationInfoResponse> ValidationInfoAsync(
        ValidationInfoSignaturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Each entry is one DER object of at most 16 MiB, base64. An entry the file already holds, byte for byte, is not stored again: `added` counts the new ones. An entry that is not one DER object fails the request and nothing is stored; the error names it, as in `certificates[1]`. The server stores what it is given and asks no certificate authority: collect the answers first. It needs `doc.sign` for the document, not for a group of fields, and is refused after a certification that allows no changes. It cannot be undone, and it leaves undo for earlier changes as it was. Arrived in 3.3.
    /// </summary>
    WithRawResponseTask<DocSignaturesAddValidationInfoResponse> AddValidationInfoAsync(
        DocSignaturesAddValidationInfoRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
