using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocManifest200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("docVersion")]
    public required int DocVersion { get; set; }

    [JsonPropertyName("layoutVersion")]
    public required int LayoutVersion { get; set; }

    [JsonPropertyName("metadataVersion")]
    public required int MetadataVersion { get; set; }

    [JsonPropertyName("actionsVersion")]
    public int? ActionsVersion { get; set; }

    [JsonPropertyName("attachmentsVersion")]
    public int? AttachmentsVersion { get; set; }

    [JsonPropertyName("auditHead")]
    public required int AuditHead { get; set; }

    [JsonPropertyName("baseSha")]
    public required string BaseSha { get; set; }

    [JsonPropertyName("scopes")]
    public DocManifest200ResponseScopes? Scopes { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<DocManifest200ResponsePagesItem> Pages { get; set; } =
        new List<DocManifest200ResponsePagesItem>();

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
