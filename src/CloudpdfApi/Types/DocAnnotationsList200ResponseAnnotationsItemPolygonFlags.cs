using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemPolygonFlags : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("invisible")]
    public required bool Invisible { get; set; }

    [JsonPropertyName("hidden")]
    public required bool Hidden { get; set; }

    [JsonPropertyName("print")]
    public required bool Print { get; set; }

    [JsonPropertyName("noZoom")]
    public required bool NoZoom { get; set; }

    [JsonPropertyName("noRotate")]
    public required bool NoRotate { get; set; }

    [JsonPropertyName("noView")]
    public required bool NoView { get; set; }

    [JsonPropertyName("readOnly")]
    public required bool ReadOnly { get; set; }

    [JsonPropertyName("locked")]
    public required bool Locked { get; set; }

    [JsonPropertyName("toggleNoView")]
    public required bool ToggleNoView { get; set; }

    [JsonPropertyName("lockedContents")]
    public required bool LockedContents { get; set; }

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
