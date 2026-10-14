using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesViewports200ResponseViewportsItemMeasureRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItem> X { get; set; } =
        new List<DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<DocPagesViewports200ResponseViewportsItemMeasureRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItem> Distance { get; set; } =
        new List<DocPagesViewports200ResponseViewportsItemMeasureRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<DocPagesViewports200ResponseViewportsItemMeasureRectilinearAreaItem> Area { get; set; } =
        new List<DocPagesViewports200ResponseViewportsItemMeasureRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<DocPagesViewports200ResponseViewportsItemMeasureRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public DocPagesViewports200ResponseViewportsItemMeasureRectilinearOrigin? Origin { get; set; }

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
