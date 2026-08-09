// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItemCircleRef.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemCircleRef
{
    internal DocAnnotationsList200ResponseAnnotationsItemCircleRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemCircleRef with <see cref="DocAnnotationsList200ResponseAnnotationsItemCircleRef.ObjectNumber"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemCircleRef(
        DocAnnotationsList200ResponseAnnotationsItemCircleRef.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemCircleRef with <see cref="DocAnnotationsList200ResponseAnnotationsItemCircleRef.Nm"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemCircleRef(
        DocAnnotationsList200ResponseAnnotationsItemCircleRef.Nm value
    )
    {
        Kind = "nm";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemCircleRef with <see cref="DocAnnotationsList200ResponseAnnotationsItemCircleRef.Index"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemCircleRef(
        DocAnnotationsList200ResponseAnnotationsItemCircleRef.Index value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemCircleRef.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm"/> if <see cref="Kind"/> is 'nm', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'nm'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm AsNm() =>
        IsNm
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemCircleRef.Kind is not 'nm'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex"/> if <see cref="Kind"/> is 'index', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'index'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex AsIndex() =>
        IsIndex
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemCircleRef.Kind is not 'index'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber,
            T
        > onObjectNumber,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm, T> onNm,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex, T> onIndex,
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
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber> onObjectNumber,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm> onNm,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex> onIndex,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm"/> and returns true if successful.
    /// </summary>
    public bool TryAsNm(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm? value)
    {
        if (Kind == "nm")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndex(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex? value
    )
    {
        if (Kind == "index")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemCircleRef(
        DocAnnotationsList200ResponseAnnotationsItemCircleRef.ObjectNumber value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemCircleRef(
        DocAnnotationsList200ResponseAnnotationsItemCircleRef.Nm value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemCircleRef(
        DocAnnotationsList200ResponseAnnotationsItemCircleRef.Index value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemCircleRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemCircleRef).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemCircleRef Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber"
                        ),
                "nm" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm"
                        ),
                "index" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemCircleRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleRef value,
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

        public override DocAnnotationsList200ResponseAnnotationsItemCircleRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemCircleRef(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleRef value,
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
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemCircleRef.ObjectNumber(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for nm
    /// </summary>
    [Serializable]
    public struct Nm
    {
        public Nm(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemCircleRef.Nm(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefNm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for index
    /// </summary>
    [Serializable]
    public struct Index
    {
        public Index(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemCircleRef.Index(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircleRefIndex value
        ) => new(value);
    }
}
