// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfLinkTargetWritable.JsonConverter))]
[Serializable]
public record PdfLinkTargetWritable
{
    internal PdfLinkTargetWritable(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTargetWritable with <see cref="PdfLinkTargetWritable.Goto"/>.
    /// </summary>
    public PdfLinkTargetWritable(PdfLinkTargetWritable.Goto value)
    {
        Kind = "goto";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTargetWritable with <see cref="PdfLinkTargetWritable.Uri"/>.
    /// </summary>
    public PdfLinkTargetWritable(PdfLinkTargetWritable.Uri value)
    {
        Kind = "uri";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTargetWritable with <see cref="PdfLinkTargetWritable.Named"/>.
    /// </summary>
    public PdfLinkTargetWritable(PdfLinkTargetWritable.Named value)
    {
        Kind = "named";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "goto"
    /// </summary>
    public bool IsGoto => Kind == "goto";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "uri"
    /// </summary>
    public bool IsUri => Kind == "uri";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "named"
    /// </summary>
    public bool IsNamed => Kind == "named";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetWritableGoto"/> if <see cref="Kind"/> is 'goto', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto'.</exception>
    public CloudPDF.PdfLinkTargetWritableGoto AsGoto() =>
        IsGoto
            ? (CloudPDF.PdfLinkTargetWritableGoto)Value!
            : throw new global::System.Exception("PdfLinkTargetWritable.Kind is not 'goto'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetWritableUri"/> if <see cref="Kind"/> is 'uri', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'uri'.</exception>
    public CloudPDF.PdfLinkTargetWritableUri AsUri() =>
        IsUri
            ? (CloudPDF.PdfLinkTargetWritableUri)Value!
            : throw new global::System.Exception("PdfLinkTargetWritable.Kind is not 'uri'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetWritableNamed"/> if <see cref="Kind"/> is 'named', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'named'.</exception>
    public CloudPDF.PdfLinkTargetWritableNamed AsNamed() =>
        IsNamed
            ? (CloudPDF.PdfLinkTargetWritableNamed)Value!
            : throw new global::System.Exception("PdfLinkTargetWritable.Kind is not 'named'");

    public T Match<T>(
        Func<CloudPDF.PdfLinkTargetWritableGoto, T> onGoto,
        Func<CloudPDF.PdfLinkTargetWritableUri, T> onUri,
        Func<CloudPDF.PdfLinkTargetWritableNamed, T> onNamed,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "goto" => onGoto(AsGoto()),
            "uri" => onUri(AsUri()),
            "named" => onNamed(AsNamed()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.PdfLinkTargetWritableGoto> onGoto,
        Action<CloudPDF.PdfLinkTargetWritableUri> onUri,
        Action<CloudPDF.PdfLinkTargetWritableNamed> onNamed,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "goto":
                onGoto(AsGoto());
                break;
            case "uri":
                onUri(AsUri());
                break;
            case "named":
                onNamed(AsNamed());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetWritableGoto"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto(out CloudPDF.PdfLinkTargetWritableGoto? value)
    {
        if (Kind == "goto")
        {
            value = (CloudPDF.PdfLinkTargetWritableGoto)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetWritableUri"/> and returns true if successful.
    /// </summary>
    public bool TryAsUri(out CloudPDF.PdfLinkTargetWritableUri? value)
    {
        if (Kind == "uri")
        {
            value = (CloudPDF.PdfLinkTargetWritableUri)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetWritableNamed"/> and returns true if successful.
    /// </summary>
    public bool TryAsNamed(out CloudPDF.PdfLinkTargetWritableNamed? value)
    {
        if (Kind == "named")
        {
            value = (CloudPDF.PdfLinkTargetWritableNamed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfLinkTargetWritable(PdfLinkTargetWritable.Goto value) =>
        new(value);

    public static implicit operator PdfLinkTargetWritable(PdfLinkTargetWritable.Uri value) =>
        new(value);

    public static implicit operator PdfLinkTargetWritable(PdfLinkTargetWritable.Named value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfLinkTargetWritable>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfLinkTargetWritable).IsAssignableFrom(typeToConvert);

        public override PdfLinkTargetWritable Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("kind", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'kind'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'kind' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'kind' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'kind' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("kind");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "goto" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetWritableGoto?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.PdfLinkTargetWritableGoto"
                    ),
                "uri" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetWritableUri?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.PdfLinkTargetWritableUri"
                    ),
                "named" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetWritableNamed?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfLinkTargetWritableNamed"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfLinkTargetWritable(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfLinkTargetWritable value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "goto" => JsonSerializer.SerializeToNode(value.Value, options),
                    "uri" => JsonSerializer.SerializeToNode(value.Value, options),
                    "named" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override PdfLinkTargetWritable ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfLinkTargetWritable(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfLinkTargetWritable value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for goto
    /// </summary>
    [Serializable]
    public struct Goto
    {
        public Goto(CloudPDF.PdfLinkTargetWritableGoto value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetWritableGoto Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTargetWritable.Goto(
            CloudPDF.PdfLinkTargetWritableGoto value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for uri
    /// </summary>
    [Serializable]
    public struct Uri
    {
        public Uri(CloudPDF.PdfLinkTargetWritableUri value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetWritableUri Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTargetWritable.Uri(
            CloudPDF.PdfLinkTargetWritableUri value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for named
    /// </summary>
    [Serializable]
    public struct Named
    {
        public Named(CloudPDF.PdfLinkTargetWritableNamed value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetWritableNamed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTargetWritable.Named(
            CloudPDF.PdfLinkTargetWritableNamed value
        ) => new(value);
    }
}
