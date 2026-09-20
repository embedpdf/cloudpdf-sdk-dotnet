using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItem> X { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlAreaItem> Area { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlOrigin? Origin { get; set; }

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
