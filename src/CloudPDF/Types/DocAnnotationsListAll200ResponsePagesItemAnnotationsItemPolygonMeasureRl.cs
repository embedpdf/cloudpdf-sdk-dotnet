using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItem> X { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlAreaItem> Area { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlOrigin? Origin { get; set; }

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
