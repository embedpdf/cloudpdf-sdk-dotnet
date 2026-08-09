using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle.DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyleSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle Solid =
        new(Values.Solid);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle Dashed =
        new(Values.Dashed);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle Beveled =
        new(Values.Beveled);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle Inset =
        new(Values.Inset);

    public DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle(value);
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

    public static bool operator ==(
        DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyleSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleBorderStyle value,
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
