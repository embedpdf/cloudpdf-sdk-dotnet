using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PdfActionNodeSubmitFormPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PdfActionTargetRef>? Fields { get; set; }

    [JsonPropertyName("flags")]
    public required PdfActionNodeSubmitFormPayloadFlags Flags { get; set; }

    [JsonPropertyName("charSet")]
    public string? CharSet { get; set; }

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
