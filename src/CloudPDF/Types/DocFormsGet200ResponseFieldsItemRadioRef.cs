// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItemRadioRef.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItemRadioRef
{
    internal DocFormsGet200ResponseFieldsItemRadioRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemRadioRef with <see cref="DocFormsGet200ResponseFieldsItemRadioRef.ObjectNumber"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemRadioRef(
        DocFormsGet200ResponseFieldsItemRadioRef.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItemRadioRef with <see cref="DocFormsGet200ResponseFieldsItemRadioRef.Fqn"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItemRadioRef(
        DocFormsGet200ResponseFieldsItemRadioRef.Fqn value
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
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemRadioRef.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn"/> if <see cref="Kind"/> is 'fqn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fqn'.</exception>
    public CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn AsFqn() =>
        IsFqn
            ? (CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItemRadioRef.Kind is not 'fqn'"
            );

    public T Match<T>(
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber, T> onObjectNumber,
        Func<CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn, T> onFqn,
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
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber> onObjectNumber,
        Action<CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn> onFqn,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn"/> and returns true if successful.
    /// </summary>
    public bool TryAsFqn(out CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn? value)
    {
        if (Kind == "fqn")
        {
            value = (CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItemRadioRef(
        DocFormsGet200ResponseFieldsItemRadioRef.ObjectNumber value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItemRadioRef(
        DocFormsGet200ResponseFieldsItemRadioRef.Fqn value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocFormsGet200ResponseFieldsItemRadioRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItemRadioRef).IsAssignableFrom(typeToConvert);

        public override DocFormsGet200ResponseFieldsItemRadioRef Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber"
                        ),
                "fqn" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItemRadioRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioRef value,
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

        public override DocFormsGet200ResponseFieldsItemRadioRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItemRadioRef(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioRef value,
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
        public ObjectNumber(CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemRadioRef.ObjectNumber(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fqn
    /// </summary>
    [Serializable]
    public struct Fqn
    {
        public Fqn(CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn value)
        {
            Value = value;
        }

        internal CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItemRadioRef.Fqn(
            CloudPDF.DocFormsGet200ResponseFieldsItemRadioRefFqn value
        ) => new(value);
    }
}
