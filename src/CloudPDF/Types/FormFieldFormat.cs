// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

/// <summary>
/// The shape a text field's or a dropdown's value has, by its `kind`: a date or a time with the pattern it is shown in, or `other` for a format script the engine does not recognise. A newer server can add kinds: read one your client doesn't know as `other`.
/// </summary>
[JsonConverter(typeof(FormFieldFormat.JsonConverter))]
[Serializable]
public record FormFieldFormat
{
    internal FormFieldFormat(string type, object? value)
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of FormFieldFormat with <see cref="FormFieldFormat.Date"/>.
    /// </summary>
    public FormFieldFormat(FormFieldFormat.Date value)
    {
        Kind = "date";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldFormat with <see cref="FormFieldFormat.Time"/>.
    /// </summary>
    public FormFieldFormat(FormFieldFormat.Time value)
    {
        Kind = "time";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of FormFieldFormat with <see cref="FormFieldFormat.Other"/>.
    /// </summary>
    public FormFieldFormat(FormFieldFormat.Other value)
    {
        Kind = "other";
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
    /// Returns true if <see cref="Kind"/> is "date"
    /// </summary>
    public bool IsDate => Kind == "date";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "time"
    /// </summary>
    public bool IsTime => Kind == "time";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "other"
    /// </summary>
    public bool IsOther => Kind == "other";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldFormatDate"/> if <see cref="Kind"/> is 'date', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'date'.</exception>
    public CloudPDF.FormFieldFormatDate AsDate() =>
        IsDate
            ? (CloudPDF.FormFieldFormatDate)Value!
            : throw new global::System.Exception("FormFieldFormat.Kind is not 'date'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldFormatTime"/> if <see cref="Kind"/> is 'time', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'time'.</exception>
    public CloudPDF.FormFieldFormatTime AsTime() =>
        IsTime
            ? (CloudPDF.FormFieldFormatTime)Value!
            : throw new global::System.Exception("FormFieldFormat.Kind is not 'time'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.FormFieldFormatOther"/> if <see cref="Kind"/> is 'other', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'other'.</exception>
    public CloudPDF.FormFieldFormatOther AsOther() =>
        IsOther
            ? (CloudPDF.FormFieldFormatOther)Value!
            : throw new global::System.Exception("FormFieldFormat.Kind is not 'other'");

    public T Match<T>(
        Func<CloudPDF.FormFieldFormatDate, T> onDate,
        Func<CloudPDF.FormFieldFormatTime, T> onTime,
        Func<CloudPDF.FormFieldFormatOther, T> onOther,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "date" => onDate(AsDate()),
            "time" => onTime(AsTime()),
            "other" => onOther(AsOther()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.FormFieldFormatDate> onDate,
        Action<CloudPDF.FormFieldFormatTime> onTime,
        Action<CloudPDF.FormFieldFormatOther> onOther,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "date":
                onDate(AsDate());
                break;
            case "time":
                onTime(AsTime());
                break;
            case "other":
                onOther(AsOther());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldFormatDate"/> and returns true if successful.
    /// </summary>
    public bool TryAsDate(out CloudPDF.FormFieldFormatDate? value)
    {
        if (Kind == "date")
        {
            value = (CloudPDF.FormFieldFormatDate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldFormatTime"/> and returns true if successful.
    /// </summary>
    public bool TryAsTime(out CloudPDF.FormFieldFormatTime? value)
    {
        if (Kind == "time")
        {
            value = (CloudPDF.FormFieldFormatTime)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.FormFieldFormatOther"/> and returns true if successful.
    /// </summary>
    public bool TryAsOther(out CloudPDF.FormFieldFormatOther? value)
    {
        if (Kind == "other")
        {
            value = (CloudPDF.FormFieldFormatOther)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator FormFieldFormat(FormFieldFormat.Date value) => new(value);

    public static implicit operator FormFieldFormat(FormFieldFormat.Time value) => new(value);

    public static implicit operator FormFieldFormat(FormFieldFormat.Other value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<FormFieldFormat>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(FormFieldFormat).IsAssignableFrom(typeToConvert);

        public override FormFieldFormat Read(
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
                "date" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldFormatDate?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldFormatDate"),
                "time" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldFormatTime?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldFormatTime"),
                "other" => jsonWithoutDiscriminator.Deserialize<CloudPDF.FormFieldFormatOther?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.FormFieldFormatOther"),
                _ => json.Deserialize<object?>(options),
            };
            return new FormFieldFormat(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldFormat value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "date" => JsonSerializer.SerializeToNode(value.Value, options),
                    "time" => JsonSerializer.SerializeToNode(value.Value, options),
                    "other" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override FormFieldFormat ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new FormFieldFormat(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for date
    /// </summary>
    [Serializable]
    public struct Date
    {
        public Date(CloudPDF.FormFieldFormatDate value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldFormatDate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldFormat.Date(CloudPDF.FormFieldFormatDate value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for time
    /// </summary>
    [Serializable]
    public struct Time
    {
        public Time(CloudPDF.FormFieldFormatTime value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldFormatTime Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldFormat.Time(CloudPDF.FormFieldFormatTime value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for other
    /// </summary>
    [Serializable]
    public struct Other
    {
        public Other(CloudPDF.FormFieldFormatOther value)
        {
            Value = value;
        }

        internal CloudPDF.FormFieldFormatOther Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator FormFieldFormat.Other(
            CloudPDF.FormFieldFormatOther value
        ) => new(value);
    }
}
