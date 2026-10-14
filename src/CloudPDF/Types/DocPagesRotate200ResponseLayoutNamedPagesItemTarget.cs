// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesRotate200ResponseLayoutNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record DocPagesRotate200ResponseLayoutNamedPagesItemTarget
{
    internal DocPagesRotate200ResponseLayoutNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocPagesRotate200ResponseLayoutNamedPagesItemTarget with <see cref="DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Page"/>.
    /// </summary>
    public DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
        DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Page value
    )
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesRotate200ResponseLayoutNamedPagesItemTarget with <see cref="DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Template"/>.
    /// </summary>
    public DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
        DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Template value
    )
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesRotate200ResponseLayoutNamedPagesItemTarget with <see cref="DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
        DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Dangling value
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
    /// Returns the value as a <see cref="CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage, T> onPage,
        Func<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate, T> onTemplate,
        Func<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling, T> onDangling,
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
        Action<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling> onDangling,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(
        out CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage? value
    )
    {
        if (Kind == "page")
        {
            value = (CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(
        out CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate? value
    )
    {
        if (Kind == "template")
        {
            value = (CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(
        out CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling? value
    )
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
        DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
        DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
        DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocPagesRotate200ResponseLayoutNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocPagesRotate200ResponseLayoutNamedPagesItemTarget).IsAssignableFrom(
                typeToConvert
            );

        public override DocPagesRotate200ResponseLayoutNamedPagesItemTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocPagesRotate200ResponseLayoutNamedPagesItemTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesRotate200ResponseLayoutNamedPagesItemTarget value,
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

        public override DocPagesRotate200ResponseLayoutNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocPagesRotate200ResponseLayoutNamedPagesItemTarget(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesRotate200ResponseLayoutNamedPagesItemTarget value,
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
        public Page(CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Page(
            CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Template(
            CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesRotate200ResponseLayoutNamedPagesItemTarget.Dangling(
            CloudPDF.DocPagesRotate200ResponseLayoutNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
