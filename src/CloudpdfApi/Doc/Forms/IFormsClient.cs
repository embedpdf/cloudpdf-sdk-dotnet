using CloudpdfApi;

namespace CloudpdfApi.Doc;

public partial interface IFormsClient
{
    WithRawResponseTask<DocFormsGet200Response> GetAsync(
        GetFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<global::System.IO.Stream> ExportDataAsync(
        ExportDataFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsImportData200Response> ImportDataAsync(
        ImportDataFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsReset200Response> ResetAsync(
        ResetFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocFormsSetValue200Response> SetValueAsync(
        SetValueFormsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
