using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocManifestResponse : IJsonOnDeserialized
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

    [JsonPropertyName("annotationsVersion")]
    public int? AnnotationsVersion { get; set; }

    [JsonPropertyName("formsVersion")]
    public int? FormsVersion { get; set; }

    [JsonPropertyName("outlineVersion")]
    public int? OutlineVersion { get; set; }

    [JsonPropertyName("fontsVersion")]
    public int? FontsVersion { get; set; }

    [JsonPropertyName("contentsVersion")]
    public int? ContentsVersion { get; set; }

    [JsonPropertyName("auditHead")]
    public required int AuditHead { get; set; }

    [JsonPropertyName("baseSha256")]
    public required string BaseSha256 { get; set; }

    [JsonPropertyName("layerVersion")]
    public int? LayerVersion { get; set; }

    [JsonPropertyName("working")]
    public bool? Working { get; set; }

    [JsonPropertyName("baseSizeBytes")]
    public int? BaseSizeBytes { get; set; }

    [JsonPropertyName("scopes")]
    public DocManifestResponseScopes? Scopes { get; set; }

    [JsonPropertyName("protection")]
    public DocManifestResponseProtection? Protection { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<DocManifestResponsePagesItem> Pages { get; set; } =
        new List<DocManifestResponsePagesItem>();

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
