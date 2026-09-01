// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfActionTargetRef.JsonConverter))]
[Serializable]
public record PdfActionTargetRef
{
    internal PdfActionTargetRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfActionTargetRef with <see cref="PdfActionTargetRef.Name"/>.
    /// </summary>
    public PdfActionTargetRef(PdfActionTargetRef.Name value)
    {
        Kind = "name";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionTargetRef with <see cref="PdfActionTargetRef.ObjectNumber"/>.
    /// </summary>
    public PdfActionTargetRef(PdfActionTargetRef.ObjectNumber value)
    {
        Kind = "objectNumber";
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
    /// Returns true if <see cref="Kind"/> is "name"
    /// </summary>
    public bool IsName => Kind == "name";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "objectNumber"
    /// </summary>
    public bool IsObjectNumber => Kind == "objectNumber";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionTargetRefName"/> if <see cref="Kind"/> is 'name', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'name'.</exception>
    public CloudPDF.PdfActionTargetRefName AsName() =>
        IsName
            ? (CloudPDF.PdfActionTargetRefName)Value!
            : throw new global::System.Exception("PdfActionTargetRef.Kind is not 'name'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionTargetRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.PdfActionTargetRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.PdfActionTargetRefObjectNumber)Value!
            : throw new global::System.Exception("PdfActionTargetRef.Kind is not 'objectNumber'");

    public T Match<T>(
        Func<CloudPDF.PdfActionTargetRefName, T> onName,
        Func<CloudPDF.PdfActionTargetRefObjectNumber, T> onObjectNumber,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "name" => onName(AsName()),
            "objectNumber" => onObjectNumber(AsObjectNumber()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.PdfActionTargetRefName> onName,
        Action<CloudPDF.PdfActionTargetRefObjectNumber> onObjectNumber,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "name":
                onName(AsName());
                break;
            case "objectNumber":
                onObjectNumber(AsObjectNumber());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionTargetRefName"/> and returns true if successful.
    /// </summary>
    public bool TryAsName(out CloudPDF.PdfActionTargetRefName? value)
    {
        if (Kind == "name")
        {
            value = (CloudPDF.PdfActionTargetRefName)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionTargetRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(out CloudPDF.PdfActionTargetRefObjectNumber? value)
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.PdfActionTargetRefObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfActionTargetRef(PdfActionTargetRef.Name value) => new(value);

    public static implicit operator PdfActionTargetRef(PdfActionTargetRef.ObjectNumber value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfActionTargetRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfActionTargetRef).IsAssignableFrom(typeToConvert);

        public override PdfActionTargetRef Read(
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
                "name" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionTargetRefName?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.PdfActionTargetRefName"
                    ),
                "objectNumber" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionTargetRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionTargetRefObjectNumber"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfActionTargetRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionTargetRef value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "name" => JsonSerializer.SerializeToNode(value.Value, options),
                    "objectNumber" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override PdfActionTargetRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfActionTargetRef(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionTargetRef value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for name
    /// </summary>
    [Serializable]
    public struct Name
    {
        public Name(CloudPDF.PdfActionTargetRefName value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionTargetRefName Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionTargetRef.Name(
            CloudPDF.PdfActionTargetRefName value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for objectNumber
    /// </summary>
    [Serializable]
    public struct ObjectNumber
    {
        public ObjectNumber(CloudPDF.PdfActionTargetRefObjectNumber value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionTargetRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionTargetRef.ObjectNumber(
            CloudPDF.PdfActionTargetRefObjectNumber value
        ) => new(value);
    }
}
