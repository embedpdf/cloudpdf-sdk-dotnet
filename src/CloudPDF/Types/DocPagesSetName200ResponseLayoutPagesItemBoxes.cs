using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesSetName200ResponseLayoutPagesItemBoxes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("media")]
    public required DocPagesSetName200ResponseLayoutPagesItemBoxesMedia Media { get; set; }

    [JsonPropertyName("crop")]
    public required DocPagesSetName200ResponseLayoutPagesItemBoxesCrop Crop { get; set; }

    [JsonPropertyName("bleed")]
    public required DocPagesSetName200ResponseLayoutPagesItemBoxesBleed Bleed { get; set; }

    [JsonPropertyName("trim")]
    public required DocPagesSetName200ResponseLayoutPagesItemBoxesTrim Trim { get; set; }

    [JsonPropertyName("art")]
    public required DocPagesSetName200ResponseLayoutPagesItemBoxesArt Art { get; set; }

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
