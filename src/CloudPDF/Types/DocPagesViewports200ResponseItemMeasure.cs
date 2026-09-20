// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesViewports200ResponseItemMeasure.JsonConverter))]
[Serializable]
public record DocPagesViewports200ResponseItemMeasure
{
    internal DocPagesViewports200ResponseItemMeasure(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocPagesViewports200ResponseItemMeasure with <see cref="DocPagesViewports200ResponseItemMeasure.Rl"/>.
    /// </summary>
    public DocPagesViewports200ResponseItemMeasure(DocPagesViewports200ResponseItemMeasure.Rl value)
    {
        Subtype = "RL";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesViewports200ResponseItemMeasure with <see cref="DocPagesViewports200ResponseItemMeasure.Geo"/>.
    /// </summary>
    public DocPagesViewports200ResponseItemMeasure(
        DocPagesViewports200ResponseItemMeasure.Geo value
    )
    {
        Subtype = "GEO";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesViewports200ResponseItemMeasure with <see cref="DocPagesViewports200ResponseItemMeasure.Unknown"/>.
    /// </summary>
    public DocPagesViewports200ResponseItemMeasure(
        DocPagesViewports200ResponseItemMeasure.Unknown value
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
    /// Returns the value as a <see cref="CloudPDF.DocPagesViewports200ResponseItemMeasureRl"/> if <see cref="Subtype"/> is 'RL', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'RL'.</exception>
    public CloudPDF.DocPagesViewports200ResponseItemMeasureRl AsRl() =>
        IsRl
            ? (CloudPDF.DocPagesViewports200ResponseItemMeasureRl)Value!
            : throw new global::System.Exception(
                "DocPagesViewports200ResponseItemMeasure.Subtype is not 'RL'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesViewports200ResponseItemMeasureGeo"/> if <see cref="Subtype"/> is 'GEO', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'GEO'.</exception>
    public CloudPDF.DocPagesViewports200ResponseItemMeasureGeo AsGeo() =>
        IsGeo
            ? (CloudPDF.DocPagesViewports200ResponseItemMeasureGeo)Value!
            : throw new global::System.Exception(
                "DocPagesViewports200ResponseItemMeasure.Subtype is not 'GEO'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown"/> if <see cref="Subtype"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unknown'.</exception>
    public CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown)Value!
            : throw new global::System.Exception(
                "DocPagesViewports200ResponseItemMeasure.Subtype is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudPDF.DocPagesViewports200ResponseItemMeasureRl, T> onRl,
        Func<CloudPDF.DocPagesViewports200ResponseItemMeasureGeo, T> onGeo,
        Func<CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown, T> onUnknown,
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
        Action<CloudPDF.DocPagesViewports200ResponseItemMeasureRl> onRl,
        Action<CloudPDF.DocPagesViewports200ResponseItemMeasureGeo> onGeo,
        Action<CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesViewports200ResponseItemMeasureRl"/> and returns true if successful.
    /// </summary>
    public bool TryAsRl(out CloudPDF.DocPagesViewports200ResponseItemMeasureRl? value)
    {
        if (Subtype == "RL")
        {
            value = (CloudPDF.DocPagesViewports200ResponseItemMeasureRl)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesViewports200ResponseItemMeasureGeo"/> and returns true if successful.
    /// </summary>
    public bool TryAsGeo(out CloudPDF.DocPagesViewports200ResponseItemMeasureGeo? value)
    {
        if (Subtype == "GEO")
        {
            value = (CloudPDF.DocPagesViewports200ResponseItemMeasureGeo)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown? value)
    {
        if (Subtype == "unknown")
        {
            value = (CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocPagesViewports200ResponseItemMeasure(
        DocPagesViewports200ResponseItemMeasure.Rl value
    ) => new(value);

    public static implicit operator DocPagesViewports200ResponseItemMeasure(
        DocPagesViewports200ResponseItemMeasure.Geo value
    ) => new(value);

    public static implicit operator DocPagesViewports200ResponseItemMeasure(
        DocPagesViewports200ResponseItemMeasure.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocPagesViewports200ResponseItemMeasure>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocPagesViewports200ResponseItemMeasure).IsAssignableFrom(typeToConvert);

        public override DocPagesViewports200ResponseItemMeasure Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesViewports200ResponseItemMeasureRl?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesViewports200ResponseItemMeasureRl"
                        ),
                "GEO" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesViewports200ResponseItemMeasureGeo?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesViewports200ResponseItemMeasureGeo"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocPagesViewports200ResponseItemMeasure(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasure value,
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

        public override DocPagesViewports200ResponseItemMeasure ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocPagesViewports200ResponseItemMeasure(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasure value,
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
        public Rl(CloudPDF.DocPagesViewports200ResponseItemMeasureRl value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesViewports200ResponseItemMeasureRl Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesViewports200ResponseItemMeasure.Rl(
            CloudPDF.DocPagesViewports200ResponseItemMeasureRl value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for GEO
    /// </summary>
    [Serializable]
    public struct Geo
    {
        public Geo(CloudPDF.DocPagesViewports200ResponseItemMeasureGeo value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesViewports200ResponseItemMeasureGeo Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesViewports200ResponseItemMeasure.Geo(
            CloudPDF.DocPagesViewports200ResponseItemMeasureGeo value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesViewports200ResponseItemMeasure.Unknown(
            CloudPDF.DocPagesViewports200ResponseItemMeasureUnknown value
        ) => new(value);
    }
}
