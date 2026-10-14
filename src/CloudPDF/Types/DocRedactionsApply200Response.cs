using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocRedactionsApply200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("scope")]
    public required DocRedactionsApply200ResponseScope Scope { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<DocRedactionsApply200ResponseResultsItem> Results { get; set; } =
        new List<DocRedactionsApply200ResponseResultsItem>();

    [JsonPropertyName("removedAnnotationCount")]
    public required int RemovedAnnotationCount { get; set; }

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
