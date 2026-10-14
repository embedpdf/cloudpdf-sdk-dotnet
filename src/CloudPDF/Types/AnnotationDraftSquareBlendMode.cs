using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftSquareBlendMode.AnnotationDraftSquareBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftSquareBlendMode : IStringEnum
{
    public static readonly AnnotationDraftSquareBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftSquareBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftSquareBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftSquareBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftSquareBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftSquareBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftSquareBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftSquareBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftSquareBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftSquareBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftSquareBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftSquareBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftSquareBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftSquareBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftSquareBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftSquareBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftSquareBlendMode(string value)
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
    public static AnnotationDraftSquareBlendMode FromCustom(string value)
    {
        return new AnnotationDraftSquareBlendMode(value);
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

    public static bool operator ==(AnnotationDraftSquareBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftSquareBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftSquareBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftSquareBlendMode(string value) => new(value);

    internal class AnnotationDraftSquareBlendModeSerializer
        : JsonConverter<AnnotationDraftSquareBlendMode>
    {
        public override AnnotationDraftSquareBlendMode Read(
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
            return new AnnotationDraftSquareBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftSquareBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftSquareBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftSquareBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftSquareBlendMode value,
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
