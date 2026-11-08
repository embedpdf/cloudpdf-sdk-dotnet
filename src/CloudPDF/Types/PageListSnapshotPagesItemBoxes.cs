using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PageListSnapshotPagesItemBoxes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("media")]
    public required PageListSnapshotPagesItemBoxesMedia Media { get; set; }

    [JsonPropertyName("crop")]
    public required PageListSnapshotPagesItemBoxesCrop Crop { get; set; }

    [JsonPropertyName("bleed")]
    public required PageListSnapshotPagesItemBoxesBleed Bleed { get; set; }

    [JsonPropertyName("trim")]
    public required PageListSnapshotPagesItemBoxesTrim Trim { get; set; }

    [JsonPropertyName("art")]
    public required PageListSnapshotPagesItemBoxesArt Art { get; set; }

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
