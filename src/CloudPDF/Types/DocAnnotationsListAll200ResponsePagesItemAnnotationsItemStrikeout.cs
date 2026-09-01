using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutRect Rect { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutReplyType? ReplyType { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("quadPoints")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutQuadPointsItem> QuadPoints { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutQuadPointsItem>();

    [JsonPropertyName("intent")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeoutIntent? Intent { get; set; }

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
