// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry
{
    internal DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported)
                Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone, T> onNone,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar,
            T
        > onScalar,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray, T> onArray,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported,
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
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone> onNone,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar> onScalar,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray> onArray,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value =
                (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry value,
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
        public None(CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.None(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntry.Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknownDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
