using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesList200ResponseProtectionFieldLocksItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("signatureIndex")]
    public required int SignatureIndex { get; set; }

    [JsonPropertyName("source")]
    public required DocSignaturesList200ResponseProtectionFieldLocksItemSource Source { get; set; }

    [JsonPropertyName("spec")]
    public DocSignaturesList200ResponseProtectionFieldLocksItemSpec? Spec { get; set; }

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
