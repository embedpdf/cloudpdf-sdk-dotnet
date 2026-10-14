using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchLineLineEndingsEnd.AnnotationPatchLineLineEndingsEndSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchLineLineEndingsEnd : IStringEnum
{
    public static readonly AnnotationPatchLineLineEndingsEnd None = new(Values.None);

    public static readonly AnnotationPatchLineLineEndingsEnd Square = new(Values.Square);

    public static readonly AnnotationPatchLineLineEndingsEnd Circle = new(Values.Circle);

    public static readonly AnnotationPatchLineLineEndingsEnd Diamond = new(Values.Diamond);

    public static readonly AnnotationPatchLineLineEndingsEnd OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationPatchLineLineEndingsEnd ClosedArrow = new(Values.ClosedArrow);

    public static readonly AnnotationPatchLineLineEndingsEnd Butt = new(Values.Butt);

    public static readonly AnnotationPatchLineLineEndingsEnd ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationPatchLineLineEndingsEnd RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationPatchLineLineEndingsEnd Slash = new(Values.Slash);

    public AnnotationPatchLineLineEndingsEnd(string value)
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
    public static AnnotationPatchLineLineEndingsEnd FromCustom(string value)
    {
        return new AnnotationPatchLineLineEndingsEnd(value);
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

    public static bool operator ==(AnnotationPatchLineLineEndingsEnd value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchLineLineEndingsEnd value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchLineLineEndingsEnd value) => value.Value;

    public static explicit operator AnnotationPatchLineLineEndingsEnd(string value) => new(value);

    internal class AnnotationPatchLineLineEndingsEndSerializer
        : JsonConverter<AnnotationPatchLineLineEndingsEnd>
    {
        public override AnnotationPatchLineLineEndingsEnd Read(
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
            return new AnnotationPatchLineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineLineEndingsEnd ReadAsPropertyName(
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
            return new AnnotationPatchLineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineLineEndingsEnd value,
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
        public const string None = "none";

        public const string Square = "square";

        public const string Circle = "circle";

        public const string Diamond = "diamond";

        public const string OpenArrow = "open-arrow";

        public const string ClosedArrow = "closed-arrow";

        public const string Butt = "butt";

        public const string ROpenArrow = "r-open-arrow";

        public const string RClosedArrow = "r-closed-arrow";

        public const string Slash = "slash";
    }
}
