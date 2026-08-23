using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// The operator pre-registered the authority: the request names a connection and a key inside it. Which provider backs the connection (S3, GCS, Azure Blob, filesystem, ...) is deployment configuration, never wire surface.
/// </summary>
[Serializable]
public record DocumentsImportFromRequestSourceConnection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The operator-registered storage connection to read from.
    /// </summary>
    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    /// <summary>
    /// The object key to read, inside the connection's configured scope. At most 1024 UTF-8 bytes.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Pins a specific version of the object. Provider-interpreted (S3 VersionId, GCS generation, Azure version id); providers without versioning reject it.
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
