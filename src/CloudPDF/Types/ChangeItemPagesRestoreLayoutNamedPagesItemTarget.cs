// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeItemPagesRestoreLayoutNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record ChangeItemPagesRestoreLayoutNamedPagesItemTarget
{
    internal ChangeItemPagesRestoreLayoutNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesRestoreLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Page"/>.
    /// </summary>
    public ChangeItemPagesRestoreLayoutNamedPagesItemTarget(
        ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Page value
    )
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesRestoreLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Template"/>.
    /// </summary>
    public ChangeItemPagesRestoreLayoutNamedPagesItemTarget(
        ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Template value
    )
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesRestoreLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public ChangeItemPagesRestoreLayoutNamedPagesItemTarget(
        ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Dangling value
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
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage, T> onPage,
        Func<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate, T> onTemplate,
        Func<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling, T> onDangling,
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
        Action<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling> onDangling,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(out CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage? value)
    {
        if (Kind == "page")
        {
            value = (CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(
        out CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate? value
    )
    {
        if (Kind == "template")
        {
            value = (CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(
        out CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling? value
    )
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ChangeItemPagesRestoreLayoutNamedPagesItemTarget(
        ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator ChangeItemPagesRestoreLayoutNamedPagesItemTarget(
        ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator ChangeItemPagesRestoreLayoutNamedPagesItemTarget(
        ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<ChangeItemPagesRestoreLayoutNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ChangeItemPagesRestoreLayoutNamedPagesItemTarget).IsAssignableFrom(
                typeToConvert
            );

        public override ChangeItemPagesRestoreLayoutNamedPagesItemTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ChangeItemPagesRestoreLayoutNamedPagesItemTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesRestoreLayoutNamedPagesItemTarget value,
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

        public override ChangeItemPagesRestoreLayoutNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ChangeItemPagesRestoreLayoutNamedPagesItemTarget(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesRestoreLayoutNamedPagesItemTarget value,
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
        public Page(CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Page(
            CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Template(
            CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesRestoreLayoutNamedPagesItemTarget.Dangling(
            CloudPDF.ChangeItemPagesRestoreLayoutNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
