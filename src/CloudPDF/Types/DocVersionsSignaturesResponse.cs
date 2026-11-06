using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsSignaturesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("chainValid")]
    public required bool ChainValid { get; set; }

    [JsonPropertyName("revisions")]
    public IEnumerable<DocVersionsSignaturesResponseRevisionsItem> Revisions { get; set; } =
        new List<DocVersionsSignaturesResponseRevisionsItem>();

    [JsonPropertyName("signatures")]
    public IEnumerable<DocVersionsSignaturesResponseSignaturesItem> Signatures { get; set; } =
        new List<DocVersionsSignaturesResponseSignaturesItem>();

    [JsonPropertyName("protection")]
    public required DocVersionsSignaturesResponseProtection Protection { get; set; }

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
