using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocHeadResponseState.DocHeadResponseStateSerializer))]
[Serializable]
public readonly record struct DocHeadResponseState : IStringEnum
{
    public static readonly DocHeadResponseState Pending = new(Values.Pending);

    public static readonly DocHeadResponseState Ready = new(Values.Ready);

    public static readonly DocHeadResponseState Failed = new(Values.Failed);

    public static readonly DocHeadResponseState Deleting = new(Values.Deleting);

    public DocHeadResponseState(string value)
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
    public static DocHeadResponseState FromCustom(string value)
    {
        return new DocHeadResponseState(value);
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

    public static bool operator ==(DocHeadResponseState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHeadResponseState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHeadResponseState value) => value.Value;

    public static explicit operator DocHeadResponseState(string value) => new(value);

    internal class DocHeadResponseStateSerializer : JsonConverter<DocHeadResponseState>
    {
        public override DocHeadResponseState Read(
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
            return new DocHeadResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHeadResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHeadResponseState ReadAsPropertyName(
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
            return new DocHeadResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHeadResponseState value,
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
        public const string Pending = "pending";

        public const string Ready = "ready";

        public const string Failed = "failed";

        public const string Deleting = "deleting";
    }
}
