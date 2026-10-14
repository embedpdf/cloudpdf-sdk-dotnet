using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldTextOrigin.FormFieldTextOriginSerializer))]
[Serializable]
public readonly record struct FormFieldTextOrigin : IStringEnum
{
    public static readonly FormFieldTextOrigin Acroform = new(Values.Acroform);

    public static readonly FormFieldTextOrigin Recovered = new(Values.Recovered);

    public FormFieldTextOrigin(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static FormFieldTextOrigin FromCustom(string value)
    {
        return new FormFieldTextOrigin(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(FormFieldTextOrigin value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldTextOrigin value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldTextOrigin value) => value.Value;

    public static explicit operator FormFieldTextOrigin(string value) => new(value);

    internal class FormFieldTextOriginSerializer : JsonConverter<FormFieldTextOrigin>
    {
        public override FormFieldTextOrigin Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new FormFieldTextOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldTextOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldTextOrigin ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new FormFieldTextOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldTextOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Acroform = "acroform";

        public const string Recovered = "recovered";
    }
}
