using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemPagesCopyLayoutPagesItemBoxes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("media")]
    public required ChangeItemPagesCopyLayoutPagesItemBoxesMedia Media { get; set; }

    [JsonPropertyName("crop")]
    public required ChangeItemPagesCopyLayoutPagesItemBoxesCrop Crop { get; set; }

    [JsonPropertyName("bleed")]
    public required ChangeItemPagesCopyLayoutPagesItemBoxesBleed Bleed { get; set; }

    [JsonPropertyName("trim")]
    public required ChangeItemPagesCopyLayoutPagesItemBoxesTrim Trim { get; set; }

    [JsonPropertyName("art")]
    public required ChangeItemPagesCopyLayoutPagesItemBoxesArt Art { get; set; }

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
