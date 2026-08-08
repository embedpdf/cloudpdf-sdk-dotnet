using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[Serializable]
public record DocFormsGet200ResponseFieldsItemSignatureActionsValidate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("root")]
    public DocFormsGet200ResponseFieldsItemSignatureActionsValidateRoot? Root { get; set; }

    [JsonPropertyName("incomplete")]
    public required bool Incomplete { get; set; }

    [JsonPropertyName("warningFlags")]
    public required int WarningFlags { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<DocFormsGet200ResponseFieldsItemSignatureActionsValidateWarningsItem> Warnings { get; set; } =
        new List<DocFormsGet200ResponseFieldsItemSignatureActionsValidateWarningsItem>();

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
