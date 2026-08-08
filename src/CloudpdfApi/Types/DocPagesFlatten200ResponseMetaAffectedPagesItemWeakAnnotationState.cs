// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.JsonConverter)
)]
[Serializable]
public record DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState
{
    internal DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
        string type,
        object? value
    )
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState with <see cref="DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Unknown"/>.
    /// </summary>
    public DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
        DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Unknown value
    )
    {
        Kind = "unknown";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState with <see cref="DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Known"/>.
    /// </summary>
    public DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
        DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Known value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown"/> if <see cref="Kind"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unknown'.</exception>
    public CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown AsUnknown() =>
        IsUnknown
            ? (CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown)
                Value!
            : throw new global::System.Exception(
                "DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Kind is not 'unknown'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown"/> if <see cref="Kind"/> is 'known', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'known'.</exception>
    public CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown AsKnown() =>
        IsKnown
            ? (CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown)
                Value!
            : throw new global::System.Exception(
                "DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Kind is not 'known'"
            );

    public T Match<T>(
        Func<
            CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown,
            T
        > onUnknown,
        Func<
            CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown,
            T
        > onKnown,
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
        Action<CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown> onUnknown,
        Action<CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown> onKnown,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown? value
    )
    {
        if (Kind == "unknown")
        {
            value =
                (CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown"/> and returns true if successful.
    /// </summary>
    public bool TryAsKnown(
        out CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown? value
    )
    {
        if (Kind == "known")
        {
            value =
                (CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
        DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Unknown value
    ) => new(value);

    public static implicit operator DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
        DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Known value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState).IsAssignableFrom(
                typeToConvert
            );

        public override DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown"
                        ),
                "known" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState value,
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

        public override DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState value,
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
            CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Unknown(
            CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateUnknown value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for known
    /// </summary>
    [Serializable]
    public struct Known
    {
        public Known(
            CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationState.Known(
            CloudpdfApi.DocPagesFlatten200ResponseMetaAffectedPagesItemWeakAnnotationStateKnown value
        ) => new(value);
    }
}
