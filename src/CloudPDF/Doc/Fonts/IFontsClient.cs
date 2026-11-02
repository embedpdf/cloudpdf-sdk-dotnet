using CloudPDF;
using CloudPDF.Doc.Fonts;

namespace CloudPDF.Doc;

public partial interface IFontsClient
{
    public IProgramsClient Programs { get; }
    WithRawResponseTask<FontList> ListAsync(
        ListFontsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FontResolution> ResolveAsync(
        ResolveFontsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
