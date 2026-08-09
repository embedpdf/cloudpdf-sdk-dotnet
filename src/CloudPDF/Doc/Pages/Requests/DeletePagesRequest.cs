using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[Serializable]
public record DeletePagesRequest
{
    [JsonIgnore]
    public required string DocId { get; set; }

    [JsonIgnore]
    public required string LayerName { get; set; }

    /// <summary>
    /// Base64-encoded password for an encrypted document. Valid only with the API token (403 anywhere else). An encrypted document answers 422 DocPasswordRequired when the header is absent. Viewer doc JWTs use the SDK password-session flow instead.
    /// </summary>
    [JsonIgnore]
    public string? DocumentPassword { get; set; }

    [JsonIgnore]
    public Dictionary<string, object?> Body { get; set; } = new Dictionary<string, object?>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
