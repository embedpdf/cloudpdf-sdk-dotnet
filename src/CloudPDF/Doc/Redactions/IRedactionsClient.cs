using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IRedactionsClient
{
    WithRawResponseTask<DocRedactionsApply200Response> ApplyAsync(
        DocRedactionsApplyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
