using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ListDocumentsRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Only documents in this state. Without it, every state except deleting.
    /// </summary>
    [JsonIgnore]
    public ListDocumentsRequestState? State { get; set; }

    /// <summary>
    /// Only documents whose name contains this text, ignoring case.
    /// </summary>
    [JsonIgnore]
    public string? Q { get; set; }

    /// <summary>
    /// Only documents directly in this folder (root: the top level). Without it, documents in every folder.
    /// </summary>
    [JsonIgnore]
    public string? FolderId { get; set; }

    /// <summary>
    /// createdAt (default), name (ignoring case), or size (stored bytes; 0 while pending).
    /// </summary>
    [JsonIgnore]
    public ListDocumentsRequestSort? Sort { get; set; }

    /// <summary>
    /// Defaults to the reading order of the sort: A to Z for name, newest and largest first otherwise.
    /// </summary>
    [JsonIgnore]
    public ListDocumentsRequestOrder? Order { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
