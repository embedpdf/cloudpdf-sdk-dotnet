// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPolylineMeasure.JsonConverter))]
[Serializable]
public record AnnotationPolylineMeasure
{
    internal AnnotationPolylineMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationPolylineMeasure with <see cref="AnnotationPolylineMeasure.Rectilinear"/>.
    /// </summary>
    public AnnotationPolylineMeasure(AnnotationPolylineMeasure.Rectilinear value)
    {
        Subtype = "rectilinear";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPolylineMeasure with <see cref="AnnotationPolylineMeasure.Geospatial"/>.
    /// </summary>
    public AnnotationPolylineMeasure(AnnotationPolylineMeasure.Geospatial value)
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPolylineMeasure with <see cref="AnnotationPolylineMeasure.Unknown"/>.
    /// </summary>
    public AnnotationPolylineMeasure(AnnotationPolylineMeasure.Unknown value)
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
    /// Returns the value as a <see cref="CloudPDF.AnnotationPolylineMeasureRectilinear"/> if <see cref="Subtype"/> is 'rectilinear', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'rectilinear'.</exception>
    public CloudPDF.AnnotationPolylineMeasureRectilinear AsRectilinear() =>
        IsRectilinear
            ? (CloudPDF.AnnotationPolylineMeasureRectilinear)Value!
            : throw new global::System.Exception(
                "AnnotationPolylineMeasure.Subtype is not 'rectilinear'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPolylineMeasureGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.AnnotationPolylineMeasureGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.AnnotationPolylineMeasureGeospatial)Value!
            : throw new global::System.Exception(
                "AnnotationPolylineMeasure.Subtype is not 'geospatial'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPolylineMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.AnnotationPolylineMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.AnnotationPolylineMeasureUnknown)Value!
            : throw new global::System.Exception(
                "AnnotationPolylineMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.AnnotationPolylineMeasureRectilinear, T> onRectilinear,
        Func<CloudPDF.AnnotationPolylineMeasureGeospatial, T> onGeospatial,
        Func<CloudPDF.AnnotationPolylineMeasureUnknown, T> onUnknown,
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
        Action<CloudPDF.AnnotationPolylineMeasureRectilinear> onRectilinear,
        Action<CloudPDF.AnnotationPolylineMeasureGeospatial> onGeospatial,
        Action<CloudPDF.AnnotationPolylineMeasureUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPolylineMeasureRectilinear"/> and returns true if successful.
    /// </summary>
    public bool TryAsRectilinear(out CloudPDF.AnnotationPolylineMeasureRectilinear? value)
    {
        if (Subtype == "rectilinear")
        {
            value = (CloudPDF.AnnotationPolylineMeasureRectilinear)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPolylineMeasureGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(out CloudPDF.AnnotationPolylineMeasureGeospatial? value)
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.AnnotationPolylineMeasureGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPolylineMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.AnnotationPolylineMeasureUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.AnnotationPolylineMeasureUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationPolylineMeasure(
        AnnotationPolylineMeasure.Rectilinear value
    ) => new(value);

    public static implicit operator AnnotationPolylineMeasure(
        AnnotationPolylineMeasure.Geospatial value
    ) => new(value);

    public static implicit operator AnnotationPolylineMeasure(
        AnnotationPolylineMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationPolylineMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationPolylineMeasure).IsAssignableFrom(typeToConvert);

        public override AnnotationPolylineMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPolylineMeasureRectilinear?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPolylineMeasureRectilinear"
                        ),
                "geospatial" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPolylineMeasureGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPolylineMeasureGeospatial"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPolylineMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPolylineMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationPolylineMeasure(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolylineMeasure value,
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

        public override AnnotationPolylineMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationPolylineMeasure(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolylineMeasure value,
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
        public Rectilinear(CloudPDF.AnnotationPolylineMeasureRectilinear value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPolylineMeasureRectilinear Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPolylineMeasure.Rectilinear(
            CloudPDF.AnnotationPolylineMeasureRectilinear value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for geospatial
    /// </summary>
    [Serializable]
    public struct Geospatial
    {
        public Geospatial(CloudPDF.AnnotationPolylineMeasureGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPolylineMeasureGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPolylineMeasure.Geospatial(
            CloudPDF.AnnotationPolylineMeasureGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.AnnotationPolylineMeasureUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPolylineMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPolylineMeasure.Unknown(
            CloudPDF.AnnotationPolylineMeasureUnknown value
        ) => new(value);
    }
}
