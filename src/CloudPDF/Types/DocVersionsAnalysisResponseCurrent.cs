using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsAnalysisResponseCurrent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("verdict")]
    public required DocVersionsAnalysisResponseCurrentVerdict Verdict { get; set; }

    [JsonPropertyName("complete")]
    public required bool Complete { get; set; }

    [JsonPropertyName("primary")]
    public DocVersionsAnalysisResponseCurrentPrimary? Primary { get; set; }

    [JsonPropertyName("findings")]
    public IEnumerable<DocVersionsAnalysisResponseCurrentFindingsItem> Findings { get; set; } =
        new List<DocVersionsAnalysisResponseCurrentFindingsItem>();

    [JsonPropertyName("method")]
    public required DocVersionsAnalysisResponseCurrentMethod Method { get; set; }

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
