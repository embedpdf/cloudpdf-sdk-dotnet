using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IAttachmentsClient
{
    /// <summary>
    /// A file that decodes past the server's limit is refused (PayloadTooLarge).
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> DownloadAsync(
        DownloadAttachmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// A file-attachment annotation's file is listed with the annotation; read its bytes with `doc.annotations.readFile`.
    /// </summary>
    WithRawResponseTask<AttachmentList> ListAsync(
        ListAttachmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
