using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemStampActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsActivate? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsCursorEnter? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsCursorExit? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDown? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseUp? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsFocus? Focus { get; set; }

    [JsonPropertyName("blur")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsBlur? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsPageOpen? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsPageClose? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsPageVisible? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public DocAnnotationsList200ResponseAnnotationsItemStampActionsPageInvisible? PageInvisible { get; set; }

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
