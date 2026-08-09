// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry
{
    internal DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone, T> onNone,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar, T> onScalar,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray, T> onArray,
        Func<
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported,
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
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone> onNone,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar> onScalar,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray> onArray,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry value,
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
        public None(CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.None(
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Scalar(
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Array(
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntry.Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemComboboxDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
