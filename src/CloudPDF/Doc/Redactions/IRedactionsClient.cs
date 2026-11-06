using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IRedactionsClient
{
    WithRawResponseTask<DocRedactionsApplyResponse> ApplyAsync(
        DocRedactionsApplyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
