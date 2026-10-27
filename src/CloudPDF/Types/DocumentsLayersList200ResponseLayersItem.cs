using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocumentsLayersList200ResponseLayersItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("docId")]
    public required string DocId { get; set; }

    [JsonPropertyName("layerName")]
    public required string LayerName { get; set; }

    [JsonPropertyName("shareId")]
    public string? ShareId { get; set; }

    [JsonPropertyName("visitorId")]
    public string? VisitorId { get; set; }

    [JsonPropertyName("storageSizeBytes")]
    public double? StorageSizeBytes { get; set; }

    [JsonPropertyName("createdAt")]
    public required double CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required double UpdatedAt { get; set; }

    [JsonPropertyName("lastSeenAt")]
    public double? LastSeenAt { get; set; }

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
