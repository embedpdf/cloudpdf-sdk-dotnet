using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftFreeTextBlendMode.AnnotationDraftFreeTextBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftFreeTextBlendMode : IStringEnum
{
    public static readonly AnnotationDraftFreeTextBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftFreeTextBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftFreeTextBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftFreeTextBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftFreeTextBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftFreeTextBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftFreeTextBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftFreeTextBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftFreeTextBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftFreeTextBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftFreeTextBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftFreeTextBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftFreeTextBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftFreeTextBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftFreeTextBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftFreeTextBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftFreeTextBlendMode(string value)
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
    public static AnnotationDraftFreeTextBlendMode FromCustom(string value)
    {
        return new AnnotationDraftFreeTextBlendMode(value);
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

    public static bool operator ==(AnnotationDraftFreeTextBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFreeTextBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFreeTextBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftFreeTextBlendMode(string value) => new(value);

    internal class AnnotationDraftFreeTextBlendModeSerializer
        : JsonConverter<AnnotationDraftFreeTextBlendMode>
    {
        public override AnnotationDraftFreeTextBlendMode Read(
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
            return new AnnotationDraftFreeTextBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextBlendMode value,
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
