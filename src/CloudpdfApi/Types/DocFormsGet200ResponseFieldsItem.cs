// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocFormsGet200ResponseFieldsItem.JsonConverter))]
[Serializable]
public record DocFormsGet200ResponseFieldsItem
{
    internal DocFormsGet200ResponseFieldsItem(string type, object? value)
    {
        Family = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Text"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Text value)
    {
        Family = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Checkbox"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Checkbox value)
    {
        Family = "checkbox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Radio"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Radio value)
    {
        Family = "radio";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Combobox"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Combobox value)
    {
        Family = "combobox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Listbox"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Listbox value)
    {
        Family = "listbox";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Pushbutton"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Pushbutton value)
    {
        Family = "pushbutton";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Signature"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Signature value)
    {
        Family = "signature";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocFormsGet200ResponseFieldsItem with <see cref="DocFormsGet200ResponseFieldsItem.Unknown"/>.
    /// </summary>
    public DocFormsGet200ResponseFieldsItem(DocFormsGet200ResponseFieldsItem.Unknown value)
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
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemText"/> if <see cref="Family"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'text'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemText AsText() =>
        IsText
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemText)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox"/> if <see cref="Family"/> is 'checkbox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'checkbox'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox AsCheckbox() =>
        IsCheckbox
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'checkbox'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio"/> if <see cref="Family"/> is 'radio', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'radio'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio AsRadio() =>
        IsRadio
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'radio'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox"/> if <see cref="Family"/> is 'combobox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'combobox'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox AsCombobox() =>
        IsCombobox
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'combobox'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox"/> if <see cref="Family"/> is 'listbox', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'listbox'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox AsListbox() =>
        IsListbox
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'listbox'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton"/> if <see cref="Family"/> is 'pushbutton', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'pushbutton'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton AsPushbutton() =>
        IsPushbutton
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'pushbutton'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature"/> if <see cref="Family"/> is 'signature', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'signature'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature AsSignature() =>
        IsSignature
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'signature'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown"/> if <see cref="Family"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Family"/> is not 'unknown'.</exception>
    public CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown AsUnknown() =>
        IsUnknown
            ? (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown)Value!
            : throw new global::System.Exception(
                "DocFormsGet200ResponseFieldsItem.Family is not 'unknown'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemText, T> onText,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox, T> onCheckbox,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio, T> onRadio,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox, T> onCombobox,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox, T> onListbox,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton, T> onPushbutton,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature, T> onSignature,
        Func<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown, T> onUnknown,
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
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemText> onText,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox> onCheckbox,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio> onRadio,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox> onCombobox,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox> onListbox,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton> onPushbutton,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature> onSignature,
        Action<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown> onUnknown,
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
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudpdfApi.DocFormsGet200ResponseFieldsItemText? value)
    {
        if (Family == "text")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox"/> and returns true if successful.
    /// </summary>
    public bool TryAsCheckbox(out CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox? value)
    {
        if (Family == "checkbox")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio"/> and returns true if successful.
    /// </summary>
    public bool TryAsRadio(out CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio? value)
    {
        if (Family == "radio")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox"/> and returns true if successful.
    /// </summary>
    public bool TryAsCombobox(out CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox? value)
    {
        if (Family == "combobox")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox"/> and returns true if successful.
    /// </summary>
    public bool TryAsListbox(out CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox? value)
    {
        if (Family == "listbox")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton"/> and returns true if successful.
    /// </summary>
    public bool TryAsPushbutton(out CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton? value)
    {
        if (Family == "pushbutton")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature"/> and returns true if successful.
    /// </summary>
    public bool TryAsSignature(out CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature? value)
    {
        if (Family == "signature")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown? value)
    {
        if (Family == "unknown")
        {
            value = (CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Text value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Checkbox value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Radio value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Combobox value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Listbox value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Pushbutton value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Signature value
    ) => new(value);

    public static implicit operator DocFormsGet200ResponseFieldsItem(
        DocFormsGet200ResponseFieldsItem.Unknown value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<DocFormsGet200ResponseFieldsItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocFormsGet200ResponseFieldsItem).IsAssignableFrom(typeToConvert);

        public override DocFormsGet200ResponseFieldsItem Read(
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
                "text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemText"
                        ),
                "checkbox" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox"
                        ),
                "radio" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio"
                        ),
                "combobox" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox"
                        ),
                "listbox" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox"
                        ),
                "pushbutton" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton"
                        ),
                "signature" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature"
                        ),
                "unknown" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocFormsGet200ResponseFieldsItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItem value,
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

        public override DocFormsGet200ResponseFieldsItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocFormsGet200ResponseFieldsItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItem value,
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
        public Text(CloudpdfApi.DocFormsGet200ResponseFieldsItemText value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Text(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for checkbox
    /// </summary>
    [Serializable]
    public struct Checkbox
    {
        public Checkbox(CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Checkbox(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCheckbox value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for radio
    /// </summary>
    [Serializable]
    public struct Radio
    {
        public Radio(CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Radio(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemRadio value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for combobox
    /// </summary>
    [Serializable]
    public struct Combobox
    {
        public Combobox(CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Combobox(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemCombobox value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for listbox
    /// </summary>
    [Serializable]
    public struct Listbox
    {
        public Listbox(CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Listbox(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemListbox value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pushbutton
    /// </summary>
    [Serializable]
    public struct Pushbutton
    {
        public Pushbutton(CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Pushbutton(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemPushbutton value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for signature
    /// </summary>
    [Serializable]
    public struct Signature
    {
        public Signature(CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Signature(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemSignature value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocFormsGet200ResponseFieldsItem.Unknown(
            CloudpdfApi.DocFormsGet200ResponseFieldsItemUnknown value
        ) => new(value);
    }
}
