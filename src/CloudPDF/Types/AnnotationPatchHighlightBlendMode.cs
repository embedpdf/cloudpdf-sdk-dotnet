using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchHighlightBlendMode.AnnotationPatchHighlightBlendModeSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchHighlightBlendMode : IStringEnum
{
    public static readonly AnnotationPatchHighlightBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchHighlightBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchHighlightBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchHighlightBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchHighlightBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchHighlightBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchHighlightBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchHighlightBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchHighlightBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchHighlightBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchHighlightBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchHighlightBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchHighlightBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchHighlightBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchHighlightBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchHighlightBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchHighlightBlendMode(string value)
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
    public static AnnotationPatchHighlightBlendMode FromCustom(string value)
    {
        return new AnnotationPatchHighlightBlendMode(value);
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

    public static bool operator ==(AnnotationPatchHighlightBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchHighlightBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchHighlightBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchHighlightBlendMode(string value) => new(value);

    internal class AnnotationPatchHighlightBlendModeSerializer
        : JsonConverter<AnnotationPatchHighlightBlendMode>
    {
        public override AnnotationPatchHighlightBlendMode Read(
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
            return new AnnotationPatchHighlightBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchHighlightBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchHighlightBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchHighlightBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchHighlightBlendMode value,
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
