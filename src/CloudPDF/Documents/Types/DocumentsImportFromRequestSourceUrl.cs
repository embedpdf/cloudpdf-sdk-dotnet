using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// The caller supplies the authority: a presigned S3/GCS/Azure/R2/MinIO GET, or any HTTPS endpoint the deployment import policy allows. The URL is a capability — treat it as a secret. CloudPDF never echoes its query string back in errors, logs, or stored failure reasons.
/// </summary>
[Serializable]
public record DocumentsImportFromRequestSourceUrl : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The URL to fetch. Must be allowed by the deployment import policy (scheme, network range, size) and must declare a length.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

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
