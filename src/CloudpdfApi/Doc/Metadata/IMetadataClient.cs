using CloudpdfApi;

namespace CloudpdfApi.Doc;

public partial interface IMetadataClient
{
    WithRawResponseTask<DocMetadataGet200Response> GetAsync(
        GetMetadataRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
