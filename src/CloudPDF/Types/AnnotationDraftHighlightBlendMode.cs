using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftHighlightBlendMode.AnnotationDraftHighlightBlendModeSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftHighlightBlendMode : IStringEnum
{
    public static readonly AnnotationDraftHighlightBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftHighlightBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftHighlightBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftHighlightBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftHighlightBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftHighlightBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftHighlightBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftHighlightBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftHighlightBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftHighlightBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftHighlightBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftHighlightBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftHighlightBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftHighlightBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftHighlightBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftHighlightBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftHighlightBlendMode(string value)
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
    public static AnnotationDraftHighlightBlendMode FromCustom(string value)
    {
        return new AnnotationDraftHighlightBlendMode(value);
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

    public static bool operator ==(AnnotationDraftHighlightBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftHighlightBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftHighlightBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftHighlightBlendMode(string value) => new(value);

    internal class AnnotationDraftHighlightBlendModeSerializer
        : JsonConverter<AnnotationDraftHighlightBlendMode>
    {
        public override AnnotationDraftHighlightBlendMode Read(
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
            return new AnnotationDraftHighlightBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftHighlightBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftHighlightBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftHighlightBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftHighlightBlendMode value,
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
        public const string Normal = "normal";

        public const string Multiply = "multiply";

        public const string Screen = "screen";

        public const string Overlay = "overlay";

        public const string Darken = "darken";

        public const string Lighten = "lighten";

        public const string ColorDodge = "color-dodge";

        public const string ColorBurn = "color-burn";

        public const string HardLight = "hard-light";

        public const string SoftLight = "soft-light";

        public const string Difference = "difference";

        public const string Exclusion = "exclusion";

        public const string Hue = "hue";

        public const string Saturation = "saturation";

        public const string Color = "color";

        public const string Luminosity = "luminosity";
    }
}
