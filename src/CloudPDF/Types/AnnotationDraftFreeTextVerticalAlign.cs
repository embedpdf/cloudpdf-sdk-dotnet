using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFreeTextVerticalAlign.AnnotationDraftFreeTextVerticalAlignSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFreeTextVerticalAlign : IStringEnum
{
    public static readonly AnnotationDraftFreeTextVerticalAlign Top = new(Values.Top);

    public static readonly AnnotationDraftFreeTextVerticalAlign Middle = new(Values.Middle);

    public static readonly AnnotationDraftFreeTextVerticalAlign Bottom = new(Values.Bottom);

    public AnnotationDraftFreeTextVerticalAlign(string value)
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
    public static AnnotationDraftFreeTextVerticalAlign FromCustom(string value)
    {
        return new AnnotationDraftFreeTextVerticalAlign(value);
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

    public static bool operator ==(AnnotationDraftFreeTextVerticalAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFreeTextVerticalAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFreeTextVerticalAlign value) =>
        value.Value;

    public static explicit operator AnnotationDraftFreeTextVerticalAlign(string value) =>
        new(value);

    internal class AnnotationDraftFreeTextVerticalAlignSerializer
        : JsonConverter<AnnotationDraftFreeTextVerticalAlign>
    {
        public override AnnotationDraftFreeTextVerticalAlign Read(
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
            return new AnnotationDraftFreeTextVerticalAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextVerticalAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextVerticalAlign ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextVerticalAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextVerticalAlign value,
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
