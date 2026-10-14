// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfLinkTarget.JsonConverter))]
[Serializable]
public record PdfLinkTarget
{
    internal PdfLinkTarget(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.Goto"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.Goto value)
    {
        Kind = "goto";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.Uri"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.Uri value)
    {
        Kind = "uri";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.GotoRemote"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.GotoRemote value)
    {
        Kind = "goto-remote";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.Launch"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.Launch value)
    {
        Kind = "launch";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.Javascript"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.Javascript value)
    {
        Kind = "javascript";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.Named"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.Named value)
    {
        Kind = "named";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfLinkTarget with <see cref="PdfLinkTarget.Unsupported"/>.
    /// </summary>
    public PdfLinkTarget(PdfLinkTarget.Unsupported value)
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
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetGoto"/> if <see cref="Kind"/> is 'goto', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto'.</exception>
    public CloudPDF.PdfLinkTargetGoto AsGoto() =>
        IsGoto
            ? (CloudPDF.PdfLinkTargetGoto)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'goto'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetUri"/> if <see cref="Kind"/> is 'uri', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'uri'.</exception>
    public CloudPDF.PdfLinkTargetUri AsUri() =>
        IsUri
            ? (CloudPDF.PdfLinkTargetUri)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'uri'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetGotoRemote"/> if <see cref="Kind"/> is 'goto-remote', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'goto-remote'.</exception>
    public CloudPDF.PdfLinkTargetGotoRemote AsGotoRemote() =>
        IsGotoRemote
            ? (CloudPDF.PdfLinkTargetGotoRemote)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'goto-remote'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetLaunch"/> if <see cref="Kind"/> is 'launch', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'launch'.</exception>
    public CloudPDF.PdfLinkTargetLaunch AsLaunch() =>
        IsLaunch
            ? (CloudPDF.PdfLinkTargetLaunch)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'launch'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetJavascript"/> if <see cref="Kind"/> is 'javascript', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'javascript'.</exception>
    public CloudPDF.PdfLinkTargetJavascript AsJavascript() =>
        IsJavascript
            ? (CloudPDF.PdfLinkTargetJavascript)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'javascript'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetNamed"/> if <see cref="Kind"/> is 'named', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'named'.</exception>
    public CloudPDF.PdfLinkTargetNamed AsNamed() =>
        IsNamed
            ? (CloudPDF.PdfLinkTargetNamed)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'named'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfLinkTargetUnsupported"/> if <see cref="Kind"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'unsupported'.</exception>
    public CloudPDF.PdfLinkTargetUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.PdfLinkTargetUnsupported)Value!
            : throw new global::System.Exception("PdfLinkTarget.Kind is not 'unsupported'");

    public T Match<T>(
        Func<CloudPDF.PdfLinkTargetGoto, T> onGoto,
        Func<CloudPDF.PdfLinkTargetUri, T> onUri,
        Func<CloudPDF.PdfLinkTargetGotoRemote, T> onGotoRemote,
        Func<CloudPDF.PdfLinkTargetLaunch, T> onLaunch,
        Func<CloudPDF.PdfLinkTargetJavascript, T> onJavascript,
        Func<CloudPDF.PdfLinkTargetNamed, T> onNamed,
        Func<CloudPDF.PdfLinkTargetUnsupported, T> onUnsupported,
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
        Action<CloudPDF.PdfLinkTargetGoto> onGoto,
        Action<CloudPDF.PdfLinkTargetUri> onUri,
        Action<CloudPDF.PdfLinkTargetGotoRemote> onGotoRemote,
        Action<CloudPDF.PdfLinkTargetLaunch> onLaunch,
        Action<CloudPDF.PdfLinkTargetJavascript> onJavascript,
        Action<CloudPDF.PdfLinkTargetNamed> onNamed,
        Action<CloudPDF.PdfLinkTargetUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetGoto"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto(out CloudPDF.PdfLinkTargetGoto? value)
    {
        if (Kind == "goto")
        {
            value = (CloudPDF.PdfLinkTargetGoto)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetUri"/> and returns true if successful.
    /// </summary>
    public bool TryAsUri(out CloudPDF.PdfLinkTargetUri? value)
    {
        if (Kind == "uri")
        {
            value = (CloudPDF.PdfLinkTargetUri)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetGotoRemote"/> and returns true if successful.
    /// </summary>
    public bool TryAsGotoRemote(out CloudPDF.PdfLinkTargetGotoRemote? value)
    {
        if (Kind == "goto-remote")
        {
            value = (CloudPDF.PdfLinkTargetGotoRemote)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetLaunch"/> and returns true if successful.
    /// </summary>
    public bool TryAsLaunch(out CloudPDF.PdfLinkTargetLaunch? value)
    {
        if (Kind == "launch")
        {
            value = (CloudPDF.PdfLinkTargetLaunch)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetJavascript"/> and returns true if successful.
    /// </summary>
    public bool TryAsJavascript(out CloudPDF.PdfLinkTargetJavascript? value)
    {
        if (Kind == "javascript")
        {
            value = (CloudPDF.PdfLinkTargetJavascript)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetNamed"/> and returns true if successful.
    /// </summary>
    public bool TryAsNamed(out CloudPDF.PdfLinkTargetNamed? value)
    {
        if (Kind == "named")
        {
            value = (CloudPDF.PdfLinkTargetNamed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfLinkTargetUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.PdfLinkTargetUnsupported? value)
    {
        if (Kind == "unsupported")
        {
            value = (CloudPDF.PdfLinkTargetUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.Goto value) => new(value);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.Uri value) => new(value);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.GotoRemote value) => new(value);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.Launch value) => new(value);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.Javascript value) => new(value);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.Named value) => new(value);

    public static implicit operator PdfLinkTarget(PdfLinkTarget.Unsupported value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfLinkTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfLinkTarget).IsAssignableFrom(typeToConvert);

        public override PdfLinkTarget Read(
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
                "goto" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetGoto?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfLinkTargetGoto"),
                "uri" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetUri?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfLinkTargetUri"),
                "goto-remote" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetGotoRemote?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfLinkTargetGotoRemote"
                        ),
                "launch" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetLaunch?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfLinkTargetLaunch"),
                "javascript" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetJavascript?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfLinkTargetJavascript"
                        ),
                "named" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetNamed?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfLinkTargetNamed"),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfLinkTargetUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfLinkTargetUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfLinkTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfLinkTarget value,
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

        public override PdfLinkTarget ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfLinkTarget(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfLinkTarget value,
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
        public Goto(CloudPDF.PdfLinkTargetGoto value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetGoto Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.Goto(CloudPDF.PdfLinkTargetGoto value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for uri
    /// </summary>
    [Serializable]
    public struct Uri
    {
        public Uri(CloudPDF.PdfLinkTargetUri value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetUri Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.Uri(CloudPDF.PdfLinkTargetUri value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for goto-remote
    /// </summary>
    [Serializable]
    public struct GotoRemote
    {
        public GotoRemote(CloudPDF.PdfLinkTargetGotoRemote value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetGotoRemote Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.GotoRemote(
            CloudPDF.PdfLinkTargetGotoRemote value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for launch
    /// </summary>
    [Serializable]
    public struct Launch
    {
        public Launch(CloudPDF.PdfLinkTargetLaunch value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetLaunch Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.Launch(CloudPDF.PdfLinkTargetLaunch value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for javascript
    /// </summary>
    [Serializable]
    public struct Javascript
    {
        public Javascript(CloudPDF.PdfLinkTargetJavascript value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetJavascript Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.Javascript(
            CloudPDF.PdfLinkTargetJavascript value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for named
    /// </summary>
    [Serializable]
    public struct Named
    {
        public Named(CloudPDF.PdfLinkTargetNamed value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetNamed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.Named(CloudPDF.PdfLinkTargetNamed value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.PdfLinkTargetUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.PdfLinkTargetUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfLinkTarget.Unsupported(
            CloudPDF.PdfLinkTargetUnsupported value
        ) => new(value);
    }
}
