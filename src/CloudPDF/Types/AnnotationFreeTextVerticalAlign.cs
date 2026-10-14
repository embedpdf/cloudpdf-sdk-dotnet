using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationFreeTextVerticalAlign.AnnotationFreeTextVerticalAlignSerializer))]
[Serializable]
public readonly record struct AnnotationFreeTextVerticalAlign : IStringEnum
{
    public static readonly AnnotationFreeTextVerticalAlign Top = new(Values.Top);

    public static readonly AnnotationFreeTextVerticalAlign Middle = new(Values.Middle);

    public static readonly AnnotationFreeTextVerticalAlign Bottom = new(Values.Bottom);

    public AnnotationFreeTextVerticalAlign(string value)
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
    public static AnnotationFreeTextVerticalAlign FromCustom(string value)
    {
        return new AnnotationFreeTextVerticalAlign(value);
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

    public static bool operator ==(AnnotationFreeTextVerticalAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextVerticalAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextVerticalAlign value) => value.Value;

    public static explicit operator AnnotationFreeTextVerticalAlign(string value) => new(value);

    internal class AnnotationFreeTextVerticalAlignSerializer
        : JsonConverter<AnnotationFreeTextVerticalAlign>
    {
        public override AnnotationFreeTextVerticalAlign Read(
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
            return new AnnotationFreeTextVerticalAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextVerticalAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextVerticalAlign ReadAsPropertyName(
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
            return new AnnotationFreeTextVerticalAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextVerticalAlign value,
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
        public const string Top = "top";

        public const string Middle = "middle";

        public const string Bottom = "bottom";
    }
}
