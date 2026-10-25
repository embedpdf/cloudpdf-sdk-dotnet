using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[Serializable]
public record DownloadAttachmentsRequest
{
    [JsonIgnore]
    public required string DocId { get; set; }

    [JsonIgnore]
    public required string LayerName { get; set; }

    /// <summary>
    /// The embedded file's name-tree key (its `ref.key`), token-text encoded, as `fieldKey` is.
    /// </summary>
    [JsonIgnore]
    public required string FileKey { get; set; }

    /// <summary>
    /// Base64-encoded password for an encrypted document. Valid only with the API token (403 anywhere else). An encrypted document answers 422 DocPasswordRequired when the header is absent. Viewer doc JWTs use the SDK password-session flow instead.
    /// </summary>
    [JsonIgnore]
    public string? DocumentPassword { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
