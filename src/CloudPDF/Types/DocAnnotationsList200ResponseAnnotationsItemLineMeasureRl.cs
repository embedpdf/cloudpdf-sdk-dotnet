using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItem> X { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlAreaItem> Area { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlOrigin? Origin { get; set; }

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
