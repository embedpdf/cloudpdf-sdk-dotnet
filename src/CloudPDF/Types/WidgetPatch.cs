using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace CloudPDF;

[Serializable]
public record WidgetPatch : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("subtype")]
    public WidgetPatchSubtype? Subtype { get; set; }

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
    public WidgetPatchRect? Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("blendMode")]
    public WidgetPatchBlendMode? BlendMode { get; set; }

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
    public WidgetPatchReply? Reply { get; set; }

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
    public OneOf<WidgetActionsPatch?, PdfAnnotationActions?>? Actions { get; set; }

    [JsonPropertyName("box")]
    public WidgetPatchBox? Box { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("interiorColor")]
    public string? InteriorColor { get; set; }

    [JsonPropertyName("strokeWidth")]
    public double? StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public WidgetPatchBorderStyle? BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    [JsonPropertyName("fontSize")]
    public double? FontSize { get; set; }

    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    [JsonPropertyName("textAlign")]
    public WidgetPatchTextAlign? TextAlign { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("checkStyle")]
    public WidgetPatchCheckStyle? CheckStyle { get; set; }

    [JsonPropertyName("field")]
    public object? Field { get; set; }

    [JsonPropertyName("fieldFamily")]
    public object? FieldFamily { get; set; }

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
