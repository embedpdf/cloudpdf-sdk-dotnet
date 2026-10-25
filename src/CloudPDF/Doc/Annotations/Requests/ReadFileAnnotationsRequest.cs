using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[Serializable]
public record ReadFileAnnotationsRequest
{
    [JsonIgnore]
    public required string DocId { get; set; }

    [JsonIgnore]
    public required string LayerName { get; set; }

    /// <summary>
    /// The page's address, `obj:N`: the page's indirect object number, the durable identity every `PageLayout.ref` carries. Mirrors `annotKey` and `fieldKey`.
    /// </summary>
    [JsonIgnore]
    public required string PageKey { get; set; }

    /// <summary>
    /// The annotation's address on the page: `obj:N`, its indirect object number, or `base:N` for an annotation the uploaded file stored inline (without an object number of its own), the position it was born at in the page's /Annots. The name the annotation's `ref` carries for life.
    /// </summary>
    [JsonIgnore]
    public required string AnnotKey { get; set; }

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
