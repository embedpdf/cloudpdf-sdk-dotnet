using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocMetadataGet200Response : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("keywords")]
    public string? Keywords { get; set; }

    [JsonPropertyName("producer")]
    public string? Producer { get; set; }

    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("modified")]
    public DateTime? Modified { get; set; }

    [JsonPropertyName("trapped")]
    public required DocMetadataGet200ResponseTrapped Trapped { get; set; }

    [JsonPropertyName("custom")]
    public Dictionary<string, string> Custom { get; set; } = new Dictionary<string, string>();

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
