using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocumentsInitRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonPropertyName("contentLength")]
    public required double ContentLength { get; set; }

    [JsonPropertyName("contentSha256")]
    public required string ContentSha256 { get; set; }

    /// <summary>
    /// What people call the document: shown in dashboards, searched and sorted by. 1 to 255 characters, no control characters, no leading or trailing whitespace. Names need not be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A folder id, or root for the top level.
    /// </summary>
    [JsonPropertyName("folderId")]
    public string? FolderId { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object?>? Metadata { get; set; }

    [JsonPropertyName("idempotencyKey")]
    public string? IdempotencyKey { get; set; }

    /// <summary>
    /// always-create (default) creates a new document every time. reuse-existing returns a document that already holds the same content instead of storing it twice.
    /// </summary>
    [JsonPropertyName("dedupMode")]
    public DocumentsInitRequestDedupMode? DedupMode { get; set; }

    [JsonPropertyName("docId")]
    public string? DocId { get; set; }

    [JsonPropertyName("uploadTtlSec")]
    public double? UploadTtlSec { get; set; }

    [JsonPropertyName("uploadPreference")]
    public DocumentsInitRequestUploadPreference? UploadPreference { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
