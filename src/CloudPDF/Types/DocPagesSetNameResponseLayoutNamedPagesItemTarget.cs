// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesSetNameResponseLayoutNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record DocPagesSetNameResponseLayoutNamedPagesItemTarget
{
    internal DocPagesSetNameResponseLayoutNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocPagesSetNameResponseLayoutNamedPagesItemTarget with <see cref="DocPagesSetNameResponseLayoutNamedPagesItemTarget.Page"/>.
    /// </summary>
    public DocPagesSetNameResponseLayoutNamedPagesItemTarget(
        DocPagesSetNameResponseLayoutNamedPagesItemTarget.Page value
    )
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesSetNameResponseLayoutNamedPagesItemTarget with <see cref="DocPagesSetNameResponseLayoutNamedPagesItemTarget.Template"/>.
    /// </summary>
    public DocPagesSetNameResponseLayoutNamedPagesItemTarget(
        DocPagesSetNameResponseLayoutNamedPagesItemTarget.Template value
    )
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocPagesSetNameResponseLayoutNamedPagesItemTarget with <see cref="DocPagesSetNameResponseLayoutNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public DocPagesSetNameResponseLayoutNamedPagesItemTarget(
        DocPagesSetNameResponseLayoutNamedPagesItemTarget.Dangling value
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
    /// Returns the value as a <see cref="CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "DocPagesSetNameResponseLayoutNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "DocPagesSetNameResponseLayoutNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "DocPagesSetNameResponseLayoutNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage, T> onPage,
        Func<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate, T> onTemplate,
        Func<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling, T> onDangling,
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
        Action<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling> onDangling,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(out CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage? value)
    {
        if (Kind == "page")
        {
            value = (CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(
        out CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate? value
    )
    {
        if (Kind == "template")
        {
            value = (CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(
        out CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling? value
    )
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocPagesSetNameResponseLayoutNamedPagesItemTarget(
        DocPagesSetNameResponseLayoutNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator DocPagesSetNameResponseLayoutNamedPagesItemTarget(
        DocPagesSetNameResponseLayoutNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator DocPagesSetNameResponseLayoutNamedPagesItemTarget(
        DocPagesSetNameResponseLayoutNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocPagesSetNameResponseLayoutNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocPagesSetNameResponseLayoutNamedPagesItemTarget).IsAssignableFrom(
                typeToConvert
            );

        public override DocPagesSetNameResponseLayoutNamedPagesItemTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocPagesSetNameResponseLayoutNamedPagesItemTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetNameResponseLayoutNamedPagesItemTarget value,
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

        public override DocPagesSetNameResponseLayoutNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocPagesSetNameResponseLayoutNamedPagesItemTarget(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetNameResponseLayoutNamedPagesItemTarget value,
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
        public Page(CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesSetNameResponseLayoutNamedPagesItemTarget.Page(
            CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesSetNameResponseLayoutNamedPagesItemTarget.Template(
            CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling value)
        {
            Value = value;
        }

        internal CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocPagesSetNameResponseLayoutNamedPagesItemTarget.Dangling(
            CloudPDF.DocPagesSetNameResponseLayoutNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
