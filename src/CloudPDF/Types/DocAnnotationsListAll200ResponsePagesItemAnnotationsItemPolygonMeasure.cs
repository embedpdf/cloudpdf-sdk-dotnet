// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.JsonConverter)
)]
[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure
{
    internal DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        string type,
        object? value
    )
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Rl"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Rl value
    )
    {
        Subtype = "RL";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Geo"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Geo value
    )
    {
        Subtype = "GEO";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Unknown"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Unknown value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl"/> if <see cref="Subtype"/> is 'RL', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'RL'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl AsRl() =>
        IsRl
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Subtype is not 'RL'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo"/> if <see cref="Subtype"/> is 'GEO', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'GEO'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo AsGeo() =>
        IsGeo
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Subtype is not 'GEO'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl,
            T
        > onRl,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo,
            T
        > onGeo,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown,
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
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl> onRl,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo> onGeo,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl"/> and returns true if successful.
    /// </summary>
    public bool TryAsRl(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl? value
    )
    {
        if (Subtype == "RL")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeo(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo? value
    )
    {
        if (Subtype == "GEO")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown? value
    )
    {
        if (Subtype == "unknown")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Rl value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Geo value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl"
                        ),
                "GEO" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure value,
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

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure value,
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
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Rl(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRl value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GEO
    /// </summary>
    [Serializable]
    public struct Geo
    {
        public Geo(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Geo(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureGeo value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasure.Unknown(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureUnknown value
        ) => new(value);
    }
}
