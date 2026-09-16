using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsSignatures200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("chainValid")]
    public required bool ChainValid { get; set; }

    [JsonPropertyName("revisions")]
    public IEnumerable<DocVersionsSignatures200ResponseRevisionsItem> Revisions { get; set; } =
        new List<DocVersionsSignatures200ResponseRevisionsItem>();

    [JsonPropertyName("signatures")]
    public IEnumerable<DocVersionsSignatures200ResponseSignaturesItem> Signatures { get; set; } =
        new List<DocVersionsSignatures200ResponseSignaturesItem>();

    [JsonPropertyName("protection")]
    public required DocVersionsSignatures200ResponseProtection Protection { get; set; }

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
