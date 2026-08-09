// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry
{
    internal DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.None"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.None value
    )
    {
        Kind = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Scalar"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Scalar value
    )
    {
        Kind = "scalar";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Array"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Array value
    )
    {
        Kind = "array";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry with <see cref="DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Unsupported"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone"/> if <see cref="Kind"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'none'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone AsNone() =>
        IsNone
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Kind is not 'none'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar"/> if <see cref="Kind"/> is 'scalar', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'scalar'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar AsScalar() =>
        IsScalar
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Kind is not 'scalar'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray"/> if <see cref="Kind"/> is 'array', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'array'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray AsArray() =>
        IsArray
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Kind is not 'array'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported)
                Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone, T> onNone,
        Func<
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar,
            T
        > onScalar,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray, T> onArray,
        Func<
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported,
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
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone> onNone,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar> onScalar,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray> onArray,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(
        out CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone? value
    )
    {
        if (Kind == "none")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar"/> and returns true if successful.
    /// </summary>
    public bool TryAsScalar(
        out CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar? value
    )
    {
        if (Kind == "scalar")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray"/> and returns true if successful.
    /// </summary>
    public bool TryAsArray(
        out CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray? value
    )
    {
        if (Kind == "array")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value =
                (CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.None value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Scalar value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Array value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
        DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry).IsAssignableFrom(
                typeToConvert
            );

        public override DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone"
                        ),
                "scalar" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar"
                        ),
                "array" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry value,
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

        public override DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry value,
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
        public None(CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.None(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryNone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for scalar
    /// </summary>
    [Serializable]
    public struct Scalar
    {
        public Scalar(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Scalar(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryScalar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for array
    /// </summary>
    [Serializable]
    public struct Array
    {
        public Array(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Array(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryArray value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntry.Unsupported(
            CloudPDF.DocFormsGet200ResponseFieldsItemPushbuttonDefaultValueEntryUnsupported value
        ) => new(value);
    }
}
