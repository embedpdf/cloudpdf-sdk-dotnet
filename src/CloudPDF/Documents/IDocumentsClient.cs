namespace CloudPDF;

public partial interface IDocumentsClient
{
    WithRawResponseTask<DocumentsList200Response> ListAsync(
        ListDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsGet200Response> GetAsync(
        GetDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        DeleteDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsCommit200Response> CommitAsync(
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
    /// This bounded origin-mediated fallback must only be used after documents.init returns upload.kind=proxy. Auto mode prefers a presigned object-store PUT whenever available.
    /// </summary>
    WithRawResponseTask<DocumentsUploadProxy200Response> UploadProxyAsync(
        UploadProxyDocumentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocumentsInit200Response> InitAsync(
        DocumentsInitRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
