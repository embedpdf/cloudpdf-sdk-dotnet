using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocumentsImportFromRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonPropertyName("source")]
    public required DocumentsImportFromRequestSource Source { get; set; }

    [JsonPropertyName("expected")]
    public DocumentsImportFromRequestExpected? Expected { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object?>? Metadata { get; set; }

    [JsonPropertyName("idempotencyKey")]
    public string? IdempotencyKey { get; set; }

    [JsonPropertyName("dedupMode")]
    public DocumentsImportFromRequestDedupMode? DedupMode { get; set; }

    [JsonPropertyName("docId")]
    public string? DocId { get; set; }

    [JsonPropertyName("mode")]
    public DocumentsImportFromRequestMode? Mode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
