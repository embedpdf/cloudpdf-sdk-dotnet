using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemPagesDeleteLayout : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<ChangeItemPagesDeleteLayoutPagesItem> Pages { get; set; } =
        new List<ChangeItemPagesDeleteLayoutPagesItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<ChangeItemPagesDeleteLayoutNamedPagesItem> NamedPages { get; set; } =
        new List<ChangeItemPagesDeleteLayoutNamedPagesItem>();

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
