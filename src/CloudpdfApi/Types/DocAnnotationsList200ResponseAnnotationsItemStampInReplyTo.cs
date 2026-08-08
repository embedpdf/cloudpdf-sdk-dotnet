// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo
{
    internal DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo with <see cref="DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.ObjectNumber"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo with <see cref="DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Nm"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Nm value
    )
    {
        Kind = "nm";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo with <see cref="DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Index"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Index value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm"/> if <see cref="Kind"/> is 'nm', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'nm'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm AsNm() =>
        IsNm
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Kind is not 'nm'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex"/> if <see cref="Kind"/> is 'index', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'index'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex AsIndex() =>
        IsIndex
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Kind is not 'index'"
            );

    public T Match<T>(
        Func<
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber,
            T
        > onObjectNumber,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm, T> onNm,
        Func<
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex,
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
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber> onObjectNumber,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm> onNm,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex> onIndex,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value =
                (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm"/> and returns true if successful.
    /// </summary>
    public bool TryAsNm(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm? value
    )
    {
        if (Kind == "nm")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndex(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex? value
    )
    {
        if (Kind == "index")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.ObjectNumber value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Nm value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
        DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Index value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber"
                        ),
                "nm" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm"
                        ),
                "index" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo value,
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

        public override DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo value,
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
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.ObjectNumber(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for nm
    /// </summary>
    [Serializable]
    public struct Nm
    {
        public Nm(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Nm(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToNm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for index
    /// </summary>
    [Serializable]
    public struct Index
    {
        public Index(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStampInReplyTo.Index(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStampInReplyToIndex value
        ) => new(value);
    }
}
