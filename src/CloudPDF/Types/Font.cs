using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record Font : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("source")]
    public required FontSource Source { get; set; }

    [JsonPropertyName("familyName")]
    public required string FamilyName { get; set; }

    [JsonPropertyName("weight")]
    public required int Weight { get; set; }

    [JsonPropertyName("italic")]
    public required bool Italic { get; set; }

    [JsonPropertyName("postScriptName")]
    public string? PostScriptName { get; set; }

    [JsonPropertyName("canChoose")]
    public required bool CanChoose { get; set; }

    [JsonPropertyName("restrictions")]
    public IEnumerable<FontRestrictionsItem> Restrictions { get; set; } =
        new List<FontRestrictionsItem>();

    [JsonPropertyName("programs")]
    public IEnumerable<FontProgram> Programs { get; set; } = new List<FontProgram>();

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
