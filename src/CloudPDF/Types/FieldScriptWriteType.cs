using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FieldScriptWriteType.FieldScriptWriteTypeSerializer))]
[Serializable]
public readonly record struct FieldScriptWriteType : IStringEnum
{
    public static readonly FieldScriptWriteType Javascript = new(Values.Javascript);

    public FieldScriptWriteType(string value)
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
    public static FieldScriptWriteType FromCustom(string value)
    {
        return new FieldScriptWriteType(value);
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

    public static bool operator ==(FieldScriptWriteType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldScriptWriteType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldScriptWriteType value) => value.Value;

    public static explicit operator FieldScriptWriteType(string value) => new(value);

    internal class FieldScriptWriteTypeSerializer : JsonConverter<FieldScriptWriteType>
    {
        public override FieldScriptWriteType Read(
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
            return new FieldScriptWriteType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FieldScriptWriteType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FieldScriptWriteType ReadAsPropertyName(
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
            return new FieldScriptWriteType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FieldScriptWriteType value,
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
        public const string Javascript = "javascript";
    }
}
