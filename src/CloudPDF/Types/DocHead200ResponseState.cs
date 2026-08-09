using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocHead200ResponseState.DocHead200ResponseStateSerializer))]
[Serializable]
public readonly record struct DocHead200ResponseState : IStringEnum
{
    public static readonly DocHead200ResponseState Pending = new(Values.Pending);

    public static readonly DocHead200ResponseState Ready = new(Values.Ready);

    public static readonly DocHead200ResponseState Failed = new(Values.Failed);

    public static readonly DocHead200ResponseState Deleting = new(Values.Deleting);

    public DocHead200ResponseState(string value)
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
    public static DocHead200ResponseState FromCustom(string value)
    {
        return new DocHead200ResponseState(value);
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

    public static bool operator ==(DocHead200ResponseState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHead200ResponseState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHead200ResponseState value) => value.Value;

    public static explicit operator DocHead200ResponseState(string value) => new(value);

    internal class DocHead200ResponseStateSerializer : JsonConverter<DocHead200ResponseState>
    {
        public override DocHead200ResponseState Read(
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
            return new DocHead200ResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHead200ResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHead200ResponseState ReadAsPropertyName(
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
            return new DocHead200ResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHead200ResponseState value,
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
