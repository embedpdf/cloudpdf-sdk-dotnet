using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocFormsGet200ResponseFieldsItemRadio : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocFormsGet200ResponseFieldsItemRadioRef Ref { get; set; }

    [JsonPropertyName("fieldObjectNumber")]
    public required int FieldObjectNumber { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("origin")]
    public required DocFormsGet200ResponseFieldsItemRadioOrigin Origin { get; set; }

    [JsonPropertyName("flags")]
    public required DocFormsGet200ResponseFieldsItemRadioFlags Flags { get; set; }

    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("mappingName")]
    public string? MappingName { get; set; }

    [JsonPropertyName("valueEntry")]
    public required DocFormsGet200ResponseFieldsItemRadioValueEntry ValueEntry { get; set; }

    [JsonPropertyName("defaultValueEntry")]
    public required DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry DefaultValueEntry { get; set; }

    [JsonPropertyName("actions")]
    public PdfFieldActions? Actions { get; set; }

    [JsonPropertyName("widgets")]
    public IEnumerable<DocFormsGet200ResponseFieldsItemRadioWidgetsItem> Widgets { get; set; } =
        new List<DocFormsGet200ResponseFieldsItemRadioWidgetsItem>();

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
