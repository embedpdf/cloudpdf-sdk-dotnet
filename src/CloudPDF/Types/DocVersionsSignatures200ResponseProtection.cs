using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsSignatures200ResponseProtection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("enforced")]
    public DocVersionsSignatures200ResponseProtectionEnforced? Enforced { get; set; }

    [JsonPropertyName("judged")]
    public DocVersionsSignatures200ResponseProtectionJudged? Judged { get; set; }

    [JsonPropertyName("certification")]
    public DocVersionsSignatures200ResponseProtectionCertification? Certification { get; set; }

    [JsonPropertyName("fieldLocks")]
    public IEnumerable<DocVersionsSignatures200ResponseProtectionFieldLocksItem> FieldLocks { get; set; } =
        new List<DocVersionsSignatures200ResponseProtectionFieldLocksItem>();

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
