// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftPolylineMeasureUnknown.JsonConverter))]
[Serializable]
public record AnnotationDraftPolylineMeasureUnknown
{
    internal AnnotationDraftPolylineMeasureUnknown(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraftPolylineMeasureUnknown with <see cref="AnnotationDraftPolylineMeasureUnknown.Geospatial"/>.
    /// </summary>
    public AnnotationDraftPolylineMeasureUnknown(
        AnnotationDraftPolylineMeasureUnknown.Geospatial value
    )
    {
        Subtype = "geospatial";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraftPolylineMeasureUnknown with <see cref="AnnotationDraftPolylineMeasureUnknown.Unknown"/>.
    /// </summary>
    public AnnotationDraftPolylineMeasureUnknown(
        AnnotationDraftPolylineMeasureUnknown.Unknown value
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
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial"/> if <see cref="Subtype"/> is 'geospatial', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'geospatial'.</exception>
    public CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial AsGeospatial() =>
        IsGeospatial
            ? (CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial)Value!
            : throw new global::System.Exception(
                "AnnotationDraftPolylineMeasureUnknown.Subtype is not 'geospatial'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown)Value!
            : throw new global::System.Exception(
                "AnnotationDraftPolylineMeasureUnknown.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial, T> onGeospatial,
        Func<CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown, T> onUnknown,
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
        Action<CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial> onGeospatial,
        Action<CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeospatial(out CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial? value)
    {
        if (Subtype == "geospatial")
        {
            value = (CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationDraftPolylineMeasureUnknown(
        AnnotationDraftPolylineMeasureUnknown.Geospatial value
    ) => new(value);

    public static implicit operator AnnotationDraftPolylineMeasureUnknown(
        AnnotationDraftPolylineMeasureUnknown.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationDraftPolylineMeasureUnknown>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationDraftPolylineMeasureUnknown).IsAssignableFrom(typeToConvert);

        public override AnnotationDraftPolylineMeasureUnknown Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationDraftPolylineMeasureUnknown(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasureUnknown value,
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

        public override AnnotationDraftPolylineMeasureUnknown ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationDraftPolylineMeasureUnknown(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasureUnknown value,
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
        public Geospatial(CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraftPolylineMeasureUnknown.Geospatial(
            CloudPDF.AnnotationDraftPolylineMeasureUnknownGeospatial value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraftPolylineMeasureUnknown.Unknown(
            CloudPDF.AnnotationDraftPolylineMeasureUnknownUnknown value
        ) => new(value);
    }
}
