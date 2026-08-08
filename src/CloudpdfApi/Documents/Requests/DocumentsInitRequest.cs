using CloudpdfApi.Core;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

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

    [JsonPropertyName("dedupMode")]
    public DocumentsInitRequestDedupMode? DedupMode { get; set; }

    [JsonPropertyName("docId")]
    public string? DocId { get; set; }

    [JsonPropertyName("uploadTtlSec")]
    public double? UploadTtlSec { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
