using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationPolylineMeasureRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<AnnotationPolylineMeasureRectilinearXItem> X { get; set; } =
        new List<AnnotationPolylineMeasureRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<AnnotationPolylineMeasureRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<AnnotationPolylineMeasureRectilinearDistanceItem> Distance { get; set; } =
        new List<AnnotationPolylineMeasureRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<AnnotationPolylineMeasureRectilinearAreaItem> Area { get; set; } =
        new List<AnnotationPolylineMeasureRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<AnnotationPolylineMeasureRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<AnnotationPolylineMeasureRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public AnnotationPolylineMeasureRectilinearOrigin? Origin { get; set; }

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
