using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace CloudPDF;

[Serializable]
public record AnnotationPatchFreeText : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public object? Ref { get; set; }

    [JsonPropertyName("page")]
    public object? Page { get; set; }

    [JsonPropertyName("hasAppearance")]
    public object? HasAppearance { get; set; }

    [JsonPropertyName("appearanceState")]
    public object? AppearanceState { get; set; }

    [JsonPropertyName("nm")]
    public string? Nm { get; set; }

    [JsonPropertyName("rect")]
    public AnnotationPatchFreeTextRect? Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("blendMode")]
    public AnnotationPatchFreeTextBlendMode? BlendMode { get; set; }

    [JsonPropertyName("invisible")]
    public bool? Invisible { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("print")]
    public bool? Print { get; set; }

    [JsonPropertyName("noZoom")]
    public bool? NoZoom { get; set; }

    [JsonPropertyName("noRotate")]
    public bool? NoRotate { get; set; }

    [JsonPropertyName("noView")]
    public bool? NoView { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    [JsonPropertyName("toggleNoView")]
    public bool? ToggleNoView { get; set; }

    [JsonPropertyName("lockedContents")]
    public bool? LockedContents { get; set; }

    [JsonPropertyName("reply")]
    public AnnotationPatchFreeTextReply? Reply { get; set; }

    [JsonPropertyName("popup")]
    public object? Popup { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("author")]
    public object? Author { get; set; }

    [JsonPropertyName("createdAt")]
    public object? CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public object? ModifiedAt { get; set; }

    [JsonPropertyName("userId")]
    public object? UserId { get; set; }

    [JsonPropertyName("createdBy")]
    public object? CreatedBy { get; set; }

    [JsonPropertyName("modifiedBy")]
    public object? ModifiedBy { get; set; }

    [JsonPropertyName("importedBy")]
    public object? ImportedBy { get; set; }

    [JsonPropertyName("actions")]
    public object? Actions { get; set; }

    [JsonPropertyName("box")]
    public AnnotationPatchFreeTextBox? Box { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("intent")]
    public OneOf<
        AnnotationPatchFreeTextIntentZero,
        AnnotationPatchFreeTextIntentOne
    >? Intent { get; set; }

    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    [JsonPropertyName("fontSize")]
    public double? FontSize { get; set; }

    [JsonPropertyName("textAlign")]
    public AnnotationPatchFreeTextTextAlign? TextAlign { get; set; }

    [JsonPropertyName("verticalAlign")]
    public AnnotationPatchFreeTextVerticalAlign? VerticalAlign { get; set; }

    [JsonPropertyName("richText")]
    public AnnotationPatchFreeTextRichText? RichText { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    [JsonPropertyName("interiorColor")]
    public string? InteriorColor { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    [JsonPropertyName("strokeWidth")]
    public double? StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public OneOf<
        AnnotationPatchFreeTextBorderStyleZero,
        AnnotationPatchFreeTextBorderStyleOne
    >? BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("cloudyIntensity")]
    public double? CloudyIntensity { get; set; }

    [JsonPropertyName("calloutLine")]
    public IEnumerable<object>? CalloutLine { get; set; }

    [JsonPropertyName("lineEnding")]
    public AnnotationPatchFreeTextLineEnding? LineEnding { get; set; }

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
