using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextBorderStyleZero.AnnotationPatchFreeTextBorderStyleZeroSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextBorderStyleZero : IStringEnum
{
    public static readonly AnnotationPatchFreeTextBorderStyleZero Solid = new(Values.Solid);

    public static readonly AnnotationPatchFreeTextBorderStyleZero Dashed = new(Values.Dashed);

    public AnnotationPatchFreeTextBorderStyleZero(string value)
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
    public static AnnotationPatchFreeTextBorderStyleZero FromCustom(string value)
    {
        return new AnnotationPatchFreeTextBorderStyleZero(value);
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

    public static bool operator ==(AnnotationPatchFreeTextBorderStyleZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFreeTextBorderStyleZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextBorderStyleZero value) =>
        value.Value;

    public static explicit operator AnnotationPatchFreeTextBorderStyleZero(string value) =>
        new(value);

    internal class AnnotationPatchFreeTextBorderStyleZeroSerializer
        : JsonConverter<AnnotationPatchFreeTextBorderStyleZero>
    {
        public override AnnotationPatchFreeTextBorderStyleZero Read(
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
            return new AnnotationPatchFreeTextBorderStyleZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextBorderStyleZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextBorderStyleZero ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextBorderStyleZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextBorderStyleZero value,
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
        public const string Solid = "solid";

        public const string Dashed = "dashed";
    }
}
