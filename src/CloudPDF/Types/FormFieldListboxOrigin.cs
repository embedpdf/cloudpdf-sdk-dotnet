using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldListboxOrigin.FormFieldListboxOriginSerializer))]
[Serializable]
public readonly record struct FormFieldListboxOrigin : IStringEnum
{
    public static readonly FormFieldListboxOrigin Acroform = new(Values.Acroform);

    public static readonly FormFieldListboxOrigin Recovered = new(Values.Recovered);

    public FormFieldListboxOrigin(string value)
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
    public static FormFieldListboxOrigin FromCustom(string value)
    {
        return new FormFieldListboxOrigin(value);
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

    public static bool operator ==(FormFieldListboxOrigin value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldListboxOrigin value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldListboxOrigin value) => value.Value;

    public static explicit operator FormFieldListboxOrigin(string value) => new(value);

    internal class FormFieldListboxOriginSerializer : JsonConverter<FormFieldListboxOrigin>
    {
        public override FormFieldListboxOrigin Read(
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
            return new FormFieldListboxOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldListboxOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldListboxOrigin ReadAsPropertyName(
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
            return new FormFieldListboxOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldListboxOrigin value,
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
