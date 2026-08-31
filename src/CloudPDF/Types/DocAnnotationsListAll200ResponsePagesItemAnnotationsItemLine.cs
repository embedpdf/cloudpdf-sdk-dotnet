using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineRef Ref { get; set; }

    [JsonPropertyName("pageObjectNumber")]
    public required int PageObjectNumber { get; set; }

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("identityQuality")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIdentityQuality IdentityQuality { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("flags")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineFlags Flags { get; set; }

    [JsonPropertyName("rect")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineRect Rect { get; set; }

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
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineBlendMode BlendMode { get; set; }

    [JsonPropertyName("inReplyTo")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineInReplyTo? InReplyTo { get; set; }

    [JsonPropertyName("replyType")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineReplyType? ReplyType { get; set; }

    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    [JsonPropertyName("actions")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineActions? Actions { get; set; }

    [JsonPropertyName("color")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineColor Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("strokeWidth")]
    public required double StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineBorderStyle BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("interiorColor")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineInteriorColor? InteriorColor { get; set; }

    [JsonPropertyName("linePoints")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineLinePoints LinePoints { get; set; }

    [JsonPropertyName("lineEndings")]
    public required DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineLineEndings LineEndings { get; set; }

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
