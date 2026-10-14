using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextVerticalAlign.AnnotationPatchFreeTextVerticalAlignSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextVerticalAlign : IStringEnum
{
    public static readonly AnnotationPatchFreeTextVerticalAlign Top = new(Values.Top);

    public static readonly AnnotationPatchFreeTextVerticalAlign Middle = new(Values.Middle);

    public static readonly AnnotationPatchFreeTextVerticalAlign Bottom = new(Values.Bottom);

    public AnnotationPatchFreeTextVerticalAlign(string value)
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
    public static AnnotationPatchFreeTextVerticalAlign FromCustom(string value)
    {
        return new AnnotationPatchFreeTextVerticalAlign(value);
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

    public static bool operator ==(AnnotationPatchFreeTextVerticalAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFreeTextVerticalAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextVerticalAlign value) =>
        value.Value;

    public static explicit operator AnnotationPatchFreeTextVerticalAlign(string value) =>
        new(value);

    internal class AnnotationPatchFreeTextVerticalAlignSerializer
        : JsonConverter<AnnotationPatchFreeTextVerticalAlign>
    {
        public override AnnotationPatchFreeTextVerticalAlign Read(
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
            return new AnnotationPatchFreeTextVerticalAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextVerticalAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextVerticalAlign ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextVerticalAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextVerticalAlign value,
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
