using CloudPDF;

namespace CloudPDF.Doc.Metadata;

public partial interface ICustomClient
{
    WithRawResponseTask<Dictionary<string, string>> GetAsync(
        GetCustomRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
