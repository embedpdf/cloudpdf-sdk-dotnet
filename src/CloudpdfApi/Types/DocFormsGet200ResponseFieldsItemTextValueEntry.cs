// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemTextValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemTextValueEntry
{
    internal DocFormsGet200ResponseFieldsItemTextValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemTextValueEntry with <see cref="DocFormsGet200ResponseFieldsItemTextValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemTextValueEntry with <see cref="DocFormsGet200ResponseFieldsItemTextValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemTextValueEntry with <see cref="DocFormsGet200ResponseFieldsItemTextValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemTextValueEntry with <see cref="DocFormsGet200ResponseFieldsItemTextValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone AsNone() =>
        IsNone
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemTextValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemTextValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray AsArray() =>
        IsArray
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemTextValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemTextValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone, T> onNone,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar, T> onScalar,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray, T> onArray,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported,
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
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone> onNone,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar> onScalar,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray> onArray,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone? value)
    {
        if (Kind == "none")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry(
        DocFormsGet200ResponseFieldsItemTextValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemTextValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemTextValueEntry).IsAssignableFrom(typeToConvert);

        public override DocFormsGet200ResponseFieldsItemTextValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemTextValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemTextValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemTextValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextValueEntry value,
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
        public None(CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry.None(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry.Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry.Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemTextValueEntry.Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemTextValueEntryUnsupported value
        ) => new(value);
    }
}
