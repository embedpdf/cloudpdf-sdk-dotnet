using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemPagesCopyLayout : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<ChangeItemPagesCopyLayoutPagesItem> Pages { get; set; } =
        new List<ChangeItemPagesCopyLayoutPagesItem>();

    [JsonPropertyName("labels")]
    public IEnumerable<ChangeItemPagesCopyLayoutLabelsItem> Labels { get; set; } =
        new List<ChangeItemPagesCopyLayoutLabelsItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<ChangeItemPagesCopyLayoutNamedPagesItem> NamedPages { get; set; } =
        new List<ChangeItemPagesCopyLayoutNamedPagesItem>();

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
