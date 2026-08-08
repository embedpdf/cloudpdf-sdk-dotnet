// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocManifest200ResponsePagesItemStateWeakAnnotationState.JsonConverter))]
[Serializable]
public record DocManifest200ResponsePagesItemStateWeakAnnotationState
{
    internal DocManifest200ResponsePagesItemStateWeakAnnotationState(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocManifest200ResponsePagesItemStateWeakAnnotationState with <see cref="DocManifest200ResponsePagesItemStateWeakAnnotationState.Unknown"/>.
    /// </summary>
    public DocManifest200ResponsePagesItemStateWeakAnnotationState(
        DocManifest200ResponsePagesItemStateWeakAnnotationState.Unknown value
    )
    {
        Kind = "unknown";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocManifest200ResponsePagesItemStateWeakAnnotationState with <see cref="DocManifest200ResponsePagesItemStateWeakAnnotationState.Known"/>.
    /// </summary>
    public DocManifest200ResponsePagesItemStateWeakAnnotationState(
        DocManifest200ResponsePagesItemStateWeakAnnotationState.Known value
    )
    {
        Kind = "known";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Kind == "unknown";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "known"
    /// </summary>
    public bool IsKnown => Kind == "known";

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown"/> if <see cref="Kind"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unknown'.</exception>
    public CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown AsUnknown() =>
        IsUnknown
            ? (CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown)Value!
            : throw new global::System.Exception(
                "DocManifest200ResponsePagesItemStateWeakAnnotationState.Kind is not 'unknown'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown"/> if <see cref="Kind"/> is 'known', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'known'.</exception>
    public CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown AsKnown() =>
        IsKnown
            ? (CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown)Value!
            : throw new global::System.Exception(
                "DocManifest200ResponsePagesItemStateWeakAnnotationState.Kind is not 'known'"
            );

    public T Match<T>(
        Func<
            CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown,
            T
        > onUnknown,
        Func<CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown, T> onKnown,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "unknown" => onUnknown(AsUnknown()),
            "known" => onKnown(AsKnown()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown> onUnknown,
        Action<CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown> onKnown,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "unknown":
                onUnknown(AsUnknown());
                break;
            case "known":
                onKnown(AsKnown());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown? value
    )
    {
        if (Kind == "unknown")
        {
            value = (CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown"/> and returns true if successful.
    /// </summary>
    public bool TryAsKnown(
        out CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown? value
    )
    {
        if (Kind == "known")
        {
            value = (CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocManifest200ResponsePagesItemStateWeakAnnotationState(
        DocManifest200ResponsePagesItemStateWeakAnnotationState.Unknown value
    ) => new(value);

    public static implicit operator DocManifest200ResponsePagesItemStateWeakAnnotationState(
        DocManifest200ResponsePagesItemStateWeakAnnotationState.Known value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocManifest200ResponsePagesItemStateWeakAnnotationState>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocManifest200ResponsePagesItemStateWeakAnnotationState).IsAssignableFrom(
                typeToConvert
            );

        public override DocManifest200ResponsePagesItemStateWeakAnnotationState Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("kind", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'kind'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'kind' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'kind' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'kind' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("kind");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown"
                        ),
                "known" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocManifest200ResponsePagesItemStateWeakAnnotationState(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest200ResponsePagesItemStateWeakAnnotationState value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "unknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    "known" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocManifest200ResponsePagesItemStateWeakAnnotationState ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocManifest200ResponsePagesItemStateWeakAnnotationState(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest200ResponsePagesItemStateWeakAnnotationState value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(
            CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocManifest200ResponsePagesItemStateWeakAnnotationState.Unknown(
            CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateUnknown value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for known
    /// </summary>
    [Serializable]
    public struct Known
    {
        public Known(CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocManifest200ResponsePagesItemStateWeakAnnotationState.Known(
            CloudpdfApi.DocManifest200ResponsePagesItemStateWeakAnnotationStateKnown value
        ) => new(value);
    }
}
