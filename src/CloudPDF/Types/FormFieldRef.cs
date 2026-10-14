// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldRef.JsonConverter))]
[Serializable]
public record FormFieldRef
{
    internal FormFieldRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldRef with <see cref="FormFieldRef.ObjectNumber"/>.
    /// </summary>
    public FormFieldRef(FormFieldRef.ObjectNumber value)
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldRef with <see cref="FormFieldRef.Fqn"/>.
    /// </summary>
    public FormFieldRef(FormFieldRef.Fqn value)
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
    /// Returns the value as a <see cref="CloudPDF.FormFieldRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.FormFieldRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.FormFieldRefObjectNumber)Value!
            : throw new global::System.Exception("FormFieldRef.Kind is not 'objectNumber'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldRefFqn"/> if <see cref="Kind"/> is 'fqn', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fqn'.</exception>
    public CloudPDF.FormFieldRefFqn AsFqn() =>
        IsFqn
            ? (CloudPDF.FormFieldRefFqn)Value!
            : throw new global::System.Exception("FormFieldRef.Kind is not 'fqn'");

    public T Match<T>(
        Func<CloudPDF.FormFieldRefObjectNumber, T> onObjectNumber,
        Func<CloudPDF.FormFieldRefFqn, T> onFqn,
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
        Action<CloudPDF.FormFieldRefObjectNumber> onObjectNumber,
        Action<CloudPDF.FormFieldRefFqn> onFqn,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(out CloudPDF.FormFieldRefObjectNumber? value)
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.FormFieldRefObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRefFqn"/> and returns true if successful.
    /// </summary>
    public bool TryAsFqn(out CloudPDF.FormFieldRefFqn? value)
    {
        if (Kind == "fqn")
        {
            value = (CloudPDF.FormFieldRefFqn)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldRef(FormFieldRef.ObjectNumber value) => new(value);

    public static implicit operator FormFieldRef(FormFieldRef.Fqn value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldRef).IsAssignableFrom(typeToConvert);

        public override FormFieldRef Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldRefObjectNumber"
                        ),
                "fqn" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRefFqn?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldRefFqn"),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldRef value,
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

        public override FormFieldRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldRef(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldRef value,
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
        public ObjectNumber(CloudPDF.FormFieldRefObjectNumber value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldRef.ObjectNumber(
            CloudPDF.FormFieldRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fqn
    /// </summary>
    [Serializable]
    public struct Fqn
    {
        public Fqn(CloudPDF.FormFieldRefFqn value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRefFqn Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldRef.Fqn(CloudPDF.FormFieldRefFqn value) =>
            new(value);
    }
}
