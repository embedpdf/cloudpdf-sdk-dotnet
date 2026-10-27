using CloudPDF;

namespace CloudPDF.Documents;

public partial interface ILayersClient
{
    WithRawResponseTask<DocumentsLayersList200Response> ListAsync(
        ListLayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask DeleteAsync(
        DeleteLayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
