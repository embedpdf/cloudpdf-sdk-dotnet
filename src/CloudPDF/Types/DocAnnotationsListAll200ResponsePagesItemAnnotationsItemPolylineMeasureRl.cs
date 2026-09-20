using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlXItem> X { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlAreaItem> Area { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRlOrigin? Origin { get; set; }

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
