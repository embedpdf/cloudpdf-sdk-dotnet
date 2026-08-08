using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi.Doc;

[JsonConverter(typeof(ExportDataFormsRequestFormat.ExportDataFormsRequestFormatSerializer))]
[Serializable]
public readonly record struct ExportDataFormsRequestFormat : IStringEnum
{
    public static readonly ExportDataFormsRequestFormat Fdf = new(Values.Fdf);

    public static readonly ExportDataFormsRequestFormat Xfdf = new(Values.Xfdf);

    public ExportDataFormsRequestFormat(string value)
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
    public static ExportDataFormsRequestFormat FromCustom(string value)
    {
        return new ExportDataFormsRequestFormat(value);
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

    public static bool operator ==(ExportDataFormsRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExportDataFormsRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExportDataFormsRequestFormat value) => value.Value;

    public static explicit operator ExportDataFormsRequestFormat(string value) => new(value);

    internal class ExportDataFormsRequestFormatSerializer
        : JsonConverter<ExportDataFormsRequestFormat>
    {
        public override ExportDataFormsRequestFormat Read(
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
            return new ExportDataFormsRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExportDataFormsRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ExportDataFormsRequestFormat ReadAsPropertyName(
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
            return new ExportDataFormsRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ExportDataFormsRequestFormat value,
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
        public const string Fdf = "fdf";

        public const string Xfdf = "xfdf";
    }
}
