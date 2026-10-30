using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsUpdate200ResponseGrantVisitorIdentityFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
