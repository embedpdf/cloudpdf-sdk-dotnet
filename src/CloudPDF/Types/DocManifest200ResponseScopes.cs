using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocManifest200ResponseScopes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("content")]
    public required DocManifest200ResponseScopesContent Content { get; set; }

    [JsonPropertyName("annotations")]
    public required DocManifest200ResponseScopesAnnotations Annotations { get; set; }

    [JsonPropertyName("layout")]
    public required DocManifest200ResponseScopesLayout Layout { get; set; }

    [JsonPropertyName("attachments")]
    public required DocManifest200ResponseScopesAttachments Attachments { get; set; }

    [JsonPropertyName("metadata")]
    public required DocManifest200ResponseScopesMetadata Metadata { get; set; }

    [JsonPropertyName("actions")]
    public required DocManifest200ResponseScopesActions Actions { get; set; }

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
