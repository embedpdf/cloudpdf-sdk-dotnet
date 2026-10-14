// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldSignatureDefaultValueEntry.JsonConverter))]
[Serializable]
public record FormFieldSignatureDefaultValueEntry
{
    internal FormFieldSignatureDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldSignatureDefaultValueEntry with <see cref="FormFieldSignatureDefaultValueEntry.None"/>.
    /// </summary>
    public FormFieldSignatureDefaultValueEntry(FormFieldSignatureDefaultValueEntry.None value)
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldSignatureDefaultValueEntry with <see cref="FormFieldSignatureDefaultValueEntry.Scalar"/>.
    /// </summary>
    public FormFieldSignatureDefaultValueEntry(FormFieldSignatureDefaultValueEntry.Scalar value)
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldSignatureDefaultValueEntry with <see cref="FormFieldSignatureDefaultValueEntry.Array"/>.
    /// </summary>
    public FormFieldSignatureDefaultValueEntry(FormFieldSignatureDefaultValueEntry.Array value)
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldSignatureDefaultValueEntry with <see cref="FormFieldSignatureDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public FormFieldSignatureDefaultValueEntry(
        FormFieldSignatureDefaultValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.FormFieldSignatureDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.FormFieldSignatureDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "FormFieldSignatureDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.FormFieldSignatureDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.FormFieldSignatureDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "FormFieldSignatureDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.FormFieldSignatureDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.FormFieldSignatureDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "FormFieldSignatureDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "FormFieldSignatureDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.FormFieldSignatureDefaultValueEntryNone, T> onNone,
        Func<CloudPDF.FormFieldSignatureDefaultValueEntryScalar, T> onScalar,
        Func<CloudPDF.FormFieldSignatureDefaultValueEntryArray, T> onArray,
        Func<CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported, T> onUnsupported,
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
        Action<CloudPDF.FormFieldSignatureDefaultValueEntryNone> onNone,
        Action<CloudPDF.FormFieldSignatureDefaultValueEntryScalar> onScalar,
        Action<CloudPDF.FormFieldSignatureDefaultValueEntryArray> onArray,
        Action<CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.FormFieldSignatureDefaultValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.FormFieldSignatureDefaultValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(out CloudPDF.FormFieldSignatureDefaultValueEntryScalar? value)
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.FormFieldSignatureDefaultValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(out CloudPDF.FormFieldSignatureDefaultValueEntryArray? value)
    {
        if (Kind == "array")
        {
            value = (CloudPDF.FormFieldSignatureDefaultValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldSignatureDefaultValueEntry(
        FormFieldSignatureDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator FormFieldSignatureDefaultValueEntry(
        FormFieldSignatureDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator FormFieldSignatureDefaultValueEntry(
        FormFieldSignatureDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator FormFieldSignatureDefaultValueEntry(
        FormFieldSignatureDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldSignatureDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldSignatureDefaultValueEntry).IsAssignableFrom(typeToConvert);

        public override FormFieldSignatureDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldSignatureDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldSignatureDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldSignatureDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldSignatureDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldSignatureDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldSignatureDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldSignatureDefaultValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldSignatureDefaultValueEntry value,
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

        public override FormFieldSignatureDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldSignatureDefaultValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldSignatureDefaultValueEntry value,
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
        public None(CloudPDF.FormFieldSignatureDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldSignatureDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldSignatureDefaultValueEntry.None(
            CloudPDF.FormFieldSignatureDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.FormFieldSignatureDefaultValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldSignatureDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldSignatureDefaultValueEntry.Scalar(
            CloudPDF.FormFieldSignatureDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.FormFieldSignatureDefaultValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldSignatureDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldSignatureDefaultValueEntry.Array(
            CloudPDF.FormFieldSignatureDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldSignatureDefaultValueEntry.Unsupported(
            CloudPDF.FormFieldSignatureDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
