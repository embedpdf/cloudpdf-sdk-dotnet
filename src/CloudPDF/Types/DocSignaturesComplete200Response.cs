using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesComplete200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("status")]
    public required DocSignaturesComplete200ResponseStatus Status { get; set; }

    [JsonPropertyName("signature")]
    public required DocSignaturesComplete200ResponseSignature Signature { get; set; }

    [JsonPropertyName("version")]
    public required DocSignaturesComplete200ResponseVersion Version { get; set; }

    [JsonPropertyName("previous")]
    public required DocSignaturesComplete200ResponsePrevious Previous { get; set; }

    [JsonPropertyName("protection")]
    public required DocSignaturesComplete200ResponseProtection Protection { get; set; }

    [JsonPropertyName("meta")]
    public required DocSignaturesComplete200ResponseMeta Meta { get; set; }

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
