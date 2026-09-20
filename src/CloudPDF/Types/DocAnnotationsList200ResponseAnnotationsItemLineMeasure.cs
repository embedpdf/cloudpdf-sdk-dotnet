// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItemLineMeasure.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemLineMeasure
{
    internal DocAnnotationsList200ResponseAnnotationsItemLineMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLineMeasure with <see cref="DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Rl"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Rl value
    )
    {
        Subtype = "RL";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLineMeasure with <see cref="DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Geo"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Geo value
    )
    {
        Subtype = "GEO";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLineMeasure with <see cref="DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Unknown"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Unknown value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl"/> if <see cref="Subtype"/> is 'RL', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'RL'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl AsRl() =>
        IsRl
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Subtype is not 'RL'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo"/> if <see cref="Subtype"/> is 'GEO', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'GEO'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo AsGeo() =>
        IsGeo
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Subtype is not 'GEO'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl, T> onRl,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo, T> onGeo,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown, T> onUnknown,
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
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl> onRl,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo> onGeo,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl"/> and returns true if successful.
    /// </summary>
    public bool TryAsRl(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl? value
    )
    {
        if (Subtype == "RL")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeo(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo? value
    )
    {
        if (Subtype == "GEO")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown? value
    )
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Rl value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Geo value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemLineMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemLineMeasure).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemLineMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl"
                        ),
                "GEO" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineMeasure value,
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

        public override DocAnnotationsList200ResponseAnnotationsItemLineMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemLineMeasure(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineMeasure value,
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
        public Rl(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Rl(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRl value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GEO
    /// </summary>
    [Serializable]
    public struct Geo
    {
        public Geo(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Geo(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureGeo value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasure.Unknown(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLineMeasureUnknown value
        ) => new(value);
    }
}
