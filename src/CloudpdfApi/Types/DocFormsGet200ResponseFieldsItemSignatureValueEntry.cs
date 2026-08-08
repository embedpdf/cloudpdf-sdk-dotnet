// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemSignatureValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemSignatureValueEntry
{
    internal DocFormsGet200ResponseFieldsItemSignatureValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone AsNone() =>
        IsNone
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray AsArray() =>
        IsArray
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone, T> onNone,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar, T> onScalar,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray, T> onArray,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported,
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
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone> onNone,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar> onScalar,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray> onArray,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemSignatureValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemSignatureValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemSignatureValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemSignatureValueEntry(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemSignatureValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemSignatureValueEntry(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureValueEntry value,
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
        public None(CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry.None(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry.Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry.Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureValueEntry.Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureValueEntryUnsupported value
        ) => new(value);
    }
}
