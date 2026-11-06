using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsSignaturesResponseSignaturesItemSeedValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("parserVersion")]
    public int? ParserVersion { get; set; }

    [JsonPropertyName("parserVersionRequired")]
    public required bool ParserVersionRequired { get; set; }

    [JsonPropertyName("mdp")]
    public int? Mdp { get; set; }

    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    [JsonPropertyName("filterRequired")]
    public required bool FilterRequired { get; set; }

    [JsonPropertyName("subFilters")]
    public IEnumerable<string> SubFilters { get; set; } = new List<string>();

    [JsonPropertyName("subFiltersRequired")]
    public required bool SubFiltersRequired { get; set; }

    [JsonPropertyName("digestMethods")]
    public IEnumerable<string> DigestMethods { get; set; } = new List<string>();

    [JsonPropertyName("digestMethodsRequired")]
    public required bool DigestMethodsRequired { get; set; }

    [JsonPropertyName("reasons")]
    public IEnumerable<string> Reasons { get; set; } = new List<string>();

    [JsonPropertyName("reasonsRequired")]
    public required bool ReasonsRequired { get; set; }

    [JsonPropertyName("unsupportedRequired")]
    public required bool UnsupportedRequired { get; set; }

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
