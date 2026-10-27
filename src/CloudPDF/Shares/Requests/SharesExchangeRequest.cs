using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record SharesExchangeRequest
{
    [JsonPropertyName("shareToken")]
    public required string ShareToken { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("visitorHandle")]
    public string? VisitorHandle { get; set; }

    [JsonPropertyName("restart")]
    public bool? Restart { get; set; }

    [JsonPropertyName("visitorIdentity")]
    public SharesExchangeRequestVisitorIdentity? VisitorIdentity { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
