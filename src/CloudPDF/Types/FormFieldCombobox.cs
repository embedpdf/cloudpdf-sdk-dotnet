using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FormFieldCombobox : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required FormFieldRef Ref { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("origin")]
    public required FormFieldComboboxOrigin Origin { get; set; }

    [JsonPropertyName("readOnly")]
    public required bool ReadOnly { get; set; }

    [JsonPropertyName("required")]
    public required bool Required { get; set; }

    [JsonPropertyName("noExport")]
    public required bool NoExport { get; set; }

    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("mappingName")]
    public string? MappingName { get; set; }

    [JsonPropertyName("valueEntry")]
    public required FormValueEntry ValueEntry { get; set; }

    [JsonPropertyName("defaultValueEntry")]
    public required FormValueEntry DefaultValueEntry { get; set; }

    [JsonPropertyName("actions")]
    public PdfFieldActions? Actions { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("filledBy")]
    public string? FilledBy { get; set; }

    [JsonPropertyName("filledByName")]
    public string? FilledByName { get; set; }

    [JsonPropertyName("filledAt")]
    public DateTime? FilledAt { get; set; }

    [JsonPropertyName("importedBy")]
    public string? ImportedBy { get; set; }

    [JsonPropertyName("widgets")]
    public IEnumerable<FormWidget> Widgets { get; set; } = new List<FormWidget>();

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("defaultValue")]
    public required string DefaultValue { get; set; }

    [JsonPropertyName("edit")]
    public required bool Edit { get; set; }

    [JsonPropertyName("options")]
    public IEnumerable<FormFieldComboboxOptionsItem> Options { get; set; } =
        new List<FormFieldComboboxOptionsItem>();

    /// <summary>
    /// The shape a text field's or a dropdown's value has, by its `kind`: a date or a time with the pattern it is shown in, or `other` for a format script the engine does not recognise. A newer server can add kinds: read one your client doesn't know as `other`.
    /// </summary>
    [JsonPropertyName("format")]
    public FormFieldFormat? Format { get; set; }

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
