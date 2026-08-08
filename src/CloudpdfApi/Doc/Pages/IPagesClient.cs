using CloudpdfApi;

namespace CloudpdfApi.Doc;

public partial interface IPagesClient
{
    WithRawResponseTask<DocPagesDelete200Response> DeleteAsync(
        DeletePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesFlatten200Response> FlattenAsync(
        FlattenPagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesMove200Response> MoveAsync(
        MovePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DocPagesRotate200Response> RotateAsync(
        RotatePagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
