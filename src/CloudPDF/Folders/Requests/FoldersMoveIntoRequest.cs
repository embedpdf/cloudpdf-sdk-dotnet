using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FoldersMoveIntoRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    /// <summary>
    /// A folder id, or root for the top level.
    /// </summary>
    [JsonIgnore]
    public required string FolderId { get; set; }

    [JsonPropertyName("documentIds")]
    public IEnumerable<string>? DocumentIds { get; set; }

    [JsonPropertyName("folderIds")]
    public IEnumerable<string>? FolderIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
