using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationLineIntent.AnnotationLineIntentSerializer))]
[Serializable]
public readonly record struct AnnotationLineIntent : IStringEnum
{
    public static readonly AnnotationLineIntent LineArrow = new(Values.LineArrow);

    public static readonly AnnotationLineIntent LineDimension = new(Values.LineDimension);

    public AnnotationLineIntent(string value)
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
    public static AnnotationLineIntent FromCustom(string value)
    {
        return new AnnotationLineIntent(value);
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

    public static bool operator ==(AnnotationLineIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationLineIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationLineIntent value) => value.Value;

    public static explicit operator AnnotationLineIntent(string value) => new(value);

    internal class AnnotationLineIntentSerializer : JsonConverter<AnnotationLineIntent>
    {
        public override AnnotationLineIntent Read(
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
            return new AnnotationLineIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLineIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationLineIntent ReadAsPropertyName(
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
            return new AnnotationLineIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLineIntent value,
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
