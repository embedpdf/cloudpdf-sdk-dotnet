using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationPolygonMeasureRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<AnnotationPolygonMeasureRectilinearXItem> X { get; set; } =
        new List<AnnotationPolygonMeasureRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<AnnotationPolygonMeasureRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<AnnotationPolygonMeasureRectilinearDistanceItem> Distance { get; set; } =
        new List<AnnotationPolygonMeasureRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<AnnotationPolygonMeasureRectilinearAreaItem> Area { get; set; } =
        new List<AnnotationPolygonMeasureRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<AnnotationPolygonMeasureRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<AnnotationPolygonMeasureRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public AnnotationPolygonMeasureRectilinearOrigin? Origin { get; set; }

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
