using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationSquareBorderStyle.AnnotationSquareBorderStyleSerializer))]
[Serializable]
public readonly record struct AnnotationSquareBorderStyle : IStringEnum
{
    public static readonly AnnotationSquareBorderStyle Solid = new(Values.Solid);

    public static readonly AnnotationSquareBorderStyle Dashed = new(Values.Dashed);

    public static readonly AnnotationSquareBorderStyle Beveled = new(Values.Beveled);

    public static readonly AnnotationSquareBorderStyle Inset = new(Values.Inset);

    public AnnotationSquareBorderStyle(string value)
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
    public static AnnotationSquareBorderStyle FromCustom(string value)
    {
        return new AnnotationSquareBorderStyle(value);
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

    public static bool operator ==(AnnotationSquareBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationSquareBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationSquareBorderStyle value) => value.Value;

    public static explicit operator AnnotationSquareBorderStyle(string value) => new(value);

    internal class AnnotationSquareBorderStyleSerializer
        : JsonConverter<AnnotationSquareBorderStyle>
    {
        public override AnnotationSquareBorderStyle Read(
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
            return new AnnotationSquareBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationSquareBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationSquareBorderStyle ReadAsPropertyName(
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
            return new AnnotationSquareBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationSquareBorderStyle value,
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
        public const string Solid = "solid";

        public const string Dashed = "dashed";

        public const string Beveled = "beveled";

        public const string Inset = "inset";
    }
}
