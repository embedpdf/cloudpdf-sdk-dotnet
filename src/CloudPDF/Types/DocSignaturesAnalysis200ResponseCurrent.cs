using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesAnalysis200ResponseCurrent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("verdict")]
    public required DocSignaturesAnalysis200ResponseCurrentVerdict Verdict { get; set; }

    [JsonPropertyName("complete")]
    public required bool Complete { get; set; }

    [JsonPropertyName("primary")]
    public DocSignaturesAnalysis200ResponseCurrentPrimary? Primary { get; set; }

    [JsonPropertyName("findings")]
    public IEnumerable<DocSignaturesAnalysis200ResponseCurrentFindingsItem> Findings { get; set; } =
        new List<DocSignaturesAnalysis200ResponseCurrentFindingsItem>();

    [JsonPropertyName("method")]
    public required DocSignaturesAnalysis200ResponseCurrentMethod Method { get; set; }

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
