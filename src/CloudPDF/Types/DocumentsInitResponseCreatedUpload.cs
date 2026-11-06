// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentsInitResponseCreatedUpload.JsonConverter))]
[Serializable]
public record DocumentsInitResponseCreatedUpload
{
    internal DocumentsInitResponseCreatedUpload(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponseCreatedUpload with <see cref="DocumentsInitResponseCreatedUpload.Presigned"/>.
    /// </summary>
    public DocumentsInitResponseCreatedUpload(DocumentsInitResponseCreatedUpload.Presigned value)
    {
        Kind = "presigned";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsInitResponseCreatedUpload with <see cref="DocumentsInitResponseCreatedUpload.Proxy"/>.
    /// </summary>
    public DocumentsInitResponseCreatedUpload(DocumentsInitResponseCreatedUpload.Proxy value)
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
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseCreatedUploadPresigned"/> if <see cref="Kind"/> is 'presigned', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'presigned'.</exception>
    public CloudPDF.DocumentsInitResponseCreatedUploadPresigned AsPresigned() =>
        IsPresigned
            ? (CloudPDF.DocumentsInitResponseCreatedUploadPresigned)Value!
            : throw new global::System.Exception(
                "DocumentsInitResponseCreatedUpload.Kind is not 'presigned'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsInitResponseCreatedUploadProxy"/> if <see cref="Kind"/> is 'proxy', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'proxy'.</exception>
    public CloudPDF.DocumentsInitResponseCreatedUploadProxy AsProxy() =>
        IsProxy
            ? (CloudPDF.DocumentsInitResponseCreatedUploadProxy)Value!
            : throw new global::System.Exception(
                "DocumentsInitResponseCreatedUpload.Kind is not 'proxy'"
            );

    public T Match<T>(
        Func<CloudPDF.DocumentsInitResponseCreatedUploadPresigned, T> onPresigned,
        Func<CloudPDF.DocumentsInitResponseCreatedUploadProxy, T> onProxy,
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
        Action<CloudPDF.DocumentsInitResponseCreatedUploadPresigned> onPresigned,
        Action<CloudPDF.DocumentsInitResponseCreatedUploadProxy> onProxy,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseCreatedUploadPresigned"/> and returns true if successful.
    /// </summary>
    public bool TryAsPresigned(out CloudPDF.DocumentsInitResponseCreatedUploadPresigned? value)
    {
        if (Kind == "presigned")
        {
            value = (CloudPDF.DocumentsInitResponseCreatedUploadPresigned)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsInitResponseCreatedUploadProxy"/> and returns true if successful.
    /// </summary>
    public bool TryAsProxy(out CloudPDF.DocumentsInitResponseCreatedUploadProxy? value)
    {
        if (Kind == "proxy")
        {
            value = (CloudPDF.DocumentsInitResponseCreatedUploadProxy)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsInitResponseCreatedUpload(
        DocumentsInitResponseCreatedUpload.Presigned value
    ) => new(value);

    public static implicit operator DocumentsInitResponseCreatedUpload(
        DocumentsInitResponseCreatedUpload.Proxy value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsInitResponseCreatedUpload>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsInitResponseCreatedUpload).IsAssignableFrom(typeToConvert);

        public override DocumentsInitResponseCreatedUpload Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseCreatedUploadPresigned?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseCreatedUploadPresigned"
                        ),
                "proxy" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsInitResponseCreatedUploadProxy?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsInitResponseCreatedUploadProxy"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsInitResponseCreatedUpload(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInitResponseCreatedUpload value,
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

        public override DocumentsInitResponseCreatedUpload ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsInitResponseCreatedUpload(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInitResponseCreatedUpload value,
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
        public Presigned(CloudPDF.DocumentsInitResponseCreatedUploadPresigned value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseCreatedUploadPresigned Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponseCreatedUpload.Presigned(
            CloudPDF.DocumentsInitResponseCreatedUploadPresigned value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for proxy
    /// </summary>
    [Serializable]
    public struct Proxy
    {
        public Proxy(CloudPDF.DocumentsInitResponseCreatedUploadProxy value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsInitResponseCreatedUploadProxy Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsInitResponseCreatedUpload.Proxy(
            CloudPDF.DocumentsInitResponseCreatedUploadProxy value
        ) => new(value);
    }
}
