using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocPagesFlatten200ResponseMetaAffectedPagesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("revision")]
    public required DocPagesFlatten200ResponseMetaAffectedPagesItemRevision Revision { get; set; }

    [JsonPropertyName("weakAnnotationState")]
    public required DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState WeakAnnotationState { get; set; }

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
