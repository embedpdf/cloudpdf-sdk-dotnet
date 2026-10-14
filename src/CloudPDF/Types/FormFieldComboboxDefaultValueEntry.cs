// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldComboboxDefaultValueEntry.JsonConverter))]
[Serializable]
public record FormFieldComboboxDefaultValueEntry
{
    internal FormFieldComboboxDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldComboboxDefaultValueEntry with <see cref="FormFieldComboboxDefaultValueEntry.None"/>.
    /// </summary>
    public FormFieldComboboxDefaultValueEntry(FormFieldComboboxDefaultValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldComboboxDefaultValueEntry with <see cref="FormFieldComboboxDefaultValueEntry.Scalar"/>.
    /// </summary>
    public FormFieldComboboxDefaultValueEntry(FormFieldComboboxDefaultValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldComboboxDefaultValueEntry with <see cref="FormFieldComboboxDefaultValueEntry.Array"/>.
    /// </summary>
    public FormFieldComboboxDefaultValueEntry(FormFieldComboboxDefaultValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldComboboxDefaultValueEntry with <see cref="FormFieldComboboxDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public FormFieldComboboxDefaultValueEntry(FormFieldComboboxDefaultValueEntry.Unsupported value)
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormFieldComboboxDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormFieldComboboxDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "FormFieldComboboxDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormFieldComboboxDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormFieldComboboxDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "FormFieldComboboxDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormFieldComboboxDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormFieldComboboxDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "FormFieldComboboxDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "FormFieldComboboxDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.FormFieldComboboxDefaultValueEntryNone, T> onNone,
        Func<CloudPDF.FormFieldComboboxDefaultValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormFieldComboboxDefaultValueEntryArray, T> onArray,
        Func<CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported, T> onUnsupported,
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
        Action<CloudPDF.FormFieldComboboxDefaultValueEntryNone> onNone,
        Action<CloudPDF.FormFieldComboboxDefaultValueEntryScalar> onScalar,
        Action<CloudPDF.FormFieldComboboxDefaultValueEntryArray> onArray,
        Action<CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormFieldComboboxDefaultValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormFieldComboboxDefaultValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormFieldComboboxDefaultValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormFieldComboboxDefaultValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormFieldComboboxDefaultValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormFieldComboboxDefaultValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldComboboxDefaultValueEntry(
        FormFieldComboboxDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator FormFieldComboboxDefaultValueEntry(
        FormFieldComboboxDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator FormFieldComboboxDefaultValueEntry(
        FormFieldComboboxDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator FormFieldComboboxDefaultValueEntry(
        FormFieldComboboxDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldComboboxDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldComboboxDefaultValueEntry).IsAssignableFrom(typeToConvert);

        public override FormFieldComboboxDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldComboboxDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldComboboxDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldComboboxDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldComboboxDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldComboboxDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldComboboxDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldComboboxDefaultValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldComboboxDefaultValueEntry value,
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

        public override FormFieldComboboxDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldComboboxDefaultValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldComboboxDefaultValueEntry value,
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
        public None(CloudPDF.FormFieldComboboxDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldComboboxDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldComboboxDefaultValueEntry.None(
            CloudPDF.FormFieldComboboxDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormFieldComboboxDefaultValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldComboboxDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldComboboxDefaultValueEntry.Scalar(
            CloudPDF.FormFieldComboboxDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormFieldComboboxDefaultValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldComboboxDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldComboboxDefaultValueEntry.Array(
            CloudPDF.FormFieldComboboxDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldComboboxDefaultValueEntry.Unsupported(
            CloudPDF.FormFieldComboboxDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
