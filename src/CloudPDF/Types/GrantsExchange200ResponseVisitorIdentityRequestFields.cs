using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchange200ResponseVisitorIdentityRequestFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsExchange200ResponseVisitorIdentityRequestFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
