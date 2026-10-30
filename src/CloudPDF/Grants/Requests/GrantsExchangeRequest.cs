using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsExchangeRequest
{
    [JsonPropertyName("grant")]
    public required string Grant { get; set; }

    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; set; }

    [JsonPropertyName("visitorHandle")]
    public string? VisitorHandle { get; set; }

    [JsonPropertyName("restart")]
    public bool? Restart { get; set; }

    [JsonPropertyName("visitorIdentity")]
    public GrantsExchangeRequestVisitorIdentity? VisitorIdentity { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
