using CloudPDF;
using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[Serializable]
public record DocPagesSetScaleRequestMeasure : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("subtype")]
    public required DocPagesSetScaleRequestMeasureSubtype Subtype { get; set; }

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocPagesSetScaleRequestMeasureXItem> X { get; set; } =
        new List<DocPagesSetScaleRequestMeasureXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocPagesSetScaleRequestMeasureYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocPagesSetScaleRequestMeasureDistanceItem> Distance { get; set; } =
        new List<DocPagesSetScaleRequestMeasureDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocPagesSetScaleRequestMeasureAreaItem> Area { get; set; } =
        new List<DocPagesSetScaleRequestMeasureAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocPagesSetScaleRequestMeasureAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocPagesSetScaleRequestMeasureSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocPagesSetScaleRequestMeasureOrigin? Origin { get; set; }

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
