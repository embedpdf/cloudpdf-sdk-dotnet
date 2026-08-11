using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record SharesUpdateRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string ShareId { get; set; }

    [JsonPropertyName("scope")]
    public IEnumerable<string>? Scope { get; set; }

    [JsonPropertyName("origins")]
    public IEnumerable<string>? Origins { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("sessionTtlSeconds")]
    public int? SessionTtlSeconds { get; set; }

    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    [JsonPropertyName("expiresAt")]
    public int? ExpiresAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
