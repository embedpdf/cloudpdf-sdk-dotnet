using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesListResponseSignaturesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("field")]
    public required FormFieldRef Field { get; set; }

    [JsonPropertyName("fieldName")]
    public required string FieldName { get; set; }

    [JsonPropertyName("widget")]
    public FormWidget? Widget { get; set; }

    [JsonPropertyName("signed")]
    public required bool Signed { get; set; }

    [JsonPropertyName("kind")]
    public required DocSignaturesListResponseSignaturesItemKind Kind { get; set; }

    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    [JsonPropertyName("subFilter")]
    public string? SubFilter { get; set; }

    [JsonPropertyName("byteRange")]
    public IEnumerable<object>? ByteRange { get; set; }

    [JsonPropertyName("contentsSizeBytes")]
    public required int ContentsSizeBytes { get; set; }

    [JsonPropertyName("coverage")]
    public DocSignaturesListResponseSignaturesItemCoverage? Coverage { get; set; }

    [JsonPropertyName("revisionIndex")]
    public int? RevisionIndex { get; set; }

    [JsonPropertyName("signer")]
    public required DocSignaturesListResponseSignaturesItemSigner Signer { get; set; }

    [JsonPropertyName("docMdp")]
    public int? DocMdp { get; set; }

    [JsonPropertyName("catalogCertification")]
    public required bool CatalogCertification { get; set; }

    [JsonPropertyName("fieldMdp")]
    public FieldLockSpec? FieldMdp { get; set; }

    [JsonPropertyName("lock")]
    public FieldLockSpec? Lock { get; set; }

    [JsonPropertyName("seedValue")]
    public DocSignaturesListResponseSignaturesItemSeedValue? SeedValue { get; set; }

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
