// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(TokensIssueRequest.JsonConverter))]
[Serializable]
public record TokensIssueRequest
{
    internal TokensIssueRequest(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of TokensIssueRequest with <see cref="TokensIssueRequest.Doc"/>.
    /// </summary>
    public TokensIssueRequest(TokensIssueRequest.Doc value)
    {
        Kind = "doc";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of TokensIssueRequest with <see cref="TokensIssueRequest.Tenant"/>.
    /// </summary>
    public TokensIssueRequest(TokensIssueRequest.Tenant value)
    {
        Kind = "tenant";
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
    /// Returns true if <see cref="Kind"/> is "doc"
    /// </summary>
    public bool IsDoc => Kind == "doc";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "tenant"
    /// </summary>
    public bool IsTenant => Kind == "tenant";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.TokensIssueRequestDoc"/> if <see cref="Kind"/> is 'doc', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'doc'.</exception>
    public CloudPDF.TokensIssueRequestDoc AsDoc() =>
        IsDoc
            ? (CloudPDF.TokensIssueRequestDoc)Value!
            : throw new global::System.Exception("TokensIssueRequest.Kind is not 'doc'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.TokensIssueRequestTenant"/> if <see cref="Kind"/> is 'tenant', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'tenant'.</exception>
    public CloudPDF.TokensIssueRequestTenant AsTenant() =>
        IsTenant
            ? (CloudPDF.TokensIssueRequestTenant)Value!
            : throw new global::System.Exception("TokensIssueRequest.Kind is not 'tenant'");

    public T Match<T>(
        Func<CloudPDF.TokensIssueRequestDoc, T> onDoc,
        Func<CloudPDF.TokensIssueRequestTenant, T> onTenant,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "doc" => onDoc(AsDoc()),
            "tenant" => onTenant(AsTenant()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.TokensIssueRequestDoc> onDoc,
        Action<CloudPDF.TokensIssueRequestTenant> onTenant,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "doc":
                onDoc(AsDoc());
                break;
            case "tenant":
                onTenant(AsTenant());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.TokensIssueRequestDoc"/> and returns true if successful.
    /// </summary>
    public bool TryAsDoc(out CloudPDF.TokensIssueRequestDoc? value)
    {
        if (Kind == "doc")
        {
            value = (CloudPDF.TokensIssueRequestDoc)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.TokensIssueRequestTenant"/> and returns true if successful.
    /// </summary>
    public bool TryAsTenant(out CloudPDF.TokensIssueRequestTenant? value)
    {
        if (Kind == "tenant")
        {
            value = (CloudPDF.TokensIssueRequestTenant)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator TokensIssueRequest(TokensIssueRequest.Doc value) => new(value);

    public static implicit operator TokensIssueRequest(TokensIssueRequest.Tenant value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<TokensIssueRequest>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(TokensIssueRequest).IsAssignableFrom(typeToConvert);

        public override TokensIssueRequest Read(
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
                "doc" => jsonWithoutDiscriminator.Deserialize<CloudPDF.TokensIssueRequestDoc?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.TokensIssueRequestDoc"
                    ),
                "tenant" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.TokensIssueRequestTenant?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.TokensIssueRequestTenant"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new TokensIssueRequest(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TokensIssueRequest value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "doc" => JsonSerializer.SerializeToNode(value.Value, options),
                    "tenant" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override TokensIssueRequest ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new TokensIssueRequest(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TokensIssueRequest value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for doc
    /// </summary>
    [Serializable]
    public struct Doc
    {
        public Doc(CloudPDF.TokensIssueRequestDoc value)
        {
            Value = value;
        }

        internal CloudPDF.TokensIssueRequestDoc Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator TokensIssueRequest.Doc(
            CloudPDF.TokensIssueRequestDoc value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tenant
    /// </summary>
    [Serializable]
    public struct Tenant
    {
        public Tenant(CloudPDF.TokensIssueRequestTenant value)
        {
            Value = value;
        }

        internal CloudPDF.TokensIssueRequestTenant Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator TokensIssueRequest.Tenant(
            CloudPDF.TokensIssueRequestTenant value
        ) => new(value);
    }
}
