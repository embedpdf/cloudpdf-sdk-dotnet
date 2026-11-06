using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IFormsClient
{
    WithRawResponseTask<DocFormsListResponse> ListAsync(
        ListFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsReorderCalculationsResponse> ReorderCalculationsAsync(
        DocFormsReorderCalculationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsSetValueResponse> SetValueAsync(
        SetValueFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsResetResponse> ResetAsync(
        DocFormsResetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsDeleteWidgetResponse> DeleteWidgetAsync(
        DeleteWidgetFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsUpdateWidgetResponse> UpdateWidgetAsync(
        DocFormsUpdateWidgetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsReorderWidgetsResponse> ReorderWidgetsAsync(
        DocFormsReorderWidgetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
