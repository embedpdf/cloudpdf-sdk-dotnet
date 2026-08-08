// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemCheckboxValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemCheckboxValueEntry
{
    internal DocFormsGet200ResponseFieldsItemCheckboxValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemCheckboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemCheckboxValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemCheckboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemCheckboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemCheckboxValueEntry with <see cref="DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone AsNone() =>
        IsNone
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray AsArray() =>
        IsArray
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone, T> onNone,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar, T> onScalar,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray, T> onArray,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported,
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
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone> onNone,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar> onScalar,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray> onArray,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry(
        DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemCheckboxValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemCheckboxValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemCheckboxValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemCheckboxValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemCheckboxValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemCheckboxValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemCheckboxValueEntry(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemCheckboxValueEntry value,
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
        public None(CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry.None(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemCheckboxValueEntry.Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckboxValueEntryUnsupported value
        ) => new(value);
    }
}
