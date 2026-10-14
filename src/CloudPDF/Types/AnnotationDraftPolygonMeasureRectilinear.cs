using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationDraftPolygonMeasureRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<AnnotationDraftPolygonMeasureRectilinearXItem> X { get; set; } =
        new List<AnnotationDraftPolygonMeasureRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<AnnotationDraftPolygonMeasureRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<AnnotationDraftPolygonMeasureRectilinearDistanceItem> Distance { get; set; } =
        new List<AnnotationDraftPolygonMeasureRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<AnnotationDraftPolygonMeasureRectilinearAreaItem> Area { get; set; } =
        new List<AnnotationDraftPolygonMeasureRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<AnnotationDraftPolygonMeasureRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<AnnotationDraftPolygonMeasureRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public AnnotationDraftPolygonMeasureRectilinearOrigin? Origin { get; set; }

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
