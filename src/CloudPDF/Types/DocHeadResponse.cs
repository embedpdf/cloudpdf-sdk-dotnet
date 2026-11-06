using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocHeadResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("baseSha256")]
    public required string BaseSha256 { get; set; }

    [JsonPropertyName("sizeBytes")]
    public required int SizeBytes { get; set; }

    [JsonPropertyName("docVersion")]
    public required int DocVersion { get; set; }

    [JsonPropertyName("state")]
    public required DocHeadResponseState State { get; set; }

    [JsonPropertyName("encryption")]
    public required DocHeadResponseEncryption Encryption { get; set; }

    [JsonPropertyName("permissions")]
    public required DocHeadResponsePermissions Permissions { get; set; }

    [JsonPropertyName("access")]
    public required DocHeadResponseAccess Access { get; set; }

    [JsonPropertyName("engine")]
    public Dictionary<string, string> Engine { get; set; } = new Dictionary<string, string>();

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
