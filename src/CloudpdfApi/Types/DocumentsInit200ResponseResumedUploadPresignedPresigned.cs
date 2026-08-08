using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocumentsInit200ResponseResumedUploadPresignedPresigned : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("method")]
    public required DocumentsInit200ResponseResumedUploadPresignedPresignedMethod Method { get; set; }

    [JsonPropertyName("expiresAt")]
    public required double ExpiresAt { get; set; }

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
