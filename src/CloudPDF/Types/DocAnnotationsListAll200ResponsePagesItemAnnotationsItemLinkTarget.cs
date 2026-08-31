// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.JsonConverter)
)]
[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget
{
    internal DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        string type,
        object? value
    )
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Goto"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Goto value
    )
    {
        Kind = "goto";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Uri"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Uri value
    )
    {
        Kind = "uri";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.GotoRemote"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.GotoRemote value
    )
    {
        Kind = "goto-remote";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Launch"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Launch value
    )
    {
        Kind = "launch";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Javascript"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Javascript value
    )
    {
        Kind = "javascript";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Named"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Named value
    )
    {
        Kind = "named";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Unsupported"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto"/> if <see cref="Kind"/> is 'goto', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto AsGoto() =>
        IsGoto
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'goto'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri"/> if <see cref="Kind"/> is 'uri', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'uri'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri AsUri() =>
        IsUri
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'uri'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote"/> if <see cref="Kind"/> is 'goto-remote', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto-remote'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote AsGotoRemote() =>
        IsGotoRemote
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'goto-remote'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch"/> if <see cref="Kind"/> is 'launch', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'launch'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch AsLaunch() =>
        IsLaunch
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'launch'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript"/> if <see cref="Kind"/> is 'javascript', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'javascript'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript AsJavascript() =>
        IsJavascript
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'javascript'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed"/> if <see cref="Kind"/> is 'named', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'named'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed AsNamed() =>
        IsNamed
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'named'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Kind is not 'unsupported'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto,
            T
        > onGoto,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri,
            T
        > onUri,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote,
            T
        > onGotoRemote,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch,
            T
        > onLaunch,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript,
            T
        > onJavascript,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed,
            T
        > onNamed,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported,
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
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto> onGoto,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri> onUri,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote> onGotoRemote,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch> onLaunch,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript> onJavascript,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed> onNamed,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto? value
    )
    {
        if (Kind == "goto")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri"/> and returns true if successful.
    /// </summary>
    public bool TryAsUri(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri? value
    )
    {
        if (Kind == "uri")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote"/> and returns true if successful.
    /// </summary>
    public bool TryAsGotoRemote(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote? value
    )
    {
        if (Kind == "goto-remote")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch"/> and returns true if successful.
    /// </summary>
    public bool TryAsLaunch(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch? value
    )
    {
        if (Kind == "launch")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript"/> and returns true if successful.
    /// </summary>
    public bool TryAsJavascript(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript? value
    )
    {
        if (Kind == "javascript")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed"/> and returns true if successful.
    /// </summary>
    public bool TryAsNamed(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed? value
    )
    {
        if (Kind == "named")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported? value
    )
    {
        if (Kind == "unsupported")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Goto value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Uri value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.GotoRemote value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Launch value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Javascript value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Named value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto"
                        ),
                "uri" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri"
                        ),
                "goto-remote" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote"
                        ),
                "launch" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch"
                        ),
                "javascript" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript"
                        ),
                "named" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget value,
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

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget value,
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
        public Goto(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Goto(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGoto value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for uri
    /// </summary>
    [Serializable]
    public struct Uri
    {
        public Uri(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Uri(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUri value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto-remote
    /// </summary>
    [Serializable]
    public struct GotoRemote
    {
        public GotoRemote(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.GotoRemote(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoRemote value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for launch
    /// </summary>
    [Serializable]
    public struct Launch
    {
        public Launch(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Launch(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetLaunch value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for javascript
    /// </summary>
    [Serializable]
    public struct Javascript
    {
        public Javascript(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Javascript(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetJavascript value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for named
    /// </summary>
    [Serializable]
    public struct Named
    {
        public Named(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Named(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetNamed value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTarget.Unsupported(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetUnsupported value
        ) => new(value);
    }
}
