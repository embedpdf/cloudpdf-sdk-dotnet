using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemPolylineActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsActivate? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsCursorEnter? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsCursorExit? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsMouseDown? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsMouseUp? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsFocus? Focus { get; set; }

    [JsonPropertyName("blur")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlur? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsPageOpen? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsPageClose? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsPageVisible? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsPageInvisible? PageInvisible { get; set; }

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
