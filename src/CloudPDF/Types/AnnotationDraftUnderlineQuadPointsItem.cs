using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationDraftUnderlineQuadPointsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("upperLeft")]
    public required AnnotationDraftUnderlineQuadPointsItemUpperLeft UpperLeft { get; set; }

    [JsonPropertyName("upperRight")]
    public required AnnotationDraftUnderlineQuadPointsItemUpperRight UpperRight { get; set; }

    [JsonPropertyName("lowerLeft")]
    public required AnnotationDraftUnderlineQuadPointsItemLowerLeft LowerLeft { get; set; }

    [JsonPropertyName("lowerRight")]
    public required AnnotationDraftUnderlineQuadPointsItemLowerRight LowerRight { get; set; }

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
