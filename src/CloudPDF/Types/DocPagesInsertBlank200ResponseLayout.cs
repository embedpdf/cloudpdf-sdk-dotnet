using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesInsertBlank200ResponseLayout : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<DocPagesInsertBlank200ResponseLayoutPagesItem> Pages { get; set; } =
        new List<DocPagesInsertBlank200ResponseLayoutPagesItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<DocPagesInsertBlank200ResponseLayoutNamedPagesItem> NamedPages { get; set; } =
        new List<DocPagesInsertBlank200ResponseLayoutNamedPagesItem>();

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
