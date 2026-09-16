using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsAnalysis200ResponseCurrent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("verdict")]
    public required DocVersionsAnalysis200ResponseCurrentVerdict Verdict { get; set; }

    [JsonPropertyName("complete")]
    public required bool Complete { get; set; }

    [JsonPropertyName("primary")]
    public DocVersionsAnalysis200ResponseCurrentPrimary? Primary { get; set; }

    [JsonPropertyName("findings")]
    public IEnumerable<DocVersionsAnalysis200ResponseCurrentFindingsItem> Findings { get; set; } =
        new List<DocVersionsAnalysis200ResponseCurrentFindingsItem>();

    [JsonPropertyName("method")]
    public required DocVersionsAnalysis200ResponseCurrentMethod Method { get; set; }

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
