// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocChanges200ResponseChangesItem.JsonConverter))]
[Serializable]
public record DocChanges200ResponseChangesItem
{
    internal DocChanges200ResponseChangesItem(string type, object? value)
    {
        Status = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocChanges200ResponseChangesItem with <see cref="DocChanges200ResponseChangesItem.Applied"/>.
    /// </summary>
    public DocChanges200ResponseChangesItem(DocChanges200ResponseChangesItem.Applied value)
    {
        Status = "applied";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocChanges200ResponseChangesItem with <see cref="DocChanges200ResponseChangesItem.Refused"/>.
    /// </summary>
    public DocChanges200ResponseChangesItem(DocChanges200ResponseChangesItem.Refused value)
    {
        Status = "refused";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Status"/> is "applied"
    /// </summary>
    public bool IsApplied => Status == "applied";

    /// <summary>
    /// Returns true if <see cref="Status"/> is "refused"
    /// </summary>
    public bool IsRefused => Status == "refused";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocChanges200ResponseChangesItemApplied"/> if <see cref="Status"/> is 'applied', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'applied'.</exception>
    public CloudPDF.DocChanges200ResponseChangesItemApplied AsApplied() =>
        IsApplied
            ? (CloudPDF.DocChanges200ResponseChangesItemApplied)Value!
            : throw new global::System.Exception(
                "DocChanges200ResponseChangesItem.Status is not 'applied'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocChanges200ResponseChangesItemRefused"/> if <see cref="Status"/> is 'refused', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'refused'.</exception>
    public CloudPDF.DocChanges200ResponseChangesItemRefused AsRefused() =>
        IsRefused
            ? (CloudPDF.DocChanges200ResponseChangesItemRefused)Value!
            : throw new global::System.Exception(
                "DocChanges200ResponseChangesItem.Status is not 'refused'"
            );

    public T Match<T>(
        Func<CloudPDF.DocChanges200ResponseChangesItemApplied, T> onApplied,
        Func<CloudPDF.DocChanges200ResponseChangesItemRefused, T> onRefused,
        Func<string, object?, T> onUnknown_
    )
    {
        return Status switch
        {
            "applied" => onApplied(AsApplied()),
            "refused" => onRefused(AsRefused()),
            _ => onUnknown_(Status, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocChanges200ResponseChangesItemApplied> onApplied,
        Action<CloudPDF.DocChanges200ResponseChangesItemRefused> onRefused,
        Action<string, object?> onUnknown_
    )
    {
        switch (Status)
        {
            case "applied":
                onApplied(AsApplied());
                break;
            case "refused":
                onRefused(AsRefused());
                break;
            default:
                onUnknown_(Status, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocChanges200ResponseChangesItemApplied"/> and returns true if successful.
    /// </summary>
    public bool TryAsApplied(out CloudPDF.DocChanges200ResponseChangesItemApplied? value)
    {
        if (Status == "applied")
        {
            value = (CloudPDF.DocChanges200ResponseChangesItemApplied)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocChanges200ResponseChangesItemRefused"/> and returns true if successful.
    /// </summary>
    public bool TryAsRefused(out CloudPDF.DocChanges200ResponseChangesItemRefused? value)
    {
        if (Status == "refused")
        {
            value = (CloudPDF.DocChanges200ResponseChangesItemRefused)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocChanges200ResponseChangesItem(
        DocChanges200ResponseChangesItem.Applied value
    ) => new(value);

    public static implicit operator DocChanges200ResponseChangesItem(
        DocChanges200ResponseChangesItem.Refused value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocChanges200ResponseChangesItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocChanges200ResponseChangesItem).IsAssignableFrom(typeToConvert);

        public override DocChanges200ResponseChangesItem Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("status", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'status'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'status' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'status' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'status' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("status");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "applied" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocChanges200ResponseChangesItemApplied?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocChanges200ResponseChangesItemApplied"
                        ),
                "refused" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocChanges200ResponseChangesItemRefused?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocChanges200ResponseChangesItemRefused"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocChanges200ResponseChangesItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocChanges200ResponseChangesItem value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Status switch
                {
                    "applied" => JsonSerializer.SerializeToNode(value.Value, options),
                    "refused" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["status"] = value.Status;
            json.WriteTo(writer, options);
        }

        public override DocChanges200ResponseChangesItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocChanges200ResponseChangesItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocChanges200ResponseChangesItem value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Status);
        }
    }

    /// <summary>
    /// Discriminated union type for applied
    /// </summary>
    [Serializable]
    public struct Applied
    {
        public Applied(CloudPDF.DocChanges200ResponseChangesItemApplied value)
        {
            Value = value;
        }

        internal CloudPDF.DocChanges200ResponseChangesItemApplied Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocChanges200ResponseChangesItem.Applied(
            CloudPDF.DocChanges200ResponseChangesItemApplied value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for refused
    /// </summary>
    [Serializable]
    public struct Refused
    {
        public Refused(CloudPDF.DocChanges200ResponseChangesItemRefused value)
        {
            Value = value;
        }

        internal CloudPDF.DocChanges200ResponseChangesItemRefused Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocChanges200ResponseChangesItem.Refused(
            CloudPDF.DocChanges200ResponseChangesItemRefused value
        ) => new(value);
    }
}
