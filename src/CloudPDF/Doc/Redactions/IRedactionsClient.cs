using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IRedactionsClient
{
    WithRawResponseTask<DocRedactionsApply200Response> ApplyAsync(
        ApplyRedactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
