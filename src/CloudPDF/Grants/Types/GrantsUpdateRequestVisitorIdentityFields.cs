using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsUpdateRequestVisitorIdentityFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsUpdateRequestVisitorIdentityFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsUpdateRequestVisitorIdentityFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsUpdateRequestVisitorIdentityFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsUpdateRequestVisitorIdentityFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsUpdateRequestVisitorIdentityFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
