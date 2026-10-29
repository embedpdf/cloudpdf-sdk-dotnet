using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FoldersUpdateRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string FolderId { get; set; }

    /// <summary>
    /// What people call the folder: 1 to 255 characters, no control characters, no leading or trailing whitespace, and unique among the folder's siblings, ignoring case.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
