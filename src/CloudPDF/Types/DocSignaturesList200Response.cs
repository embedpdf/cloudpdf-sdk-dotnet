using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesList200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("chainValid")]
    public required bool ChainValid { get; set; }

    [JsonPropertyName("revisions")]
    public IEnumerable<DocSignaturesList200ResponseRevisionsItem> Revisions { get; set; } =
        new List<DocSignaturesList200ResponseRevisionsItem>();

    [JsonPropertyName("signatures")]
    public IEnumerable<DocSignaturesList200ResponseSignaturesItem> Signatures { get; set; } =
        new List<DocSignaturesList200ResponseSignaturesItem>();

    [JsonPropertyName("protection")]
    public required DocSignaturesList200ResponseProtection Protection { get; set; }

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
