using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record AnnotationPatchFreeTextRichText : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("body")]
    public AnnotationPatchFreeTextRichTextBody? Body { get; set; }

    [JsonPropertyName("paragraphs")]
    public IEnumerable<AnnotationPatchFreeTextRichTextParagraphsItem> Paragraphs { get; set; } =
        new List<AnnotationPatchFreeTextRichTextParagraphsItem>();

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
