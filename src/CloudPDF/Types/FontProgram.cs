using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FontProgram : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("displaySha256")]
    public string? DisplaySha256 { get; set; }

    [JsonPropertyName("sourceSha256")]
    public string? SourceSha256 { get; set; }

    [JsonPropertyName("embedded")]
    public required FontProgramEmbedded Embedded { get; set; }

    [JsonPropertyName("format")]
    public FontProgramFormat? Format { get; set; }

    [JsonPropertyName("embeddingPermission")]
    public FontProgramEmbeddingPermission? EmbeddingPermission { get; set; }

    [JsonPropertyName("canDownload")]
    public required bool CanDownload { get; set; }

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
