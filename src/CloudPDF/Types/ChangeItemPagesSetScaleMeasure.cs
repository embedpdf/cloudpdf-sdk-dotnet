using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemPagesSetScaleMeasure : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("subtype")]
    public required ChangeItemPagesSetScaleMeasureSubtype Subtype { get; set; }

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<ChangeItemPagesSetScaleMeasureXItem> X { get; set; } =
        new List<ChangeItemPagesSetScaleMeasureXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<ChangeItemPagesSetScaleMeasureYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<ChangeItemPagesSetScaleMeasureDistanceItem> Distance { get; set; } =
        new List<ChangeItemPagesSetScaleMeasureDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<ChangeItemPagesSetScaleMeasureAreaItem> Area { get; set; } =
        new List<ChangeItemPagesSetScaleMeasureAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<ChangeItemPagesSetScaleMeasureAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<ChangeItemPagesSetScaleMeasureSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public ChangeItemPagesSetScaleMeasureOrigin? Origin { get; set; }

    [JsonPropertyName("cyx")]
    public double? Cyx { get; set; }

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
