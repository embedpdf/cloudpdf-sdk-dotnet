// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchLineMeasureUnknown.JsonConverter))]
[Serializable]
public record AnnotationPatchLineMeasureUnknown
{
    internal AnnotationPatchLineMeasureUnknown(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatchLineMeasureUnknown with <see cref="AnnotationPatchLineMeasureUnknown.Geospatial"/>.
    /// </summary>
    public AnnotationPatchLineMeasureUnknown(AnnotationPatchLineMeasureUnknown.Geospatial value)
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatchLineMeasureUnknown with <see cref="AnnotationPatchLineMeasureUnknown.Unknown"/>.
    /// </summary>
    public AnnotationPatchLineMeasureUnknown(AnnotationPatchLineMeasureUnknown.Unknown value)
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
    /// Returns true if <see cref="Subtype"/> is "geospatial"
    /// </summary>
    public bool IsGeospatial => Subtype == "geospatial";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Subtype == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial)Value!
            : throw new global::System.Exception(
                "AnnotationPatchLineMeasureUnknown.Subtype is not 'geospatial'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchLineMeasureUnknownUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.AnnotationPatchLineMeasureUnknownUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.AnnotationPatchLineMeasureUnknownUnknown)Value!
            : throw new global::System.Exception(
                "AnnotationPatchLineMeasureUnknown.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial, T> onGeospatial,
        Func<CloudPDF.AnnotationPatchLineMeasureUnknownUnknown, T> onUnknown,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "geospatial" => onGeospatial(AsGeospatial()),
            "unknown" => onUnknown(AsUnknown()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial> onGeospatial,
        Action<CloudPDF.AnnotationPatchLineMeasureUnknownUnknown> onUnknown,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(out CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial? value)
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchLineMeasureUnknownUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.AnnotationPatchLineMeasureUnknownUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.AnnotationPatchLineMeasureUnknownUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationPatchLineMeasureUnknown(
        AnnotationPatchLineMeasureUnknown.Geospatial value
    ) => new(value);

    public static implicit operator AnnotationPatchLineMeasureUnknown(
        AnnotationPatchLineMeasureUnknown.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationPatchLineMeasureUnknown>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationPatchLineMeasureUnknown).IsAssignableFrom(typeToConvert);

        public override AnnotationPatchLineMeasureUnknown Read(
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
                "geospatial" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchLineMeasureUnknownUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchLineMeasureUnknownUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationPatchLineMeasureUnknown(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureUnknown value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "geospatial" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override AnnotationPatchLineMeasureUnknown ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationPatchLineMeasureUnknown(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureUnknown value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Subtype);
        }
    }

    /// <summary>
    /// Discriminated union type for geospatial
    /// </summary>
    [Serializable]
    public struct Geospatial
    {
        public Geospatial(CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatchLineMeasureUnknown.Geospatial(
            CloudPDF.AnnotationPatchLineMeasureUnknownGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.AnnotationPatchLineMeasureUnknownUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchLineMeasureUnknownUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatchLineMeasureUnknown.Unknown(
            CloudPDF.AnnotationPatchLineMeasureUnknownUnknown value
        ) => new(value);
    }
}
