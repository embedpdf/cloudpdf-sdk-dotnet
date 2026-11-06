// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// A field's stored value, by its `kind`. A newer server can add kinds: read one your client doesn't know as `unsupported`.
/// </summary>
[JsonConverter(typeof(FormValueEntry.JsonConverter))]
[Serializable]
public record FormValueEntry
{
    internal FormValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormValueEntry with <see cref="FormValueEntry.None"/>.
    /// </summary>
    public FormValueEntry(FormValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormValueEntry with <see cref="FormValueEntry.Scalar"/>.
    /// </summary>
    public FormValueEntry(FormValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormValueEntry with <see cref="FormValueEntry.Array"/>.
    /// </summary>
    public FormValueEntry(FormValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormValueEntry with <see cref="FormValueEntry.Unsupported"/>.
    /// </summary>
    public FormValueEntry(FormValueEntry.Unsupported value)
    {
        Kind = "unsupported";
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
    /// Returns true if <see cref="Kind"/> is "none"
    /// </summary>
    public bool IsNone => Kind == "none";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "scalar"
    /// </summary>
    public bool IsScalar => Kind == "scalar";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "array"
    /// </summary>
    public bool IsArray => Kind == "array";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "unsupported"
    /// </summary>
    public bool IsUnsupported => Kind == "unsupported";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormValueEntryNone)Value!
            : throw new global::System.Exception("FormValueEntry.Kind is not 'none'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormValueEntryScalar)Value!
            : throw new global::System.Exception("FormValueEntry.Kind is not 'scalar'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormValueEntryArray)Value!
            : throw new global::System.Exception("FormValueEntry.Kind is not 'array'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormValueEntryUnsupported)Value!
            : throw new global::System.Exception("FormValueEntry.Kind is not 'unsupported'");

    public T Match<T>(
        Func<CloudPDF.FormValueEntryNone, T> onNone,
        Func<CloudPDF.FormValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormValueEntryArray, T> onArray,
        Func<CloudPDF.FormValueEntryUnsupported, T> onUnsupported,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "none" => onNone(AsNone()),
            "scalar" => onScalar(AsScalar()),
            "array" => onArray(AsArray()),
            "unsupported" => onUnsupported(AsUnsupported()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.FormValueEntryNone> onNone,
        Action<CloudPDF.FormValueEntryScalar> onScalar,
        Action<CloudPDF.FormValueEntryArray> onArray,
        Action<CloudPDF.FormValueEntryUnsupported> onUnsupported,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "none":
                onNone(AsNone());
                break;
            case "scalar":
                onScalar(AsScalar());
                break;
            case "array":
                onArray(AsArray());
                break;
            case "unsupported":
                onUnsupported(AsUnsupported());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.FormValueEntryUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormValueEntry(FormValueEntry.None value) => new(value);

    public static implicit operator FormValueEntry(FormValueEntry.Scalar value) => new(value);

    public static implicit operator FormValueEntry(FormValueEntry.Array value) => new(value);

    public static implicit operator FormValueEntry(FormValueEntry.Unsupported value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormValueEntry).IsAssignableFrom(typeToConvert);

        public override FormValueEntry Read(
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
                "none" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormValueEntryNone?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormValueEntryNone"),
                "scalar" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormValueEntryScalar?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormValueEntryScalar"),
                "array" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormValueEntryArray?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormValueEntryArray"),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormValueEntry value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "none" => JsonSerializer.SerializeToNode(value.Value, options),
                    "scalar" => JsonSerializer.SerializeToNode(value.Value, options),
                    "array" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unsupported" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override FormValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormValueEntry value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for none
    /// </summary>
    [Serializable]
    public struct None
    {
        public None(CloudPDF.FormValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormValueEntry.None(CloudPDF.FormValueEntryNone value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormValueEntry.Scalar(
            CloudPDF.FormValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormValueEntry.Array(CloudPDF.FormValueEntryArray value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormValueEntry.Unsupported(
            CloudPDF.FormValueEntryUnsupported value
        ) => new(value);
    }
}
