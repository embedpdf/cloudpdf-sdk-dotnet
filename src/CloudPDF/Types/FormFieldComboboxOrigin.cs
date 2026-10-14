using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldComboboxOrigin.FormFieldComboboxOriginSerializer))]
[Serializable]
public readonly record struct FormFieldComboboxOrigin : IStringEnum
{
    public static readonly FormFieldComboboxOrigin Acroform = new(Values.Acroform);

    public static readonly FormFieldComboboxOrigin Recovered = new(Values.Recovered);

    public FormFieldComboboxOrigin(string value)
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
    public static FormFieldComboboxOrigin FromCustom(string value)
    {
        return new FormFieldComboboxOrigin(value);
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

    public static bool operator ==(FormFieldComboboxOrigin value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldComboboxOrigin value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldComboboxOrigin value) => value.Value;

    public static explicit operator FormFieldComboboxOrigin(string value) => new(value);

    internal class FormFieldComboboxOriginSerializer : JsonConverter<FormFieldComboboxOrigin>
    {
        public override FormFieldComboboxOrigin Read(
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
            return new FormFieldComboboxOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldComboboxOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldComboboxOrigin ReadAsPropertyName(
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
            return new FormFieldComboboxOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldComboboxOrigin value,
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
