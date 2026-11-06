using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesRemoveNameResponseLayout : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<DocPagesRemoveNameResponseLayoutPagesItem> Pages { get; set; } =
        new List<DocPagesRemoveNameResponseLayoutPagesItem>();

    [JsonPropertyName("labels")]
    public IEnumerable<DocPagesRemoveNameResponseLayoutLabelsItem> Labels { get; set; } =
        new List<DocPagesRemoveNameResponseLayoutLabelsItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<DocPagesRemoveNameResponseLayoutNamedPagesItem> NamedPages { get; set; } =
        new List<DocPagesRemoveNameResponseLayoutNamedPagesItem>();

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
