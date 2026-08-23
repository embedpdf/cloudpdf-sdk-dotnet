// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// Where CloudPDF pulls the bytes from. The two shapes differ in WHO supplies the authority to read, not in which storage vendor holds the file.
/// </summary>
[JsonConverter(typeof(DocumentsImportFromRequestSource.JsonConverter))]
[Serializable]
public record DocumentsImportFromRequestSource
{
    internal DocumentsImportFromRequestSource(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocumentsImportFromRequestSource with <see cref="DocumentsImportFromRequestSource.Url"/>.
    /// </summary>
    public DocumentsImportFromRequestSource(DocumentsImportFromRequestSource.Url value)
    {
        Kind = "url";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocumentsImportFromRequestSource with <see cref="DocumentsImportFromRequestSource.Connection"/>.
    /// </summary>
    public DocumentsImportFromRequestSource(DocumentsImportFromRequestSource.Connection value)
    {
        Kind = "connection";
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
    /// Returns true if <see cref="Kind"/> is "url"
    /// </summary>
    public bool IsUrl => Kind == "url";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "connection"
    /// </summary>
    public bool IsConnection => Kind == "connection";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsImportFromRequestSourceUrl"/> if <see cref="Kind"/> is 'url', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'url'.</exception>
    public CloudPDF.DocumentsImportFromRequestSourceUrl AsUrl() =>
        IsUrl
            ? (CloudPDF.DocumentsImportFromRequestSourceUrl)Value!
            : throw new global::System.Exception(
                "DocumentsImportFromRequestSource.Kind is not 'url'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocumentsImportFromRequestSourceConnection"/> if <see cref="Kind"/> is 'connection', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'connection'.</exception>
    public CloudPDF.DocumentsImportFromRequestSourceConnection AsConnection() =>
        IsConnection
            ? (CloudPDF.DocumentsImportFromRequestSourceConnection)Value!
            : throw new global::System.Exception(
                "DocumentsImportFromRequestSource.Kind is not 'connection'"
            );

    public T Match<T>(
        Func<CloudPDF.DocumentsImportFromRequestSourceUrl, T> onUrl,
        Func<CloudPDF.DocumentsImportFromRequestSourceConnection, T> onConnection,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "url" => onUrl(AsUrl()),
            "connection" => onConnection(AsConnection()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocumentsImportFromRequestSourceUrl> onUrl,
        Action<CloudPDF.DocumentsImportFromRequestSourceConnection> onConnection,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "url":
                onUrl(AsUrl());
                break;
            case "connection":
                onConnection(AsConnection());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsImportFromRequestSourceUrl"/> and returns true if successful.
    /// </summary>
    public bool TryAsUrl(out CloudPDF.DocumentsImportFromRequestSourceUrl? value)
    {
        if (Kind == "url")
        {
            value = (CloudPDF.DocumentsImportFromRequestSourceUrl)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocumentsImportFromRequestSourceConnection"/> and returns true if successful.
    /// </summary>
    public bool TryAsConnection(out CloudPDF.DocumentsImportFromRequestSourceConnection? value)
    {
        if (Kind == "connection")
        {
            value = (CloudPDF.DocumentsImportFromRequestSourceConnection)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocumentsImportFromRequestSource(
        DocumentsImportFromRequestSource.Url value
    ) => new(value);

    public static implicit operator DocumentsImportFromRequestSource(
        DocumentsImportFromRequestSource.Connection value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocumentsImportFromRequestSource>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocumentsImportFromRequestSource).IsAssignableFrom(typeToConvert);

        public override DocumentsImportFromRequestSource Read(
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
                "url" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsImportFromRequestSourceUrl?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsImportFromRequestSourceUrl"
                        ),
                "connection" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocumentsImportFromRequestSourceConnection?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocumentsImportFromRequestSourceConnection"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocumentsImportFromRequestSource(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsImportFromRequestSource value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "url" => JsonSerializer.SerializeToNode(value.Value, options),
                    "connection" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocumentsImportFromRequestSource ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocumentsImportFromRequestSource(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsImportFromRequestSource value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for url
    /// </summary>
    [Serializable]
    public struct Url
    {
        public Url(CloudPDF.DocumentsImportFromRequestSourceUrl value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsImportFromRequestSourceUrl Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsImportFromRequestSource.Url(
            CloudPDF.DocumentsImportFromRequestSourceUrl value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for connection
    /// </summary>
    [Serializable]
    public struct Connection
    {
        public Connection(CloudPDF.DocumentsImportFromRequestSourceConnection value)
        {
            Value = value;
        }

        internal CloudPDF.DocumentsImportFromRequestSourceConnection Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocumentsImportFromRequestSource.Connection(
            CloudPDF.DocumentsImportFromRequestSourceConnection value
        ) => new(value);
    }
}
