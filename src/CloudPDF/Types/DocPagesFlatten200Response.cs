using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocPagesFlatten200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pages")]
    public IEnumerable<PageRef> Pages { get; set; } = new List<PageRef>();

    [JsonPropertyName("usage")]
    public required DocPagesFlatten200ResponseUsage Usage { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<DocPagesFlatten200ResponseResultsItem> Results { get; set; } =
        new List<DocPagesFlatten200ResponseResultsItem>();

    [JsonPropertyName("meta")]
    public required MutationMeta Meta { get; set; }

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
