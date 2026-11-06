using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchangeResponseVisitorIdentityRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fields")]
    public required GrantsExchangeResponseVisitorIdentityRequestFields Fields { get; set; }

    [JsonPropertyName("missing")]
    public IEnumerable<GrantsExchangeResponseVisitorIdentityRequestMissingItem> Missing { get; set; } =
        new List<GrantsExchangeResponseVisitorIdentityRequestMissingItem>();

    [JsonPropertyName("invalid")]
    public IEnumerable<GrantsExchangeResponseVisitorIdentityRequestInvalidItem> Invalid { get; set; } =
        new List<GrantsExchangeResponseVisitorIdentityRequestInvalidItem>();

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
