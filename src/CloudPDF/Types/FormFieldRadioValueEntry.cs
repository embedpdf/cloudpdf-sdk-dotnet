// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldRadioValueEntry.JsonConverter))]
[Serializable]
public record FormFieldRadioValueEntry
{
    internal FormFieldRadioValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldRadioValueEntry with <see cref="FormFieldRadioValueEntry.None"/>.
    /// </summary>
    public FormFieldRadioValueEntry(FormFieldRadioValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldRadioValueEntry with <see cref="FormFieldRadioValueEntry.Scalar"/>.
    /// </summary>
    public FormFieldRadioValueEntry(FormFieldRadioValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldRadioValueEntry with <see cref="FormFieldRadioValueEntry.Array"/>.
    /// </summary>
    public FormFieldRadioValueEntry(FormFieldRadioValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldRadioValueEntry with <see cref="FormFieldRadioValueEntry.Unsupported"/>.
    /// </summary>
    public FormFieldRadioValueEntry(FormFieldRadioValueEntry.Unsupported value)
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldRadioValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormFieldRadioValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormFieldRadioValueEntryNone)Value!
            : throw new global::System.Exception("FormFieldRadioValueEntry.Kind is not 'none'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldRadioValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormFieldRadioValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormFieldRadioValueEntryScalar)Value!
            : throw new global::System.Exception("FormFieldRadioValueEntry.Kind is not 'scalar'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldRadioValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormFieldRadioValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormFieldRadioValueEntryArray)Value!
            : throw new global::System.Exception("FormFieldRadioValueEntry.Kind is not 'array'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldRadioValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormFieldRadioValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormFieldRadioValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "FormFieldRadioValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.FormFieldRadioValueEntryNone, T> onNone,
        Func<CloudPDF.FormFieldRadioValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormFieldRadioValueEntryArray, T> onArray,
        Func<CloudPDF.FormFieldRadioValueEntryUnsupported, T> onUnsupported,
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
        Action<CloudPDF.FormFieldRadioValueEntryNone> onNone,
        Action<CloudPDF.FormFieldRadioValueEntryScalar> onScalar,
        Action<CloudPDF.FormFieldRadioValueEntryArray> onArray,
        Action<CloudPDF.FormFieldRadioValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRadioValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormFieldRadioValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormFieldRadioValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRadioValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormFieldRadioValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormFieldRadioValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRadioValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormFieldRadioValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormFieldRadioValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRadioValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.FormFieldRadioValueEntryUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormFieldRadioValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldRadioValueEntry(FormFieldRadioValueEntry.None value) =>
        new(value);

    public static implicit operator FormFieldRadioValueEntry(
        FormFieldRadioValueEntry.Scalar value
    ) => new(value);

    public static implicit operator FormFieldRadioValueEntry(
        FormFieldRadioValueEntry.Array value
    ) => new(value);

    public static implicit operator FormFieldRadioValueEntry(
        FormFieldRadioValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldRadioValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldRadioValueEntry).IsAssignableFrom(typeToConvert);

        public override FormFieldRadioValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRadioValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldRadioValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRadioValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldRadioValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRadioValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldRadioValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRadioValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldRadioValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldRadioValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldRadioValueEntry value,
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

        public override FormFieldRadioValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldRadioValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldRadioValueEntry value,
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
        public None(CloudPDF.FormFieldRadioValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRadioValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldRadioValueEntry.None(
            CloudPDF.FormFieldRadioValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormFieldRadioValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRadioValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldRadioValueEntry.Scalar(
            CloudPDF.FormFieldRadioValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormFieldRadioValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRadioValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldRadioValueEntry.Array(
            CloudPDF.FormFieldRadioValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormFieldRadioValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRadioValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldRadioValueEntry.Unsupported(
            CloudPDF.FormFieldRadioValueEntryUnsupported value
        ) => new(value);
    }
}
