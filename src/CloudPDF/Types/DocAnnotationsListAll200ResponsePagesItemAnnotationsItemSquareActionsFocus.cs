using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquareActionsFocus
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("root")]
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquareActionsFocusRoot? Root { get; set; }

    [JsonPropertyName("incomplete")]
    public required bool Incomplete { get; set; }

    [JsonPropertyName("warningFlags")]
    public required int WarningFlags { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquareActionsFocusWarningsItem> Warnings { get; set; } =
        new List<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquareActionsFocusWarningsItem>();

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
