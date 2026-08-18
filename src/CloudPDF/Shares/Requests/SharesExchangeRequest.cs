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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
