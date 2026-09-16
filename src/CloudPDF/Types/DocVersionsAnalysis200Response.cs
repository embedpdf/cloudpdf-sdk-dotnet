using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsAnalysis200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("mode")]
    public required DocVersionsAnalysis200ResponseMode Mode { get; set; }

    [JsonPropertyName("policyVersion")]
    public required int PolicyVersion { get; set; }

    [JsonPropertyName("basis")]
    public required DocVersionsAnalysis200ResponseBasis Basis { get; set; }

    [JsonPropertyName("since")]
    public required DocVersionsAnalysis200ResponseSince Since { get; set; }

    [JsonPropertyName("until")]
    public required DocVersionsAnalysis200ResponseUntil Until { get; set; }

    [JsonPropertyName("restrictions")]
    public IEnumerable<DocVersionsAnalysis200ResponseRestrictionsItem> Restrictions { get; set; } =
        new List<DocVersionsAnalysis200ResponseRestrictionsItem>();

    [JsonPropertyName("current")]
    public required DocVersionsAnalysis200ResponseCurrent Current { get; set; }

    [JsonPropertyName("later")]
    public required DocVersionsAnalysis200ResponseLater Later { get; set; }

    [JsonPropertyName("verdict")]
    public required DocVersionsAnalysis200ResponseVerdict Verdict { get; set; }

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
