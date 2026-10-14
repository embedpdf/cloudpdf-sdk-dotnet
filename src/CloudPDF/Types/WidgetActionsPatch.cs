using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record WidgetActionsPatch : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public PdfActionWrite? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public PdfActionWrite? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public PdfActionWrite? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public PdfActionWrite? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public PdfActionWrite? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public PdfActionWrite? Focus { get; set; }

    [JsonPropertyName("blur")]
    public PdfActionWrite? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public PdfActionWrite? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public PdfActionWrite? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public PdfActionWrite? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public PdfActionWrite? PageInvisible { get; set; }

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
