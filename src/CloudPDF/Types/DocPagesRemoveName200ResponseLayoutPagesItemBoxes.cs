using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesRemoveName200ResponseLayoutPagesItemBoxes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("media")]
    public required DocPagesRemoveName200ResponseLayoutPagesItemBoxesMedia Media { get; set; }

    [JsonPropertyName("crop")]
    public required DocPagesRemoveName200ResponseLayoutPagesItemBoxesCrop Crop { get; set; }

    [JsonPropertyName("bleed")]
    public required DocPagesRemoveName200ResponseLayoutPagesItemBoxesBleed Bleed { get; set; }

    [JsonPropertyName("trim")]
    public required DocPagesRemoveName200ResponseLayoutPagesItemBoxesTrim Trim { get; set; }

    [JsonPropertyName("art")]
    public required DocPagesRemoveName200ResponseLayoutPagesItemBoxesArt Art { get; set; }

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
