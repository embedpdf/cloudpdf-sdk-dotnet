using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record WidgetPlacement : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("page")]
    public required PageRef Page { get; set; }

    [JsonPropertyName("rect")]
    public WidgetPlacementRect? Rect { get; set; }

    [JsonPropertyName("box")]
    public WidgetPlacementBox? Box { get; set; }

    [JsonPropertyName("rotation")]
    public double? Rotation { get; set; }

    [JsonPropertyName("exportValue")]
    public string? ExportValue { get; set; }

    [JsonPropertyName("actions")]
    public WidgetActionsPatch? Actions { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("interiorColor")]
    public string? InteriorColor { get; set; }

    [JsonPropertyName("strokeWidth")]
    public double? StrokeWidth { get; set; }

    [JsonPropertyName("borderStyle")]
    public WidgetPlacementBorderStyle? BorderStyle { get; set; }

    [JsonPropertyName("dashArray")]
    public IEnumerable<double>? DashArray { get; set; }

    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    [JsonPropertyName("fontSize")]
    public double? FontSize { get; set; }

    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    [JsonPropertyName("textAlign")]
    public WidgetPlacementTextAlign? TextAlign { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("checkStyle")]
    public WidgetPlacementCheckStyle? CheckStyle { get; set; }

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
