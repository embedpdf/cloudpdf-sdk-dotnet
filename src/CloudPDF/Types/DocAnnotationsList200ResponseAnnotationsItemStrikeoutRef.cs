// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef
{
    internal DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef with <see cref="DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.ObjectNumber"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef with <see cref="DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Nm"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Nm value
    )
    {
        Kind = "nm";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef with <see cref="DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Index"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Index value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm"/> if <see cref="Kind"/> is 'nm', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'nm'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm AsNm() =>
        IsNm
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Kind is not 'nm'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex"/> if <see cref="Kind"/> is 'index', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'index'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex AsIndex() =>
        IsIndex
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Kind is not 'index'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber,
            T
        > onObjectNumber,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm, T> onNm,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex, T> onIndex,
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
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber> onObjectNumber,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm> onNm,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex> onIndex,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm"/> and returns true if successful.
    /// </summary>
    public bool TryAsNm(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm? value
    )
    {
        if (Kind == "nm")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndex(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex? value
    )
    {
        if (Kind == "index")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.ObjectNumber value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Nm value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Index value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber"
                        ),
                "nm" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm"
                        ),
                "index" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef value,
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

        public override DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef value,
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
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.ObjectNumber(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for nm
    /// </summary>
    [Serializable]
    public struct Nm
    {
        public Nm(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Nm(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefNm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for index
    /// </summary>
    [Serializable]
    public struct Index
    {
        public Index(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutRef.Index(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeoutRefIndex value
        ) => new(value);
    }
}
