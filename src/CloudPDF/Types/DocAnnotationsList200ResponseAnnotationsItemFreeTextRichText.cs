using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemFreeTextRichText : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("body")]
    public required DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBody Body { get; set; }

    [JsonPropertyName("paragraphs")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItem> Paragraphs { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItem>();

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
