using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemFreeText : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextRect Rect { get; set; }

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
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextReplyType? ReplyType { get; set; }

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

    [JsonPropertyName("intent")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextIntent Intent { get; set; }

    [JsonPropertyName("fontFamily")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextFontFamily FontFamily { get; set; }

    [JsonPropertyName("fontSize")]
    public required double FontSize { get; set; }

    [JsonPropertyName("textAlign")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextTextAlign TextAlign { get; set; }

    [JsonPropertyName("color")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextColor Color { get; set; }

    [JsonPropertyName("fontColor")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextFontColor? FontColor { get; set; }

    [JsonPropertyName("interiorColor")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextInteriorColor? InteriorColor { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("strokeWidth")]
    public required double StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextBorderStyle BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("rectDifferences")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextRectDifferences? RectDifferences { get; set; }

    [JsonPropertyName("calloutLine")]
    public IEnumerable<object>? CalloutLine { get; set; }

    [JsonPropertyName("lineEnding")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextLineEnding? LineEnding { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("unrotatedRect")]
    public DocAnnotationsList200ResponseAnnotationsItemFreeTextUnrotatedRect? UnrotatedRect { get; set; }

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
