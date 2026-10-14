using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationHighlightQuadPointsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("upperLeft")]
    public required AnnotationHighlightQuadPointsItemUpperLeft UpperLeft { get; set; }

    [JsonPropertyName("upperRight")]
    public required AnnotationHighlightQuadPointsItemUpperRight UpperRight { get; set; }

    [JsonPropertyName("lowerLeft")]
    public required AnnotationHighlightQuadPointsItemLowerLeft LowerLeft { get; set; }

    [JsonPropertyName("lowerRight")]
    public required AnnotationHighlightQuadPointsItemLowerRight LowerRight { get; set; }

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
