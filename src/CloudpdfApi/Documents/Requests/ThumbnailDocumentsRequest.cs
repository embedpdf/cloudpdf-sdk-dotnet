using CloudpdfApi.Core;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record ThumbnailDocumentsRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
