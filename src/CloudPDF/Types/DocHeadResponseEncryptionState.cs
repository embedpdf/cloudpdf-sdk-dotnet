using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocHeadResponseEncryptionState.DocHeadResponseEncryptionStateSerializer))]
[Serializable]
public readonly record struct DocHeadResponseEncryptionState : IStringEnum
{
    public static readonly DocHeadResponseEncryptionState Unknown = new(Values.Unknown);

    public static readonly DocHeadResponseEncryptionState None = new(Values.None);

    public static readonly DocHeadResponseEncryptionState Encrypted = new(Values.Encrypted);

    public static readonly DocHeadResponseEncryptionState Unsupported = new(Values.Unsupported);

    public DocHeadResponseEncryptionState(string value)
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
    public static DocHeadResponseEncryptionState FromCustom(string value)
    {
        return new DocHeadResponseEncryptionState(value);
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

    public static bool operator ==(DocHeadResponseEncryptionState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHeadResponseEncryptionState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHeadResponseEncryptionState value) => value.Value;

    public static explicit operator DocHeadResponseEncryptionState(string value) => new(value);

    internal class DocHeadResponseEncryptionStateSerializer
        : JsonConverter<DocHeadResponseEncryptionState>
    {
        public override DocHeadResponseEncryptionState Read(
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
            return new DocHeadResponseEncryptionState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHeadResponseEncryptionState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHeadResponseEncryptionState ReadAsPropertyName(
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
            return new DocHeadResponseEncryptionState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHeadResponseEncryptionState value,
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
        public const string Unknown = "unknown";

        public const string None = "none";

        public const string Encrypted = "encrypted";

        public const string Unsupported = "unsupported";
    }
}
