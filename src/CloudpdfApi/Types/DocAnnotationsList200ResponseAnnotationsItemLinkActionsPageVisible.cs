using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemLinkActionsPageVisible
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("root")]
    public DocAnnotationsList200ResponseAnnotationsItemLinkActionsPageVisibleRoot? Root { get; set; }

    [JsonPropertyName("incomplete")]
    public required bool Incomplete { get; set; }

    [JsonPropertyName("warningFlags")]
    public required int WarningFlags { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<DocAnnotationsList200ResponseAnnotationsItemLinkActionsPageVisibleWarningsItem> Warnings { get; set; } =
        new List<DocAnnotationsList200ResponseAnnotationsItemLinkActionsPageVisibleWarningsItem>();

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
