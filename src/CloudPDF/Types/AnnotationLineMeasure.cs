// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationLineMeasure.JsonConverter))]
[Serializable]
public record AnnotationLineMeasure
{
    internal AnnotationLineMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationLineMeasure with <see cref="AnnotationLineMeasure.Rectilinear"/>.
    /// </summary>
    public AnnotationLineMeasure(AnnotationLineMeasure.Rectilinear value)
    {
        Subtype = "rectilinear";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationLineMeasure with <see cref="AnnotationLineMeasure.Geospatial"/>.
    /// </summary>
    public AnnotationLineMeasure(AnnotationLineMeasure.Geospatial value)
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationLineMeasure with <see cref="AnnotationLineMeasure.Unknown"/>.
    /// </summary>
    public AnnotationLineMeasure(AnnotationLineMeasure.Unknown value)
    {
        Subtype = "unknown";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("subtype")]
    public string Subtype { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "rectilinear"
    /// </summary>
    public bool IsRectilinear => Subtype == "rectilinear";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "geospatial"
    /// </summary>
    public bool IsGeospatial => Subtype == "geospatial";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Subtype == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationLineMeasureRectilinear"/> if <see cref="Subtype"/> is 'rectilinear', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'rectilinear'.</exception>
    public CloudPDF.AnnotationLineMeasureRectilinear AsRectilinear() =>
        IsRectilinear
            ? (CloudPDF.AnnotationLineMeasureRectilinear)Value!
            : throw new global::System.Exception(
                "AnnotationLineMeasure.Subtype is not 'rectilinear'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationLineMeasureGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.AnnotationLineMeasureGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.AnnotationLineMeasureGeospatial)Value!
            : throw new global::System.Exception(
                "AnnotationLineMeasure.Subtype is not 'geospatial'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationLineMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.AnnotationLineMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.AnnotationLineMeasureUnknown)Value!
            : throw new global::System.Exception("AnnotationLineMeasure.Subtype is not 'unknown'");

    public T Match<T>(
        Func<CloudPDF.AnnotationLineMeasureRectilinear, T> onRectilinear,
        Func<CloudPDF.AnnotationLineMeasureGeospatial, T> onGeospatial,
        Func<CloudPDF.AnnotationLineMeasureUnknown, T> onUnknown,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "rectilinear" => onRectilinear(AsRectilinear()),
            "geospatial" => onGeospatial(AsGeospatial()),
            "unknown" => onUnknown(AsUnknown()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.AnnotationLineMeasureRectilinear> onRectilinear,
        Action<CloudPDF.AnnotationLineMeasureGeospatial> onGeospatial,
        Action<CloudPDF.AnnotationLineMeasureUnknown> onUnknown,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
            case "rectilinear":
                onRectilinear(AsRectilinear());
                break;
            case "geospatial":
                onGeospatial(AsGeospatial());
                break;
            case "unknown":
                onUnknown(AsUnknown());
                break;
            default:
                onUnknown_(Subtype, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationLineMeasureRectilinear"/> and returns true if successful.
    /// </summary>
    public bool TryAsRectilinear(out CloudPDF.AnnotationLineMeasureRectilinear? value)
    {
        if (Subtype == "rectilinear")
        {
            value = (CloudPDF.AnnotationLineMeasureRectilinear)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationLineMeasureGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(out CloudPDF.AnnotationLineMeasureGeospatial? value)
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.AnnotationLineMeasureGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationLineMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.AnnotationLineMeasureUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.AnnotationLineMeasureUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationLineMeasure(
        AnnotationLineMeasure.Rectilinear value
    ) => new(value);

    public static implicit operator AnnotationLineMeasure(AnnotationLineMeasure.Geospatial value) =>
        new(value);

    public static implicit operator AnnotationLineMeasure(AnnotationLineMeasure.Unknown value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationLineMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationLineMeasure).IsAssignableFrom(typeToConvert);

        public override AnnotationLineMeasure Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("subtype", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'subtype'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'subtype' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'subtype' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'subtype' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("subtype");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "rectilinear" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationLineMeasureRectilinear?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationLineMeasureRectilinear"
                        ),
                "geospatial" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationLineMeasureGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationLineMeasureGeospatial"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationLineMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationLineMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationLineMeasure(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLineMeasure value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "rectilinear" => JsonSerializer.SerializeToNode(value.Value, options),
                    "geospatial" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override AnnotationLineMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationLineMeasure(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLineMeasure value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Subtype);
        }
    }

    /// <summary>
    /// Discriminated union type for rectilinear
    /// </summary>
    [Serializable]
    public struct Rectilinear
    {
        public Rectilinear(CloudPDF.AnnotationLineMeasureRectilinear value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationLineMeasureRectilinear Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationLineMeasure.Rectilinear(
            CloudPDF.AnnotationLineMeasureRectilinear value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for geospatial
    /// </summary>
    [Serializable]
    public struct Geospatial
    {
        public Geospatial(CloudPDF.AnnotationLineMeasureGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationLineMeasureGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationLineMeasure.Geospatial(
            CloudPDF.AnnotationLineMeasureGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.AnnotationLineMeasureUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationLineMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationLineMeasure.Unknown(
            CloudPDF.AnnotationLineMeasureUnknown value
        ) => new(value);
    }
}
