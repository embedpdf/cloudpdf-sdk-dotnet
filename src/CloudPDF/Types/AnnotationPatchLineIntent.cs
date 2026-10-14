using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchLineIntent.AnnotationPatchLineIntentSerializer))]
[Serializable]
public readonly record struct AnnotationPatchLineIntent : IStringEnum
{
    public static readonly AnnotationPatchLineIntent LineArrow = new(Values.LineArrow);

    public static readonly AnnotationPatchLineIntent LineDimension = new(Values.LineDimension);

    public AnnotationPatchLineIntent(string value)
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
    public static AnnotationPatchLineIntent FromCustom(string value)
    {
        return new AnnotationPatchLineIntent(value);
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

    public static bool operator ==(AnnotationPatchLineIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchLineIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchLineIntent value) => value.Value;

    public static explicit operator AnnotationPatchLineIntent(string value) => new(value);

    internal class AnnotationPatchLineIntentSerializer : JsonConverter<AnnotationPatchLineIntent>
    {
        public override AnnotationPatchLineIntent Read(
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
            return new AnnotationPatchLineIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineIntent ReadAsPropertyName(
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
            return new AnnotationPatchLineIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineIntent value,
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
        public const string LineArrow = "line-arrow";

        public const string LineDimension = "line-dimension";
    }
}
