using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextLineEnding.AnnotationPatchFreeTextLineEndingSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextLineEnding : IStringEnum
{
    public static readonly AnnotationPatchFreeTextLineEnding None = new(Values.None);

    public static readonly AnnotationPatchFreeTextLineEnding Square = new(Values.Square);

    public static readonly AnnotationPatchFreeTextLineEnding Circle = new(Values.Circle);

    public static readonly AnnotationPatchFreeTextLineEnding Diamond = new(Values.Diamond);

    public static readonly AnnotationPatchFreeTextLineEnding OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationPatchFreeTextLineEnding ClosedArrow = new(Values.ClosedArrow);

    public static readonly AnnotationPatchFreeTextLineEnding Butt = new(Values.Butt);

    public static readonly AnnotationPatchFreeTextLineEnding ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationPatchFreeTextLineEnding RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationPatchFreeTextLineEnding Slash = new(Values.Slash);

    public AnnotationPatchFreeTextLineEnding(string value)
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
    public static AnnotationPatchFreeTextLineEnding FromCustom(string value)
    {
        return new AnnotationPatchFreeTextLineEnding(value);
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

    public static bool operator ==(AnnotationPatchFreeTextLineEnding value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFreeTextLineEnding value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextLineEnding value) => value.Value;

    public static explicit operator AnnotationPatchFreeTextLineEnding(string value) => new(value);

    internal class AnnotationPatchFreeTextLineEndingSerializer
        : JsonConverter<AnnotationPatchFreeTextLineEnding>
    {
        public override AnnotationPatchFreeTextLineEnding Read(
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
            return new AnnotationPatchFreeTextLineEnding(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextLineEnding value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextLineEnding ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextLineEnding(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextLineEnding value,
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
