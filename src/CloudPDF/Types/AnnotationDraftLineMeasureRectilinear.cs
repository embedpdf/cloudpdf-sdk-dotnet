using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationDraftLineMeasureRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<AnnotationDraftLineMeasureRectilinearXItem> X { get; set; } =
        new List<AnnotationDraftLineMeasureRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<AnnotationDraftLineMeasureRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<AnnotationDraftLineMeasureRectilinearDistanceItem> Distance { get; set; } =
        new List<AnnotationDraftLineMeasureRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<AnnotationDraftLineMeasureRectilinearAreaItem> Area { get; set; } =
        new List<AnnotationDraftLineMeasureRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<AnnotationDraftLineMeasureRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<AnnotationDraftLineMeasureRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public AnnotationDraftLineMeasureRectilinearOrigin? Origin { get; set; }

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
