// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentsInitResponseResumedUpload.JsonConverter))]
[Serializable]
public record DocumentsInitResponseResumedUpload
{
    internal DocumentsInitResponseResumedUpload(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponseResumedUpload with <see cref="DocumentsInitResponseResumedUpload.Presigned"/>.
    /// </summary>
    public DocumentsInitResponseResumedUpload(DocumentsInitResponseResumedUpload.Presigned value)
    {
        Kind = "presigned";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponseResumedUpload with <see cref="DocumentsInitResponseResumedUpload.Proxy"/>.
    /// </summary>
    public DocumentsInitResponseResumedUpload(DocumentsInitResponseResumedUpload.Proxy value)
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
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseResumedUploadPresigned"/> if <see cref="Kind"/> is 'presigned', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'presigned'.</exception>
    public CloudPDF.DocumentsInitResponseResumedUploadPresigned AsPresigned() =>
        IsPresigned
            ? (CloudPDF.DocumentsInitResponseResumedUploadPresigned)Value!
            : throw new global::System.Exception(
                "DocumentsInitResponseResumedUpload.Kind is not 'presigned'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseResumedUploadProxy"/> if <see cref="Kind"/> is 'proxy', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'proxy'.</exception>
    public CloudPDF.DocumentsInitResponseResumedUploadProxy AsProxy() =>
        IsProxy
            ? (CloudPDF.DocumentsInitResponseResumedUploadProxy)Value!
            : throw new global::System.Exception(
                "DocumentsInitResponseResumedUpload.Kind is not 'proxy'"
            );

    public T Match<T>(
        Func<CloudPDF.DocumentsInitResponseResumedUploadPresigned, T> onPresigned,
        Func<CloudPDF.DocumentsInitResponseResumedUploadProxy, T> onProxy,
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
        Action<CloudPDF.DocumentsInitResponseResumedUploadPresigned> onPresigned,
        Action<CloudPDF.DocumentsInitResponseResumedUploadProxy> onProxy,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseResumedUploadPresigned"/> and returns true if successful.
    /// </summary>
    public bool TryAsPresigned(out CloudPDF.DocumentsInitResponseResumedUploadPresigned? value)
    {
        if (Kind == "presigned")
        {
            value = (CloudPDF.DocumentsInitResponseResumedUploadPresigned)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseResumedUploadProxy"/> and returns true if successful.
    /// </summary>
    public bool TryAsProxy(out CloudPDF.DocumentsInitResponseResumedUploadProxy? value)
    {
        if (Kind == "proxy")
        {
            value = (CloudPDF.DocumentsInitResponseResumedUploadProxy)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsInitResponseResumedUpload(
        DocumentsInitResponseResumedUpload.Presigned value
    ) => new(value);

    public static implicit operator DocumentsInitResponseResumedUpload(
        DocumentsInitResponseResumedUpload.Proxy value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsInitResponseResumedUpload>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsInitResponseResumedUpload).IsAssignableFrom(typeToConvert);

        public override DocumentsInitResponseResumedUpload Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseResumedUploadPresigned?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseResumedUploadPresigned"
                        ),
                "proxy" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseResumedUploadProxy?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseResumedUploadProxy"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsInitResponseResumedUpload(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInitResponseResumedUpload value,
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

        public override DocumentsInitResponseResumedUpload ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsInitResponseResumedUpload(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInitResponseResumedUpload value,
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
        public Presigned(CloudPDF.DocumentsInitResponseResumedUploadPresigned value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseResumedUploadPresigned Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponseResumedUpload.Presigned(
            CloudPDF.DocumentsInitResponseResumedUploadPresigned value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for proxy
    /// </summary>
    [Serializable]
    public struct Proxy
    {
        public Proxy(CloudPDF.DocumentsInitResponseResumedUploadProxy value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseResumedUploadProxy Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponseResumedUpload.Proxy(
            CloudPDF.DocumentsInitResponseResumedUploadProxy value
        ) => new(value);
    }
}
