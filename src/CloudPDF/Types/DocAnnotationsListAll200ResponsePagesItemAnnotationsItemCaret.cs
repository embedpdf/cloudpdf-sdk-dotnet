using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretRect Rect { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretReplyType? ReplyType { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("intent")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretIntent? Intent { get; set; }

    [JsonPropertyName("rectDifferences")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretRectDifferences? RectDifferences { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("unrotatedRect")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaretUnrotatedRect? UnrotatedRect { get; set; }

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
