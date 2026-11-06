using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchangeResponse : IJsonOnDeserialized
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
    public required GrantsExchangeResponseLayerMode LayerMode { get; set; }

    [JsonPropertyName("visitor")]
    public required GrantsExchangeResponseVisitor Visitor { get; set; }

    [JsonPropertyName("expiresAt")]
    public required DateTime ExpiresAt { get; set; }

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
