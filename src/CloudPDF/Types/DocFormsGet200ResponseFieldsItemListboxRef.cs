// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemListboxRef.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemListboxRef
{
    internal DocFormsGet200ResponseFieldsItemListboxRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemListboxRef with <see cref="DocFormsGet200ResponseFieldsItemListboxRef.ObjectNumber"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemListboxRef(
        DocFormsGet200ResponseFieldsItemListboxRef.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemListboxRef with <see cref="DocFormsGet200ResponseFieldsItemListboxRef.Fqn"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemListboxRef(
        DocFormsGet200ResponseFieldsItemListboxRef.Fqn value
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
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemListboxRef.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn"/> if <see cref="Kind"/> is 'fqn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fqn'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn AsFqn() =>
        IsFqn
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemListboxRef.Kind is not 'fqn'"
            );

    public T Match<T>(
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber, T> onObjectNumber,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn, T> onFqn,
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
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber> onObjectNumber,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn> onFqn,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn"/> and returns true if successful.
    /// </summary>
    public bool TryAsFqn(out CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn? value)
    {
        if (Kind == "fqn")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemListboxRef(
        DocFormsGet200ResponseFieldsItemListboxRef.ObjectNumber value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemListboxRef(
        DocFormsGet200ResponseFieldsItemListboxRef.Fqn value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocFormsGet200ResponseFieldsItemListboxRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemListboxRef).IsAssignableFrom(typeToConvert);

        public override DocFormsGet200ResponseFieldsItemListboxRef Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber"
                        ),
                "fqn" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemListboxRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemListboxRef value,
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

        public override DocFormsGet200ResponseFieldsItemListboxRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemListboxRef(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemListboxRef value,
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
        public ObjectNumber(CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemListboxRef.ObjectNumber(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fqn
    /// </summary>
    [Serializable]
    public struct Fqn
    {
        public Fqn(CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemListboxRef.Fqn(
            CloudPDF.DocFormsGet200ResponseFieldsItemListboxRefFqn value
        ) => new(value);
    }
}
