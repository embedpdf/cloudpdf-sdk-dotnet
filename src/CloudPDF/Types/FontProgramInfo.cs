using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FontProgramInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displayHash")]
    public string? DisplayHash { get; set; }

    [JsonPropertyName("sourceHash")]
    public string? SourceHash { get; set; }

    [JsonPropertyName("embedded")]
    public required FontProgramInfoEmbedded Embedded { get; set; }

    [JsonPropertyName("format")]
    public FontProgramInfoFormat? Format { get; set; }

    [JsonPropertyName("embeddingPermission")]
    public FontProgramInfoEmbeddingPermission? EmbeddingPermission { get; set; }

    [JsonPropertyName("canDownload")]
    public required bool CanDownload { get; set; }

    [JsonPropertyName("covers")]
    public IEnumerable<FontProgramInfoCoversItem> Covers { get; set; } =
        new List<FontProgramInfoCoversItem>();

    [JsonPropertyName("ascent")]
    public required double Ascent { get; set; }

    [JsonPropertyName("descent")]
    public required double Descent { get; set; }

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
