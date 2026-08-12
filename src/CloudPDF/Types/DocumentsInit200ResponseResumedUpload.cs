// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentsInit200ResponseResumedUpload.JsonConverter))]
[Serializable]
public record DocumentsInit200ResponseResumedUpload
{
    internal DocumentsInit200ResponseResumedUpload(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200ResponseResumedUpload with <see cref="DocumentsInit200ResponseResumedUpload.Presigned"/>.
    /// </summary>
    public DocumentsInit200ResponseResumedUpload(
        DocumentsInit200ResponseResumedUpload.Presigned value
    )
    {
        Kind = "presigned";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInit200ResponseResumedUpload with <see cref="DocumentsInit200ResponseResumedUpload.Proxy"/>.
    /// </summary>
    public DocumentsInit200ResponseResumedUpload(DocumentsInit200ResponseResumedUpload.Proxy value)
    {
        Kind = "proxy";
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
    /// Returns true if <see cref="Kind"/> is "proxy"
    /// </summary>
    public bool IsProxy => Kind == "proxy";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInit200ResponseResumedUploadPresigned"/> if <see cref="Kind"/> is 'presigned', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'presigned'.</exception>
    public CloudPDF.DocumentsInit200ResponseResumedUploadPresigned AsPresigned() =>
        IsPresigned
            ? (CloudPDF.DocumentsInit200ResponseResumedUploadPresigned)Value!
            : throw new global::System.Exception(
                "DocumentsInit200ResponseResumedUpload.Kind is not 'presigned'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInit200ResponseResumedUploadProxy"/> if <see cref="Kind"/> is 'proxy', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'proxy'.</exception>
    public CloudPDF.DocumentsInit200ResponseResumedUploadProxy AsProxy() =>
        IsProxy
            ? (CloudPDF.DocumentsInit200ResponseResumedUploadProxy)Value!
            : throw new global::System.Exception(
                "DocumentsInit200ResponseResumedUpload.Kind is not 'proxy'"
            );

    public T Match<T>(
        Func<CloudPDF.DocumentsInit200ResponseResumedUploadPresigned, T> onPresigned,
        Func<CloudPDF.DocumentsInit200ResponseResumedUploadProxy, T> onProxy,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "presigned" => onPresigned(AsPresigned()),
            "proxy" => onProxy(AsProxy()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocumentsInit200ResponseResumedUploadPresigned> onPresigned,
        Action<CloudPDF.DocumentsInit200ResponseResumedUploadProxy> onProxy,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "presigned":
                onPresigned(AsPresigned());
                break;
            case "proxy":
                onProxy(AsProxy());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInit200ResponseResumedUploadPresigned"/> and returns true if successful.
    /// </summary>
    public bool TryAsPresigned(out CloudPDF.DocumentsInit200ResponseResumedUploadPresigned? value)
    {
        if (Kind == "presigned")
        {
            value = (CloudPDF.DocumentsInit200ResponseResumedUploadPresigned)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInit200ResponseResumedUploadProxy"/> and returns true if successful.
    /// </summary>
    public bool TryAsProxy(out CloudPDF.DocumentsInit200ResponseResumedUploadProxy? value)
    {
        if (Kind == "proxy")
        {
            value = (CloudPDF.DocumentsInit200ResponseResumedUploadProxy)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsInit200ResponseResumedUpload(
        DocumentsInit200ResponseResumedUpload.Presigned value
    ) => new(value);

    public static implicit operator DocumentsInit200ResponseResumedUpload(
        DocumentsInit200ResponseResumedUpload.Proxy value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsInit200ResponseResumedUpload>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsInit200ResponseResumedUpload).IsAssignableFrom(typeToConvert);

        public override DocumentsInit200ResponseResumedUpload Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInit200ResponseResumedUploadPresigned?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInit200ResponseResumedUploadPresigned"
                        ),
                "proxy" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInit200ResponseResumedUploadProxy?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInit200ResponseResumedUploadProxy"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsInit200ResponseResumedUpload(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseResumedUpload value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "presigned" => JsonSerializer.SerializeToNode(value.Value, options),
                    "proxy" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocumentsInit200ResponseResumedUpload ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsInit200ResponseResumedUpload(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseResumedUpload value,
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
        public Presigned(CloudPDF.DocumentsInit200ResponseResumedUploadPresigned value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInit200ResponseResumedUploadPresigned Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200ResponseResumedUpload.Presigned(
            CloudPDF.DocumentsInit200ResponseResumedUploadPresigned value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for proxy
    /// </summary>
    [Serializable]
    public struct Proxy
    {
        public Proxy(CloudPDF.DocumentsInit200ResponseResumedUploadProxy value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInit200ResponseResumedUploadProxy Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInit200ResponseResumedUpload.Proxy(
            CloudPDF.DocumentsInit200ResponseResumedUploadProxy value
        ) => new(value);
    }
}
