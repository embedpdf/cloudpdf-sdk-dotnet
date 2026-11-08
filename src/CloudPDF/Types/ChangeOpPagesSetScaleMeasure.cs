using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeOpPagesSetScaleMeasure : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("subtype")]
    public required ChangeOpPagesSetScaleMeasureSubtype Subtype { get; set; }

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<ChangeOpPagesSetScaleMeasureXItem> X { get; set; } =
        new List<ChangeOpPagesSetScaleMeasureXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<ChangeOpPagesSetScaleMeasureYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<ChangeOpPagesSetScaleMeasureDistanceItem> Distance { get; set; } =
        new List<ChangeOpPagesSetScaleMeasureDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<ChangeOpPagesSetScaleMeasureAreaItem> Area { get; set; } =
        new List<ChangeOpPagesSetScaleMeasureAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<ChangeOpPagesSetScaleMeasureAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<ChangeOpPagesSetScaleMeasureSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public ChangeOpPagesSetScaleMeasureOrigin? Origin { get; set; }

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
