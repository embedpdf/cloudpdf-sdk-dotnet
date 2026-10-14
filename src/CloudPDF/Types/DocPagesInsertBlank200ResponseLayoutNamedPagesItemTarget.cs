// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget
{
    internal DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget with <see cref="DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Page"/>.
    /// </summary>
    public DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
        DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Page value
    )
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget with <see cref="DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Template"/>.
    /// </summary>
    public DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
        DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Template value
    )
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget with <see cref="DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
        DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Dangling value
    )
    {
        Kind = "dangling";
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
    /// Returns true if <see cref="Kind"/> is "page"
    /// </summary>
    public bool IsPage => Kind == "page";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "template"
    /// </summary>
    public bool IsTemplate => Kind == "template";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "dangling"
    /// </summary>
    public bool IsDangling => Kind == "dangling";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage, T> onPage,
        Func<
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate,
            T
        > onTemplate,
        Func<
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling,
            T
        > onDangling,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "page" => onPage(AsPage()),
            "template" => onTemplate(AsTemplate()),
            "dangling" => onDangling(AsDangling()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling> onDangling,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "page":
                onPage(AsPage());
                break;
            case "template":
                onTemplate(AsTemplate());
                break;
            case "dangling":
                onDangling(AsDangling());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(
        out CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage? value
    )
    {
        if (Kind == "page")
        {
            value = (CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(
        out CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate? value
    )
    {
        if (Kind == "template")
        {
            value = (CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(
        out CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling? value
    )
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
        DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
        DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
        DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget).IsAssignableFrom(
                typeToConvert
            );

        public override DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget Read(
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
                "page" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "page" => JsonSerializer.SerializeToNode(value.Value, options),
                    "template" => JsonSerializer.SerializeToNode(value.Value, options),
                    "dangling" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for page
    /// </summary>
    [Serializable]
    public struct Page
    {
        public Page(CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Page(
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Template(
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesInsertBlank200ResponseLayoutNamedPagesItemTarget.Dangling(
            CloudPDF.DocPagesInsertBlank200ResponseLayoutNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
