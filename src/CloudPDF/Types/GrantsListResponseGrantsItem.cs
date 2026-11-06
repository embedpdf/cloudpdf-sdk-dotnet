using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsListResponseGrantsItem : IJsonOnDeserialized
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

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("layerMode")]
    public required GrantsListResponseGrantsItemLayerMode LayerMode { get; set; }

    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    [JsonPropertyName("keepVisitorLayers")]
    public required bool KeepVisitorLayers { get; set; }

    [JsonPropertyName("visitorIdleSeconds")]
    public int? VisitorIdleSeconds { get; set; }

    [JsonPropertyName("visitorIdentity")]
    public GrantsListResponseGrantsItemVisitorIdentity? VisitorIdentity { get; set; }

    [JsonPropertyName("identity")]
    public Identity? Identity { get; set; }

    [JsonPropertyName("scope")]
    public IEnumerable<string> Scope { get; set; } = new List<string>();

    [JsonPropertyName("origins")]
    public IEnumerable<string>? Origins { get; set; }

    [JsonPropertyName("passphraseProtected")]
    public required bool PassphraseProtected { get; set; }

    [JsonPropertyName("sessionTtlSeconds")]
    public required int SessionTtlSeconds { get; set; }

    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }

    [JsonPropertyName("archivedAt")]
    public DateTime? ArchivedAt { get; set; }

    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    [JsonPropertyName("exchangeCount")]
    public required int ExchangeCount { get; set; }

    [JsonPropertyName("lastExchangedAt")]
    public DateTime? LastExchangedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public required string CreatedBy { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
