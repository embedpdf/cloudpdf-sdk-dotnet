// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeItemPagesCopyLayoutNamedPagesItemTarget.JsonConverter))]
[Serializable]
public record ChangeItemPagesCopyLayoutNamedPagesItemTarget
{
    internal ChangeItemPagesCopyLayoutNamedPagesItemTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesCopyLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesCopyLayoutNamedPagesItemTarget.Page"/>.
    /// </summary>
    public ChangeItemPagesCopyLayoutNamedPagesItemTarget(
        ChangeItemPagesCopyLayoutNamedPagesItemTarget.Page value
    )
    {
        Kind = "page";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesCopyLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesCopyLayoutNamedPagesItemTarget.Template"/>.
    /// </summary>
    public ChangeItemPagesCopyLayoutNamedPagesItemTarget(
        ChangeItemPagesCopyLayoutNamedPagesItemTarget.Template value
    )
    {
        Kind = "template";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItemPagesCopyLayoutNamedPagesItemTarget with <see cref="ChangeItemPagesCopyLayoutNamedPagesItemTarget.Dangling"/>.
    /// </summary>
    public ChangeItemPagesCopyLayoutNamedPagesItemTarget(
        ChangeItemPagesCopyLayoutNamedPagesItemTarget.Dangling value
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
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage"/> if <see cref="Kind"/> is 'page', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'page'.</exception>
    public CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage AsPage() =>
        IsPage
            ? (CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesCopyLayoutNamedPagesItemTarget.Kind is not 'page'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate"/> if <see cref="Kind"/> is 'template', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'template'.</exception>
    public CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate AsTemplate() =>
        IsTemplate
            ? (CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesCopyLayoutNamedPagesItemTarget.Kind is not 'template'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling"/> if <see cref="Kind"/> is 'dangling', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'dangling'.</exception>
    public CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling AsDangling() =>
        IsDangling
            ? (CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling)Value!
            : throw new global::System.Exception(
                "ChangeItemPagesCopyLayoutNamedPagesItemTarget.Kind is not 'dangling'"
            );

    public T Match<T>(
        Func<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage, T> onPage,
        Func<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate, T> onTemplate,
        Func<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling, T> onDangling,
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
        Action<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage> onPage,
        Action<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate> onTemplate,
        Action<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling> onDangling,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPage(out CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage? value)
    {
        if (Kind == "page")
        {
            value = (CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate"/> and returns true if successful.
    /// </summary>
    public bool TryAsTemplate(
        out CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate? value
    )
    {
        if (Kind == "template")
        {
            value = (CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling"/> and returns true if successful.
    /// </summary>
    public bool TryAsDangling(
        out CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling? value
    )
    {
        if (Kind == "dangling")
        {
            value = (CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ChangeItemPagesCopyLayoutNamedPagesItemTarget(
        ChangeItemPagesCopyLayoutNamedPagesItemTarget.Page value
    ) => new(value);

    public static implicit operator ChangeItemPagesCopyLayoutNamedPagesItemTarget(
        ChangeItemPagesCopyLayoutNamedPagesItemTarget.Template value
    ) => new(value);

    public static implicit operator ChangeItemPagesCopyLayoutNamedPagesItemTarget(
        ChangeItemPagesCopyLayoutNamedPagesItemTarget.Dangling value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<ChangeItemPagesCopyLayoutNamedPagesItemTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ChangeItemPagesCopyLayoutNamedPagesItemTarget).IsAssignableFrom(typeToConvert);

        public override ChangeItemPagesCopyLayoutNamedPagesItemTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage"
                        ),
                "template" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate"
                        ),
                "dangling" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ChangeItemPagesCopyLayoutNamedPagesItemTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesCopyLayoutNamedPagesItemTarget value,
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

        public override ChangeItemPagesCopyLayoutNamedPagesItemTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ChangeItemPagesCopyLayoutNamedPagesItemTarget(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesCopyLayoutNamedPagesItemTarget value,
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
        public Page(CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesCopyLayoutNamedPagesItemTarget.Page(
            CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetPage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for template
    /// </summary>
    [Serializable]
    public struct Template
    {
        public Template(CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesCopyLayoutNamedPagesItemTarget.Template(
            CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetTemplate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for dangling
    /// </summary>
    [Serializable]
    public struct Dangling
    {
        public Dangling(CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItemPagesCopyLayoutNamedPagesItemTarget.Dangling(
            CloudPDF.ChangeItemPagesCopyLayoutNamedPagesItemTargetDangling value
        ) => new(value);
    }
}
