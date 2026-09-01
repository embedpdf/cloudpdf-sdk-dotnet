using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PdfAnnotationActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public PdfActionTree? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public PdfActionTree? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public PdfActionTree? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public PdfActionTree? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public PdfActionTree? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public PdfActionTree? Focus { get; set; }

    [JsonPropertyName("blur")]
    public PdfActionTree? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public PdfActionTree? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public PdfActionTree? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public PdfActionTree? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public PdfActionTree? PageInvisible { get; set; }

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
