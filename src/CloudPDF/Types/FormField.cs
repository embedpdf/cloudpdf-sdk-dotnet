// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormField.JsonConverter))]
[Serializable]
public record FormField
{
    internal FormField(string type, object? value)
    {
        Family = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Text"/>.
    /// </summary>
    public FormField(FormField.Text value)
    {
        Family = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Checkbox"/>.
    /// </summary>
    public FormField(FormField.Checkbox value)
    {
        Family = "checkbox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Radio"/>.
    /// </summary>
    public FormField(FormField.Radio value)
    {
        Family = "radio";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Combobox"/>.
    /// </summary>
    public FormField(FormField.Combobox value)
    {
        Family = "combobox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Listbox"/>.
    /// </summary>
    public FormField(FormField.Listbox value)
    {
        Family = "listbox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Pushbutton"/>.
    /// </summary>
    public FormField(FormField.Pushbutton value)
    {
        Family = "pushbutton";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Signature"/>.
    /// </summary>
    public FormField(FormField.Signature value)
    {
        Family = "signature";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormField with <see cref="FormField.Unknown"/>.
    /// </summary>
    public FormField(FormField.Unknown value)
    {
        Family = "unknown";
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
    /// Returns true if <see cref="Family"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Family == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldText"/> if <see cref="Family"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'text'.</exception>
    public CloudPDF.FormFieldText AsText() =>
        IsText
            ? (CloudPDF.FormFieldText)Value!
            : throw new global::System.Exception("FormField.Family is not 'text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldCheckbox"/> if <see cref="Family"/> is 'checkbox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'checkbox'.</exception>
    public CloudPDF.FormFieldCheckbox AsCheckbox() =>
        IsCheckbox
            ? (CloudPDF.FormFieldCheckbox)Value!
            : throw new global::System.Exception("FormField.Family is not 'checkbox'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldRadio"/> if <see cref="Family"/> is 'radio', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'radio'.</exception>
    public CloudPDF.FormFieldRadio AsRadio() =>
        IsRadio
            ? (CloudPDF.FormFieldRadio)Value!
            : throw new global::System.Exception("FormField.Family is not 'radio'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldCombobox"/> if <see cref="Family"/> is 'combobox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'combobox'.</exception>
    public CloudPDF.FormFieldCombobox AsCombobox() =>
        IsCombobox
            ? (CloudPDF.FormFieldCombobox)Value!
            : throw new global::System.Exception("FormField.Family is not 'combobox'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldListbox"/> if <see cref="Family"/> is 'listbox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'listbox'.</exception>
    public CloudPDF.FormFieldListbox AsListbox() =>
        IsListbox
            ? (CloudPDF.FormFieldListbox)Value!
            : throw new global::System.Exception("FormField.Family is not 'listbox'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldPushbutton"/> if <see cref="Family"/> is 'pushbutton', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'pushbutton'.</exception>
    public CloudPDF.FormFieldPushbutton AsPushbutton() =>
        IsPushbutton
            ? (CloudPDF.FormFieldPushbutton)Value!
            : throw new global::System.Exception("FormField.Family is not 'pushbutton'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldSignature"/> if <see cref="Family"/> is 'signature', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'signature'.</exception>
    public CloudPDF.FormFieldSignature AsSignature() =>
        IsSignature
            ? (CloudPDF.FormFieldSignature)Value!
            : throw new global::System.Exception("FormField.Family is not 'signature'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldUnknown"/> if <see cref="Family"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'unknown'.</exception>
    public CloudPDF.FormFieldUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.FormFieldUnknown)Value!
            : throw new global::System.Exception("FormField.Family is not 'unknown'");

    public T Match<T>(
        Func<CloudPDF.FormFieldText, T> onText,
        Func<CloudPDF.FormFieldCheckbox, T> onCheckbox,
        Func<CloudPDF.FormFieldRadio, T> onRadio,
        Func<CloudPDF.FormFieldCombobox, T> onCombobox,
        Func<CloudPDF.FormFieldListbox, T> onListbox,
        Func<CloudPDF.FormFieldPushbutton, T> onPushbutton,
        Func<CloudPDF.FormFieldSignature, T> onSignature,
        Func<CloudPDF.FormFieldUnknown, T> onUnknown,
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
            "unknown" => onUnknown(AsUnknown()),
            _ => onUnknown_(Family, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.FormFieldText> onText,
        Action<CloudPDF.FormFieldCheckbox> onCheckbox,
        Action<CloudPDF.FormFieldRadio> onRadio,
        Action<CloudPDF.FormFieldCombobox> onCombobox,
        Action<CloudPDF.FormFieldListbox> onListbox,
        Action<CloudPDF.FormFieldPushbutton> onPushbutton,
        Action<CloudPDF.FormFieldSignature> onSignature,
        Action<CloudPDF.FormFieldUnknown> onUnknown,
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
            case "unknown":
                onUnknown(AsUnknown());
                break;
            default:
                onUnknown_(Family, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudPDF.FormFieldText? value)
    {
        if (Family == "text")
        {
            value = (CloudPDF.FormFieldText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldCheckbox"/> and returns true if successful.
    /// </summary>
    public bool TryAsCheckbox(out CloudPDF.FormFieldCheckbox? value)
    {
        if (Family == "checkbox")
        {
            value = (CloudPDF.FormFieldCheckbox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldRadio"/> and returns true if successful.
    /// </summary>
    public bool TryAsRadio(out CloudPDF.FormFieldRadio? value)
    {
        if (Family == "radio")
        {
            value = (CloudPDF.FormFieldRadio)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldCombobox"/> and returns true if successful.
    /// </summary>
    public bool TryAsCombobox(out CloudPDF.FormFieldCombobox? value)
    {
        if (Family == "combobox")
        {
            value = (CloudPDF.FormFieldCombobox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldListbox"/> and returns true if successful.
    /// </summary>
    public bool TryAsListbox(out CloudPDF.FormFieldListbox? value)
    {
        if (Family == "listbox")
        {
            value = (CloudPDF.FormFieldListbox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldPushbutton"/> and returns true if successful.
    /// </summary>
    public bool TryAsPushbutton(out CloudPDF.FormFieldPushbutton? value)
    {
        if (Family == "pushbutton")
        {
            value = (CloudPDF.FormFieldPushbutton)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldSignature"/> and returns true if successful.
    /// </summary>
    public bool TryAsSignature(out CloudPDF.FormFieldSignature? value)
    {
        if (Family == "signature")
        {
            value = (CloudPDF.FormFieldSignature)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.FormFieldUnknown? value)
    {
        if (Family == "unknown")
        {
            value = (CloudPDF.FormFieldUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormField(FormField.Text value) => new(value);

    public static implicit operator FormField(FormField.Checkbox value) => new(value);

    public static implicit operator FormField(FormField.Radio value) => new(value);

    public static implicit operator FormField(FormField.Combobox value) => new(value);

    public static implicit operator FormField(FormField.Listbox value) => new(value);

    public static implicit operator FormField(FormField.Pushbutton value) => new(value);

    public static implicit operator FormField(FormField.Signature value) => new(value);

    public static implicit operator FormField(FormField.Unknown value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormField>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormField).IsAssignableFrom(typeToConvert);

        public override FormField Read(
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
                "text" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldText?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldText"),
                "checkbox" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldCheckbox?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldCheckbox"),
                "radio" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldRadio?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldRadio"),
                "combobox" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldCombobox?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldCombobox"),
                "listbox" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldListbox?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldListbox"),
                "pushbutton" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldPushbutton?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldPushbutton"),
                "signature" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldSignature?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldSignature"),
                "unknown" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldUnknown?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldUnknown"),
                _ => json.Deserialize<object?>(options),
            };
            return new FormField(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormField value,
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
                    "unknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["family"] = value.Family;
            json.WriteTo(writer, options);
        }

        public override FormField ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormField(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormField value,
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
        public Text(CloudPDF.FormFieldText value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Text(CloudPDF.FormFieldText value) => new(value);
    }

    /// <summary>
    /// Discriminated union type for checkbox
    /// </summary>
    [Serializable]
    public struct Checkbox
    {
        public Checkbox(CloudPDF.FormFieldCheckbox value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldCheckbox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Checkbox(CloudPDF.FormFieldCheckbox value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for radio
    /// </summary>
    [Serializable]
    public struct Radio
    {
        public Radio(CloudPDF.FormFieldRadio value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldRadio Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Radio(CloudPDF.FormFieldRadio value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for combobox
    /// </summary>
    [Serializable]
    public struct Combobox
    {
        public Combobox(CloudPDF.FormFieldCombobox value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldCombobox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Combobox(CloudPDF.FormFieldCombobox value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for listbox
    /// </summary>
    [Serializable]
    public struct Listbox
    {
        public Listbox(CloudPDF.FormFieldListbox value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldListbox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Listbox(CloudPDF.FormFieldListbox value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for pushbutton
    /// </summary>
    [Serializable]
    public struct Pushbutton
    {
        public Pushbutton(CloudPDF.FormFieldPushbutton value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldPushbutton Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Pushbutton(CloudPDF.FormFieldPushbutton value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for signature
    /// </summary>
    [Serializable]
    public struct Signature
    {
        public Signature(CloudPDF.FormFieldSignature value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldSignature Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Signature(CloudPDF.FormFieldSignature value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.FormFieldUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormField.Unknown(CloudPDF.FormFieldUnknown value) =>
            new(value);
    }
}
