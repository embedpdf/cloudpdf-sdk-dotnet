using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRl : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlXItem> X { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItem> Area { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocAnnotationsList200ResponseAnnotationsItemPolygonMeasureRlOrigin? Origin { get; set; }

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
