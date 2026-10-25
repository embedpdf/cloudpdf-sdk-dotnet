// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeItemPagesInsertLayoutNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record ChangeItemPagesInsertLayoutNamedPagesItemTarget
{
    internal ChangeItemPagesInsertLayoutNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesInsertLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesInsertLayoutNamedPagesItemTarget.Page"/>.
    /// </summary>
    public ChangeItemPagesInsertLayoutNamedPagesItemTarget(
        ChangeItemPagesInsertLayoutNamedPagesItemTarget.Page value
    )
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesInsertLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesInsertLayoutNamedPagesItemTarget.Template"/>.
    /// </summary>
    public ChangeItemPagesInsertLayoutNamedPagesItemTarget(
        ChangeItemPagesInsertLayoutNamedPagesItemTarget.Template value
    )
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesInsertLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesInsertLayoutNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public ChangeItemPagesInsertLayoutNamedPagesItemTarget(
        ChangeItemPagesInsertLayoutNamedPagesItemTarget.Dangling value
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
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesInsertLayoutNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesInsertLayoutNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesInsertLayoutNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage, T> onPage,
        Func<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate, T> onTemplate,
        Func<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling, T> onDangling,
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
        Action<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling> onDangling,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(out CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage? value)
    {
        if (Kind == "page")
        {
            value = (CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(
        out CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate? value
    )
    {
        if (Kind == "template")
        {
            value = (CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(
        out CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling? value
    )
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ChangeItemPagesInsertLayoutNamedPagesItemTarget(
        ChangeItemPagesInsertLayoutNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator ChangeItemPagesInsertLayoutNamedPagesItemTarget(
        ChangeItemPagesInsertLayoutNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator ChangeItemPagesInsertLayoutNamedPagesItemTarget(
        ChangeItemPagesInsertLayoutNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<ChangeItemPagesInsertLayoutNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ChangeItemPagesInsertLayoutNamedPagesItemTarget).IsAssignableFrom(typeToConvert);

        public override ChangeItemPagesInsertLayoutNamedPagesItemTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ChangeItemPagesInsertLayoutNamedPagesItemTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesInsertLayoutNamedPagesItemTarget value,
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

        public override ChangeItemPagesInsertLayoutNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ChangeItemPagesInsertLayoutNamedPagesItemTarget(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesInsertLayoutNamedPagesItemTarget value,
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
        public Page(CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesInsertLayoutNamedPagesItemTarget.Page(
            CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesInsertLayoutNamedPagesItemTarget.Template(
            CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesInsertLayoutNamedPagesItemTarget.Dangling(
            CloudPDF.ChangeItemPagesInsertLayoutNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
