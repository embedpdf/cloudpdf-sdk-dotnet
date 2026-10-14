// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchPolylineMeasureUnknown.JsonConverter))]
[Serializable]
public record AnnotationPatchPolylineMeasureUnknown
{
    internal AnnotationPatchPolylineMeasureUnknown(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatchPolylineMeasureUnknown with <see cref="AnnotationPatchPolylineMeasureUnknown.Geospatial"/>.
    /// </summary>
    public AnnotationPatchPolylineMeasureUnknown(
        AnnotationPatchPolylineMeasureUnknown.Geospatial value
    )
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatchPolylineMeasureUnknown with <see cref="AnnotationPatchPolylineMeasureUnknown.Unknown"/>.
    /// </summary>
    public AnnotationPatchPolylineMeasureUnknown(
        AnnotationPatchPolylineMeasureUnknown.Unknown value
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
    /// Returns true if <see cref="Subtype"/> is "geospatial"
    /// </summary>
    public bool IsGeospatial => Subtype == "geospatial";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Subtype == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial)Value!
            : throw new global::System.Exception(
                "AnnotationPatchPolylineMeasureUnknown.Subtype is not 'geospatial'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown)Value!
            : throw new global::System.Exception(
                "AnnotationPatchPolylineMeasureUnknown.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial, T> onGeospatial,
        Func<CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown, T> onUnknown,
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
        Action<CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial> onGeospatial,
        Action<CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(out CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial? value)
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationPatchPolylineMeasureUnknown(
        AnnotationPatchPolylineMeasureUnknown.Geospatial value
    ) => new(value);

    public static implicit operator AnnotationPatchPolylineMeasureUnknown(
        AnnotationPatchPolylineMeasureUnknown.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationPatchPolylineMeasureUnknown>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationPatchPolylineMeasureUnknown).IsAssignableFrom(typeToConvert);

        public override AnnotationPatchPolylineMeasureUnknown Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationPatchPolylineMeasureUnknown(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineMeasureUnknown value,
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

        public override AnnotationPatchPolylineMeasureUnknown ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationPatchPolylineMeasureUnknown(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineMeasureUnknown value,
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
        public Geospatial(CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatchPolylineMeasureUnknown.Geospatial(
            CloudPDF.AnnotationPatchPolylineMeasureUnknownGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatchPolylineMeasureUnknown.Unknown(
            CloudPDF.AnnotationPatchPolylineMeasureUnknownUnknown value
        ) => new(value);
    }
}
