using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesAnalysisResponseCurrent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("verdict")]
    public required DocSignaturesAnalysisResponseCurrentVerdict Verdict { get; set; }

    [JsonPropertyName("complete")]
    public required bool Complete { get; set; }

    [JsonPropertyName("primary")]
    public DocSignaturesAnalysisResponseCurrentPrimary? Primary { get; set; }

    [JsonPropertyName("findings")]
    public IEnumerable<DocSignaturesAnalysisResponseCurrentFindingsItem> Findings { get; set; } =
        new List<DocSignaturesAnalysisResponseCurrentFindingsItem>();

    [JsonPropertyName("method")]
    public required DocSignaturesAnalysisResponseCurrentMethod Method { get; set; }

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
