using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocumentsImportFromRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    /// <summary>
    /// Where CloudPDF pulls the bytes from. The two shapes differ in who supplies the authority to read, not in which storage vendor holds the file.
    /// </summary>
    [JsonPropertyName("source")]
    public required DocumentsImportFromRequestSource Source { get; set; }

    /// <summary>
    /// Integrity pins, enforced when present. When absent, the server-observed values become authoritative.
    /// </summary>
    [JsonPropertyName("expected")]
    public DocumentsImportFromRequestExpected? Expected { get; set; }

    /// <summary>
    /// What people call the document: shown in dashboards, searched and sorted by. 1 to 255 characters, no control characters, no leading or trailing whitespace. Names need not be unique.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A folder id, or root for the top level.
    /// </summary>
    [JsonPropertyName("folderId")]
    public string? FolderId { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object?>? Metadata { get; set; }

    /// <summary>
    /// Retrying with the same key resumes the same document rather than importing a second copy — including after a 502.
    /// </summary>
    [JsonPropertyName("idempotencyKey")]
    public string? IdempotencyKey { get; set; }

    /// <summary>
    /// always-create (default) creates a new document every time. reuse-existing returns a document that already holds the same content instead of storing it twice.
    /// </summary>
    [JsonPropertyName("dedupMode")]
    public DocumentsImportFromRequestDedupMode? DedupMode { get; set; }

    [JsonPropertyName("docId")]
    public string? DocId { get; set; }

    /// <summary>
    /// sync (default) holds the response open for the whole transfer. async answers 202 with the document pending and transfers in the background; it requires a connection source, and filesystem connections additionally require expected.sha256.
    /// </summary>
    [JsonPropertyName("mode")]
    public DocumentsImportFromRequestMode? Mode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
