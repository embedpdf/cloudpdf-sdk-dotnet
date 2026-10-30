using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchange200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("token")]
    public required string Token { get; set; }

    [JsonPropertyName("docId")]
    public required string DocId { get; set; }

    [JsonPropertyName("layerName")]
    public required string LayerName { get; set; }

    [JsonPropertyName("layerMode")]
    public required GrantsExchange200ResponseLayerMode LayerMode { get; set; }

    [JsonPropertyName("visitor")]
    public required GrantsExchange200ResponseVisitor Visitor { get; set; }

    [JsonPropertyName("expiresAt")]
    public required double ExpiresAt { get; set; }

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
