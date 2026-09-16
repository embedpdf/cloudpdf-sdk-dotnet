using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesPrepare200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("signingId")]
    public required string SigningId { get; set; }

    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    [JsonPropertyName("algorithm")]
    public required DocSignaturesPrepare200ResponseAlgorithm Algorithm { get; set; }

    [JsonPropertyName("byteRange")]
    public IEnumerable<object> ByteRange { get; set; } = new List<object>();

    [JsonPropertyName("contentsSize")]
    public required int ContentsSize { get; set; }

    [JsonPropertyName("subFilter")]
    public required string SubFilter { get; set; }

    [JsonPropertyName("expectedVersion")]
    public required DocSignaturesPrepare200ResponseExpectedVersion ExpectedVersion { get; set; }

    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; set; }

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
