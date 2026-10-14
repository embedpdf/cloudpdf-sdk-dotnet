using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolygonBorderStyleOne.AnnotationPatchPolygonBorderStyleOneSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolygonBorderStyleOne : IStringEnum
{
    public static readonly AnnotationPatchPolygonBorderStyleOne Solid = new(Values.Solid);

    public static readonly AnnotationPatchPolygonBorderStyleOne Dashed = new(Values.Dashed);

    public static readonly AnnotationPatchPolygonBorderStyleOne Beveled = new(Values.Beveled);

    public static readonly AnnotationPatchPolygonBorderStyleOne Inset = new(Values.Inset);

    public AnnotationPatchPolygonBorderStyleOne(string value)
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
    public static AnnotationPatchPolygonBorderStyleOne FromCustom(string value)
    {
        return new AnnotationPatchPolygonBorderStyleOne(value);
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

    public static bool operator ==(AnnotationPatchPolygonBorderStyleOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolygonBorderStyleOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolygonBorderStyleOne value) =>
        value.Value;

    public static explicit operator AnnotationPatchPolygonBorderStyleOne(string value) =>
        new(value);

    internal class AnnotationPatchPolygonBorderStyleOneSerializer
        : JsonConverter<AnnotationPatchPolygonBorderStyleOne>
    {
        public override AnnotationPatchPolygonBorderStyleOne Read(
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
            return new AnnotationPatchPolygonBorderStyleOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonBorderStyleOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonBorderStyleOne ReadAsPropertyName(
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
            return new AnnotationPatchPolygonBorderStyleOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonBorderStyleOne value,
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

        public const string Beveled = "beveled";

        public const string Inset = "inset";
    }
}
