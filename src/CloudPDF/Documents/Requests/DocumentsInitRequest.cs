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
