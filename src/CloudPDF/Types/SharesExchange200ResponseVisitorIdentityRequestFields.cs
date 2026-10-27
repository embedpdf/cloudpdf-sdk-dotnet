using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record SharesExchange200ResponseVisitorIdentityRequestFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public SharesExchange200ResponseVisitorIdentityRequestFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public SharesExchange200ResponseVisitorIdentityRequestFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public SharesExchange200ResponseVisitorIdentityRequestFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public SharesExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
