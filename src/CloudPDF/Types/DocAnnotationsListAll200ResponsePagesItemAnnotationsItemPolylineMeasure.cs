// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.JsonConverter)
)]
[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure
{
    internal DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        string type,
        object? value
    )
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Rl"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Rl value
    )
    {
        Subtype = "RL";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Geo"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Geo value
    )
    {
        Subtype = "GEO";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Unknown"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Unknown value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl"/> if <see cref="Subtype"/> is 'RL', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'RL'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl AsRl() =>
        IsRl
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Subtype is not 'RL'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo"/> if <see cref="Subtype"/> is 'GEO', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'GEO'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo AsGeo() =>
        IsGeo
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Subtype is not 'GEO'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl,
            T
        > onRl,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo,
            T
        > onGeo,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown,
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
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl> onRl,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo> onGeo,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl"/> and returns true if successful.
    /// </summary>
    public bool TryAsRl(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl? value
    )
    {
        if (Subtype == "RL")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeo(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo? value
    )
    {
        if (Subtype == "GEO")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown? value
    )
    {
        if (Subtype == "unknown")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Rl value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Geo value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl"
                        ),
                "GEO" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure value,
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

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure value,
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
        public Rl(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Rl(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureRl value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GEO
    /// </summary>
    [Serializable]
    public struct Geo
    {
        public Geo(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Geo(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureGeo value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasure.Unknown(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineMeasureUnknown value
        ) => new(value);
    }
}
