using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesSetNameResponseLayout : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<DocPagesSetNameResponseLayoutPagesItem> Pages { get; set; } =
        new List<DocPagesSetNameResponseLayoutPagesItem>();

    [JsonPropertyName("labels")]
    public IEnumerable<DocPagesSetNameResponseLayoutLabelsItem> Labels { get; set; } =
        new List<DocPagesSetNameResponseLayoutLabelsItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<DocPagesSetNameResponseLayoutNamedPagesItem> NamedPages { get; set; } =
        new List<DocPagesSetNameResponseLayoutNamedPagesItem>();

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
