using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesList200ResponseSignaturesItemSeedValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("requiredFlags")]
    public required int RequiredFlags { get; set; }

    [JsonPropertyName("presentFlags")]
    public required int PresentFlags { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }

    [JsonPropertyName("mdp")]
    public double? Mdp { get; set; }

    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    [JsonPropertyName("subFilters")]
    public IEnumerable<string> SubFilters { get; set; } = new List<string>();

    [JsonPropertyName("digestMethods")]
    public IEnumerable<string> DigestMethods { get; set; } = new List<string>();

    [JsonPropertyName("reasons")]
    public IEnumerable<string> Reasons { get; set; } = new List<string>();

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
