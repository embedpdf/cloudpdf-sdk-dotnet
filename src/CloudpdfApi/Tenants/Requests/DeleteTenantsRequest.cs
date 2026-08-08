using CloudpdfApi.Core;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DeleteTenantsRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
