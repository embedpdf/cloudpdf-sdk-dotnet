using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationFileAttachment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required AnnotationRef Ref { get; set; }

    [JsonPropertyName("page")]
    public required PageRef Page { get; set; }

    [JsonPropertyName("hasAppearance")]
    public required bool HasAppearance { get; set; }

    [JsonPropertyName("appearanceState")]
    public string? AppearanceState { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("rect")]
    public required AnnotationFileAttachmentRect Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("blendMode")]
    public required AnnotationFileAttachmentBlendMode BlendMode { get; set; }

    [JsonPropertyName("invisible")]
    public required bool Invisible { get; set; }

    [JsonPropertyName("hidden")]
    public required bool Hidden { get; set; }

    [JsonPropertyName("print")]
    public required bool Print { get; set; }

    [JsonPropertyName("noZoom")]
    public required bool NoZoom { get; set; }

    [JsonPropertyName("noRotate")]
    public required bool NoRotate { get; set; }

    [JsonPropertyName("noView")]
    public required bool NoView { get; set; }

    [JsonPropertyName("readOnly")]
    public required bool ReadOnly { get; set; }

    [JsonPropertyName("locked")]
    public required bool Locked { get; set; }

    [JsonPropertyName("toggleNoView")]
    public required bool ToggleNoView { get; set; }

    [JsonPropertyName("lockedContents")]
    public required bool LockedContents { get; set; }

    [JsonPropertyName("reply")]
    public AnnotationFileAttachmentReply? Reply { get; set; }

    [JsonPropertyName("popup")]
    public AnnotationRef? Popup { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("importedBy")]
    public string? ImportedBy { get; set; }

    [JsonPropertyName("actions")]
    public PdfAnnotationActions? Actions { get; set; }

    [JsonPropertyName("color")]
    public required string Color { get; set; }

    [JsonPropertyName("opacity")]
    public required double Opacity { get; set; }

    [JsonPropertyName("icon")]
    public required AnnotationFileAttachmentIcon Icon { get; set; }

    [JsonPropertyName("file")]
    public AnnotationFileAttachmentFile? File { get; set; }

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
