using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemInk : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkRect Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("modified")]
    public DateTime? Modified { get; set; }

    [JsonPropertyName("blendMode")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsList200ResponseAnnotationsItemInkInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsList200ResponseAnnotationsItemInkReplyType? ReplyType { get; set; }

    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    [JsonPropertyName("actions")]
    public DocAnnotationsList200ResponseAnnotationsItemInkActions? Actions { get; set; }

    [JsonPropertyName("color")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("strokeWidth")]
    public required double StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public required DocAnnotationsList200ResponseAnnotationsItemInkBorderStyle BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("intent")]
    public DocAnnotationsList200ResponseAnnotationsItemInkIntent? Intent { get; set; }

    [JsonPropertyName("inkList")]
    public IEnumerable<
        IEnumerable<DocAnnotationsList200ResponseAnnotationsItemInkInkListItemItem>
    > InkList { get; set; } =
        new List<IEnumerable<DocAnnotationsList200ResponseAnnotationsItemInkInkListItemItem>>();

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

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
