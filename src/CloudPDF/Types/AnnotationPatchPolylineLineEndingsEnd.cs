using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolylineLineEndingsEnd.AnnotationPatchPolylineLineEndingsEndSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolylineLineEndingsEnd : IStringEnum
{
    public static readonly AnnotationPatchPolylineLineEndingsEnd None = new(Values.None);

    public static readonly AnnotationPatchPolylineLineEndingsEnd Square = new(Values.Square);

    public static readonly AnnotationPatchPolylineLineEndingsEnd Circle = new(Values.Circle);

    public static readonly AnnotationPatchPolylineLineEndingsEnd Diamond = new(Values.Diamond);

    public static readonly AnnotationPatchPolylineLineEndingsEnd OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationPatchPolylineLineEndingsEnd ClosedArrow = new(
        Values.ClosedArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsEnd Butt = new(Values.Butt);

    public static readonly AnnotationPatchPolylineLineEndingsEnd ROpenArrow = new(
        Values.ROpenArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsEnd RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsEnd Slash = new(Values.Slash);

    public AnnotationPatchPolylineLineEndingsEnd(string value)
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
    public static AnnotationPatchPolylineLineEndingsEnd FromCustom(string value)
    {
        return new AnnotationPatchPolylineLineEndingsEnd(value);
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

    public static bool operator ==(AnnotationPatchPolylineLineEndingsEnd value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolylineLineEndingsEnd value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolylineLineEndingsEnd value) =>
        value.Value;

    public static explicit operator AnnotationPatchPolylineLineEndingsEnd(string value) =>
        new(value);

    internal class AnnotationPatchPolylineLineEndingsEndSerializer
        : JsonConverter<AnnotationPatchPolylineLineEndingsEnd>
    {
        public override AnnotationPatchPolylineLineEndingsEnd Read(
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
            return new AnnotationPatchPolylineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineLineEndingsEnd ReadAsPropertyName(
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
            return new AnnotationPatchPolylineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineLineEndingsEnd value,
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
