// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocChangesResponseChangesItem.JsonConverter))]
[Serializable]
public record DocChangesResponseChangesItem
{
    internal DocChangesResponseChangesItem(string type, object? value)
    {
        Status = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocChangesResponseChangesItem with <see cref="DocChangesResponseChangesItem.Applied"/>.
    /// </summary>
    public DocChangesResponseChangesItem(DocChangesResponseChangesItem.Applied value)
    {
        Status = "applied";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocChangesResponseChangesItem with <see cref="DocChangesResponseChangesItem.Refused"/>.
    /// </summary>
    public DocChangesResponseChangesItem(DocChangesResponseChangesItem.Refused value)
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
    /// Returns the value as a <see cref="CloudPDF.DocChangesResponseChangesItemApplied"/> if <see cref="Status"/> is 'applied', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'applied'.</exception>
    public CloudPDF.DocChangesResponseChangesItemApplied AsApplied() =>
        IsApplied
            ? (CloudPDF.DocChangesResponseChangesItemApplied)Value!
            : throw new global::System.Exception(
                "DocChangesResponseChangesItem.Status is not 'applied'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocChangesResponseChangesItemRefused"/> if <see cref="Status"/> is 'refused', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'refused'.</exception>
    public CloudPDF.DocChangesResponseChangesItemRefused AsRefused() =>
        IsRefused
            ? (CloudPDF.DocChangesResponseChangesItemRefused)Value!
            : throw new global::System.Exception(
                "DocChangesResponseChangesItem.Status is not 'refused'"
            );

    public T Match<T>(
        Func<CloudPDF.DocChangesResponseChangesItemApplied, T> onApplied,
        Func<CloudPDF.DocChangesResponseChangesItemRefused, T> onRefused,
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
        Action<CloudPDF.DocChangesResponseChangesItemApplied> onApplied,
        Action<CloudPDF.DocChangesResponseChangesItemRefused> onRefused,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocChangesResponseChangesItemApplied"/> and returns true if successful.
    /// </summary>
    public bool TryAsApplied(out CloudPDF.DocChangesResponseChangesItemApplied? value)
    {
        if (Status == "applied")
        {
            value = (CloudPDF.DocChangesResponseChangesItemApplied)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocChangesResponseChangesItemRefused"/> and returns true if successful.
    /// </summary>
    public bool TryAsRefused(out CloudPDF.DocChangesResponseChangesItemRefused? value)
    {
        if (Status == "refused")
        {
            value = (CloudPDF.DocChangesResponseChangesItemRefused)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocChangesResponseChangesItem(
        DocChangesResponseChangesItem.Applied value
    ) => new(value);

    public static implicit operator DocChangesResponseChangesItem(
        DocChangesResponseChangesItem.Refused value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocChangesResponseChangesItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocChangesResponseChangesItem).IsAssignableFrom(typeToConvert);

        public override DocChangesResponseChangesItem Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocChangesResponseChangesItemApplied?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocChangesResponseChangesItemApplied"
                        ),
                "refused" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocChangesResponseChangesItemRefused?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocChangesResponseChangesItemRefused"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocChangesResponseChangesItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocChangesResponseChangesItem value,
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

        public override DocChangesResponseChangesItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocChangesResponseChangesItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocChangesResponseChangesItem value,
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
        public Applied(CloudPDF.DocChangesResponseChangesItemApplied value)
        {
            Value = value;
        }

        internal CloudPDF.DocChangesResponseChangesItemApplied Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocChangesResponseChangesItem.Applied(
            CloudPDF.DocChangesResponseChangesItemApplied value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for refused
    /// </summary>
    [Serializable]
    public struct Refused
    {
        public Refused(CloudPDF.DocChangesResponseChangesItemRefused value)
        {
            Value = value;
        }

        internal CloudPDF.DocChangesResponseChangesItemRefused Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocChangesResponseChangesItem.Refused(
            CloudPDF.DocChangesResponseChangesItemRefused value
        ) => new(value);
    }
}
