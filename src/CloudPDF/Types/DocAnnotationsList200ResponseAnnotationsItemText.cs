using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemText : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsList200ResponseAnnotationsItemTextRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsList200ResponseAnnotationsItemTextFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsList200ResponseAnnotationsItemTextRect Rect { get; set; }

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
    public required DocAnnotationsList200ResponseAnnotationsItemTextBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsList200ResponseAnnotationsItemTextInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsList200ResponseAnnotationsItemTextReplyType? ReplyType { get; set; }

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
    public required DocAnnotationsList200ResponseAnnotationsItemTextColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("icon")]
    public required DocAnnotationsList200ResponseAnnotationsItemTextIcon Icon { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("stateModel")]
    public string? StateModel { get; set; }

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
