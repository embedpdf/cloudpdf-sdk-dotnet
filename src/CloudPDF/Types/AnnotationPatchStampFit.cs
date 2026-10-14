using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchStampFit.AnnotationPatchStampFitSerializer))]
[Serializable]
public readonly record struct AnnotationPatchStampFit : IStringEnum
{
    public static readonly AnnotationPatchStampFit Contain = new(Values.Contain);

    public static readonly AnnotationPatchStampFit Cover = new(Values.Cover);

    public static readonly AnnotationPatchStampFit Fill = new(Values.Fill);

    public AnnotationPatchStampFit(string value)
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
    public static AnnotationPatchStampFit FromCustom(string value)
    {
        return new AnnotationPatchStampFit(value);
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

    public static bool operator ==(AnnotationPatchStampFit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchStampFit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchStampFit value) => value.Value;

    public static explicit operator AnnotationPatchStampFit(string value) => new(value);

    internal class AnnotationPatchStampFitSerializer : JsonConverter<AnnotationPatchStampFit>
    {
        public override AnnotationPatchStampFit Read(
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
            return new AnnotationPatchStampFit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchStampFit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchStampFit ReadAsPropertyName(
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
            return new AnnotationPatchStampFit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchStampFit value,
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
