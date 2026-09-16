using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesAnalysis200ResponseRestrictionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("signatureIndex")]
    public required int SignatureIndex { get; set; }

    [JsonPropertyName("revisionIndex")]
    public required int RevisionIndex { get; set; }

    [JsonPropertyName("source")]
    public required DocSignaturesAnalysis200ResponseRestrictionsItemSource Source { get; set; }

    [JsonPropertyName("own")]
    public required bool Own { get; set; }

    [JsonPropertyName("permission")]
    public double? Permission { get; set; }

    [JsonPropertyName("fields")]
    public object? Fields { get; set; }

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
