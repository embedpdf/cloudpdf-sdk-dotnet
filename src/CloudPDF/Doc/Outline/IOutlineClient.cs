using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IOutlineClient
{
    WithRawResponseTask<DocumentOutline> GetAsync(
        GetOutlineRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
