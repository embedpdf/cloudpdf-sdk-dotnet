using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record OutlineMutationMeta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("affectedPages")]
    public IEnumerable<PageRef> AffectedPages { get; set; } = new List<PageRef>();

    [JsonPropertyName("cacheDelta")]
    public CacheDelta? CacheDelta { get; set; }

    [JsonPropertyName("opId")]
    public required string OpId { get; set; }

    [JsonPropertyName("undoable")]
    public required bool Undoable { get; set; }

    [JsonPropertyName("changed")]
    public IEnumerable<OutlineItemRef> Changed { get; set; } = new List<OutlineItemRef>();

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
