using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationUnderlineQuadPointsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("upperLeft")]
    public required AnnotationUnderlineQuadPointsItemUpperLeft UpperLeft { get; set; }

    [JsonPropertyName("upperRight")]
    public required AnnotationUnderlineQuadPointsItemUpperRight UpperRight { get; set; }

    [JsonPropertyName("lowerLeft")]
    public required AnnotationUnderlineQuadPointsItemLowerLeft LowerLeft { get; set; }

    [JsonPropertyName("lowerRight")]
    public required AnnotationUnderlineQuadPointsItemLowerRight LowerRight { get; set; }

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
