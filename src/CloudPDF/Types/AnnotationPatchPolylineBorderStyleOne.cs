using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolylineBorderStyleOne.AnnotationPatchPolylineBorderStyleOneSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolylineBorderStyleOne : IStringEnum
{
    public static readonly AnnotationPatchPolylineBorderStyleOne Solid = new(Values.Solid);

    public static readonly AnnotationPatchPolylineBorderStyleOne Dashed = new(Values.Dashed);

    public static readonly AnnotationPatchPolylineBorderStyleOne Beveled = new(Values.Beveled);

    public static readonly AnnotationPatchPolylineBorderStyleOne Inset = new(Values.Inset);

    public AnnotationPatchPolylineBorderStyleOne(string value)
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
    public static AnnotationPatchPolylineBorderStyleOne FromCustom(string value)
    {
        return new AnnotationPatchPolylineBorderStyleOne(value);
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

    public static bool operator ==(AnnotationPatchPolylineBorderStyleOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolylineBorderStyleOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolylineBorderStyleOne value) =>
        value.Value;

    public static explicit operator AnnotationPatchPolylineBorderStyleOne(string value) =>
        new(value);

    internal class AnnotationPatchPolylineBorderStyleOneSerializer
        : JsonConverter<AnnotationPatchPolylineBorderStyleOne>
    {
        public override AnnotationPatchPolylineBorderStyleOne Read(
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
            return new AnnotationPatchPolylineBorderStyleOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineBorderStyleOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineBorderStyleOne ReadAsPropertyName(
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
            return new AnnotationPatchPolylineBorderStyleOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineBorderStyleOne value,
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
