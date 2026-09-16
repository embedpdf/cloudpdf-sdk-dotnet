using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsSignatures200ResponseSignaturesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("field")]
    public required DocVersionsSignatures200ResponseSignaturesItemField Field { get; set; }

    [JsonPropertyName("fieldName")]
    public required string FieldName { get; set; }

    [JsonPropertyName("widget")]
    public DocVersionsSignatures200ResponseSignaturesItemWidget? Widget { get; set; }

    [JsonPropertyName("signed")]
    public required bool Signed { get; set; }

    [JsonPropertyName("kind")]
    public required DocVersionsSignatures200ResponseSignaturesItemKind Kind { get; set; }

    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    [JsonPropertyName("subFilter")]
    public string? SubFilter { get; set; }

    [JsonPropertyName("byteRange")]
    public IEnumerable<object>? ByteRange { get; set; }

    [JsonPropertyName("contentsSize")]
    public required int ContentsSize { get; set; }

    [JsonPropertyName("coverage")]
    public DocVersionsSignatures200ResponseSignaturesItemCoverage? Coverage { get; set; }

    [JsonPropertyName("revisionIndex")]
    public int? RevisionIndex { get; set; }

    [JsonPropertyName("signer")]
    public required DocVersionsSignatures200ResponseSignaturesItemSigner Signer { get; set; }

    [JsonPropertyName("docMdp")]
    public double? DocMdp { get; set; }

    [JsonPropertyName("catalogCertification")]
    public required bool CatalogCertification { get; set; }

    [JsonPropertyName("fieldMdp")]
    public DocVersionsSignatures200ResponseSignaturesItemFieldMdp? FieldMdp { get; set; }

    [JsonPropertyName("lock")]
    public DocVersionsSignatures200ResponseSignaturesItemLock? Lock { get; set; }

    [JsonPropertyName("seedValue")]
    public DocVersionsSignatures200ResponseSignaturesItemSeedValue? SeedValue { get; set; }

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
