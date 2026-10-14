using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocRedactionsApply200ResponseResultsItemStatus.DocRedactionsApply200ResponseResultsItemStatusSerializer)
)]
[Serializable]
public readonly record struct DocRedactionsApply200ResponseResultsItemStatus : IStringEnum
{
    public static readonly DocRedactionsApply200ResponseResultsItemStatus Applied = new(
        Values.Applied
    );

    public static readonly DocRedactionsApply200ResponseResultsItemStatus Unchanged = new(
        Values.Unchanged
    );

    public DocRedactionsApply200ResponseResultsItemStatus(string value)
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
    public static DocRedactionsApply200ResponseResultsItemStatus FromCustom(string value)
    {
        return new DocRedactionsApply200ResponseResultsItemStatus(value);
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
        DocRedactionsApply200ResponseResultsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocRedactionsApply200ResponseResultsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocRedactionsApply200ResponseResultsItemStatus value) =>
        value.Value;

    public static explicit operator DocRedactionsApply200ResponseResultsItemStatus(string value) =>
        new(value);

    internal class DocRedactionsApply200ResponseResultsItemStatusSerializer
        : JsonConverter<DocRedactionsApply200ResponseResultsItemStatus>
    {
        public override DocRedactionsApply200ResponseResultsItemStatus Read(
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
            return new DocRedactionsApply200ResponseResultsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocRedactionsApply200ResponseResultsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocRedactionsApply200ResponseResultsItemStatus ReadAsPropertyName(
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
            return new DocRedactionsApply200ResponseResultsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocRedactionsApply200ResponseResultsItemStatus value,
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
        public const string Applied = "applied";

        public const string Unchanged = "unchanged";
    }
}
