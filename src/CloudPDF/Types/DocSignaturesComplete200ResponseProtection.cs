using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocSignaturesComplete200ResponseProtection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("enforced")]
    public DocSignaturesComplete200ResponseProtectionEnforced? Enforced { get; set; }

    [JsonPropertyName("judged")]
    public DocSignaturesComplete200ResponseProtectionJudged? Judged { get; set; }

    [JsonPropertyName("certification")]
    public DocSignaturesComplete200ResponseProtectionCertification? Certification { get; set; }

    [JsonPropertyName("fieldLocks")]
    public IEnumerable<DocSignaturesComplete200ResponseProtectionFieldLocksItem> FieldLocks { get; set; } =
        new List<DocSignaturesComplete200ResponseProtectionFieldLocksItem>();

    [JsonPropertyName("policyVersion")]
    public required int PolicyVersion { get; set; }

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
