using CloudPDF;

namespace CloudPDF.Grants;

public partial interface IVisitorsClient
{
    /// <summary>
    /// An archived grant's visitors are listed too.
    /// </summary>
    WithRawResponseTask<GrantsVisitorsList200Response> ListAsync(
        ListVisitorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Their handle brings them back as a new visitor, who is asked again. Deleting a visitor already deleted changes nothing.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteVisitorsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
