using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record DocumentActionsSnapshot : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("nameTreeScripts")]
    public IEnumerable<DocumentActionsSnapshotNameTreeScriptsItem> NameTreeScripts { get; set; } =
        new List<DocumentActionsSnapshotNameTreeScriptsItem>();

    [JsonPropertyName("openAction")]
    public PdfActionTree? OpenAction { get; set; }

    [JsonPropertyName("openDestination")]
    public PdfDestination? OpenDestination { get; set; }

    [JsonPropertyName("willClose")]
    public PdfActionTree? WillClose { get; set; }

    [JsonPropertyName("willSave")]
    public PdfActionTree? WillSave { get; set; }

    [JsonPropertyName("didSave")]
    public PdfActionTree? DidSave { get; set; }

    [JsonPropertyName("willPrint")]
    public PdfActionTree? WillPrint { get; set; }

    [JsonPropertyName("didPrint")]
    public PdfActionTree? DidPrint { get; set; }

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
