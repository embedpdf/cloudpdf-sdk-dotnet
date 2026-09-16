using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextParagraphsItem
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("align")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextParagraphsItemAlign? Align { get; set; }

    [JsonPropertyName("dir")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextParagraphsItemDir? Dir { get; set; }

    [JsonPropertyName("lineHeight")]
    public double? LineHeight { get; set; }

    [JsonPropertyName("margins")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextParagraphsItemMargins? Margins { get; set; }

    [JsonPropertyName("textIndent")]
    public double? TextIndent { get; set; }

    [JsonPropertyName("unknown")]
    public string? Unknown { get; set; }

    [JsonPropertyName("runs")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextParagraphsItemRunsItem> Runs { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeTextRichTextParagraphsItemRunsItem>();

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
