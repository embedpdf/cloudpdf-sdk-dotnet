using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfActionTreeWarningsItem.PdfActionTreeWarningsItemSerializer))]
[Serializable]
public readonly record struct PdfActionTreeWarningsItem : IStringEnum
{
    public static readonly PdfActionTreeWarningsItem CycleDropped = new(Values.CycleDropped);

    public static readonly PdfActionTreeWarningsItem MalformedNext = new(Values.MalformedNext);

    public static readonly PdfActionTreeWarningsItem Incomplete = new(Values.Incomplete);

    public static readonly PdfActionTreeWarningsItem PayloadDropped = new(Values.PayloadDropped);

    public PdfActionTreeWarningsItem(string value)
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
    public static PdfActionTreeWarningsItem FromCustom(string value)
    {
        return new PdfActionTreeWarningsItem(value);
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

    public static bool operator ==(PdfActionTreeWarningsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfActionTreeWarningsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfActionTreeWarningsItem value) => value.Value;

    public static explicit operator PdfActionTreeWarningsItem(string value) => new(value);

    internal class PdfActionTreeWarningsItemSerializer : JsonConverter<PdfActionTreeWarningsItem>
    {
        public override PdfActionTreeWarningsItem Read(
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
            return new PdfActionTreeWarningsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionTreeWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfActionTreeWarningsItem ReadAsPropertyName(
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
            return new PdfActionTreeWarningsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionTreeWarningsItem value,
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
        public const string CycleDropped = "cycle-dropped";

        public const string MalformedNext = "malformed-next";

        public const string Incomplete = "incomplete";

        public const string PayloadDropped = "payload-dropped";
    }
}
