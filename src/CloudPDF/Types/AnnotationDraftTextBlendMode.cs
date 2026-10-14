using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftTextBlendMode.AnnotationDraftTextBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftTextBlendMode : IStringEnum
{
    public static readonly AnnotationDraftTextBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftTextBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftTextBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftTextBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftTextBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftTextBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftTextBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftTextBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftTextBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftTextBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftTextBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftTextBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftTextBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftTextBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftTextBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftTextBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftTextBlendMode(string value)
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
    public static AnnotationDraftTextBlendMode FromCustom(string value)
    {
        return new AnnotationDraftTextBlendMode(value);
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

    public static bool operator ==(AnnotationDraftTextBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftTextBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftTextBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftTextBlendMode(string value) => new(value);

    internal class AnnotationDraftTextBlendModeSerializer
        : JsonConverter<AnnotationDraftTextBlendMode>
    {
        public override AnnotationDraftTextBlendMode Read(
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
            return new AnnotationDraftTextBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftTextBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftTextBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftTextBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftTextBlendMode value,
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
