using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationLineMeasureRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<AnnotationLineMeasureRectilinearXItem> X { get; set; } =
        new List<AnnotationLineMeasureRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<AnnotationLineMeasureRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<AnnotationLineMeasureRectilinearDistanceItem> Distance { get; set; } =
        new List<AnnotationLineMeasureRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<AnnotationLineMeasureRectilinearAreaItem> Area { get; set; } =
        new List<AnnotationLineMeasureRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<AnnotationLineMeasureRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<AnnotationLineMeasureRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public AnnotationLineMeasureRectilinearOrigin? Origin { get; set; }

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
