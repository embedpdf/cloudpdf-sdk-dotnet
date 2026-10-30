using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchange200ResponseVisitorIdentityRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fields")]
    public required GrantsExchange200ResponseVisitorIdentityRequestFields Fields { get; set; }

    [JsonPropertyName("missing")]
    public IEnumerable<GrantsExchange200ResponseVisitorIdentityRequestMissingItem> Missing { get; set; } =
        new List<GrantsExchange200ResponseVisitorIdentityRequestMissingItem>();

    [JsonPropertyName("invalid")]
    public IEnumerable<GrantsExchange200ResponseVisitorIdentityRequestInvalidItem> Invalid { get; set; } =
        new List<GrantsExchange200ResponseVisitorIdentityRequestInvalidItem>();

    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    [JsonPropertyName("privacyUrl")]
    public string? PrivacyUrl { get; set; }

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
