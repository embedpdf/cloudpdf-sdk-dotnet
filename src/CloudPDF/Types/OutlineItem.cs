using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record OutlineItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required OutlineItemRef Ref { get; set; }

    [JsonPropertyName("parent")]
    public OutlineItemRef? Parent { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("target")]
    public PdfLinkTarget? Target { get; set; }

    [JsonPropertyName("action")]
    public PdfActionTree? Action { get; set; }

    [JsonPropertyName("open")]
    public required bool Open { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("bold")]
    public required bool Bold { get; set; }

    [JsonPropertyName("italic")]
    public required bool Italic { get; set; }

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
