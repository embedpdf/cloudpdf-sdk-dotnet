using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldSignatureOrigin.FormFieldSignatureOriginSerializer))]
[Serializable]
public readonly record struct FormFieldSignatureOrigin : IStringEnum
{
    public static readonly FormFieldSignatureOrigin Acroform = new(Values.Acroform);

    public static readonly FormFieldSignatureOrigin Recovered = new(Values.Recovered);

    public FormFieldSignatureOrigin(string value)
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
    public static FormFieldSignatureOrigin FromCustom(string value)
    {
        return new FormFieldSignatureOrigin(value);
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

    public static bool operator ==(FormFieldSignatureOrigin value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldSignatureOrigin value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldSignatureOrigin value) => value.Value;

    public static explicit operator FormFieldSignatureOrigin(string value) => new(value);

    internal class FormFieldSignatureOriginSerializer : JsonConverter<FormFieldSignatureOrigin>
    {
        public override FormFieldSignatureOrigin Read(
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
            return new FormFieldSignatureOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldSignatureOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldSignatureOrigin ReadAsPropertyName(
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
            return new FormFieldSignatureOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldSignatureOrigin value,
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
