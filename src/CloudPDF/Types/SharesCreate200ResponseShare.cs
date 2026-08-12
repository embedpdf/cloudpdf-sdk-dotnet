using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record SharesCreate200ResponseShare : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }

    [JsonPropertyName("docId")]
    public required string DocId { get; set; }

    [JsonPropertyName("layerName")]
    public required string LayerName { get; set; }

    [JsonPropertyName("scope")]
    public IEnumerable<string> Scope { get; set; } = new List<string>();

    [JsonPropertyName("origins")]
    public IEnumerable<string>? Origins { get; set; }

    [JsonPropertyName("passwordProtected")]
    public required bool PasswordProtected { get; set; }

    [JsonPropertyName("sessionTtlSeconds")]
    public required double SessionTtlSeconds { get; set; }

    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }

    [JsonPropertyName("expiresAt")]
    public double? ExpiresAt { get; set; }

    [JsonPropertyName("exchangeCount")]
    public required double ExchangeCount { get; set; }

    [JsonPropertyName("lastExchangedAt")]
    public double? LastExchangedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public required string CreatedBy { get; set; }

    [JsonPropertyName("createdAt")]
    public required double CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required double UpdatedAt { get; set; }

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
