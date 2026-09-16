using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsList200ResponseVersionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("sha256")]
    public required string Sha256 { get; set; }

    [JsonPropertyName("byteLength")]
    public required int ByteLength { get; set; }

    [JsonPropertyName("number")]
    public required int Number { get; set; }

    [JsonPropertyName("parentSha256")]
    public string? ParentSha256 { get; set; }

    [JsonPropertyName("producer")]
    public required DocVersionsList200ResponseVersionsItemProducer Producer { get; set; }

    [JsonPropertyName("signingId")]
    public string? SigningId { get; set; }

    [JsonPropertyName("createdAt")]
    public required int CreatedAt { get; set; }

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
