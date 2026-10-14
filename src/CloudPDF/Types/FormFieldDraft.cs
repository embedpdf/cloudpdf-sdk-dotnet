// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldDraft.JsonConverter))]
[Serializable]
public record FormFieldDraft
{
    internal FormFieldDraft(string type, object? value)
    {
        Family = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Text"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Text value)
    {
        Family = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Checkbox"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Checkbox value)
    {
        Family = "checkbox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Radio"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Radio value)
    {
        Family = "radio";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Combobox"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Combobox value)
    {
        Family = "combobox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Listbox"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Listbox value)
    {
        Family = "listbox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Pushbutton"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Pushbutton value)
    {
        Family = "pushbutton";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldDraft with <see cref="FormFieldDraft.Signature"/>.
    /// </summary>
    public FormFieldDraft(FormFieldDraft.Signature value)
    {
        Family = "signature";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("family")]
    public string Family { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Family"/> is "text"
    /// </summary>
    public bool IsText => Family == "text";

    /// <summary>
    /// Returns true if <see cref="Family"/> is "checkbox"
    /// </summary>
    public bool IsCheckbox => Family == "checkbox";

    /// <summary>
    /// Returns true if <see cref="Family"/> is "radio"
    /// </summary>
    public bool IsRadio => Family == "radio";

    /// <summary>
    /// Returns true if <see cref="Family"/> is "combobox"
    /// </summary>
    public bool IsCombobox => Family == "combobox";

    /// <summary>
    /// Returns true if <see cref="Family"/> is "listbox"
    /// </summary>
    public bool IsListbox => Family == "listbox";

    /// <summary>
    /// Returns true if <see cref="Family"/> is "pushbutton"
    /// </summary>
    public bool IsPushbutton => Family == "pushbutton";

    /// <summary>
    /// Returns true if <see cref="Family"/> is "signature"
    /// </summary>
    public bool IsSignature => Family == "signature";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftText"/> if <see cref="Family"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'text'.</exception>
    public CloudPDF.FormFieldDraftText AsText() =>
        IsText
            ? (CloudPDF.FormFieldDraftText)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftCheckbox"/> if <see cref="Family"/> is 'checkbox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'checkbox'.</exception>
    public CloudPDF.FormFieldDraftCheckbox AsCheckbox() =>
        IsCheckbox
            ? (CloudPDF.FormFieldDraftCheckbox)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'checkbox'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftRadio"/> if <see cref="Family"/> is 'radio', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'radio'.</exception>
    public CloudPDF.FormFieldDraftRadio AsRadio() =>
        IsRadio
            ? (CloudPDF.FormFieldDraftRadio)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'radio'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftCombobox"/> if <see cref="Family"/> is 'combobox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'combobox'.</exception>
    public CloudPDF.FormFieldDraftCombobox AsCombobox() =>
        IsCombobox
            ? (CloudPDF.FormFieldDraftCombobox)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'combobox'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftListbox"/> if <see cref="Family"/> is 'listbox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'listbox'.</exception>
    public CloudPDF.FormFieldDraftListbox AsListbox() =>
        IsListbox
            ? (CloudPDF.FormFieldDraftListbox)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'listbox'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftPushbutton"/> if <see cref="Family"/> is 'pushbutton', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'pushbutton'.</exception>
    public CloudPDF.FormFieldDraftPushbutton AsPushbutton() =>
        IsPushbutton
            ? (CloudPDF.FormFieldDraftPushbutton)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'pushbutton'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldDraftSignature"/> if <see cref="Family"/> is 'signature', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'signature'.</exception>
    public CloudPDF.FormFieldDraftSignature AsSignature() =>
        IsSignature
            ? (CloudPDF.FormFieldDraftSignature)Value!
            : throw new global::System.Exception("FormFieldDraft.Family is not 'signature'");

    public T Match<T>(
        Func<CloudPDF.FormFieldDraftText, T> onText,
        Func<CloudPDF.FormFieldDraftCheckbox, T> onCheckbox,
        Func<CloudPDF.FormFieldDraftRadio, T> onRadio,
        Func<CloudPDF.FormFieldDraftCombobox, T> onCombobox,
        Func<CloudPDF.FormFieldDraftListbox, T> onListbox,
        Func<CloudPDF.FormFieldDraftPushbutton, T> onPushbutton,
        Func<CloudPDF.FormFieldDraftSignature, T> onSignature,
        Func<string, object?, T> onUnknown_
    )
    {
        return Family switch
        {
            "text" => onText(AsText()),
            "checkbox" => onCheckbox(AsCheckbox()),
            "radio" => onRadio(AsRadio()),
            "combobox" => onCombobox(AsCombobox()),
            "listbox" => onListbox(AsListbox()),
            "pushbutton" => onPushbutton(AsPushbutton()),
            "signature" => onSignature(AsSignature()),
            _ => onUnknown_(Family, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.FormFieldDraftText> onText,
        Action<CloudPDF.FormFieldDraftCheckbox> onCheckbox,
        Action<CloudPDF.FormFieldDraftRadio> onRadio,
        Action<CloudPDF.FormFieldDraftCombobox> onCombobox,
        Action<CloudPDF.FormFieldDraftListbox> onListbox,
        Action<CloudPDF.FormFieldDraftPushbutton> onPushbutton,
        Action<CloudPDF.FormFieldDraftSignature> onSignature,
        Action<string, object?> onUnknown_
    )
    {
        switch (Family)
        {
            case "text":
                onText(AsText());
                break;
            case "checkbox":
                onCheckbox(AsCheckbox());
                break;
            case "radio":
                onRadio(AsRadio());
                break;
            case "combobox":
                onCombobox(AsCombobox());
                break;
            case "listbox":
                onListbox(AsListbox());
                break;
            case "pushbutton":
                onPushbutton(AsPushbutton());
                break;
            case "signature":
                onSignature(AsSignature());
                break;
            default:
                onUnknown_(Family, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudPDF.FormFieldDraftText? value)
    {
        if (Family == "text")
        {
            value = (CloudPDF.FormFieldDraftText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftCheckbox"/> and returns true if successful.
    /// </summary>
    public bool TryAsCheckbox(out CloudPDF.FormFieldDraftCheckbox? value)
    {
        if (Family == "checkbox")
        {
            value = (CloudPDF.FormFieldDraftCheckbox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftRadio"/> and returns true if successful.
    /// </summary>
    public bool TryAsRadio(out CloudPDF.FormFieldDraftRadio? value)
    {
        if (Family == "radio")
        {
            value = (CloudPDF.FormFieldDraftRadio)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftCombobox"/> and returns true if successful.
    /// </summary>
    public bool TryAsCombobox(out CloudPDF.FormFieldDraftCombobox? value)
    {
        if (Family == "combobox")
        {
            value = (CloudPDF.FormFieldDraftCombobox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftListbox"/> and returns true if successful.
    /// </summary>
    public bool TryAsListbox(out CloudPDF.FormFieldDraftListbox? value)
    {
        if (Family == "listbox")
        {
            value = (CloudPDF.FormFieldDraftListbox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftPushbutton"/> and returns true if successful.
    /// </summary>
    public bool TryAsPushbutton(out CloudPDF.FormFieldDraftPushbutton? value)
    {
        if (Family == "pushbutton")
        {
            value = (CloudPDF.FormFieldDraftPushbutton)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldDraftSignature"/> and returns true if successful.
    /// </summary>
    public bool TryAsSignature(out CloudPDF.FormFieldDraftSignature? value)
    {
        if (Family == "signature")
        {
            value = (CloudPDF.FormFieldDraftSignature)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldDraft(FormFieldDraft.Text value) => new(value);

    public static implicit operator FormFieldDraft(FormFieldDraft.Checkbox value) => new(value);

    public static implicit operator FormFieldDraft(FormFieldDraft.Radio value) => new(value);

    public static implicit operator FormFieldDraft(FormFieldDraft.Combobox value) => new(value);

    public static implicit operator FormFieldDraft(FormFieldDraft.Listbox value) => new(value);

    public static implicit operator FormFieldDraft(FormFieldDraft.Pushbutton value) => new(value);

    public static implicit operator FormFieldDraft(FormFieldDraft.Signature value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldDraft>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldDraft).IsAssignableFrom(typeToConvert);

        public override FormFieldDraft Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("family", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'family'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'family' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'family' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'family' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("family");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "text" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftText?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldDraftText"),
                "checkbox" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftCheckbox?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldDraftCheckbox"
                        ),
                "radio" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftRadio?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldDraftRadio"),
                "combobox" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftCombobox?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldDraftCombobox"
                        ),
                "listbox" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftListbox?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.FormFieldDraftListbox"
                    ),
                "pushbutton" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftPushbutton?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldDraftPushbutton"
                        ),
                "signature" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldDraftSignature?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.FormFieldDraftSignature"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldDraft(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldDraft value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Family switch
                {
                    "text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "checkbox" => JsonSerializer.SerializeToNode(value.Value, options),
                    "radio" => JsonSerializer.SerializeToNode(value.Value, options),
                    "combobox" => JsonSerializer.SerializeToNode(value.Value, options),
                    "listbox" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pushbutton" => JsonSerializer.SerializeToNode(value.Value, options),
                    "signature" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["family"] = value.Family;
            json.WriteTo(writer, options);
        }

        public override FormFieldDraft ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldDraft(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldDraft value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Family);
        }
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudPDF.FormFieldDraftText value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Text(CloudPDF.FormFieldDraftText value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for checkbox
    /// </summary>
    [Serializable]
    public struct Checkbox
    {
        public Checkbox(CloudPDF.FormFieldDraftCheckbox value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftCheckbox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Checkbox(
            CloudPDF.FormFieldDraftCheckbox value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for radio
    /// </summary>
    [Serializable]
    public struct Radio
    {
        public Radio(CloudPDF.FormFieldDraftRadio value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftRadio Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Radio(CloudPDF.FormFieldDraftRadio value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for combobox
    /// </summary>
    [Serializable]
    public struct Combobox
    {
        public Combobox(CloudPDF.FormFieldDraftCombobox value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftCombobox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Combobox(
            CloudPDF.FormFieldDraftCombobox value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for listbox
    /// </summary>
    [Serializable]
    public struct Listbox
    {
        public Listbox(CloudPDF.FormFieldDraftListbox value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftListbox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Listbox(
            CloudPDF.FormFieldDraftListbox value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pushbutton
    /// </summary>
    [Serializable]
    public struct Pushbutton
    {
        public Pushbutton(CloudPDF.FormFieldDraftPushbutton value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftPushbutton Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Pushbutton(
            CloudPDF.FormFieldDraftPushbutton value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for signature
    /// </summary>
    [Serializable]
    public struct Signature
    {
        public Signature(CloudPDF.FormFieldDraftSignature value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldDraftSignature Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldDraft.Signature(
            CloudPDF.FormFieldDraftSignature value
        ) => new(value);
    }
}
