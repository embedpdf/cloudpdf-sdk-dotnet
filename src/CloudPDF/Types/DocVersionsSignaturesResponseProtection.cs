using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocVersionsSignaturesResponseProtection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("enforced")]
    public DocVersionsSignaturesResponseProtectionEnforced? Enforced { get; set; }

    [JsonPropertyName("judged")]
    public DocVersionsSignaturesResponseProtectionJudged? Judged { get; set; }

    [JsonPropertyName("certification")]
    public DocVersionsSignaturesResponseProtectionCertification? Certification { get; set; }

    [JsonPropertyName("fieldLocks")]
    public IEnumerable<DocVersionsSignaturesResponseProtectionFieldLocksItem> FieldLocks { get; set; } =
        new List<DocVersionsSignaturesResponseProtectionFieldLocksItem>();

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
