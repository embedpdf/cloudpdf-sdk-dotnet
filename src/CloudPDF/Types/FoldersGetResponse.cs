using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FoldersGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("folder")]
    public required FoldersGetResponseFolder Folder { get; set; }

    /// <summary>
    /// The folders above this one, from the top level down. Neither root nor the folder itself.
    /// </summary>
    [JsonPropertyName("path")]
    public IEnumerable<FoldersGetResponsePathItem> Path { get; set; } =
        new List<FoldersGetResponsePathItem>();

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
