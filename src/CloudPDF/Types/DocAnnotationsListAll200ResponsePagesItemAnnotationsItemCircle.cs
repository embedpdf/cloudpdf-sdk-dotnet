using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleRect Rect { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleReplyType? ReplyType { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("strokeWidth")]
    public required double StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleBorderStyle BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("interiorColor")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInteriorColor? InteriorColor { get; set; }

    [JsonPropertyName("cloudyIntensity")]
    public double? CloudyIntensity { get; set; }

    [JsonPropertyName("rectDifferences")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleRectDifferences? RectDifferences { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("unrotatedRect")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleUnrotatedRect? UnrotatedRect { get; set; }

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
