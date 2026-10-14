using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfLinkTargetWritableNamedName.PdfLinkTargetWritableNamedNameSerializer))]
[Serializable]
public readonly record struct PdfLinkTargetWritableNamedName : IStringEnum
{
    public static readonly PdfLinkTargetWritableNamedName NextPage = new(Values.NextPage);

    public static readonly PdfLinkTargetWritableNamedName PrevPage = new(Values.PrevPage);

    public static readonly PdfLinkTargetWritableNamedName FirstPage = new(Values.FirstPage);

    public static readonly PdfLinkTargetWritableNamedName LastPage = new(Values.LastPage);

    public PdfLinkTargetWritableNamedName(string value)
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
    public static PdfLinkTargetWritableNamedName FromCustom(string value)
    {
        return new PdfLinkTargetWritableNamedName(value);
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

    public static bool operator ==(PdfLinkTargetWritableNamedName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfLinkTargetWritableNamedName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfLinkTargetWritableNamedName value) => value.Value;

    public static explicit operator PdfLinkTargetWritableNamedName(string value) => new(value);

    internal class PdfLinkTargetWritableNamedNameSerializer
        : JsonConverter<PdfLinkTargetWritableNamedName>
    {
        public override PdfLinkTargetWritableNamedName Read(
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
            return new PdfLinkTargetWritableNamedName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfLinkTargetWritableNamedName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfLinkTargetWritableNamedName ReadAsPropertyName(
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
            return new PdfLinkTargetWritableNamedName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfLinkTargetWritableNamedName value,
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
        public const string NextPage = "NextPage";

        public const string PrevPage = "PrevPage";

        public const string FirstPage = "FirstPage";

        public const string LastPage = "LastPage";
    }
}
