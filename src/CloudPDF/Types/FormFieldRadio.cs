using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record FormFieldRadio : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required FormFieldRef Ref { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("origin")]
    public required FormFieldRadioOrigin Origin { get; set; }

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
    public required FormFieldRadioValueEntry ValueEntry { get; set; }

    [JsonPropertyName("defaultValueEntry")]
    public required FormFieldRadioDefaultValueEntry DefaultValueEntry { get; set; }

    [JsonPropertyName("actions")]
    public PdfFieldActions? Actions { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

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
    public IEnumerable<FormFieldRadioWidgetsItem> Widgets { get; set; } =
        new List<FormFieldRadioWidgetsItem>();

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("radiosInUnison")]
    public required bool RadiosInUnison { get; set; }

    [JsonPropertyName("noToggleToOff")]
    public required bool NoToggleToOff { get; set; }

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
