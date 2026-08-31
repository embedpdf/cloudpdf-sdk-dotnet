using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActions
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("activate")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsActivate? Activate { get; set; }

    [JsonPropertyName("cursorEnter")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsCursorEnter? CursorEnter { get; set; }

    [JsonPropertyName("cursorExit")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsCursorExit? CursorExit { get; set; }

    [JsonPropertyName("mouseDown")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsMouseDown? MouseDown { get; set; }

    [JsonPropertyName("mouseUp")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsMouseUp? MouseUp { get; set; }

    [JsonPropertyName("focus")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsFocus? Focus { get; set; }

    [JsonPropertyName("blur")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsBlur? Blur { get; set; }

    [JsonPropertyName("pageOpen")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsPageOpen? PageOpen { get; set; }

    [JsonPropertyName("pageClose")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsPageClose? PageClose { get; set; }

    [JsonPropertyName("pageVisible")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsPageVisible? PageVisible { get; set; }

    [JsonPropertyName("pageInvisible")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachmentActionsPageInvisible? PageInvisible { get; set; }

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
