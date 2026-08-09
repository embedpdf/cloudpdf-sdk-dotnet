// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemListboxValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemListboxValueEntry
{
    internal DocFormsGet200ResponseFieldsItemListboxValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemListboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemListboxValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemListboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemListboxValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemListboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemListboxValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemListboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemListboxValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemListboxValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemListboxValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemListboxValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemListboxValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone, T> onNone,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar, T> onScalar,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray, T> onArray,
        Func<
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported,
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
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone> onNone,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar> onScalar,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray> onArray,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry(
        DocFormsGet200ResponseFieldsItemListboxValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemListboxValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemListboxValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemListboxValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemListboxValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemListboxValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemListboxValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemListboxValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemListboxValueEntry value,
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
        public None(CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry.None(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry.Scalar(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry.Array(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemListboxValueEntry.Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxValueEntryUnsupported value
        ) => new(value);
    }
}
