using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolygonBorderStyleZero.AnnotationPatchPolygonBorderStyleZeroSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolygonBorderStyleZero : IStringEnum
{
    public static readonly AnnotationPatchPolygonBorderStyleZero Solid = new(Values.Solid);

    public static readonly AnnotationPatchPolygonBorderStyleZero Dashed = new(Values.Dashed);

    public AnnotationPatchPolygonBorderStyleZero(string value)
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
    public static AnnotationPatchPolygonBorderStyleZero FromCustom(string value)
    {
        return new AnnotationPatchPolygonBorderStyleZero(value);
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

    public static bool operator ==(AnnotationPatchPolygonBorderStyleZero value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolygonBorderStyleZero value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolygonBorderStyleZero value) =>
        value.Value;

    public static explicit operator AnnotationPatchPolygonBorderStyleZero(string value) =>
        new(value);

    internal class AnnotationPatchPolygonBorderStyleZeroSerializer
        : JsonConverter<AnnotationPatchPolygonBorderStyleZero>
    {
        public override AnnotationPatchPolygonBorderStyleZero Read(
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
            return new AnnotationPatchPolygonBorderStyleZero(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonBorderStyleZero value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonBorderStyleZero ReadAsPropertyName(
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
            return new AnnotationPatchPolygonBorderStyleZero(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonBorderStyleZero value,
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
