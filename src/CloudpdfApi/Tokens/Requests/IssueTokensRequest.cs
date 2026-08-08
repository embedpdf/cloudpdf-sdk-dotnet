using CloudpdfApi.Core;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record IssueTokensRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required TokensIssueRequest Body { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
