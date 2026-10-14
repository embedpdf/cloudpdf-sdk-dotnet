using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchFreeTextBlendMode.AnnotationPatchFreeTextBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchFreeTextBlendMode : IStringEnum
{
    public static readonly AnnotationPatchFreeTextBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchFreeTextBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchFreeTextBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchFreeTextBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchFreeTextBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchFreeTextBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchFreeTextBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchFreeTextBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchFreeTextBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchFreeTextBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchFreeTextBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchFreeTextBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchFreeTextBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchFreeTextBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchFreeTextBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchFreeTextBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchFreeTextBlendMode(string value)
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
    public static AnnotationPatchFreeTextBlendMode FromCustom(string value)
    {
        return new AnnotationPatchFreeTextBlendMode(value);
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

    public static bool operator ==(AnnotationPatchFreeTextBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFreeTextBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchFreeTextBlendMode(string value) => new(value);

    internal class AnnotationPatchFreeTextBlendModeSerializer
        : JsonConverter<AnnotationPatchFreeTextBlendMode>
    {
        public override AnnotationPatchFreeTextBlendMode Read(
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
            return new AnnotationPatchFreeTextBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextBlendMode value,
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
