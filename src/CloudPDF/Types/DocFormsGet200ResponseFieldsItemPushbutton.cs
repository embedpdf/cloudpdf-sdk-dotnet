using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocFormsGet200ResponseFieldsItemPushbutton : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ref")]
    public required DocFormsGet200ResponseFieldsItemPushbuttonRef Ref { get; set; }

    [JsonPropertyName("fieldObjectNumber")]
    public required int FieldObjectNumber { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("origin")]
    public required DocFormsGet200ResponseFieldsItemPushbuttonOrigin Origin { get; set; }

    [JsonPropertyName("flags")]
    public required DocFormsGet200ResponseFieldsItemPushbuttonFlags Flags { get; set; }

    [JsonPropertyName("alternateName")]
    public string? AlternateName { get; set; }

    [JsonPropertyName("mappingName")]
    public string? MappingName { get; set; }

    [JsonPropertyName("valueEntry")]
    public required DocFormsGet200ResponseFieldsItemPushbuttonValueEntry ValueEntry { get; set; }

    [JsonPropertyName("defaultValueEntry")]
    public required DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry DefaultValueEntry { get; set; }

    [JsonPropertyName("actions")]
    public PdfFieldActions? Actions { get; set; }

    [JsonPropertyName("widgets")]
    public IEnumerable<DocFormsGet200ResponseFieldsItemPushbuttonWidgetsItem> Widgets { get; set; } =
        new List<DocFormsGet200ResponseFieldsItemPushbuttonWidgetsItem>();

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
