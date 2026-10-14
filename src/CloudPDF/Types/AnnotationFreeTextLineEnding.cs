using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationFreeTextLineEnding.AnnotationFreeTextLineEndingSerializer))]
[Serializable]
public readonly record struct AnnotationFreeTextLineEnding : IStringEnum
{
    public static readonly AnnotationFreeTextLineEnding None = new(Values.None);

    public static readonly AnnotationFreeTextLineEnding Square = new(Values.Square);

    public static readonly AnnotationFreeTextLineEnding Circle = new(Values.Circle);

    public static readonly AnnotationFreeTextLineEnding Diamond = new(Values.Diamond);

    public static readonly AnnotationFreeTextLineEnding OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationFreeTextLineEnding ClosedArrow = new(Values.ClosedArrow);

    public static readonly AnnotationFreeTextLineEnding Butt = new(Values.Butt);

    public static readonly AnnotationFreeTextLineEnding ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationFreeTextLineEnding RClosedArrow = new(Values.RClosedArrow);

    public static readonly AnnotationFreeTextLineEnding Slash = new(Values.Slash);

    public AnnotationFreeTextLineEnding(string value)
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
    public static AnnotationFreeTextLineEnding FromCustom(string value)
    {
        return new AnnotationFreeTextLineEnding(value);
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

    public static bool operator ==(AnnotationFreeTextLineEnding value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextLineEnding value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextLineEnding value) => value.Value;

    public static explicit operator AnnotationFreeTextLineEnding(string value) => new(value);

    internal class AnnotationFreeTextLineEndingSerializer
        : JsonConverter<AnnotationFreeTextLineEnding>
    {
        public override AnnotationFreeTextLineEnding Read(
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
            return new AnnotationFreeTextLineEnding(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextLineEnding value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextLineEnding ReadAsPropertyName(
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
            return new AnnotationFreeTextLineEnding(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextLineEnding value,
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
