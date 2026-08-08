using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemTextActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsActivate? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsCursorEnter? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsCursorExit? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsMouseDown? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsMouseUp? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsFocus? Focus { get; set; }

    [JsonPropertyName("blur")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsBlur? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsPageOpen? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsPageClose? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsPageVisible? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public DocAnnotationsList200ResponseAnnotationsItemTextActionsPageInvisible? PageInvisible { get; set; }

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
