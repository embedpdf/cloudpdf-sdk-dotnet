using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record RichTextDocumentBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("family")]
    public required string Family { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }

    [JsonPropertyName("italic")]
    public required bool Italic { get; set; }

    [JsonPropertyName("size")]
    public required double Size { get; set; }

    [JsonPropertyName("color")]
    public required string Color { get; set; }

    [JsonPropertyName("decoration")]
    public IEnumerable<RichTextDocumentBodyDecorationItem> Decoration { get; set; } =
        new List<RichTextDocumentBodyDecorationItem>();

    [JsonPropertyName("script")]
    public required RichTextDocumentBodyScript Script { get; set; }

    [JsonPropertyName("letterSpacing")]
    public required double LetterSpacing { get; set; }

    [JsonPropertyName("horizontalScale")]
    public required double HorizontalScale { get; set; }

    [JsonPropertyName("unknown")]
    public string? Unknown { get; set; }

    [JsonPropertyName("align")]
    public required RichTextDocumentBodyAlign Align { get; set; }

    [JsonPropertyName("dir")]
    public required RichTextDocumentBodyDir Dir { get; set; }

    [JsonPropertyName("lineHeight")]
    public double? LineHeight { get; set; }

    [JsonPropertyName("margins")]
    public RichTextDocumentBodyMargins? Margins { get; set; }

    [JsonPropertyName("textIndent")]
    public double? TextIndent { get; set; }

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
