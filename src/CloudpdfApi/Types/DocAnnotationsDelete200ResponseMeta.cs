using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsDelete200ResponseMeta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("affectedPages")]
    public IEnumerable<DocAnnotationsDelete200ResponseMetaAffectedPagesItem> AffectedPages { get; set; } =
        new List<DocAnnotationsDelete200ResponseMetaAffectedPagesItem>();

    [JsonPropertyName("cacheDelta")]
    public DocAnnotationsDelete200ResponseMetaCacheDelta? CacheDelta { get; set; }

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
