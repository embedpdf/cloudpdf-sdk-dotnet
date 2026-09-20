// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure
{
    internal DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure with <see cref="DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Rl"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Rl value
    )
    {
        Subtype = "RL";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure with <see cref="DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Geo"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Geo value
    )
    {
        Subtype = "GEO";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure with <see cref="DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Unknown"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Unknown value
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
    /// Returns true if <see cref="Subtype"/> is "RL"
    /// </summary>
    public bool IsRl => Subtype == "RL";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "GEO"
    /// </summary>
    public bool IsGeo => Subtype == "GEO";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Subtype == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl"/> if <see cref="Subtype"/> is 'RL', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'RL'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl AsRl() =>
        IsRl
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Subtype is not 'RL'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo"/> if <see cref="Subtype"/> is 'GEO', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'GEO'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo AsGeo() =>
        IsGeo
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Subtype is not 'GEO'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl, T> onRl,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo, T> onGeo,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown,
            T
        > onUnknown,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "RL" => onRl(AsRl()),
            "GEO" => onGeo(AsGeo()),
            "unknown" => onUnknown(AsUnknown()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl> onRl,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo> onGeo,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown> onUnknown,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
            case "RL":
                onRl(AsRl());
                break;
            case "GEO":
                onGeo(AsGeo());
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl"/> and returns true if successful.
    /// </summary>
    public bool TryAsRl(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl? value
    )
    {
        if (Subtype == "RL")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeo(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo? value
    )
    {
        if (Subtype == "GEO")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown? value
    )
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Rl value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Geo value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure Read(
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
                "RL" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl"
                        ),
                "GEO" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "RL" => JsonSerializer.SerializeToNode(value.Value, options),
                    "GEO" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Subtype);
        }
    }

    /// <summary>
    /// Discriminated union type for RL
    /// </summary>
    [Serializable]
    public struct Rl
    {
        public Rl(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Rl(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRl value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GEO
    /// </summary>
    [Serializable]
    public struct Geo
    {
        public Geo(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Geo(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureGeo value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasure.Unknown(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureUnknown value
        ) => new(value);
    }
}
