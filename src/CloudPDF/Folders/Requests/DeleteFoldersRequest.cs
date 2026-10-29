using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DeleteFoldersRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string FolderId { get; set; }

    /// <summary>
    /// true deletes everything in the folder too. Never the default.
    /// </summary>
    [JsonIgnore]
    public bool? Recursive { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
