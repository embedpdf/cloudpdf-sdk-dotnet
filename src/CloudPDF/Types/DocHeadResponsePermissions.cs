using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocHeadResponsePermissions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("known")]
    public required bool Known { get; set; }

    [JsonPropertyName("flags")]
    public PdfPermissionFlags? Flags { get; set; }

    [JsonPropertyName("allAllowed")]
    public bool? AllAllowed { get; set; }

    [JsonPropertyName("openedAs")]
    public DocHeadResponsePermissionsOpenedAs? OpenedAs { get; set; }

    [JsonPropertyName("securityHandlerRevision")]
    public int? SecurityHandlerRevision { get; set; }

    [JsonPropertyName("canUpgradeToOwner")]
    public required bool CanUpgradeToOwner { get; set; }

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
