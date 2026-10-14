using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPolylineLineEndingsEnd.AnnotationPolylineLineEndingsEndSerializer))]
[Serializable]
public readonly record struct AnnotationPolylineLineEndingsEnd : IStringEnum
{
    public static readonly AnnotationPolylineLineEndingsEnd None = new(Values.None);

    public static readonly AnnotationPolylineLineEndingsEnd Square = new(Values.Square);

    public static readonly AnnotationPolylineLineEndingsEnd Circle = new(Values.Circle);

    public static readonly AnnotationPolylineLineEndingsEnd Diamond = new(Values.Diamond);

    public static readonly AnnotationPolylineLineEndingsEnd OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationPolylineLineEndingsEnd ClosedArrow = new(Values.ClosedArrow);

    public static readonly AnnotationPolylineLineEndingsEnd Butt = new(Values.Butt);

    public static readonly AnnotationPolylineLineEndingsEnd ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationPolylineLineEndingsEnd RClosedArrow = new(Values.RClosedArrow);

    public static readonly AnnotationPolylineLineEndingsEnd Slash = new(Values.Slash);

    public AnnotationPolylineLineEndingsEnd(string value)
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
    public static AnnotationPolylineLineEndingsEnd FromCustom(string value)
    {
        return new AnnotationPolylineLineEndingsEnd(value);
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

    public static bool operator ==(AnnotationPolylineLineEndingsEnd value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPolylineLineEndingsEnd value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPolylineLineEndingsEnd value) => value.Value;

    public static explicit operator AnnotationPolylineLineEndingsEnd(string value) => new(value);

    internal class AnnotationPolylineLineEndingsEndSerializer
        : JsonConverter<AnnotationPolylineLineEndingsEnd>
    {
        public override AnnotationPolylineLineEndingsEnd Read(
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
            return new AnnotationPolylineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolylineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolylineLineEndingsEnd ReadAsPropertyName(
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
            return new AnnotationPolylineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolylineLineEndingsEnd value,
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
