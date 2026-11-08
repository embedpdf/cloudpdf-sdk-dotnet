// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PageListSnapshotNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record PageListSnapshotNamedPagesItemTarget
{
    internal PageListSnapshotNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PageListSnapshotNamedPagesItemTarget with <see cref="PageListSnapshotNamedPagesItemTarget.Page"/>.
    /// </summary>
    public PageListSnapshotNamedPagesItemTarget(PageListSnapshotNamedPagesItemTarget.Page value)
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageListSnapshotNamedPagesItemTarget with <see cref="PageListSnapshotNamedPagesItemTarget.Template"/>.
    /// </summary>
    public PageListSnapshotNamedPagesItemTarget(PageListSnapshotNamedPagesItemTarget.Template value)
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PageListSnapshotNamedPagesItemTarget with <see cref="PageListSnapshotNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public PageListSnapshotNamedPagesItemTarget(PageListSnapshotNamedPagesItemTarget.Dangling value)
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
    /// Returns the value as a <see cref="CloudPDF.PageListSnapshotNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.PageListSnapshotNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.PageListSnapshotNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "PageListSnapshotNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "PageListSnapshotNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PageListSnapshotNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.PageListSnapshotNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.PageListSnapshotNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "PageListSnapshotNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.PageListSnapshotNamedPagesItemTargetPage, T> onPage,
        Func<CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate, T> onTemplate,
        Func<CloudPDF.PageListSnapshotNamedPagesItemTargetDangling, T> onDangling,
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
        Action<CloudPDF.PageListSnapshotNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.PageListSnapshotNamedPagesItemTargetDangling> onDangling,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.PageListSnapshotNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(out CloudPDF.PageListSnapshotNamedPagesItemTargetPage? value)
    {
        if (Kind == "page")
        {
            value = (CloudPDF.PageListSnapshotNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(out CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate? value)
    {
        if (Kind == "template")
        {
            value = (CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PageListSnapshotNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(out CloudPDF.PageListSnapshotNamedPagesItemTargetDangling? value)
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.PageListSnapshotNamedPagesItemTargetDangling)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PageListSnapshotNamedPagesItemTarget(
        PageListSnapshotNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator PageListSnapshotNamedPagesItemTarget(
        PageListSnapshotNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator PageListSnapshotNamedPagesItemTarget(
        PageListSnapshotNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PageListSnapshotNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PageListSnapshotNamedPagesItemTarget).IsAssignableFrom(typeToConvert);

        public override PageListSnapshotNamedPagesItemTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PageListSnapshotNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PageListSnapshotNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PageListSnapshotNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PageListSnapshotNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PageListSnapshotNamedPagesItemTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PageListSnapshotNamedPagesItemTarget value,
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

        public override PageListSnapshotNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PageListSnapshotNamedPagesItemTarget(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PageListSnapshotNamedPagesItemTarget value,
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
        public Page(CloudPDF.PageListSnapshotNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.PageListSnapshotNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageListSnapshotNamedPagesItemTarget.Page(
            CloudPDF.PageListSnapshotNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate value)
        {
            Value = value;
        }

        internal CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageListSnapshotNamedPagesItemTarget.Template(
            CloudPDF.PageListSnapshotNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(CloudPDF.PageListSnapshotNamedPagesItemTargetDangling value)
        {
            Value = value;
        }

        internal CloudPDF.PageListSnapshotNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PageListSnapshotNamedPagesItemTarget.Dangling(
            CloudPDF.PageListSnapshotNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
