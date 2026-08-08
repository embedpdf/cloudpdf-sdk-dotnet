// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry
{
    internal DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported)
                Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone, T> onNone,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar,
            T
        > onScalar,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray,
            T
        > onArray,
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported,
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
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone> onNone,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar> onScalar,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray> onArray,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value =
                (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry value,
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
        public None(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.None(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Scalar(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Array(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntry.Unsupported(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
