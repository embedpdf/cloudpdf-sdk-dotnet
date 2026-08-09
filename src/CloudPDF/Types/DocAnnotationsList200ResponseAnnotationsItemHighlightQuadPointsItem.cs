using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemHighlightQuadPointsItem
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("p1")]
    public required DocAnnotationsList200ResponseAnnotationsItemHighlightQuadPointsItemP1 P1 { get; set; }

    [JsonPropertyName("p2")]
    public required DocAnnotationsList200ResponseAnnotationsItemHighlightQuadPointsItemP2 P2 { get; set; }

    [JsonPropertyName("p3")]
    public required DocAnnotationsList200ResponseAnnotationsItemHighlightQuadPointsItemP3 P3 { get; set; }

    [JsonPropertyName("p4")]
    public required DocAnnotationsList200ResponseAnnotationsItemHighlightQuadPointsItemP4 P4 { get; set; }

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
