using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ResolvedFontRun : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("font")]
    public required string Font { get; set; }

    [JsonPropertyName("weight")]
    public required double Weight { get; set; }

    [JsonPropertyName("italic")]
    public required bool Italic { get; set; }

    [JsonPropertyName("substituted")]
    public required bool Substituted { get; set; }

    [JsonPropertyName("program")]
    public string? Program { get; set; }

    [JsonPropertyName("fallbacks")]
    public IEnumerable<string> Fallbacks { get; set; } = new List<string>();

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
