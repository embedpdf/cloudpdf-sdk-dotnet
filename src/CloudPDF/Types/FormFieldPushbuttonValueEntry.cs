// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldPushbuttonValueEntry.JsonConverter))]
[Serializable]
public record FormFieldPushbuttonValueEntry
{
    internal FormFieldPushbuttonValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonValueEntry with <see cref="FormFieldPushbuttonValueEntry.None"/>.
    /// </summary>
    public FormFieldPushbuttonValueEntry(FormFieldPushbuttonValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonValueEntry with <see cref="FormFieldPushbuttonValueEntry.Scalar"/>.
    /// </summary>
    public FormFieldPushbuttonValueEntry(FormFieldPushbuttonValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonValueEntry with <see cref="FormFieldPushbuttonValueEntry.Array"/>.
    /// </summary>
    public FormFieldPushbuttonValueEntry(FormFieldPushbuttonValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonValueEntry with <see cref="FormFieldPushbuttonValueEntry.Unsupported"/>.
    /// </summary>
    public FormFieldPushbuttonValueEntry(FormFieldPushbuttonValueEntry.Unsupported value)
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormFieldPushbuttonValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormFieldPushbuttonValueEntryNone)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormFieldPushbuttonValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormFieldPushbuttonValueEntryScalar)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormFieldPushbuttonValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormFieldPushbuttonValueEntryArray)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormFieldPushbuttonValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormFieldPushbuttonValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.FormFieldPushbuttonValueEntryNone, T> onNone,
        Func<CloudPDF.FormFieldPushbuttonValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormFieldPushbuttonValueEntryArray, T> onArray,
        Func<CloudPDF.FormFieldPushbuttonValueEntryUnsupported, T> onUnsupported,
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
        Action<CloudPDF.FormFieldPushbuttonValueEntryNone> onNone,
        Action<CloudPDF.FormFieldPushbuttonValueEntryScalar> onScalar,
        Action<CloudPDF.FormFieldPushbuttonValueEntryArray> onArray,
        Action<CloudPDF.FormFieldPushbuttonValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormFieldPushbuttonValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormFieldPushbuttonValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormFieldPushbuttonValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormFieldPushbuttonValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormFieldPushbuttonValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormFieldPushbuttonValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.FormFieldPushbuttonValueEntryUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormFieldPushbuttonValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldPushbuttonValueEntry(
        FormFieldPushbuttonValueEntry.None value
    ) => new(value);

    public static implicit operator FormFieldPushbuttonValueEntry(
        FormFieldPushbuttonValueEntry.Scalar value
    ) => new(value);

    public static implicit operator FormFieldPushbuttonValueEntry(
        FormFieldPushbuttonValueEntry.Array value
    ) => new(value);

    public static implicit operator FormFieldPushbuttonValueEntry(
        FormFieldPushbuttonValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldPushbuttonValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldPushbuttonValueEntry).IsAssignableFrom(typeToConvert);

        public override FormFieldPushbuttonValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldPushbuttonValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldPushbuttonValueEntry value,
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

        public override FormFieldPushbuttonValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldPushbuttonValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldPushbuttonValueEntry value,
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
        public None(CloudPDF.FormFieldPushbuttonValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonValueEntry.None(
            CloudPDF.FormFieldPushbuttonValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormFieldPushbuttonValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonValueEntry.Scalar(
            CloudPDF.FormFieldPushbuttonValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormFieldPushbuttonValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonValueEntry.Array(
            CloudPDF.FormFieldPushbuttonValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormFieldPushbuttonValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonValueEntry.Unsupported(
            CloudPDF.FormFieldPushbuttonValueEntryUnsupported value
        ) => new(value);
    }
}
