// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.JsonConverter)
)]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo
{
    internal DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        string type,
        object? value
    )
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo with <see cref="DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.ObjectNumber"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo with <see cref="DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Nm"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Nm value
    )
    {
        Kind = "nm";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo with <see cref="DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Index"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Index value
    )
    {
        Kind = "index";
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
    /// Returns true if <see cref="Kind"/> is "objectNumber"
    /// </summary>
    public bool IsObjectNumber => Kind == "objectNumber";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "nm"
    /// </summary>
    public bool IsNm => Kind == "nm";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "index"
    /// </summary>
    public bool IsIndex => Kind == "index";

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm"/> if <see cref="Kind"/> is 'nm', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'nm'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm AsNm() =>
        IsNm
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Kind is not 'nm'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex"/> if <see cref="Kind"/> is 'index', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'index'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex AsIndex() =>
        IsIndex
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Kind is not 'index'"
            );

    public T Match<T>(
        Func<
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber,
            T
        > onObjectNumber,
        Func<
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm,
            T
        > onNm,
        Func<
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex,
            T
        > onIndex,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "objectNumber" => onObjectNumber(AsObjectNumber()),
            "nm" => onNm(AsNm()),
            "index" => onIndex(AsIndex()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber> onObjectNumber,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm> onNm,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex> onIndex,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "objectNumber":
                onObjectNumber(AsObjectNumber());
                break;
            case "nm":
                onNm(AsNm());
                break;
            case "index":
                onIndex(AsIndex());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value =
                (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm"/> and returns true if successful.
    /// </summary>
    public bool TryAsNm(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm? value
    )
    {
        if (Kind == "nm")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndex(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex? value
    )
    {
        if (Kind == "index")
        {
            value =
                (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.ObjectNumber value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Nm value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Index value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo Read(
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
                "objectNumber" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber"
                        ),
                "nm" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm"
                        ),
                "index" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "objectNumber" => JsonSerializer.SerializeToNode(value.Value, options),
                    "nm" => JsonSerializer.SerializeToNode(value.Value, options),
                    "index" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for objectNumber
    /// </summary>
    [Serializable]
    public struct ObjectNumber
    {
        public ObjectNumber(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.ObjectNumber(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for nm
    /// </summary>
    [Serializable]
    public struct Nm
    {
        public Nm(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Nm(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToNm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for index
    /// </summary>
    [Serializable]
    public struct Index
    {
        public Index(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyTo.Index(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupportedInReplyToIndex value
        ) => new(value);
    }
}
