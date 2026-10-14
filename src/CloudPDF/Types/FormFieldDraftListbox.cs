using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FormFieldDraftListbox : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    [JsonPropertyName("noExport")]
    public bool? NoExport { get; set; }

    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("mappingName")]
    public string? MappingName { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("actions")]
    public FieldActionsPatch? Actions { get; set; }

    [JsonPropertyName("widgets")]
    public IEnumerable<WidgetPlacement>? Widgets { get; set; }

    [JsonPropertyName("multiSelect")]
    public bool? MultiSelect { get; set; }

    [JsonPropertyName("options")]
    public IEnumerable<FormFieldDraftListboxOptionsItem>? Options { get; set; }

    [JsonPropertyName("defaultValue")]
    public IEnumerable<string>? DefaultValue { get; set; }

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
