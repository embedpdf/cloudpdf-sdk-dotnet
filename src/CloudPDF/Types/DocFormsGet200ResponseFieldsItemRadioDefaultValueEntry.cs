// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry
{
    internal DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone, T> onNone,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar, T> onScalar,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray, T> onArray,
        Func<
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported,
            T
        > onUnsupported,
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
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone> onNone,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar> onScalar,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray> onArray,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry value,
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
        public None(CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.None(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Scalar(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Array(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemRadioDefaultValueEntry.Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
