using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Documents;

[Serializable]
public record DeleteLayersRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string Id { get; set; }

    [JsonIgnore]
    public required string LayerName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
