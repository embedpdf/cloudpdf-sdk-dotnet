using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolylineLineEndingsEnd.AnnotationDraftPolylineLineEndingsEndSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolylineLineEndingsEnd : IStringEnum
{
    public static readonly AnnotationDraftPolylineLineEndingsEnd None = new(Values.None);

    public static readonly AnnotationDraftPolylineLineEndingsEnd Square = new(Values.Square);

    public static readonly AnnotationDraftPolylineLineEndingsEnd Circle = new(Values.Circle);

    public static readonly AnnotationDraftPolylineLineEndingsEnd Diamond = new(Values.Diamond);

    public static readonly AnnotationDraftPolylineLineEndingsEnd OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationDraftPolylineLineEndingsEnd ClosedArrow = new(
        Values.ClosedArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsEnd Butt = new(Values.Butt);

    public static readonly AnnotationDraftPolylineLineEndingsEnd ROpenArrow = new(
        Values.ROpenArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsEnd RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsEnd Slash = new(Values.Slash);

    public AnnotationDraftPolylineLineEndingsEnd(string value)
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
    public static AnnotationDraftPolylineLineEndingsEnd FromCustom(string value)
    {
        return new AnnotationDraftPolylineLineEndingsEnd(value);
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

    public static bool operator ==(AnnotationDraftPolylineLineEndingsEnd value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftPolylineLineEndingsEnd value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftPolylineLineEndingsEnd value) =>
        value.Value;

    public static explicit operator AnnotationDraftPolylineLineEndingsEnd(string value) =>
        new(value);

    internal class AnnotationDraftPolylineLineEndingsEndSerializer
        : JsonConverter<AnnotationDraftPolylineLineEndingsEnd>
    {
        public override AnnotationDraftPolylineLineEndingsEnd Read(
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
            return new AnnotationDraftPolylineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolylineLineEndingsEnd ReadAsPropertyName(
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
            return new AnnotationDraftPolylineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineLineEndingsEnd value,
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
