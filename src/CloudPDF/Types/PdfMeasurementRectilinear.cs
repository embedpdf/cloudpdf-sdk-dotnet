using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PdfMeasurementRectilinear : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ratio")]
    public string? Ratio { get; set; }

    [JsonPropertyName("x")]
    public IEnumerable<PdfMeasurementRectilinearXItem> X { get; set; } =
        new List<PdfMeasurementRectilinearXItem>();

    [JsonPropertyName("y")]
    public IEnumerable<PdfMeasurementRectilinearYItem>? Y { get; set; }

    [JsonPropertyName("distance")]
    public IEnumerable<PdfMeasurementRectilinearDistanceItem> Distance { get; set; } =
        new List<PdfMeasurementRectilinearDistanceItem>();

    [JsonPropertyName("area")]
    public IEnumerable<PdfMeasurementRectilinearAreaItem> Area { get; set; } =
        new List<PdfMeasurementRectilinearAreaItem>();

    [JsonPropertyName("angle")]
    public IEnumerable<PdfMeasurementRectilinearAngleItem>? Angle { get; set; }

    [JsonPropertyName("slope")]
    public IEnumerable<PdfMeasurementRectilinearSlopeItem>? Slope { get; set; }

    [JsonPropertyName("origin")]
    public PdfMeasurementRectilinearOrigin? Origin { get; set; }

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
