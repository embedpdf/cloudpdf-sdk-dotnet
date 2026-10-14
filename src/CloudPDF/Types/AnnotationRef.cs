// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationRef.JsonConverter))]
[Serializable]
public record AnnotationRef
{
    internal AnnotationRef(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationRef with <see cref="AnnotationRef.ObjectNumber"/>.
    /// </summary>
    public AnnotationRef(AnnotationRef.ObjectNumber value)
    {
        Kind = "objectNumber";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationRef with <see cref="AnnotationRef.BaseIndex"/>.
    /// </summary>
    public AnnotationRef(AnnotationRef.BaseIndex value)
    {
        Kind = "baseIndex";
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
    /// Returns true if <see cref="Kind"/> is "baseIndex"
    /// </summary>
    public bool IsBaseIndex => Kind == "baseIndex";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationRefObjectNumber"/> if <see cref="Kind"/> is 'objectNumber', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'objectNumber'.</exception>
    public CloudPDF.AnnotationRefObjectNumber AsObjectNumber() =>
        IsObjectNumber
            ? (CloudPDF.AnnotationRefObjectNumber)Value!
            : throw new global::System.Exception("AnnotationRef.Kind is not 'objectNumber'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationRefBaseIndex"/> if <see cref="Kind"/> is 'baseIndex', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'baseIndex'.</exception>
    public CloudPDF.AnnotationRefBaseIndex AsBaseIndex() =>
        IsBaseIndex
            ? (CloudPDF.AnnotationRefBaseIndex)Value!
            : throw new global::System.Exception("AnnotationRef.Kind is not 'baseIndex'");

    public T Match<T>(
        Func<CloudPDF.AnnotationRefObjectNumber, T> onObjectNumber,
        Func<CloudPDF.AnnotationRefBaseIndex, T> onBaseIndex,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "objectNumber" => onObjectNumber(AsObjectNumber()),
            "baseIndex" => onBaseIndex(AsBaseIndex()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.AnnotationRefObjectNumber> onObjectNumber,
        Action<CloudPDF.AnnotationRefBaseIndex> onBaseIndex,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "objectNumber":
                onObjectNumber(AsObjectNumber());
                break;
            case "baseIndex":
                onBaseIndex(AsBaseIndex());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationRefObjectNumber"/> and returns true if successful.
    /// </summary>
    public bool TryAsObjectNumber(out CloudPDF.AnnotationRefObjectNumber? value)
    {
        if (Kind == "objectNumber")
        {
            value = (CloudPDF.AnnotationRefObjectNumber)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationRefBaseIndex"/> and returns true if successful.
    /// </summary>
    public bool TryAsBaseIndex(out CloudPDF.AnnotationRefBaseIndex? value)
    {
        if (Kind == "baseIndex")
        {
            value = (CloudPDF.AnnotationRefBaseIndex)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationRef(AnnotationRef.ObjectNumber value) => new(value);

    public static implicit operator AnnotationRef(AnnotationRef.BaseIndex value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationRef>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationRef).IsAssignableFrom(typeToConvert);

        public override AnnotationRef Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationRefObjectNumber?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationRefObjectNumber"
                        ),
                "baseIndex" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationRefBaseIndex?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationRefBaseIndex"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationRef(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationRef value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "objectNumber" => JsonSerializer.SerializeToNode(value.Value, options),
                    "baseIndex" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override AnnotationRef ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationRef(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationRef value,
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
        public ObjectNumber(CloudPDF.AnnotationRefObjectNumber value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationRefObjectNumber Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationRef.ObjectNumber(
            CloudPDF.AnnotationRefObjectNumber value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for baseIndex
    /// </summary>
    [Serializable]
    public struct BaseIndex
    {
        public BaseIndex(CloudPDF.AnnotationRefBaseIndex value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationRefBaseIndex Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationRef.BaseIndex(
            CloudPDF.AnnotationRefBaseIndex value
        ) => new(value);
    }
}
