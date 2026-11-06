// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentsInitResponse.JsonConverter))]
[Serializable]
public record DocumentsInitResponse
{
    internal DocumentsInitResponse(string type, object? value)
    {
        Status = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponse with <see cref="DocumentsInitResponse.Created"/>.
    /// </summary>
    public DocumentsInitResponse(DocumentsInitResponse.Created value)
    {
        Status = "created";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponse with <see cref="DocumentsInitResponse.Resumed"/>.
    /// </summary>
    public DocumentsInitResponse(DocumentsInitResponse.Resumed value)
    {
        Status = "resumed";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponse with <see cref="DocumentsInitResponse.Deduped"/>.
    /// </summary>
    public DocumentsInitResponse(DocumentsInitResponse.Deduped value)
    {
        Status = "deduped";
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
    /// Returns true if <see cref="Status"/> is "created"
    /// </summary>
    public bool IsCreated => Status == "created";

    /// <summary>
    /// Returns true if <see cref="Status"/> is "resumed"
    /// </summary>
    public bool IsResumed => Status == "resumed";

    /// <summary>
    /// Returns true if <see cref="Status"/> is "deduped"
    /// </summary>
    public bool IsDeduped => Status == "deduped";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseCreated"/> if <see cref="Status"/> is 'created', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'created'.</exception>
    public CloudPDF.DocumentsInitResponseCreated AsCreated() =>
        IsCreated
            ? (CloudPDF.DocumentsInitResponseCreated)Value!
            : throw new global::System.Exception("DocumentsInitResponse.Status is not 'created'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseResumed"/> if <see cref="Status"/> is 'resumed', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'resumed'.</exception>
    public CloudPDF.DocumentsInitResponseResumed AsResumed() =>
        IsResumed
            ? (CloudPDF.DocumentsInitResponseResumed)Value!
            : throw new global::System.Exception("DocumentsInitResponse.Status is not 'resumed'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseDeduped"/> if <see cref="Status"/> is 'deduped', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Status"/> is not 'deduped'.</exception>
    public CloudPDF.DocumentsInitResponseDeduped AsDeduped() =>
        IsDeduped
            ? (CloudPDF.DocumentsInitResponseDeduped)Value!
            : throw new global::System.Exception("DocumentsInitResponse.Status is not 'deduped'");

    public T Match<T>(
        Func<CloudPDF.DocumentsInitResponseCreated, T> onCreated,
        Func<CloudPDF.DocumentsInitResponseResumed, T> onResumed,
        Func<CloudPDF.DocumentsInitResponseDeduped, T> onDeduped,
        Func<string, object?, T> onUnknown_
    )
    {
        return Status switch
        {
            "created" => onCreated(AsCreated()),
            "resumed" => onResumed(AsResumed()),
            "deduped" => onDeduped(AsDeduped()),
            _ => onUnknown_(Status, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocumentsInitResponseCreated> onCreated,
        Action<CloudPDF.DocumentsInitResponseResumed> onResumed,
        Action<CloudPDF.DocumentsInitResponseDeduped> onDeduped,
        Action<string, object?> onUnknown_
    )
    {
        switch (Status)
        {
            case "created":
                onCreated(AsCreated());
                break;
            case "resumed":
                onResumed(AsResumed());
                break;
            case "deduped":
                onDeduped(AsDeduped());
                break;
            default:
                onUnknown_(Status, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseCreated"/> and returns true if successful.
    /// </summary>
    public bool TryAsCreated(out CloudPDF.DocumentsInitResponseCreated? value)
    {
        if (Status == "created")
        {
            value = (CloudPDF.DocumentsInitResponseCreated)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseResumed"/> and returns true if successful.
    /// </summary>
    public bool TryAsResumed(out CloudPDF.DocumentsInitResponseResumed? value)
    {
        if (Status == "resumed")
        {
            value = (CloudPDF.DocumentsInitResponseResumed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseDeduped"/> and returns true if successful.
    /// </summary>
    public bool TryAsDeduped(out CloudPDF.DocumentsInitResponseDeduped? value)
    {
        if (Status == "deduped")
        {
            value = (CloudPDF.DocumentsInitResponseDeduped)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsInitResponse(DocumentsInitResponse.Created value) =>
        new(value);

    public static implicit operator DocumentsInitResponse(DocumentsInitResponse.Resumed value) =>
        new(value);

    public static implicit operator DocumentsInitResponse(DocumentsInitResponse.Deduped value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsInitResponse>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsInitResponse).IsAssignableFrom(typeToConvert);

        public override DocumentsInitResponse Read(
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
                "created" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseCreated?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseCreated"
                        ),
                "resumed" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseResumed?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseResumed"
                        ),
                "deduped" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseDeduped?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseDeduped"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsInitResponse(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInitResponse value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Status switch
                {
                    "created" => JsonSerializer.SerializeToNode(value.Value, options),
                    "resumed" => JsonSerializer.SerializeToNode(value.Value, options),
                    "deduped" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["status"] = value.Status;
            json.WriteTo(writer, options);
        }

        public override DocumentsInitResponse ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsInitResponse(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInitResponse value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Status);
        }
    }

    /// <summary>
    /// Discriminated union type for created
    /// </summary>
    [Serializable]
    public struct Created
    {
        public Created(CloudPDF.DocumentsInitResponseCreated value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseCreated Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponse.Created(
            CloudPDF.DocumentsInitResponseCreated value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for resumed
    /// </summary>
    [Serializable]
    public struct Resumed
    {
        public Resumed(CloudPDF.DocumentsInitResponseResumed value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseResumed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponse.Resumed(
            CloudPDF.DocumentsInitResponseResumed value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for deduped
    /// </summary>
    [Serializable]
    public struct Deduped
    {
        public Deduped(CloudPDF.DocumentsInitResponseDeduped value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseDeduped Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponse.Deduped(
            CloudPDF.DocumentsInitResponseDeduped value
        ) => new(value);
    }
}
