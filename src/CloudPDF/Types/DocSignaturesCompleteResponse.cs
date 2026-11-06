using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesCompleteResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("status")]
    public required DocSignaturesCompleteResponseStatus Status { get; set; }

    [JsonPropertyName("signature")]
    public required DocSignaturesCompleteResponseSignature Signature { get; set; }

    [JsonPropertyName("version")]
    public required DocSignaturesCompleteResponseVersion Version { get; set; }

    [JsonPropertyName("previous")]
    public required DocSignaturesCompleteResponsePrevious Previous { get; set; }

    [JsonPropertyName("protection")]
    public required DocSignaturesCompleteResponseProtection Protection { get; set; }

    [JsonPropertyName("meta")]
    public required MutationMeta Meta { get; set; }

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
