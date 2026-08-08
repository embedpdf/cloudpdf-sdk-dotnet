using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemRedactActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsActivate? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsCursorEnter? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsCursorExit? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsMouseDown? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsMouseUp? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsFocus? Focus { get; set; }

    [JsonPropertyName("blur")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsBlur? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsPageOpen? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsPageClose? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsPageVisible? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public DocAnnotationsList200ResponseAnnotationsItemRedactActionsPageInvisible? PageInvisible { get; set; }

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
