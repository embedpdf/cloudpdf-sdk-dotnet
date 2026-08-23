using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// Integrity pins, enforced when present. When absent, the server-observed values become authoritative.
/// </summary>
[Serializable]
public record DocumentsImportFromRequestExpected : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Checked against the source's declared Content-Length before the transfer.
    /// </summary>
    [JsonPropertyName("sizeBytes")]
    public int? SizeBytes { get; set; }

    /// <summary>
    /// Checked against the server-observed digest after the transfer. Required when dedupMode is reuse-existing.
    /// </summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }

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
