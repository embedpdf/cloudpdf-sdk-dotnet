using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsCreate200ResponseGrantVisitorIdentityFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsCreate200ResponseGrantVisitorIdentityFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsCreate200ResponseGrantVisitorIdentityFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsCreate200ResponseGrantVisitorIdentityFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
