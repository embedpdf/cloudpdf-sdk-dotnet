using CloudPDF;

namespace CloudPDF.Doc;

public partial interface IFormsClient
{
    WithRawResponseTask<DocFormsList200Response> ListAsync(
        ListFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsReorderCalculations200Response> ReorderCalculationsAsync(
        DocFormsReorderCalculationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsSetValue200Response> SetValueAsync(
        SetValueFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsReset200Response> ResetAsync(
        DocFormsResetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsDeleteWidget200Response> DeleteWidgetAsync(
        DeleteWidgetFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsUpdateWidget200Response> UpdateWidgetAsync(
        DocFormsUpdateWidgetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsReorderWidgets200Response> ReorderWidgetsAsync(
        DocFormsReorderWidgetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
