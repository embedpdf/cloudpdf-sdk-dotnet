using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesListResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("chainValid")]
    public required bool ChainValid { get; set; }

    [JsonPropertyName("revisions")]
    public IEnumerable<DocSignaturesListResponseRevisionsItem> Revisions { get; set; } =
        new List<DocSignaturesListResponseRevisionsItem>();

    [JsonPropertyName("signatures")]
    public IEnumerable<DocSignaturesListResponseSignaturesItem> Signatures { get; set; } =
        new List<DocSignaturesListResponseSignaturesItem>();

    [JsonPropertyName("protection")]
    public required DocSignaturesListResponseProtection Protection { get; set; }

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
