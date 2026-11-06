using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchangeResponseVisitorIdentityRequestFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsExchangeResponseVisitorIdentityRequestFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsExchangeResponseVisitorIdentityRequestFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsExchangeResponseVisitorIdentityRequestFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
