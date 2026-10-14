using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationDraftStamp : IJsonOnDeserialized
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
    public AnnotationDraftStampRect? Rect { get; set; }

    [JsonPropertyName("contents")]
    public string? Contents { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("blendMode")]
    public AnnotationDraftStampBlendMode? BlendMode { get; set; }

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
    public AnnotationDraftStampReply? Reply { get; set; }

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
    public AnnotationDraftStampBox? Box { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fit")]
    public AnnotationDraftStampFit? Fit { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

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
