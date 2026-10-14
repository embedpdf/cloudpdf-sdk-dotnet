using CloudPDF;
using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[Serializable]
public record DocRedactionsApplyRequest
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

    /// <summary>
    /// Names the change: 1 to 255 printable ASCII characters. A retry under the same key on the same layer answers with what the first request committed, and changes nothing.
    /// </summary>
    [JsonIgnore]
    public string? IdempotencyKey { get; set; }

    [JsonPropertyName("pages")]
    public IEnumerable<PageRef>? Pages { get; set; }

    [JsonPropertyName("annotations")]
    public IEnumerable<AnnotationRef>? Annotations { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
