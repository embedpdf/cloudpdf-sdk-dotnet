// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftPolylineMeasure.JsonConverter))]
[Serializable]
public record AnnotationDraftPolylineMeasure
{
    internal AnnotationDraftPolylineMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraftPolylineMeasure with <see cref="AnnotationDraftPolylineMeasure.Rectilinear"/>.
    /// </summary>
    public AnnotationDraftPolylineMeasure(AnnotationDraftPolylineMeasure.Rectilinear value)
    {
        Subtype = "rectilinear";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraftPolylineMeasure with <see cref="AnnotationDraftPolylineMeasure.Unknown"/>.
    /// </summary>
    public AnnotationDraftPolylineMeasure(AnnotationDraftPolylineMeasure.Unknown value)
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
    /// Returns true if <see cref="Subtype"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Subtype == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPolylineMeasureRectilinear"/> if <see cref="Subtype"/> is 'rectilinear', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'rectilinear'.</exception>
    public CloudPDF.AnnotationDraftPolylineMeasureRectilinear AsRectilinear() =>
        IsRectilinear
            ? (CloudPDF.AnnotationDraftPolylineMeasureRectilinear)Value!
            : throw new global::System.Exception(
                "AnnotationDraftPolylineMeasure.Subtype is not 'rectilinear'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPolylineMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.AnnotationDraftPolylineMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.AnnotationDraftPolylineMeasureUnknown)Value!
            : throw new global::System.Exception(
                "AnnotationDraftPolylineMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.AnnotationDraftPolylineMeasureRectilinear, T> onRectilinear,
        Func<CloudPDF.AnnotationDraftPolylineMeasureUnknown, T> onUnknown,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "rectilinear" => onRectilinear(AsRectilinear()),
            "unknown" => onUnknown(AsUnknown()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.AnnotationDraftPolylineMeasureRectilinear> onRectilinear,
        Action<CloudPDF.AnnotationDraftPolylineMeasureUnknown> onUnknown,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
            case "rectilinear":
                onRectilinear(AsRectilinear());
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPolylineMeasureRectilinear"/> and returns true if successful.
    /// </summary>
    public bool TryAsRectilinear(out CloudPDF.AnnotationDraftPolylineMeasureRectilinear? value)
    {
        if (Subtype == "rectilinear")
        {
            value = (CloudPDF.AnnotationDraftPolylineMeasureRectilinear)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPolylineMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.AnnotationDraftPolylineMeasureUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.AnnotationDraftPolylineMeasureUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationDraftPolylineMeasure(
        AnnotationDraftPolylineMeasure.Rectilinear value
    ) => new(value);

    public static implicit operator AnnotationDraftPolylineMeasure(
        AnnotationDraftPolylineMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationDraftPolylineMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationDraftPolylineMeasure).IsAssignableFrom(typeToConvert);

        public override AnnotationDraftPolylineMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftPolylineMeasureRectilinear?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftPolylineMeasureRectilinear"
                        ),
                "unknown" => json.GetProperty("value")
                    .Deserialize<CloudPDF.AnnotationDraftPolylineMeasureUnknown?>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationDraftPolylineMeasureUnknown"
                    ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationDraftPolylineMeasure(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasure value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "rectilinear" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unknown" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override AnnotationDraftPolylineMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationDraftPolylineMeasure(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasure value,
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
        public Rectilinear(CloudPDF.AnnotationDraftPolylineMeasureRectilinear value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPolylineMeasureRectilinear Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraftPolylineMeasure.Rectilinear(
            CloudPDF.AnnotationDraftPolylineMeasureRectilinear value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.AnnotationDraftPolylineMeasureUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPolylineMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraftPolylineMeasure.Unknown(
            CloudPDF.AnnotationDraftPolylineMeasureUnknown value
        ) => new(value);
    }
}
