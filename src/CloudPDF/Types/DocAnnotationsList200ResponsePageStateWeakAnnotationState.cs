// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponsePageStateWeakAnnotationState.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponsePageStateWeakAnnotationState
{
    internal DocAnnotationsList200ResponsePageStateWeakAnnotationState(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponsePageStateWeakAnnotationState with <see cref="DocAnnotationsList200ResponsePageStateWeakAnnotationState.Unknown"/>.
    /// </summary>
    public DocAnnotationsList200ResponsePageStateWeakAnnotationState(
        DocAnnotationsList200ResponsePageStateWeakAnnotationState.Unknown value
    )
    {
        Kind = "unknown";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponsePageStateWeakAnnotationState with <see cref="DocAnnotationsList200ResponsePageStateWeakAnnotationState.Known"/>.
    /// </summary>
    public DocAnnotationsList200ResponsePageStateWeakAnnotationState(
        DocAnnotationsList200ResponsePageStateWeakAnnotationState.Known value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown"/> if <see cref="Kind"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unknown'.</exception>
    public CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponsePageStateWeakAnnotationState.Kind is not 'unknown'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown"/> if <see cref="Kind"/> is 'known', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'known'.</exception>
    public CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown AsKnown() =>
        IsKnown
            ? (CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponsePageStateWeakAnnotationState.Kind is not 'known'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown,
            T
        > onUnknown,
        Func<CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown, T> onKnown,
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
        Action<CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown> onUnknown,
        Action<CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown> onKnown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown? value
    )
    {
        if (Kind == "unknown")
        {
            value = (CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown"/> and returns true if successful.
    /// </summary>
    public bool TryAsKnown(
        out CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown? value
    )
    {
        if (Kind == "known")
        {
            value = (CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponsePageStateWeakAnnotationState(
        DocAnnotationsList200ResponsePageStateWeakAnnotationState.Unknown value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponsePageStateWeakAnnotationState(
        DocAnnotationsList200ResponsePageStateWeakAnnotationState.Known value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponsePageStateWeakAnnotationState>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponsePageStateWeakAnnotationState).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponsePageStateWeakAnnotationState Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown"
                        ),
                "known" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponsePageStateWeakAnnotationState(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponsePageStateWeakAnnotationState value,
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

        public override DocAnnotationsList200ResponsePageStateWeakAnnotationState ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponsePageStateWeakAnnotationState(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponsePageStateWeakAnnotationState value,
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
            CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponsePageStateWeakAnnotationState.Unknown(
            CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateUnknown value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for known
    /// </summary>
    [Serializable]
    public struct Known
    {
        public Known(CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponsePageStateWeakAnnotationState.Known(
            CloudPDF.DocAnnotationsList200ResponsePageStateWeakAnnotationStateKnown value
        ) => new(value);
    }
}
