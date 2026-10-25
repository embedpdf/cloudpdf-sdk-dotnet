using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemPagesRestoreLayout : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pageCount")]
    public required int PageCount { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<ChangeItemPagesRestoreLayoutPagesItem> Pages { get; set; } =
        new List<ChangeItemPagesRestoreLayoutPagesItem>();

    [JsonPropertyName("namedPages")]
    public IEnumerable<ChangeItemPagesRestoreLayoutNamedPagesItem> NamedPages { get; set; } =
        new List<ChangeItemPagesRestoreLayoutNamedPagesItem>();

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
