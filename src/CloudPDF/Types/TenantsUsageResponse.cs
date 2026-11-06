using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record TenantsUsageResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("metrics")]
    public required TenantsUsageResponseMetrics Metrics { get; set; }

    [JsonPropertyName("moduleMeters")]
    public Dictionary<string, int> ModuleMeters { get; set; } = new Dictionary<string, int>();

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
