using CloudpdfApi.Core;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record TenantsCreateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
