using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesViewports200ResponseItemMeasureRl : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocPagesViewports200ResponseItemMeasureRlXItem> X { get; set; } =
        new List<DocPagesViewports200ResponseItemMeasureRlXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocPagesViewports200ResponseItemMeasureRlYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocPagesViewports200ResponseItemMeasureRlDistanceItem> Distance { get; set; } =
        new List<DocPagesViewports200ResponseItemMeasureRlDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocPagesViewports200ResponseItemMeasureRlAreaItem> Area { get; set; } =
        new List<DocPagesViewports200ResponseItemMeasureRlAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocPagesViewports200ResponseItemMeasureRlAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocPagesViewports200ResponseItemMeasureRlSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocPagesViewports200ResponseItemMeasureRlOrigin? Origin { get; set; }

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
