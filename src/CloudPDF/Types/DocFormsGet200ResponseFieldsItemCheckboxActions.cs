using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocFormsGet200ResponseFieldsItemCheckboxActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("keystroke")]
    public DocFormsGet200ResponseFieldsItemCheckboxActionsKeystroke? Keystroke { get; set; }

    [JsonPropertyName("format")]
    public DocFormsGet200ResponseFieldsItemCheckboxActionsFormat? Format { get; set; }

    [JsonPropertyName("validate")]
    public DocFormsGet200ResponseFieldsItemCheckboxActionsValidate? Validate { get; set; }

    [JsonPropertyName("calculate")]
    public DocFormsGet200ResponseFieldsItemCheckboxActionsCalculate? Calculate { get; set; }

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
