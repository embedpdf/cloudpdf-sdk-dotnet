using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocumentsGet200ResponseDocument : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }

    [JsonPropertyName("state")]
    public required DocumentsGet200ResponseDocumentState State { get; set; }

    [JsonPropertyName("baseSha")]
    public string? BaseSha { get; set; }

    [JsonPropertyName("storageSizeBytes")]
    public double? StorageSizeBytes { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object?>? Metadata { get; set; }

    [JsonPropertyName("idempotencyKey")]
    public string? IdempotencyKey { get; set; }

    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    [JsonPropertyName("thumbnailState")]
    public DocumentsGet200ResponseDocumentThumbnailState? ThumbnailState { get; set; }

    [JsonPropertyName("thumbnailUrl")]
    public string? ThumbnailUrl { get; set; }

    [JsonPropertyName("createdAt")]
    public required double CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required double UpdatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
