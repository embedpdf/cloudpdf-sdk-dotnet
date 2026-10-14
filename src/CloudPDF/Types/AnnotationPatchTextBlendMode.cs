using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchTextBlendMode.AnnotationPatchTextBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchTextBlendMode : IStringEnum
{
    public static readonly AnnotationPatchTextBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchTextBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchTextBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchTextBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchTextBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchTextBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchTextBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchTextBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchTextBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchTextBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchTextBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchTextBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchTextBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchTextBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchTextBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchTextBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchTextBlendMode(string value)
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
    public static AnnotationPatchTextBlendMode FromCustom(string value)
    {
        return new AnnotationPatchTextBlendMode(value);
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

    public static bool operator ==(AnnotationPatchTextBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchTextBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchTextBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchTextBlendMode(string value) => new(value);

    internal class AnnotationPatchTextBlendModeSerializer
        : JsonConverter<AnnotationPatchTextBlendMode>
    {
        public override AnnotationPatchTextBlendMode Read(
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
            return new AnnotationPatchTextBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchTextBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchTextBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchTextBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchTextBlendMode value,
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
