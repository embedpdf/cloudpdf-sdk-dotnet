using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocHead200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("baseSha")]
    public required string BaseSha { get; set; }

    [JsonPropertyName("storageSizeBytes")]
    public required int StorageSizeBytes { get; set; }

    [JsonPropertyName("docVersion")]
    public required int DocVersion { get; set; }

    [JsonPropertyName("state")]
    public required DocHead200ResponseState State { get; set; }

    [JsonPropertyName("encryption")]
    public required DocHead200ResponseEncryption Encryption { get; set; }

    [JsonPropertyName("permissions")]
    public required DocHead200ResponsePermissions Permissions { get; set; }

    [JsonPropertyName("access")]
    public required DocHead200ResponseAccess Access { get; set; }

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
