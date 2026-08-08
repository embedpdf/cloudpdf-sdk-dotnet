using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemUnderlineActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsActivate? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsCursorEnter? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsCursorExit? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsMouseDown? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsMouseUp? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsFocus? Focus { get; set; }

    [JsonPropertyName("blur")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsBlur? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsPageOpen? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsPageClose? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsPageVisible? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public DocAnnotationsList200ResponseAnnotationsItemUnderlineActionsPageInvisible? PageInvisible { get; set; }

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
