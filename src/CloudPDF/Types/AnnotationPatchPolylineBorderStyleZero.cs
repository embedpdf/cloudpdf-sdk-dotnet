using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolylineBorderStyleZero.AnnotationPatchPolylineBorderStyleZeroSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolylineBorderStyleZero : IStringEnum
{
    public static readonly AnnotationPatchPolylineBorderStyleZero Solid = new(Values.Solid);

    public static readonly AnnotationPatchPolylineBorderStyleZero Dashed = new(Values.Dashed);

    public AnnotationPatchPolylineBorderStyleZero(string value)
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
    public static AnnotationPatchPolylineBorderStyleZero FromCustom(string value)
    {
        return new AnnotationPatchPolylineBorderStyleZero(value);
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

    public static bool operator ==(AnnotationPatchPolylineBorderStyleZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolylineBorderStyleZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolylineBorderStyleZero value) =>
        value.Value;

    public static explicit operator AnnotationPatchPolylineBorderStyleZero(string value) =>
        new(value);

    internal class AnnotationPatchPolylineBorderStyleZeroSerializer
        : JsonConverter<AnnotationPatchPolylineBorderStyleZero>
    {
        public override AnnotationPatchPolylineBorderStyleZero Read(
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
            return new AnnotationPatchPolylineBorderStyleZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineBorderStyleZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineBorderStyleZero ReadAsPropertyName(
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
            return new AnnotationPatchPolylineBorderStyleZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineBorderStyleZero value,
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
