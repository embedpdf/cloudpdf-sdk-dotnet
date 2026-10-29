using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FoldersCreateRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    /// <summary>
    /// What people call the folder: 1 to 255 characters, no control characters, no leading or trailing whitespace, and unique among the folder's siblings, ignoring case.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A folder id, or root for the top level.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
