using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationStampFit.AnnotationStampFitSerializer))]
[Serializable]
public readonly record struct AnnotationStampFit : IStringEnum
{
    public static readonly AnnotationStampFit Contain = new(Values.Contain);

    public static readonly AnnotationStampFit Cover = new(Values.Cover);

    public static readonly AnnotationStampFit Fill = new(Values.Fill);

    public AnnotationStampFit(string value)
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
    public static AnnotationStampFit FromCustom(string value)
    {
        return new AnnotationStampFit(value);
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

    public static bool operator ==(AnnotationStampFit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationStampFit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationStampFit value) => value.Value;

    public static explicit operator AnnotationStampFit(string value) => new(value);

    internal class AnnotationStampFitSerializer : JsonConverter<AnnotationStampFit>
    {
        public override AnnotationStampFit Read(
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
            return new AnnotationStampFit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationStampFit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationStampFit ReadAsPropertyName(
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
            return new AnnotationStampFit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationStampFit value,
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
        public const string Contain = "contain";

        public const string Cover = "cover";

        public const string Fill = "fill";
    }
}
