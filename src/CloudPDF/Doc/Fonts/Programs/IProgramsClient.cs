using CloudPDF;

namespace CloudPDF.Doc.Fonts;

public partial interface IProgramsClient
{
    /// <summary>
    /// A document token needs any one of the listed capabilities: one that may write text in the document. A file the list says can't be downloaded (`canDownload: false`) is not found.
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> DownloadAsync(
        DownloadProgramsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FontProgramInfo> GetAsync(
        GetProgramsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
