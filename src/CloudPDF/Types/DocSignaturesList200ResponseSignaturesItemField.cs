// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocSignaturesList200ResponseSignaturesItemField.JsonConverter))]
[Serializable]
public record DocSignaturesList200ResponseSignaturesItemField
{
    internal DocSignaturesList200ResponseSignaturesItemField(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocSignaturesList200ResponseSignaturesItemField with <see cref="DocSignaturesList200ResponseSignaturesItemField.ObjectNumber"/>.
    /// </summary>
    public DocSignaturesList200ResponseSignaturesItemField(
        DocSignaturesList200ResponseSignaturesItemField.ObjectNumber value
    )
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocSignaturesList200ResponseSignaturesItemField with <see cref="DocSignaturesList200ResponseSignaturesItemField.Fqn"/>.
    /// </summary>
    public DocSignaturesList200ResponseSignaturesItemField(
        DocSignaturesList200ResponseSignaturesItemField.Fqn value
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
    /// Returns the value as a <see cref="CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber)Value!
            : throw new global::System.Exception(
                "DocSignaturesList200ResponseSignaturesItemField.Kind is not 'objectNumber'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn"/> if <see cref="Kind"/> is 'fqn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fqn'.</exception>
    public CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn AsFqn() =>
        IsFqn
            ? (CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn)Value!
            : throw new global::System.Exception(
                "DocSignaturesList200ResponseSignaturesItemField.Kind is not 'fqn'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber,
            T
        > onObjectNumber,
        Func<CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn, T> onFqn,
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
        Action<CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber> onObjectNumber,
        Action<CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn> onFqn,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(
        out CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber? value
    )
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn"/> and returns true if successful.
    /// </summary>
    public bool TryAsFqn(out CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn? value)
    {
        if (Kind == "fqn")
        {
            value = (CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocSignaturesList200ResponseSignaturesItemField(
        DocSignaturesList200ResponseSignaturesItemField.ObjectNumber value
    ) => new(value);

    public static implicit operator DocSignaturesList200ResponseSignaturesItemField(
        DocSignaturesList200ResponseSignaturesItemField.Fqn value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocSignaturesList200ResponseSignaturesItemField>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocSignaturesList200ResponseSignaturesItemField).IsAssignableFrom(typeToConvert);

        public override DocSignaturesList200ResponseSignaturesItemField Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber"
                        ),
                "fqn" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocSignaturesList200ResponseSignaturesItemField(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseSignaturesItemField value,
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

        public override DocSignaturesList200ResponseSignaturesItemField ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocSignaturesList200ResponseSignaturesItemField(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseSignaturesItemField value,
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
            CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocSignaturesList200ResponseSignaturesItemField.ObjectNumber(
            CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fqn
    /// </summary>
    [Serializable]
    public struct Fqn
    {
        public Fqn(CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn value)
        {
            Value = value;
        }

        internal CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocSignaturesList200ResponseSignaturesItemField.Fqn(
            CloudPDF.DocSignaturesList200ResponseSignaturesItemFieldFqn value
        ) => new(value);
    }
}
