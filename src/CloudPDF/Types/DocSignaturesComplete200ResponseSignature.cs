using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesComplete200ResponseSignature : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("field")]
    public required DocSignaturesComplete200ResponseSignatureField Field { get; set; }

    [JsonPropertyName("fieldName")]
    public required string FieldName { get; set; }

    [JsonPropertyName("widget")]
    public DocSignaturesComplete200ResponseSignatureWidget? Widget { get; set; }

    [JsonPropertyName("signed")]
    public required bool Signed { get; set; }

    [JsonPropertyName("kind")]
    public required DocSignaturesComplete200ResponseSignatureKind Kind { get; set; }

    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    [JsonPropertyName("subFilter")]
    public string? SubFilter { get; set; }

    [JsonPropertyName("byteRange")]
    public IEnumerable<object>? ByteRange { get; set; }

    [JsonPropertyName("contentsSize")]
    public required int ContentsSize { get; set; }

    [JsonPropertyName("coverage")]
    public DocSignaturesComplete200ResponseSignatureCoverage? Coverage { get; set; }

    [JsonPropertyName("revisionIndex")]
    public int? RevisionIndex { get; set; }

    [JsonPropertyName("signer")]
    public required DocSignaturesComplete200ResponseSignatureSigner Signer { get; set; }

    [JsonPropertyName("docMdp")]
    public double? DocMdp { get; set; }

    [JsonPropertyName("catalogCertification")]
    public required bool CatalogCertification { get; set; }

    [JsonPropertyName("fieldMdp")]
    public DocSignaturesComplete200ResponseSignatureFieldMdp? FieldMdp { get; set; }

    [JsonPropertyName("lock")]
    public DocSignaturesComplete200ResponseSignatureLock? Lock { get; set; }

    [JsonPropertyName("seedValue")]
    public DocSignaturesComplete200ResponseSignatureSeedValue? SeedValue { get; set; }

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
