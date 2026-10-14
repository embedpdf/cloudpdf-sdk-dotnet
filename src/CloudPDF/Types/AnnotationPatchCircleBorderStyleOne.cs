using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchCircleBorderStyleOne.AnnotationPatchCircleBorderStyleOneSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchCircleBorderStyleOne : IStringEnum
{
    public static readonly AnnotationPatchCircleBorderStyleOne Solid = new(Values.Solid);

    public static readonly AnnotationPatchCircleBorderStyleOne Dashed = new(Values.Dashed);

    public static readonly AnnotationPatchCircleBorderStyleOne Beveled = new(Values.Beveled);

    public static readonly AnnotationPatchCircleBorderStyleOne Inset = new(Values.Inset);

    public AnnotationPatchCircleBorderStyleOne(string value)
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
    public static AnnotationPatchCircleBorderStyleOne FromCustom(string value)
    {
        return new AnnotationPatchCircleBorderStyleOne(value);
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

    public static bool operator ==(AnnotationPatchCircleBorderStyleOne value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchCircleBorderStyleOne value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchCircleBorderStyleOne value) =>
        value.Value;

    public static explicit operator AnnotationPatchCircleBorderStyleOne(string value) => new(value);

    internal class AnnotationPatchCircleBorderStyleOneSerializer
        : JsonConverter<AnnotationPatchCircleBorderStyleOne>
    {
        public override AnnotationPatchCircleBorderStyleOne Read(
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
            return new AnnotationPatchCircleBorderStyleOne(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchCircleBorderStyleOne value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchCircleBorderStyleOne ReadAsPropertyName(
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
            return new AnnotationPatchCircleBorderStyleOne(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchCircleBorderStyleOne value,
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
