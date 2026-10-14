using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftLineLineEndingsEnd.AnnotationDraftLineLineEndingsEndSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftLineLineEndingsEnd : IStringEnum
{
    public static readonly AnnotationDraftLineLineEndingsEnd None = new(Values.None);

    public static readonly AnnotationDraftLineLineEndingsEnd Square = new(Values.Square);

    public static readonly AnnotationDraftLineLineEndingsEnd Circle = new(Values.Circle);

    public static readonly AnnotationDraftLineLineEndingsEnd Diamond = new(Values.Diamond);

    public static readonly AnnotationDraftLineLineEndingsEnd OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationDraftLineLineEndingsEnd ClosedArrow = new(Values.ClosedArrow);

    public static readonly AnnotationDraftLineLineEndingsEnd Butt = new(Values.Butt);

    public static readonly AnnotationDraftLineLineEndingsEnd ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationDraftLineLineEndingsEnd RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationDraftLineLineEndingsEnd Slash = new(Values.Slash);

    public AnnotationDraftLineLineEndingsEnd(string value)
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
    public static AnnotationDraftLineLineEndingsEnd FromCustom(string value)
    {
        return new AnnotationDraftLineLineEndingsEnd(value);
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

    public static bool operator ==(AnnotationDraftLineLineEndingsEnd value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftLineLineEndingsEnd value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftLineLineEndingsEnd value) => value.Value;

    public static explicit operator AnnotationDraftLineLineEndingsEnd(string value) => new(value);

    internal class AnnotationDraftLineLineEndingsEndSerializer
        : JsonConverter<AnnotationDraftLineLineEndingsEnd>
    {
        public override AnnotationDraftLineLineEndingsEnd Read(
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
            return new AnnotationDraftLineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineLineEndingsEnd ReadAsPropertyName(
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
            return new AnnotationDraftLineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineLineEndingsEnd value,
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
