using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocFormsGet200ResponseFieldsItemUnknown : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocFormsGet200ResponseFieldsItemUnknownRef Ref { get; set; }

    [JsonPropertyName("fieldObjectNumber")]
    public required int FieldObjectNumber { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("origin")]
    public required DocFormsGet200ResponseFieldsItemUnknownOrigin Origin { get; set; }

    [JsonPropertyName("flags")]
    public required DocFormsGet200ResponseFieldsItemUnknownFlags Flags { get; set; }

    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("mappingName")]
    public string? MappingName { get; set; }

    [JsonPropertyName("valueEntry")]
    public required DocFormsGet200ResponseFieldsItemUnknownValueEntry ValueEntry { get; set; }

    [JsonPropertyName("defaultValueEntry")]
    public required DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry DefaultValueEntry { get; set; }

    [JsonPropertyName("actions")]
    public DocFormsGet200ResponseFieldsItemUnknownActions? Actions { get; set; }

    [JsonPropertyName("widgets")]
    public IEnumerable<DocFormsGet200ResponseFieldsItemUnknownWidgetsItem> Widgets { get; set; } =
        new List<DocFormsGet200ResponseFieldsItemUnknownWidgetsItem>();

    [JsonPropertyName("rawValue")]
    public required string RawValue { get; set; }

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
