using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesAnalysis200ResponseCurrentPrimary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rule")]
    public required string Rule { get; set; }

    [JsonPropertyName("verdict")]
    public required DocSignaturesAnalysis200ResponseCurrentPrimaryVerdict Verdict { get; set; }

    [JsonPropertyName("objectNumber")]
    public required int ObjectNumber { get; set; }

    [JsonPropertyName("edge")]
    public string? Edge { get; set; }

    [JsonPropertyName("detail")]
    public string? Detail { get; set; }

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
