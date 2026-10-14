using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record CacheDelta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("previousDocVersion")]
    public required int PreviousDocVersion { get; set; }

    [JsonPropertyName("docVersion")]
    public required int DocVersion { get; set; }

    [JsonPropertyName("annotationsVersion")]
    public int? AnnotationsVersion { get; set; }

    [JsonPropertyName("formsVersion")]
    public int? FormsVersion { get; set; }

    [JsonPropertyName("layoutVersion")]
    public int? LayoutVersion { get; set; }

    [JsonPropertyName("metadataVersion")]
    public int? MetadataVersion { get; set; }

    [JsonPropertyName("attachmentsVersion")]
    public int? AttachmentsVersion { get; set; }

    [JsonPropertyName("layerVersion")]
    public int? LayerVersion { get; set; }

    [JsonPropertyName("working")]
    public bool? Working { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<CacheDeltaPagesItem> Pages { get; set; } = new List<CacheDeltaPagesItem>();

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
