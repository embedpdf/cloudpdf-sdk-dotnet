// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemSignatureRef.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemSignatureRef
{
    internal DocFormsGet200ResponseFieldsItemSignatureRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureRef with <see cref="DocFormsGet200ResponseFieldsItemSignatureRef.ObjectNumber"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureRef(
        DocFormsGet200ResponseFieldsItemSignatureRef.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemSignatureRef with <see cref="DocFormsGet200ResponseFieldsItemSignatureRef.Fqn"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemSignatureRef(
        DocFormsGet200ResponseFieldsItemSignatureRef.Fqn value
    )
    {
        Kind = "fqn";
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
    /// Returns true if <see cref="Kind"/> is "objectNumber"
    /// </summary>
    public bool IsObjectNumber => Kind == "objectNumber";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fqn"
    /// </summary>
    public bool IsFqn => Kind == "fqn";

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureRef.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn"/> if <see cref="Kind"/> is 'fqn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fqn'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn AsFqn() =>
        IsFqn
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemSignatureRef.Kind is not 'fqn'"
            );

    public T Match<T>(
        Func<
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber,
            T
        > onObjectNumber,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn, T> onFqn,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "objectNumber" => onObjectNumber(AsObjectNumber()),
            "fqn" => onFqn(AsFqn()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber> onObjectNumber,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn> onFqn,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "objectNumber":
                onObjectNumber(AsObjectNumber());
                break;
            case "fqn":
                onFqn(AsFqn());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn"/> and returns true if successful.
    /// </summary>
    public bool TryAsFqn(out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn? value)
    {
        if (Kind == "fqn")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureRef(
        DocFormsGet200ResponseFieldsItemSignatureRef.ObjectNumber value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemSignatureRef(
        DocFormsGet200ResponseFieldsItemSignatureRef.Fqn value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocFormsGet200ResponseFieldsItemSignatureRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemSignatureRef).IsAssignableFrom(typeToConvert);

        public override DocFormsGet200ResponseFieldsItemSignatureRef Read(
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
                "objectNumber" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber"
                        ),
                "fqn" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemSignatureRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureRef value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "objectNumber" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fqn" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocFormsGet200ResponseFieldsItemSignatureRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemSignatureRef(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureRef value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for objectNumber
    /// </summary>
    [Serializable]
    public struct ObjectNumber
    {
        public ObjectNumber(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureRef.ObjectNumber(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fqn
    /// </summary>
    [Serializable]
    public struct Fqn
    {
        public Fqn(CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemSignatureRef.Fqn(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignatureRefFqn value
        ) => new(value);
    }
}
