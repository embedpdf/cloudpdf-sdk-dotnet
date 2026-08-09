// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItemLinkTarget.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItemLinkTarget
{
    internal DocAnnotationsList200ResponseAnnotationsItemLinkTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Goto"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Goto value
    )
    {
        Kind = "goto";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Uri"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Uri value
    )
    {
        Kind = "uri";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.GotoRemote"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.GotoRemote value
    )
    {
        Kind = "goto-remote";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Launch"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Launch value
    )
    {
        Kind = "launch";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Javascript"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Javascript value
    )
    {
        Kind = "javascript";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Named"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Named value
    )
    {
        Kind = "named";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItemLinkTarget with <see cref="DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Unsupported"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Unsupported value
    )
    {
        Kind = "unsupported";
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
    /// Returns true if <see cref="Kind"/> is "goto"
    /// </summary>
    public bool IsGoto => Kind == "goto";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "uri"
    /// </summary>
    public bool IsUri => Kind == "uri";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "goto-remote"
    /// </summary>
    public bool IsGotoRemote => Kind == "goto-remote";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "launch"
    /// </summary>
    public bool IsLaunch => Kind == "launch";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "javascript"
    /// </summary>
    public bool IsJavascript => Kind == "javascript";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "named"
    /// </summary>
    public bool IsNamed => Kind == "named";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "unsupported"
    /// </summary>
    public bool IsUnsupported => Kind == "unsupported";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto"/> if <see cref="Kind"/> is 'goto', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto AsGoto() =>
        IsGoto
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'goto'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri"/> if <see cref="Kind"/> is 'uri', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'uri'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri AsUri() =>
        IsUri
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'uri'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote"/> if <see cref="Kind"/> is 'goto-remote', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto-remote'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote AsGotoRemote() =>
        IsGotoRemote
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'goto-remote'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch"/> if <see cref="Kind"/> is 'launch', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'launch'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch AsLaunch() =>
        IsLaunch
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'launch'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript"/> if <see cref="Kind"/> is 'javascript', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'javascript'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript AsJavascript() =>
        IsJavascript
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'javascript'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed"/> if <see cref="Kind"/> is 'named', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'named'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed AsNamed() =>
        IsNamed
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'named'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto, T> onGoto,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri, T> onUri,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote,
            T
        > onGotoRemote,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch, T> onLaunch,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript,
            T
        > onJavascript,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed, T> onNamed,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported,
            T
        > onUnsupported,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "goto" => onGoto(AsGoto()),
            "uri" => onUri(AsUri()),
            "goto-remote" => onGotoRemote(AsGotoRemote()),
            "launch" => onLaunch(AsLaunch()),
            "javascript" => onJavascript(AsJavascript()),
            "named" => onNamed(AsNamed()),
            "unsupported" => onUnsupported(AsUnsupported()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto> onGoto,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri> onUri,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote> onGotoRemote,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch> onLaunch,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript> onJavascript,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed> onNamed,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported> onUnsupported,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "goto":
                onGoto(AsGoto());
                break;
            case "uri":
                onUri(AsUri());
                break;
            case "goto-remote":
                onGotoRemote(AsGotoRemote());
                break;
            case "launch":
                onLaunch(AsLaunch());
                break;
            case "javascript":
                onJavascript(AsJavascript());
                break;
            case "named":
                onNamed(AsNamed());
                break;
            case "unsupported":
                onUnsupported(AsUnsupported());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto? value
    )
    {
        if (Kind == "goto")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri"/> and returns true if successful.
    /// </summary>
    public bool TryAsUri(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri? value
    )
    {
        if (Kind == "uri")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote"/> and returns true if successful.
    /// </summary>
    public bool TryAsGotoRemote(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote? value
    )
    {
        if (Kind == "goto-remote")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch"/> and returns true if successful.
    /// </summary>
    public bool TryAsLaunch(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch? value
    )
    {
        if (Kind == "launch")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript"/> and returns true if successful.
    /// </summary>
    public bool TryAsJavascript(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript? value
    )
    {
        if (Kind == "javascript")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed"/> and returns true if successful.
    /// </summary>
    public bool TryAsNamed(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed? value
    )
    {
        if (Kind == "named")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Goto value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Uri value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.GotoRemote value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Launch value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Javascript value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Named value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
        DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemLinkTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItemLinkTarget).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsList200ResponseAnnotationsItemLinkTarget Read(
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
                "goto" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto"
                        ),
                "uri" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri"
                        ),
                "goto-remote" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote"
                        ),
                "launch" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch"
                        ),
                "javascript" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript"
                        ),
                "named" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItemLinkTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLinkTarget value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "goto" => JsonSerializer.SerializeToNode(value.Value, options),
                    "uri" => JsonSerializer.SerializeToNode(value.Value, options),
                    "goto-remote" => JsonSerializer.SerializeToNode(value.Value, options),
                    "launch" => JsonSerializer.SerializeToNode(value.Value, options),
                    "javascript" => JsonSerializer.SerializeToNode(value.Value, options),
                    "named" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unsupported" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemLinkTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItemLinkTarget(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLinkTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for goto
    /// </summary>
    [Serializable]
    public struct Goto
    {
        public Goto(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Goto(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGoto value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for uri
    /// </summary>
    [Serializable]
    public struct Uri
    {
        public Uri(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Uri(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUri value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto-remote
    /// </summary>
    [Serializable]
    public struct GotoRemote
    {
        public GotoRemote(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.GotoRemote(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetGotoRemote value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for launch
    /// </summary>
    [Serializable]
    public struct Launch
    {
        public Launch(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Launch(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetLaunch value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for javascript
    /// </summary>
    [Serializable]
    public struct Javascript
    {
        public Javascript(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Javascript(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetJavascript value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for named
    /// </summary>
    [Serializable]
    public struct Named
    {
        public Named(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Named(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetNamed value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItemLinkTarget.Unsupported(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLinkTargetUnsupported value
        ) => new(value);
    }
}
