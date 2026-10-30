using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsCreateRequestVisitorIdentityFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsCreateRequestVisitorIdentityFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsCreateRequestVisitorIdentityFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsCreateRequestVisitorIdentityFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsCreateRequestVisitorIdentityFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
