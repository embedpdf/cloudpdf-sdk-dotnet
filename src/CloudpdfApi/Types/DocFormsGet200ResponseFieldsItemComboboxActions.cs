using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocFormsGet200ResponseFieldsItemComboboxActions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("keystroke")]
    public DocFormsGet200ResponseFieldsItemComboboxActionsKeystroke? Keystroke { get; set; }

    [JsonPropertyName("format")]
    public DocFormsGet200ResponseFieldsItemComboboxActionsFormat? Format { get; set; }

    [JsonPropertyName("validate")]
    public DocFormsGet200ResponseFieldsItemComboboxActionsValidate? Validate { get; set; }

    [JsonPropertyName("calculate")]
    public DocFormsGet200ResponseFieldsItemComboboxActionsCalculate? Calculate { get; set; }

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
