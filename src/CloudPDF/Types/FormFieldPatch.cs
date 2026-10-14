using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace CloudPDF;

[Serializable]
public record FormFieldPatch : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public string? Name { get; set; }

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

    [JsonPropertyName("family")]
    public FormFieldPatchFamily? Family { get; set; }

    [JsonPropertyName("defaultValue")]
    public OneOf<string, IEnumerable<string>>? DefaultValue { get; set; }

    [JsonPropertyName("maxLength")]
    public int? MaxLength { get; set; }

    [JsonPropertyName("multiline")]
    public bool? Multiline { get; set; }

    [JsonPropertyName("password")]
    public bool? Password { get; set; }

    [JsonPropertyName("comb")]
    public bool? Comb { get; set; }

    [JsonPropertyName("radiosInUnison")]
    public bool? RadiosInUnison { get; set; }

    [JsonPropertyName("noToggleToOff")]
    public bool? NoToggleToOff { get; set; }

    [JsonPropertyName("edit")]
    public bool? Edit { get; set; }

    [JsonPropertyName("multiSelect")]
    public bool? MultiSelect { get; set; }

    [JsonPropertyName("options")]
    public IEnumerable<FormFieldPatchOptionsItem>? Options { get; set; }

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
