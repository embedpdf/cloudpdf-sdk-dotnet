using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record SharesExchange200ResponseVisitorIdentityRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fields")]
    public required SharesExchange200ResponseVisitorIdentityRequestFields Fields { get; set; }

    [JsonPropertyName("missing")]
    public IEnumerable<SharesExchange200ResponseVisitorIdentityRequestMissingItem> Missing { get; set; } =
        new List<SharesExchange200ResponseVisitorIdentityRequestMissingItem>();

    [JsonPropertyName("invalid")]
    public IEnumerable<SharesExchange200ResponseVisitorIdentityRequestInvalidItem> Invalid { get; set; } =
        new List<SharesExchange200ResponseVisitorIdentityRequestInvalidItem>();

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
