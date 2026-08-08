using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocFormsGet200ResponseFieldsItemCheckbox : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocFormsGet200ResponseFieldsItemCheckboxRef Ref { get; set; }

    [JsonPropertyName("fieldObjectNumber")]
    public required int FieldObjectNumber { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("origin")]
    public required DocFormsGet200ResponseFieldsItemCheckboxOrigin Origin { get; set; }

    [JsonPropertyName("flags")]
    public required DocFormsGet200ResponseFieldsItemCheckboxFlags Flags { get; set; }

    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("mappingName")]
    public string? MappingName { get; set; }

    [JsonPropertyName("valueEntry")]
    public required DocFormsGet200ResponseFieldsItemCheckboxValueEntry ValueEntry { get; set; }

    [JsonPropertyName("defaultValueEntry")]
    public required DocFormsGet200ResponseFieldsItemCheckboxDefaultValueEntry DefaultValueEntry { get; set; }

    [JsonPropertyName("actions")]
    public DocFormsGet200ResponseFieldsItemCheckboxActions? Actions { get; set; }

    [JsonPropertyName("widgets")]
    public IEnumerable<DocFormsGet200ResponseFieldsItemCheckboxWidgetsItem> Widgets { get; set; } =
        new List<DocFormsGet200ResponseFieldsItemCheckboxWidgetsItem>();

    [JsonPropertyName("checked")]
    public required bool Checked { get; set; }

    [JsonPropertyName("exportValue")]
    public required string ExportValue { get; set; }

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
