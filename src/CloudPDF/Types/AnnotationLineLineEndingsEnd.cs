using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationLineLineEndingsEnd.AnnotationLineLineEndingsEndSerializer))]
[Serializable]
public readonly record struct AnnotationLineLineEndingsEnd : IStringEnum
{
    public static readonly AnnotationLineLineEndingsEnd None = new(Values.None);

    public static readonly AnnotationLineLineEndingsEnd Square = new(Values.Square);

    public static readonly AnnotationLineLineEndingsEnd Circle = new(Values.Circle);

    public static readonly AnnotationLineLineEndingsEnd Diamond = new(Values.Diamond);

    public static readonly AnnotationLineLineEndingsEnd OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationLineLineEndingsEnd ClosedArrow = new(Values.ClosedArrow);

    public static readonly AnnotationLineLineEndingsEnd Butt = new(Values.Butt);

    public static readonly AnnotationLineLineEndingsEnd ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationLineLineEndingsEnd RClosedArrow = new(Values.RClosedArrow);

    public static readonly AnnotationLineLineEndingsEnd Slash = new(Values.Slash);

    public AnnotationLineLineEndingsEnd(string value)
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
    public static AnnotationLineLineEndingsEnd FromCustom(string value)
    {
        return new AnnotationLineLineEndingsEnd(value);
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

    public static bool operator ==(AnnotationLineLineEndingsEnd value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationLineLineEndingsEnd value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationLineLineEndingsEnd value) => value.Value;

    public static explicit operator AnnotationLineLineEndingsEnd(string value) => new(value);

    internal class AnnotationLineLineEndingsEndSerializer
        : JsonConverter<AnnotationLineLineEndingsEnd>
    {
        public override AnnotationLineLineEndingsEnd Read(
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
            return new AnnotationLineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationLineLineEndingsEnd ReadAsPropertyName(
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
            return new AnnotationLineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLineLineEndingsEnd value,
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
