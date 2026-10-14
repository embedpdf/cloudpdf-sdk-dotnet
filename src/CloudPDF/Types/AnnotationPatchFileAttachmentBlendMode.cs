using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFileAttachmentBlendMode.AnnotationPatchFileAttachmentBlendModeSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFileAttachmentBlendMode : IStringEnum
{
    public static readonly AnnotationPatchFileAttachmentBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchFileAttachmentBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchFileAttachmentBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchFileAttachmentBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchFileAttachmentBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchFileAttachmentBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchFileAttachmentBlendMode ColorDodge = new(
        Values.ColorDodge
    );

    public static readonly AnnotationPatchFileAttachmentBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchFileAttachmentBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchFileAttachmentBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchFileAttachmentBlendMode Difference = new(
        Values.Difference
    );

    public static readonly AnnotationPatchFileAttachmentBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchFileAttachmentBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchFileAttachmentBlendMode Saturation = new(
        Values.Saturation
    );

    public static readonly AnnotationPatchFileAttachmentBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchFileAttachmentBlendMode Luminosity = new(
        Values.Luminosity
    );

    public AnnotationPatchFileAttachmentBlendMode(string value)
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
    public static AnnotationPatchFileAttachmentBlendMode FromCustom(string value)
    {
        return new AnnotationPatchFileAttachmentBlendMode(value);
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

    public static bool operator ==(AnnotationPatchFileAttachmentBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFileAttachmentBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFileAttachmentBlendMode value) =>
        value.Value;

    public static explicit operator AnnotationPatchFileAttachmentBlendMode(string value) =>
        new(value);

    internal class AnnotationPatchFileAttachmentBlendModeSerializer
        : JsonConverter<AnnotationPatchFileAttachmentBlendMode>
    {
        public override AnnotationPatchFileAttachmentBlendMode Read(
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
            return new AnnotationPatchFileAttachmentBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFileAttachmentBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFileAttachmentBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchFileAttachmentBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFileAttachmentBlendMode value,
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
