// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocSignaturesComplete200ResponseSignatureField.JsonConverter))]
[Serializable]
public record DocSignaturesComplete200ResponseSignatureField
{
    internal DocSignaturesComplete200ResponseSignatureField(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocSignaturesComplete200ResponseSignatureField with <see cref="DocSignaturesComplete200ResponseSignatureField.ObjectNumber"/>.
    /// </summary>
    public DocSignaturesComplete200ResponseSignatureField(
        DocSignaturesComplete200ResponseSignatureField.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocSignaturesComplete200ResponseSignatureField with <see cref="DocSignaturesComplete200ResponseSignatureField.Fqn"/>.
    /// </summary>
    public DocSignaturesComplete200ResponseSignatureField(
        DocSignaturesComplete200ResponseSignatureField.Fqn value
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
    /// Returns the value as a <see cref="CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber)Value!
            : throw new global::System.Exception(
                "DocSignaturesComplete200ResponseSignatureField.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn"/> if <see cref="Kind"/> is 'fqn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fqn'.</exception>
    public CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn AsFqn() =>
        IsFqn
            ? (CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn)Value!
            : throw new global::System.Exception(
                "DocSignaturesComplete200ResponseSignatureField.Kind is not 'fqn'"
            );

    public T Match<T>(
        Func<CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber, T> onObjectNumber,
        Func<CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn, T> onFqn,
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
        Action<CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber> onObjectNumber,
        Action<CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn> onFqn,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn"/> and returns true if successful.
    /// </summary>
    public bool TryAsFqn(out CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn? value)
    {
        if (Kind == "fqn")
        {
            value = (CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocSignaturesComplete200ResponseSignatureField(
        DocSignaturesComplete200ResponseSignatureField.ObjectNumber value
    ) => new(value);

    public static implicit operator DocSignaturesComplete200ResponseSignatureField(
        DocSignaturesComplete200ResponseSignatureField.Fqn value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocSignaturesComplete200ResponseSignatureField>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocSignaturesComplete200ResponseSignatureField).IsAssignableFrom(typeToConvert);

        public override DocSignaturesComplete200ResponseSignatureField Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber"
                        ),
                "fqn" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocSignaturesComplete200ResponseSignatureField(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureField value,
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

        public override DocSignaturesComplete200ResponseSignatureField ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocSignaturesComplete200ResponseSignatureField(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureField value,
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
            CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocSignaturesComplete200ResponseSignatureField.ObjectNumber(
            CloudPDF.DocSignaturesComplete200ResponseSignatureFieldObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fqn
    /// </summary>
    [Serializable]
    public struct Fqn
    {
        public Fqn(CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn value)
        {
            Value = value;
        }

        internal CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocSignaturesComplete200ResponseSignatureField.Fqn(
            CloudPDF.DocSignaturesComplete200ResponseSignatureFieldFqn value
        ) => new(value);
    }
}
