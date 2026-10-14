// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfActionWrite.JsonConverter))]
[Serializable]
public record PdfActionWrite
{
    internal PdfActionWrite(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.Javascript"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.Javascript value)
    {
        Type = "javascript";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.Goto"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.Goto value)
    {
        Type = "goto";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.Uri"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.Uri value)
    {
        Type = "uri";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.Named"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.Named value)
    {
        Type = "named";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.Hide"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.Hide value)
    {
        Type = "hide";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.ResetForm"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.ResetForm value)
    {
        Type = "reset-form";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionWrite with <see cref="PdfActionWrite.SubmitForm"/>.
    /// </summary>
    public PdfActionWrite(PdfActionWrite.SubmitForm value)
    {
        Type = "submit-form";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "javascript"
    /// </summary>
    public bool IsJavascript => Type == "javascript";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "goto"
    /// </summary>
    public bool IsGoto => Type == "goto";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "uri"
    /// </summary>
    public bool IsUri => Type == "uri";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "named"
    /// </summary>
    public bool IsNamed => Type == "named";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "hide"
    /// </summary>
    public bool IsHide => Type == "hide";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "reset-form"
    /// </summary>
    public bool IsResetForm => Type == "reset-form";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "submit-form"
    /// </summary>
    public bool IsSubmitForm => Type == "submit-form";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteJavascript"/> if <see cref="Type"/> is 'javascript', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'javascript'.</exception>
    public CloudPDF.PdfActionWriteJavascript AsJavascript() =>
        IsJavascript
            ? (CloudPDF.PdfActionWriteJavascript)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'javascript'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteGoto"/> if <see cref="Type"/> is 'goto', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'goto'.</exception>
    public CloudPDF.PdfActionWriteGoto AsGoto() =>
        IsGoto
            ? (CloudPDF.PdfActionWriteGoto)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'goto'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteUri"/> if <see cref="Type"/> is 'uri', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'uri'.</exception>
    public CloudPDF.PdfActionWriteUri AsUri() =>
        IsUri
            ? (CloudPDF.PdfActionWriteUri)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'uri'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteNamed"/> if <see cref="Type"/> is 'named', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'named'.</exception>
    public CloudPDF.PdfActionWriteNamed AsNamed() =>
        IsNamed
            ? (CloudPDF.PdfActionWriteNamed)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'named'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteHide"/> if <see cref="Type"/> is 'hide', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'hide'.</exception>
    public CloudPDF.PdfActionWriteHide AsHide() =>
        IsHide
            ? (CloudPDF.PdfActionWriteHide)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'hide'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteResetForm"/> if <see cref="Type"/> is 'reset-form', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'reset-form'.</exception>
    public CloudPDF.PdfActionWriteResetForm AsResetForm() =>
        IsResetForm
            ? (CloudPDF.PdfActionWriteResetForm)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'reset-form'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionWriteSubmitForm"/> if <see cref="Type"/> is 'submit-form', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'submit-form'.</exception>
    public CloudPDF.PdfActionWriteSubmitForm AsSubmitForm() =>
        IsSubmitForm
            ? (CloudPDF.PdfActionWriteSubmitForm)Value!
            : throw new global::System.Exception("PdfActionWrite.Type is not 'submit-form'");

    public T Match<T>(
        Func<CloudPDF.PdfActionWriteJavascript, T> onJavascript,
        Func<CloudPDF.PdfActionWriteGoto, T> onGoto,
        Func<CloudPDF.PdfActionWriteUri, T> onUri,
        Func<CloudPDF.PdfActionWriteNamed, T> onNamed,
        Func<CloudPDF.PdfActionWriteHide, T> onHide,
        Func<CloudPDF.PdfActionWriteResetForm, T> onResetForm,
        Func<CloudPDF.PdfActionWriteSubmitForm, T> onSubmitForm,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "javascript" => onJavascript(AsJavascript()),
            "goto" => onGoto(AsGoto()),
            "uri" => onUri(AsUri()),
            "named" => onNamed(AsNamed()),
            "hide" => onHide(AsHide()),
            "reset-form" => onResetForm(AsResetForm()),
            "submit-form" => onSubmitForm(AsSubmitForm()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.PdfActionWriteJavascript> onJavascript,
        Action<CloudPDF.PdfActionWriteGoto> onGoto,
        Action<CloudPDF.PdfActionWriteUri> onUri,
        Action<CloudPDF.PdfActionWriteNamed> onNamed,
        Action<CloudPDF.PdfActionWriteHide> onHide,
        Action<CloudPDF.PdfActionWriteResetForm> onResetForm,
        Action<CloudPDF.PdfActionWriteSubmitForm> onSubmitForm,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "javascript":
                onJavascript(AsJavascript());
                break;
            case "goto":
                onGoto(AsGoto());
                break;
            case "uri":
                onUri(AsUri());
                break;
            case "named":
                onNamed(AsNamed());
                break;
            case "hide":
                onHide(AsHide());
                break;
            case "reset-form":
                onResetForm(AsResetForm());
                break;
            case "submit-form":
                onSubmitForm(AsSubmitForm());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteJavascript"/> and returns true if successful.
    /// </summary>
    public bool TryAsJavascript(out CloudPDF.PdfActionWriteJavascript? value)
    {
        if (Type == "javascript")
        {
            value = (CloudPDF.PdfActionWriteJavascript)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteGoto"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto(out CloudPDF.PdfActionWriteGoto? value)
    {
        if (Type == "goto")
        {
            value = (CloudPDF.PdfActionWriteGoto)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteUri"/> and returns true if successful.
    /// </summary>
    public bool TryAsUri(out CloudPDF.PdfActionWriteUri? value)
    {
        if (Type == "uri")
        {
            value = (CloudPDF.PdfActionWriteUri)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteNamed"/> and returns true if successful.
    /// </summary>
    public bool TryAsNamed(out CloudPDF.PdfActionWriteNamed? value)
    {
        if (Type == "named")
        {
            value = (CloudPDF.PdfActionWriteNamed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteHide"/> and returns true if successful.
    /// </summary>
    public bool TryAsHide(out CloudPDF.PdfActionWriteHide? value)
    {
        if (Type == "hide")
        {
            value = (CloudPDF.PdfActionWriteHide)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteResetForm"/> and returns true if successful.
    /// </summary>
    public bool TryAsResetForm(out CloudPDF.PdfActionWriteResetForm? value)
    {
        if (Type == "reset-form")
        {
            value = (CloudPDF.PdfActionWriteResetForm)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionWriteSubmitForm"/> and returns true if successful.
    /// </summary>
    public bool TryAsSubmitForm(out CloudPDF.PdfActionWriteSubmitForm? value)
    {
        if (Type == "submit-form")
        {
            value = (CloudPDF.PdfActionWriteSubmitForm)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfActionWrite(PdfActionWrite.Javascript value) => new(value);

    public static implicit operator PdfActionWrite(PdfActionWrite.Goto value) => new(value);

    public static implicit operator PdfActionWrite(PdfActionWrite.Uri value) => new(value);

    public static implicit operator PdfActionWrite(PdfActionWrite.Named value) => new(value);

    public static implicit operator PdfActionWrite(PdfActionWrite.Hide value) => new(value);

    public static implicit operator PdfActionWrite(PdfActionWrite.ResetForm value) => new(value);

    public static implicit operator PdfActionWrite(PdfActionWrite.SubmitForm value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfActionWrite>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfActionWrite).IsAssignableFrom(typeToConvert);

        public override PdfActionWrite Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "javascript" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteJavascript?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionWriteJavascript"
                        ),
                "goto" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteGoto?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionWriteGoto"),
                "uri" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteUri?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionWriteUri"),
                "named" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteNamed?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionWriteNamed"),
                "hide" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteHide?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionWriteHide"),
                "reset-form" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteResetForm?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionWriteResetForm"
                        ),
                "submit-form" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionWriteSubmitForm?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionWriteSubmitForm"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfActionWrite(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionWrite value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "javascript" => JsonSerializer.SerializeToNode(value.Value, options),
                    "goto" => JsonSerializer.SerializeToNode(value.Value, options),
                    "uri" => JsonSerializer.SerializeToNode(value.Value, options),
                    "named" => JsonSerializer.SerializeToNode(value.Value, options),
                    "hide" => JsonSerializer.SerializeToNode(value.Value, options),
                    "reset-form" => JsonSerializer.SerializeToNode(value.Value, options),
                    "submit-form" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override PdfActionWrite ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfActionWrite(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionWrite value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for javascript
    /// </summary>
    [Serializable]
    public struct Javascript
    {
        public Javascript(CloudPDF.PdfActionWriteJavascript value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteJavascript Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.Javascript(
            CloudPDF.PdfActionWriteJavascript value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto
    /// </summary>
    [Serializable]
    public struct Goto
    {
        public Goto(CloudPDF.PdfActionWriteGoto value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteGoto Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.Goto(CloudPDF.PdfActionWriteGoto value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for uri
    /// </summary>
    [Serializable]
    public struct Uri
    {
        public Uri(CloudPDF.PdfActionWriteUri value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteUri Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.Uri(CloudPDF.PdfActionWriteUri value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for named
    /// </summary>
    [Serializable]
    public struct Named
    {
        public Named(CloudPDF.PdfActionWriteNamed value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteNamed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.Named(CloudPDF.PdfActionWriteNamed value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for hide
    /// </summary>
    [Serializable]
    public struct Hide
    {
        public Hide(CloudPDF.PdfActionWriteHide value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteHide Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.Hide(CloudPDF.PdfActionWriteHide value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for reset-form
    /// </summary>
    [Serializable]
    public struct ResetForm
    {
        public ResetForm(CloudPDF.PdfActionWriteResetForm value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteResetForm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.ResetForm(
            CloudPDF.PdfActionWriteResetForm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for submit-form
    /// </summary>
    [Serializable]
    public struct SubmitForm
    {
        public SubmitForm(CloudPDF.PdfActionWriteSubmitForm value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionWriteSubmitForm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionWrite.SubmitForm(
            CloudPDF.PdfActionWriteSubmitForm value
        ) => new(value);
    }
}
