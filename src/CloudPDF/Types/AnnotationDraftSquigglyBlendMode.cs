using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftSquigglyBlendMode.AnnotationDraftSquigglyBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftSquigglyBlendMode : IStringEnum
{
    public static readonly AnnotationDraftSquigglyBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftSquigglyBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftSquigglyBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftSquigglyBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftSquigglyBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftSquigglyBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftSquigglyBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftSquigglyBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftSquigglyBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftSquigglyBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftSquigglyBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftSquigglyBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftSquigglyBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftSquigglyBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftSquigglyBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftSquigglyBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftSquigglyBlendMode(string value)
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
    public static AnnotationDraftSquigglyBlendMode FromCustom(string value)
    {
        return new AnnotationDraftSquigglyBlendMode(value);
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

    public static bool operator ==(AnnotationDraftSquigglyBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftSquigglyBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftSquigglyBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftSquigglyBlendMode(string value) => new(value);

    internal class AnnotationDraftSquigglyBlendModeSerializer
        : JsonConverter<AnnotationDraftSquigglyBlendMode>
    {
        public override AnnotationDraftSquigglyBlendMode Read(
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
            return new AnnotationDraftSquigglyBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftSquigglyBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftSquigglyBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftSquigglyBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftSquigglyBlendMode value,
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
