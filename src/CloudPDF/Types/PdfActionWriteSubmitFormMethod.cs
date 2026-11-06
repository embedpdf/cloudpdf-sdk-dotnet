using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfActionWriteSubmitFormMethod.PdfActionWriteSubmitFormMethodSerializer))]
[Serializable]
public readonly record struct PdfActionWriteSubmitFormMethod : IStringEnum
{
    public static readonly PdfActionWriteSubmitFormMethod Post = new(Values.Post);

    public static readonly PdfActionWriteSubmitFormMethod Get = new(Values.Get);

    public PdfActionWriteSubmitFormMethod(string value)
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
    public static PdfActionWriteSubmitFormMethod FromCustom(string value)
    {
        return new PdfActionWriteSubmitFormMethod(value);
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

    public static bool operator ==(PdfActionWriteSubmitFormMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfActionWriteSubmitFormMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfActionWriteSubmitFormMethod value) => value.Value;

    public static explicit operator PdfActionWriteSubmitFormMethod(string value) => new(value);

    internal class PdfActionWriteSubmitFormMethodSerializer
        : JsonConverter<PdfActionWriteSubmitFormMethod>
    {
        public override PdfActionWriteSubmitFormMethod Read(
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
            return new PdfActionWriteSubmitFormMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionWriteSubmitFormMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfActionWriteSubmitFormMethod ReadAsPropertyName(
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
            return new PdfActionWriteSubmitFormMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionWriteSubmitFormMethod value,
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
        public const string Post = "post";

        public const string Get = "get";
    }
}
