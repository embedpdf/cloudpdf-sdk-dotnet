using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsArchiveResponseGrantVisitorIdentityFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayName")]
    public GrantsArchiveResponseGrantVisitorIdentityFieldsDisplayName? DisplayName { get; set; }

    [JsonPropertyName("email")]
    public GrantsArchiveResponseGrantVisitorIdentityFieldsEmail? Email { get; set; }

    [JsonPropertyName("title")]
    public GrantsArchiveResponseGrantVisitorIdentityFieldsTitle? Title { get; set; }

    [JsonPropertyName("organization")]
    public GrantsArchiveResponseGrantVisitorIdentityFieldsOrganization? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit? OrganizationalUnit { get; set; }

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
