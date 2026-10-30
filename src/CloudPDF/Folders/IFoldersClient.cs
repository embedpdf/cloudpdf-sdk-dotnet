namespace CloudPDF;

public partial interface IFoldersClient
{
    WithRawResponseTask<FoldersList200Response> ListAsync(
        ListFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 409 Conflict carries `details.reason`: `name-taken` (a sibling has the name, ignoring case; `details.name`) or `too-deep` (folders nest at most 100 levels; `details.maxDepth`). 404 when the parent folder does not exist.
    /// </summary>
    WithRawResponseTask<FoldersCreate200Response> CreateAsync(
        FoldersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FoldersGet200Response> GetAsync(
        GetFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Without recursive, a folder with anything inside is refused: 409 Conflict with `details.reason` `not-empty` and what it holds, counted over every level below, in `details.folders` and `details.documents`. With recursive=true, the folder and every folder under it go at once, and every document in them stops opening, leaves every list and stops answering its grants at once; their stored files and grants are removed in the background. Uploads into those folders that have not committed cannot commit.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        DeleteFoldersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 409 Conflict with `details.reason` `name-taken` when a sibling has the name, ignoring case.
    /// </summary>
    WithRawResponseTask<FoldersUpdate200Response> UpdateAsync(
        FoldersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Up to 1,000 ids in total. A folder moves with everything in it. 404 NotFound names the ids that do not exist or are being deleted in `details.documentIds` and `details.folderIds`. 409 Conflict carries `details.reason`: `cycle` (the destination is a moved folder or inside one; `details.folderId`), `too-deep` (the move would nest folders deeper than 100 levels; `details.maxDepth`) or `name-taken` (a moved folder's name is taken in the destination, ignoring case; `details.name`).
    /// </summary>
    WithRawResponseTask MoveIntoAsync(
        FoldersMoveIntoRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
