// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocumentsInit200ResponseCreatedUpload.JsonConverter))]
[Serializable]
public record DocumentsInit200ResponseCreatedUpload
{
    internal DocumentsInit200ResponseCreatedUpload(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200ResponseCreatedUpload with <see cref="DocumentsInit200ResponseCreatedUpload.Presigned"/>.
    /// </summary>
    public DocumentsInit200ResponseCreatedUpload(
        DocumentsInit200ResponseCreatedUpload.Presigned value
    )
    {
        Kind = "presigned";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200ResponseCreatedUpload with <see cref="DocumentsInit200ResponseCreatedUpload.Direct"/>.
    /// </summary>
    public DocumentsInit200ResponseCreatedUpload(DocumentsInit200ResponseCreatedUpload.Direct value)
    {
        Kind = "direct";
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
    /// Returns true if <see cref="Kind"/> is "presigned"
    /// </summary>
    public bool IsPresigned => Kind == "presigned";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "direct"
    /// </summary>
    public bool IsDirect => Kind == "direct";

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned"/> if <see cref="Kind"/> is 'presigned', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'presigned'.</exception>
    public CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned AsPresigned() =>
        IsPresigned
            ? (CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned)Value!
            : throw new global::System.Exception(
                "DocumentsInit200ResponseCreatedUpload.Kind is not 'presigned'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect"/> if <see cref="Kind"/> is 'direct', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'direct'.</exception>
    public CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect AsDirect() =>
        IsDirect
            ? (CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect)Value!
            : throw new global::System.Exception(
                "DocumentsInit200ResponseCreatedUpload.Kind is not 'direct'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned, T> onPresigned,
        Func<CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect, T> onDirect,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "presigned" => onPresigned(AsPresigned()),
            "direct" => onDirect(AsDirect()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned> onPresigned,
        Action<CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect> onDirect,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "presigned":
                onPresigned(AsPresigned());
                break;
            case "direct":
                onDirect(AsDirect());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned"/> and returns true if successful.
    /// </summary>
    public bool TryAsPresigned(
        out CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned? value
    )
    {
        if (Kind == "presigned")
        {
            value = (CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect"/> and returns true if successful.
    /// </summary>
    public bool TryAsDirect(out CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect? value)
    {
        if (Kind == "direct")
        {
            value = (CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsInit200ResponseCreatedUpload(
        DocumentsInit200ResponseCreatedUpload.Presigned value
    ) => new(value);

    public static implicit operator DocumentsInit200ResponseCreatedUpload(
        DocumentsInit200ResponseCreatedUpload.Direct value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsInit200ResponseCreatedUpload>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsInit200ResponseCreatedUpload).IsAssignableFrom(typeToConvert);

        public override DocumentsInit200ResponseCreatedUpload Read(
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
                "presigned" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned"
                        ),
                "direct" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsInit200ResponseCreatedUpload(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseCreatedUpload value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "presigned" => JsonSerializer.SerializeToNode(value.Value, options),
                    "direct" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocumentsInit200ResponseCreatedUpload ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsInit200ResponseCreatedUpload(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseCreatedUpload value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for presigned
    /// </summary>
    [Serializable]
    public struct Presigned
    {
        public Presigned(CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200ResponseCreatedUpload.Presigned(
            CloudpdfApi.DocumentsInit200ResponseCreatedUploadPresigned value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for direct
    /// </summary>
    [Serializable]
    public struct Direct
    {
        public Direct(CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200ResponseCreatedUpload.Direct(
            CloudpdfApi.DocumentsInit200ResponseCreatedUploadDirect value
        ) => new(value);
    }
}
