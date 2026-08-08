// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocumentsInit200Response.JsonConverter))]
[Serializable]
public record DocumentsInit200Response
{
    internal DocumentsInit200Response(string type, object? value)
    {
        Tag = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200Response with <see cref="DocumentsInit200Response.Created"/>.
    /// </summary>
    public DocumentsInit200Response(DocumentsInit200Response.Created value)
    {
        Tag = "created";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200Response with <see cref="DocumentsInit200Response.Resumed"/>.
    /// </summary>
    public DocumentsInit200Response(DocumentsInit200Response.Resumed value)
    {
        Tag = "resumed";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200Response with <see cref="DocumentsInit200Response.Deduped"/>.
    /// </summary>
    public DocumentsInit200Response(DocumentsInit200Response.Deduped value)
    {
        Tag = "deduped";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("tag")]
    public string Tag { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Tag"/> is "created"
    /// </summary>
    public bool IsCreated => Tag == "created";

    /// <summary>
    /// Returns true if <see cref="Tag"/> is "resumed"
    /// </summary>
    public bool IsResumed => Tag == "resumed";

    /// <summary>
    /// Returns true if <see cref="Tag"/> is "deduped"
    /// </summary>
    public bool IsDeduped => Tag == "deduped";

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocumentsInit200ResponseCreated"/> if <see cref="Tag"/> is 'created', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Tag"/> is not 'created'.</exception>
    public CloudpdfApi.DocumentsInit200ResponseCreated AsCreated() =>
        IsCreated
            ? (CloudpdfApi.DocumentsInit200ResponseCreated)Value!
            : throw new global::System.Exception("DocumentsInit200Response.Tag is not 'created'");

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocumentsInit200ResponseResumed"/> if <see cref="Tag"/> is 'resumed', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Tag"/> is not 'resumed'.</exception>
    public CloudpdfApi.DocumentsInit200ResponseResumed AsResumed() =>
        IsResumed
            ? (CloudpdfApi.DocumentsInit200ResponseResumed)Value!
            : throw new global::System.Exception("DocumentsInit200Response.Tag is not 'resumed'");

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocumentsInit200ResponseDeduped"/> if <see cref="Tag"/> is 'deduped', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Tag"/> is not 'deduped'.</exception>
    public CloudpdfApi.DocumentsInit200ResponseDeduped AsDeduped() =>
        IsDeduped
            ? (CloudpdfApi.DocumentsInit200ResponseDeduped)Value!
            : throw new global::System.Exception("DocumentsInit200Response.Tag is not 'deduped'");

    public T Match<T>(
        Func<CloudpdfApi.DocumentsInit200ResponseCreated, T> onCreated,
        Func<CloudpdfApi.DocumentsInit200ResponseResumed, T> onResumed,
        Func<CloudpdfApi.DocumentsInit200ResponseDeduped, T> onDeduped,
        Func<string, object?, T> onUnknown_
    )
    {
        return Tag switch
        {
            "created" => onCreated(AsCreated()),
            "resumed" => onResumed(AsResumed()),
            "deduped" => onDeduped(AsDeduped()),
            _ => onUnknown_(Tag, Value),
        };
    }

    public void Visit(
        Action<CloudpdfApi.DocumentsInit200ResponseCreated> onCreated,
        Action<CloudpdfApi.DocumentsInit200ResponseResumed> onResumed,
        Action<CloudpdfApi.DocumentsInit200ResponseDeduped> onDeduped,
        Action<string, object?> onUnknown_
    )
    {
        switch (Tag)
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
                onUnknown_(Tag, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocumentsInit200ResponseCreated"/> and returns true if successful.
    /// </summary>
    public bool TryAsCreated(out CloudpdfApi.DocumentsInit200ResponseCreated? value)
    {
        if (Tag == "created")
        {
            value = (CloudpdfApi.DocumentsInit200ResponseCreated)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocumentsInit200ResponseResumed"/> and returns true if successful.
    /// </summary>
    public bool TryAsResumed(out CloudpdfApi.DocumentsInit200ResponseResumed? value)
    {
        if (Tag == "resumed")
        {
            value = (CloudpdfApi.DocumentsInit200ResponseResumed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocumentsInit200ResponseDeduped"/> and returns true if successful.
    /// </summary>
    public bool TryAsDeduped(out CloudpdfApi.DocumentsInit200ResponseDeduped? value)
    {
        if (Tag == "deduped")
        {
            value = (CloudpdfApi.DocumentsInit200ResponseDeduped)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsInit200Response(
        DocumentsInit200Response.Created value
    ) => new(value);

    public static implicit operator DocumentsInit200Response(
        DocumentsInit200Response.Resumed value
    ) => new(value);

    public static implicit operator DocumentsInit200Response(
        DocumentsInit200Response.Deduped value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsInit200Response>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsInit200Response).IsAssignableFrom(typeToConvert);

        public override DocumentsInit200Response Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("tag", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'tag'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'tag' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'tag' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'tag' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("tag");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "created" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocumentsInit200ResponseCreated?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocumentsInit200ResponseCreated"
                        ),
                "resumed" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocumentsInit200ResponseResumed?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocumentsInit200ResponseResumed"
                        ),
                "deduped" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocumentsInit200ResponseDeduped?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocumentsInit200ResponseDeduped"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsInit200Response(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200Response value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Tag switch
                {
                    "created" => JsonSerializer.SerializeToNode(value.Value, options),
                    "resumed" => JsonSerializer.SerializeToNode(value.Value, options),
                    "deduped" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["tag"] = value.Tag;
            json.WriteTo(writer, options);
        }

        public override DocumentsInit200Response ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsInit200Response(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200Response value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Tag);
        }
    }

    /// <summary>
    /// Discriminated union type for created
    /// </summary>
    [Serializable]
    public struct Created
    {
        public Created(CloudpdfApi.DocumentsInit200ResponseCreated value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocumentsInit200ResponseCreated Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200Response.Created(
            CloudpdfApi.DocumentsInit200ResponseCreated value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for resumed
    /// </summary>
    [Serializable]
    public struct Resumed
    {
        public Resumed(CloudpdfApi.DocumentsInit200ResponseResumed value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocumentsInit200ResponseResumed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200Response.Resumed(
            CloudpdfApi.DocumentsInit200ResponseResumed value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for deduped
    /// </summary>
    [Serializable]
    public struct Deduped
    {
        public Deduped(CloudpdfApi.DocumentsInit200ResponseDeduped value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocumentsInit200ResponseDeduped Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200Response.Deduped(
            CloudpdfApi.DocumentsInit200ResponseDeduped value
        ) => new(value);
    }
}
