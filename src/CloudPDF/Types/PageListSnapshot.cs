using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PageListSnapshot : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<PageListSnapshotPagesItem> Pages { get; set; } =
        new List<PageListSnapshotPagesItem>();

    [JsonPropertyName("labels")]
    public IEnumerable<PageListSnapshotLabelsItem> Labels { get; set; } =
        new List<PageListSnapshotLabelsItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<PageListSnapshotNamedPagesItem> NamedPages { get; set; } =
        new List<PageListSnapshotNamedPagesItem>();

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
