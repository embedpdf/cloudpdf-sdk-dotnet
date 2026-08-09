using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle.DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyleSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle Solid =
        new(Values.Solid);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle Dashed =
        new(Values.Dashed);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle Beveled =
        new(Values.Beveled);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle Inset =
        new(Values.Inset);

    public DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle(value);
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
        DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyleSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemSquareBorderStyle value,
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
