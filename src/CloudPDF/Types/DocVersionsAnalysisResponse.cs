using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsAnalysisResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("mode")]
    public required DocVersionsAnalysisResponseMode Mode { get; set; }

    [JsonPropertyName("policyVersion")]
    public required int PolicyVersion { get; set; }

    [JsonPropertyName("basis")]
    public required DocVersionsAnalysisResponseBasis Basis { get; set; }

    [JsonPropertyName("since")]
    public required DocVersionsAnalysisResponseSince Since { get; set; }

    [JsonPropertyName("until")]
    public required DocVersionsAnalysisResponseUntil Until { get; set; }

    [JsonPropertyName("restrictions")]
    public IEnumerable<DocVersionsAnalysisResponseRestrictionsItem> Restrictions { get; set; } =
        new List<DocVersionsAnalysisResponseRestrictionsItem>();

    [JsonPropertyName("current")]
    public required DocVersionsAnalysisResponseCurrent Current { get; set; }

    [JsonPropertyName("later")]
    public required DocVersionsAnalysisResponseLater Later { get; set; }

    [JsonPropertyName("verdict")]
    public required DocVersionsAnalysisResponseVerdict Verdict { get; set; }

    [JsonPropertyName("steps")]
    public IEnumerable<object> Steps { get; set; } = new List<object>();

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
