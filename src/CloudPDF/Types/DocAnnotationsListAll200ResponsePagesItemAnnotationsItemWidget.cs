using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetRect Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("modified")]
    public DateTime? Modified { get; set; }

    [JsonPropertyName("blendMode")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetReplyType? ReplyType { get; set; }

    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    [JsonPropertyName("actions")]
    public PdfAnnotationActions? Actions { get; set; }

    [JsonPropertyName("color")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetColor? Color { get; set; }

    [JsonPropertyName("interiorColor")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetInteriorColor? InteriorColor { get; set; }

    [JsonPropertyName("strokeWidth")]
    public required double StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetBorderStyle BorderStyle { get; set; }

    [JsonPropertyName("fontFamily")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFontFamily? FontFamily { get; set; }

    [JsonPropertyName("fontSize")]
    public double? FontSize { get; set; }

    [JsonPropertyName("fontColor")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFontColor? FontColor { get; set; }

    [JsonPropertyName("textAlign")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetTextAlign TextAlign { get; set; }

    [JsonPropertyName("fieldObjectNumber")]
    public required int FieldObjectNumber { get; set; }

    [JsonPropertyName("fieldFamily")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily FieldFamily { get; set; }

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
