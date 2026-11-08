using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record PageListSnapshotPagesItem : IJsonOnDeserialized
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
    public required PageListSnapshotPagesItemSize Size { get; set; }

    [JsonPropertyName("rotation")]
    public required int Rotation { get; set; }

    [JsonPropertyName("userUnit")]
    public required double UserUnit { get; set; }

    [JsonPropertyName("tabOrder")]
    public PageListSnapshotPagesItemTabOrder? TabOrder { get; set; }

    [JsonPropertyName("boxes")]
    public required PageListSnapshotPagesItemBoxes Boxes { get; set; }

    [JsonPropertyName("pdfCropBox")]
    public required PageListSnapshotPagesItemPdfCropBox PdfCropBox { get; set; }

    [JsonPropertyName("actions")]
    public PdfPageActions? Actions { get; set; }

    [JsonPropertyName("viewports")]
    public IEnumerable<PageMeasurementViewport>? Viewports { get; set; }

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
