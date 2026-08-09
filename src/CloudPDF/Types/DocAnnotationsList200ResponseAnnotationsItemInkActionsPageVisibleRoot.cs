using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemInkActionsPageVisibleRoot
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkActionsPageVisibleRootType Type { get; set; }

    [JsonPropertyName("subtype")]
    public required string Subtype { get; set; }

    [JsonPropertyName("script")]
    public string? Script { get; set; }

    [JsonPropertyName("next")]
    public IEnumerable<object> Next { get; set; } = new List<object>();

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
