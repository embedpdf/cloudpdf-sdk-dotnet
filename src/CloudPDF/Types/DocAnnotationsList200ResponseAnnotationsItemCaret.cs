using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemCaret : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsList200ResponseAnnotationsItemCaretRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsList200ResponseAnnotationsItemCaretIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsList200ResponseAnnotationsItemCaretFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsList200ResponseAnnotationsItemCaretRect Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("modified")]
    public DateTime? Modified { get; set; }

    [JsonPropertyName("blendMode")]
    public required DocAnnotationsList200ResponseAnnotationsItemCaretBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsList200ResponseAnnotationsItemCaretInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsList200ResponseAnnotationsItemCaretReplyType? ReplyType { get; set; }

    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    [JsonPropertyName("actions")]
    public DocAnnotationsList200ResponseAnnotationsItemCaretActions? Actions { get; set; }

    [JsonPropertyName("color")]
    public required DocAnnotationsList200ResponseAnnotationsItemCaretColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("intent")]
    public DocAnnotationsList200ResponseAnnotationsItemCaretIntent? Intent { get; set; }

    [JsonPropertyName("rectDifferences")]
    public DocAnnotationsList200ResponseAnnotationsItemCaretRectDifferences? RectDifferences { get; set; }

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
