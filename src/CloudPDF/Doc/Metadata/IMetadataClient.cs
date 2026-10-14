using CloudPDF;
using CloudPDF.Doc.Metadata;

namespace CloudPDF.Doc;

public partial interface IMetadataClient
{
    public ICustomClient Custom { get; }
    WithRawResponseTask<DocumentMetadata> GetAsync(
        GetMetadataRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
