using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record GrantsVisitorsListResponseVisitorsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("visitorId")]
    public required string VisitorId { get; set; }

    [JsonPropertyName("answers")]
    public required GrantsVisitorsListResponseVisitorsItemAnswers Answers { get; set; }

    [JsonPropertyName("emailVerified")]
    public required bool EmailVerified { get; set; }

    [JsonPropertyName("consentedAt")]
    public DateTime? ConsentedAt { get; set; }

    [JsonPropertyName("firstSeenAt")]
    public required DateTime FirstSeenAt { get; set; }

    [JsonPropertyName("lastSeenAt")]
    public required DateTime LastSeenAt { get; set; }

    [JsonPropertyName("layer")]
    public GrantsVisitorsListResponseVisitorsItemLayer? Layer { get; set; }

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
