// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesViewports200ResponseViewportsItemMeasure.JsonConverter))]
[Serializable]
public record DocPagesViewports200ResponseViewportsItemMeasure
{
    internal DocPagesViewports200ResponseViewportsItemMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocPagesViewports200ResponseViewportsItemMeasure with <see cref="DocPagesViewports200ResponseViewportsItemMeasure.Rectilinear"/>.
    /// </summary>
    public DocPagesViewports200ResponseViewportsItemMeasure(
        DocPagesViewports200ResponseViewportsItemMeasure.Rectilinear value
    )
    {
        Subtype = "rectilinear";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesViewports200ResponseViewportsItemMeasure with <see cref="DocPagesViewports200ResponseViewportsItemMeasure.Geospatial"/>.
    /// </summary>
    public DocPagesViewports200ResponseViewportsItemMeasure(
        DocPagesViewports200ResponseViewportsItemMeasure.Geospatial value
    )
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesViewports200ResponseViewportsItemMeasure with <see cref="DocPagesViewports200ResponseViewportsItemMeasure.Unknown"/>.
    /// </summary>
    public DocPagesViewports200ResponseViewportsItemMeasure(
        DocPagesViewports200ResponseViewportsItemMeasure.Unknown value
    )
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
    /// Returns the value as a <see cref="CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear"/> if <see cref="Subtype"/> is 'rectilinear', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'rectilinear'.</exception>
    public CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear AsRectilinear() =>
        IsRectilinear
            ? (CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear)Value!
            : throw new global::System.Exception(
                "DocPagesViewports200ResponseViewportsItemMeasure.Subtype is not 'rectilinear'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial)Value!
            : throw new global::System.Exception(
                "DocPagesViewports200ResponseViewportsItemMeasure.Subtype is not 'geospatial'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown)Value!
            : throw new global::System.Exception(
                "DocPagesViewports200ResponseViewportsItemMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear, T> onRectilinear,
        Func<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial, T> onGeospatial,
        Func<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown, T> onUnknown,
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
        Action<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear> onRectilinear,
        Action<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial> onGeospatial,
        Action<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear"/> and returns true if successful.
    /// </summary>
    public bool TryAsRectilinear(
        out CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear? value
    )
    {
        if (Subtype == "rectilinear")
        {
            value = (CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(
        out CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial? value
    )
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown? value
    )
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocPagesViewports200ResponseViewportsItemMeasure(
        DocPagesViewports200ResponseViewportsItemMeasure.Rectilinear value
    ) => new(value);

    public static implicit operator DocPagesViewports200ResponseViewportsItemMeasure(
        DocPagesViewports200ResponseViewportsItemMeasure.Geospatial value
    ) => new(value);

    public static implicit operator DocPagesViewports200ResponseViewportsItemMeasure(
        DocPagesViewports200ResponseViewportsItemMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocPagesViewports200ResponseViewportsItemMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocPagesViewports200ResponseViewportsItemMeasure).IsAssignableFrom(
                typeToConvert
            );

        public override DocPagesViewports200ResponseViewportsItemMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear"
                        ),
                "geospatial" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocPagesViewports200ResponseViewportsItemMeasure(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasure value,
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

        public override DocPagesViewports200ResponseViewportsItemMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocPagesViewports200ResponseViewportsItemMeasure(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasure value,
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
        public Rectilinear(
            CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesViewports200ResponseViewportsItemMeasure.Rectilinear(
            CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureRectilinear value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for geospatial
    /// </summary>
    [Serializable]
    public struct Geospatial
    {
        public Geospatial(CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesViewports200ResponseViewportsItemMeasure.Geospatial(
            CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesViewports200ResponseViewportsItemMeasure.Unknown(
            CloudPDF.DocPagesViewports200ResponseViewportsItemMeasureUnknown value
        ) => new(value);
    }
}
