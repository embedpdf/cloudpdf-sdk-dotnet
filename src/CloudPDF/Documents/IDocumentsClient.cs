using CloudPDF.Documents;

namespace CloudPDF;

public partial interface IDocumentsClient
{
    public ILayersClient Layers { get; }
    WithRawResponseTask<DocumentsListResponse> ListAsync(
        ListDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsGetResponse> GetAsync(
        GetDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        DeleteDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A document that is being deleted answers 404.
    /// </summary>
    WithRawResponseTask<DocumentsUpdateResponse> UpdateAsync(
        DocumentsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// An upload token commits only the documents it started; any other document answers 404.
    /// </summary>
    WithRawResponseTask<DocumentsCommitResponse> CommitAsync(
        DocumentsCommitRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> DownloadAsync(
        DownloadDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> ThumbnailAsync(
        ThumbnailDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// This bounded origin-mediated fallback must only be used after documents.init returns upload.kind=proxy. Auto mode prefers a presigned object-store PUT whenever available. An upload token sends files only to the documents it started.
    /// </summary>
    WithRawResponseTask<DocumentsUploadProxyResponse> UploadProxyAsync(
        UploadProxyDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Default mode is synchronous and bounded: the response returns only after the transfer verified and committed (or failed). mode=async (connection sources only) answers 202 immediately and an in-process worker performs the transfer with leased, fenced retries; poll the document until ready/failed. The deployment import policy gates scheme, network range, and size; sources must declare a length. CloudPDF copies and owns the bytes — the source is never referenced in place. A 502 marks a retryable upstream failure: retry with the same idempotencyKey to resume the same document. URL sources are capabilities and never echoed back. Connection sources name operator-registered storage (bucket/prefix scope, allowed credential classes, and tenant bindings are deployment configuration); `revision` is provider-interpreted (S3 VersionId, GCS generation, Azure version id).
    /// </summary>
    WithRawResponseTask<DocumentsImportFrom200Response> ImportFromAsync(
        DocumentsImportFromRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// With an upload token, the document goes into the token's folder with the token's metadata, whatever the request says; sizeBytes must be within the token's maxBytes, and the token makes at most maxFiles documents (403 after). docId, idempotencyKey and dedupMode reuse-existing are refused (400): each could reach a document the token didn't make.
    /// </summary>
    WithRawResponseTask<DocumentsInitResponse> InitAsync(
        DocumentsInitRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
