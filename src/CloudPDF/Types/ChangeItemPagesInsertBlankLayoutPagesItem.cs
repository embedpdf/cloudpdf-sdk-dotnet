using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record ChangeItemPagesInsertBlankLayoutPagesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("ref")]
    public required PageRef Ref { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("size")]
    public required ChangeItemPagesInsertBlankLayoutPagesItemSize Size { get; set; }

    [JsonPropertyName("rotation")]
    public required double Rotation { get; set; }

    [JsonPropertyName("userUnit")]
    public required double UserUnit { get; set; }

    [JsonPropertyName("tabOrder")]
    public ChangeItemPagesInsertBlankLayoutPagesItemTabOrder? TabOrder { get; set; }

    [JsonPropertyName("boxes")]
    public required ChangeItemPagesInsertBlankLayoutPagesItemBoxes Boxes { get; set; }

    [JsonPropertyName("pdfCropBox")]
    public required ChangeItemPagesInsertBlankLayoutPagesItemPdfCropBox PdfCropBox { get; set; }

    [JsonPropertyName("actions")]
    public PdfPageActions? Actions { get; set; }

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
