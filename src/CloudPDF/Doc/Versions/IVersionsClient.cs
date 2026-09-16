using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IVersionsClient
{
    /// <summary>
    /// Every completed signature publishes a new version. Never cached: the list grows.
    /// </summary>
    WithRawResponseTask<DocVersionsList200Response> ListAsync(
        ListVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Exactly one of `since.signature` / `since.revision`; `until=&lt;revision&gt;` defaults to the last. The same answer for every layer and every caller.
    /// </summary>
    WithRawResponseTask<DocVersionsAnalysis200Response> AnalysisAsync(
        AnalysisVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> DownloadAsync(
        DownloadVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> RevisionAsync(
        RevisionVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocVersionsSignatures200Response> SignaturesAsync(
        SignaturesVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// `fieldKey` is the field's fully qualified name, token-text encoded (the same encoding attachment keys use).
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> SignatureContentsAsync(
        SignatureContentsVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// What a CMS verifier compares its message digest to.
    /// </summary>
    WithRawResponseTask<global::System.IO.Stream> SignatureDigestAsync(
        SignatureDigestVersionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
