using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesPrepareResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("signingId")]
    public required string SigningId { get; set; }

    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    [JsonPropertyName("algorithm")]
    public required DocSignaturesPrepareResponseAlgorithm Algorithm { get; set; }

    [JsonPropertyName("byteRange")]
    public IEnumerable<object> ByteRange { get; set; } = new List<object>();

    [JsonPropertyName("contentsSizeBytes")]
    public required int ContentsSizeBytes { get; set; }

    [JsonPropertyName("subFilter")]
    public required string SubFilter { get; set; }

    [JsonPropertyName("expectedVersion")]
    public required DocSignaturesPrepareResponseExpectedVersion ExpectedVersion { get; set; }

    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }

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
