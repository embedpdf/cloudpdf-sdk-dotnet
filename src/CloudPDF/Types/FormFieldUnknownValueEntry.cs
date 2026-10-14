// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldUnknownValueEntry.JsonConverter))]
[Serializable]
public record FormFieldUnknownValueEntry
{
    internal FormFieldUnknownValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldUnknownValueEntry with <see cref="FormFieldUnknownValueEntry.None"/>.
    /// </summary>
    public FormFieldUnknownValueEntry(FormFieldUnknownValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldUnknownValueEntry with <see cref="FormFieldUnknownValueEntry.Scalar"/>.
    /// </summary>
    public FormFieldUnknownValueEntry(FormFieldUnknownValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldUnknownValueEntry with <see cref="FormFieldUnknownValueEntry.Array"/>.
    /// </summary>
    public FormFieldUnknownValueEntry(FormFieldUnknownValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldUnknownValueEntry with <see cref="FormFieldUnknownValueEntry.Unsupported"/>.
    /// </summary>
    public FormFieldUnknownValueEntry(FormFieldUnknownValueEntry.Unsupported value)
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldUnknownValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormFieldUnknownValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormFieldUnknownValueEntryNone)Value!
            : throw new global::System.Exception("FormFieldUnknownValueEntry.Kind is not 'none'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldUnknownValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormFieldUnknownValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormFieldUnknownValueEntryScalar)Value!
            : throw new global::System.Exception("FormFieldUnknownValueEntry.Kind is not 'scalar'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldUnknownValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormFieldUnknownValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormFieldUnknownValueEntryArray)Value!
            : throw new global::System.Exception("FormFieldUnknownValueEntry.Kind is not 'array'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldUnknownValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormFieldUnknownValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormFieldUnknownValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "FormFieldUnknownValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.FormFieldUnknownValueEntryNone, T> onNone,
        Func<CloudPDF.FormFieldUnknownValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormFieldUnknownValueEntryArray, T> onArray,
        Func<CloudPDF.FormFieldUnknownValueEntryUnsupported, T> onUnsupported,
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
        Action<CloudPDF.FormFieldUnknownValueEntryNone> onNone,
        Action<CloudPDF.FormFieldUnknownValueEntryScalar> onScalar,
        Action<CloudPDF.FormFieldUnknownValueEntryArray> onArray,
        Action<CloudPDF.FormFieldUnknownValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldUnknownValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormFieldUnknownValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormFieldUnknownValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldUnknownValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormFieldUnknownValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormFieldUnknownValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldUnknownValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormFieldUnknownValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormFieldUnknownValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldUnknownValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.FormFieldUnknownValueEntryUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormFieldUnknownValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldUnknownValueEntry(
        FormFieldUnknownValueEntry.None value
    ) => new(value);

    public static implicit operator FormFieldUnknownValueEntry(
        FormFieldUnknownValueEntry.Scalar value
    ) => new(value);

    public static implicit operator FormFieldUnknownValueEntry(
        FormFieldUnknownValueEntry.Array value
    ) => new(value);

    public static implicit operator FormFieldUnknownValueEntry(
        FormFieldUnknownValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldUnknownValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldUnknownValueEntry).IsAssignableFrom(typeToConvert);

        public override FormFieldUnknownValueEntry Read(
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
                "none" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldUnknownValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldUnknownValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldUnknownValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldUnknownValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldUnknownValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldUnknownValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldUnknownValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldUnknownValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldUnknownValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldUnknownValueEntry value,
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

        public override FormFieldUnknownValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldUnknownValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldUnknownValueEntry value,
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
        public None(CloudPDF.FormFieldUnknownValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldUnknownValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldUnknownValueEntry.None(
            CloudPDF.FormFieldUnknownValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormFieldUnknownValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldUnknownValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldUnknownValueEntry.Scalar(
            CloudPDF.FormFieldUnknownValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormFieldUnknownValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldUnknownValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldUnknownValueEntry.Array(
            CloudPDF.FormFieldUnknownValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormFieldUnknownValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldUnknownValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldUnknownValueEntry.Unsupported(
            CloudPDF.FormFieldUnknownValueEntryUnsupported value
        ) => new(value);
    }
}
