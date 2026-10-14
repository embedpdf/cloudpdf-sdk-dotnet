// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldPushbuttonDefaultValueEntry.JsonConverter))]
[Serializable]
public record FormFieldPushbuttonDefaultValueEntry
{
    internal FormFieldPushbuttonDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonDefaultValueEntry with <see cref="FormFieldPushbuttonDefaultValueEntry.None"/>.
    /// </summary>
    public FormFieldPushbuttonDefaultValueEntry(FormFieldPushbuttonDefaultValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonDefaultValueEntry with <see cref="FormFieldPushbuttonDefaultValueEntry.Scalar"/>.
    /// </summary>
    public FormFieldPushbuttonDefaultValueEntry(FormFieldPushbuttonDefaultValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonDefaultValueEntry with <see cref="FormFieldPushbuttonDefaultValueEntry.Array"/>.
    /// </summary>
    public FormFieldPushbuttonDefaultValueEntry(FormFieldPushbuttonDefaultValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldPushbuttonDefaultValueEntry with <see cref="FormFieldPushbuttonDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public FormFieldPushbuttonDefaultValueEntry(
        FormFieldPushbuttonDefaultValueEntry.Unsupported value
    )
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormFieldPushbuttonDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormFieldPushbuttonDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormFieldPushbuttonDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormFieldPushbuttonDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "FormFieldPushbuttonDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.FormFieldPushbuttonDefaultValueEntryNone, T> onNone,
        Func<CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormFieldPushbuttonDefaultValueEntryArray, T> onArray,
        Func<CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported, T> onUnsupported,
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
        Action<CloudPDF.FormFieldPushbuttonDefaultValueEntryNone> onNone,
        Action<CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar> onScalar,
        Action<CloudPDF.FormFieldPushbuttonDefaultValueEntryArray> onArray,
        Action<CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormFieldPushbuttonDefaultValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormFieldPushbuttonDefaultValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormFieldPushbuttonDefaultValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormFieldPushbuttonDefaultValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldPushbuttonDefaultValueEntry(
        FormFieldPushbuttonDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator FormFieldPushbuttonDefaultValueEntry(
        FormFieldPushbuttonDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator FormFieldPushbuttonDefaultValueEntry(
        FormFieldPushbuttonDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator FormFieldPushbuttonDefaultValueEntry(
        FormFieldPushbuttonDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldPushbuttonDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldPushbuttonDefaultValueEntry).IsAssignableFrom(typeToConvert);

        public override FormFieldPushbuttonDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldPushbuttonDefaultValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldPushbuttonDefaultValueEntry value,
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

        public override FormFieldPushbuttonDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldPushbuttonDefaultValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldPushbuttonDefaultValueEntry value,
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
        public None(CloudPDF.FormFieldPushbuttonDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonDefaultValueEntry.None(
            CloudPDF.FormFieldPushbuttonDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonDefaultValueEntry.Scalar(
            CloudPDF.FormFieldPushbuttonDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormFieldPushbuttonDefaultValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonDefaultValueEntry.Array(
            CloudPDF.FormFieldPushbuttonDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldPushbuttonDefaultValueEntry.Unsupported(
            CloudPDF.FormFieldPushbuttonDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
