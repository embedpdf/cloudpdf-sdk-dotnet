// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// A measure, by its `subtype`. A newer server can add subtypes: read one your client doesn't know as `unknown`.
/// </summary>
[JsonConverter(typeof(PdfMeasurement.JsonConverter))]
[Serializable]
public record PdfMeasurement
{
    internal PdfMeasurement(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfMeasurement with <see cref="PdfMeasurement.Rectilinear"/>.
    /// </summary>
    public PdfMeasurement(PdfMeasurement.Rectilinear value)
    {
        Subtype = "rectilinear";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfMeasurement with <see cref="PdfMeasurement.Geospatial"/>.
    /// </summary>
    public PdfMeasurement(PdfMeasurement.Geospatial value)
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfMeasurement with <see cref="PdfMeasurement.Unknown"/>.
    /// </summary>
    public PdfMeasurement(PdfMeasurement.Unknown value)
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
    /// Returns the value as a <see cref="CloudPDF.PdfMeasurementRectilinear"/> if <see cref="Subtype"/> is 'rectilinear', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'rectilinear'.</exception>
    public CloudPDF.PdfMeasurementRectilinear AsRectilinear() =>
        IsRectilinear
            ? (CloudPDF.PdfMeasurementRectilinear)Value!
            : throw new global::System.Exception("PdfMeasurement.Subtype is not 'rectilinear'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfMeasurementGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.PdfMeasurementGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.PdfMeasurementGeospatial)Value!
            : throw new global::System.Exception("PdfMeasurement.Subtype is not 'geospatial'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfMeasurementUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.PdfMeasurementUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.PdfMeasurementUnknown)Value!
            : throw new global::System.Exception("PdfMeasurement.Subtype is not 'unknown'");

    public T Match<T>(
        Func<CloudPDF.PdfMeasurementRectilinear, T> onRectilinear,
        Func<CloudPDF.PdfMeasurementGeospatial, T> onGeospatial,
        Func<CloudPDF.PdfMeasurementUnknown, T> onUnknown,
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
        Action<CloudPDF.PdfMeasurementRectilinear> onRectilinear,
        Action<CloudPDF.PdfMeasurementGeospatial> onGeospatial,
        Action<CloudPDF.PdfMeasurementUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfMeasurementRectilinear"/> and returns true if successful.
    /// </summary>
    public bool TryAsRectilinear(out CloudPDF.PdfMeasurementRectilinear? value)
    {
        if (Subtype == "rectilinear")
        {
            value = (CloudPDF.PdfMeasurementRectilinear)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfMeasurementGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(out CloudPDF.PdfMeasurementGeospatial? value)
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.PdfMeasurementGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfMeasurementUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.PdfMeasurementUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.PdfMeasurementUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfMeasurement(PdfMeasurement.Rectilinear value) => new(value);

    public static implicit operator PdfMeasurement(PdfMeasurement.Geospatial value) => new(value);

    public static implicit operator PdfMeasurement(PdfMeasurement.Unknown value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfMeasurement>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfMeasurement).IsAssignableFrom(typeToConvert);

        public override PdfMeasurement Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfMeasurementRectilinear?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfMeasurementRectilinear"
                        ),
                "geospatial" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfMeasurementGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfMeasurementGeospatial"
                        ),
                "unknown" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfMeasurementUnknown?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.PdfMeasurementUnknown"
                    ),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfMeasurement(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfMeasurement value,
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

        public override PdfMeasurement ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfMeasurement(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfMeasurement value,
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
        public Rectilinear(CloudPDF.PdfMeasurementRectilinear value)
        {
            Value = value;
        }

        internal CloudPDF.PdfMeasurementRectilinear Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfMeasurement.Rectilinear(
            CloudPDF.PdfMeasurementRectilinear value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for geospatial
    /// </summary>
    [Serializable]
    public struct Geospatial
    {
        public Geospatial(CloudPDF.PdfMeasurementGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.PdfMeasurementGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfMeasurement.Geospatial(
            CloudPDF.PdfMeasurementGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.PdfMeasurementUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.PdfMeasurementUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfMeasurement.Unknown(
            CloudPDF.PdfMeasurementUnknown value
        ) => new(value);
    }
}
