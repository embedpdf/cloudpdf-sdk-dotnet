using CloudPDF;

namespace CloudPDF.Documents;

public partial interface ILayersClient
{
    WithRawResponseTask<DocumentsLayersListResponse> ListAsync(
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
