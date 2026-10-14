using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldCheckboxOrigin.FormFieldCheckboxOriginSerializer))]
[Serializable]
public readonly record struct FormFieldCheckboxOrigin : IStringEnum
{
    public static readonly FormFieldCheckboxOrigin Acroform = new(Values.Acroform);

    public static readonly FormFieldCheckboxOrigin Recovered = new(Values.Recovered);

    public FormFieldCheckboxOrigin(string value)
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
    public static FormFieldCheckboxOrigin FromCustom(string value)
    {
        return new FormFieldCheckboxOrigin(value);
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

    public static bool operator ==(FormFieldCheckboxOrigin value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldCheckboxOrigin value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldCheckboxOrigin value) => value.Value;

    public static explicit operator FormFieldCheckboxOrigin(string value) => new(value);

    internal class FormFieldCheckboxOriginSerializer : JsonConverter<FormFieldCheckboxOrigin>
    {
        public override FormFieldCheckboxOrigin Read(
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
            return new FormFieldCheckboxOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldCheckboxOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldCheckboxOrigin ReadAsPropertyName(
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
            return new FormFieldCheckboxOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldCheckboxOrigin value,
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
