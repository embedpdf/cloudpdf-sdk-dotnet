using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocRedactionsApply200ResponseMetaCacheDelta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("previousDocVersion")]
    public required int PreviousDocVersion { get; set; }

    [JsonPropertyName("docVersion")]
    public required int DocVersion { get; set; }

    [JsonPropertyName("annotationsVersion")]
    public int? AnnotationsVersion { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<DocRedactionsApply200ResponseMetaCacheDeltaPagesItem> Pages { get; set; } =
        new List<DocRedactionsApply200ResponseMetaCacheDeltaPagesItem>();

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
