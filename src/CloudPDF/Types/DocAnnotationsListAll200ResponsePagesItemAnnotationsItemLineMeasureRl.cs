using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRl
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlXItem> X { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAreaItem> Area { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineMeasureRlOrigin? Origin { get; set; }

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
