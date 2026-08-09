using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesFlatten200ResponseMeta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("affectedPages")]
    public IEnumerable<DocPagesFlatten200ResponseMetaAffectedPagesItem> AffectedPages { get; set; } =
        new List<DocPagesFlatten200ResponseMetaAffectedPagesItem>();

    [JsonPropertyName("cacheDelta")]
    public DocPagesFlatten200ResponseMetaCacheDelta? CacheDelta { get; set; }

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
