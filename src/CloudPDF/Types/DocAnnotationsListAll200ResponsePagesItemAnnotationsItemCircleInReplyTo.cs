// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.JsonConverter)
)]
[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo
{
    internal DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        string type,
        object? value
    )
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.ObjectNumber"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Nm"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Nm value
    )
    {
        Kind = "nm";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Index"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Index value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm"/> if <see cref="Kind"/> is 'nm', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'nm'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm AsNm() =>
        IsNm
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Kind is not 'nm'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex"/> if <see cref="Kind"/> is 'index', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'index'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex AsIndex() =>
        IsIndex
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Kind is not 'index'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber,
            T
        > onObjectNumber,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm,
            T
        > onNm,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex,
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
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber> onObjectNumber,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm> onNm,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex> onIndex,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm"/> and returns true if successful.
    /// </summary>
    public bool TryAsNm(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm? value
    )
    {
        if (Kind == "nm")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndex(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex? value
    )
    {
        if (Kind == "index")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.ObjectNumber value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Nm value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Index value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber"
                        ),
                "nm" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm"
                        ),
                "index" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo value,
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

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo value,
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
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.ObjectNumber(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for nm
    /// </summary>
    [Serializable]
    public struct Nm
    {
        public Nm(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Nm(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToNm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for index
    /// </summary>
    [Serializable]
    public struct Index
    {
        public Index(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyTo.Index(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleInReplyToIndex value
        ) => new(value);
    }
}
