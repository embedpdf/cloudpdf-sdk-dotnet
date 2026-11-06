using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocRedactionsApplyResponseResultsItemStatus.DocRedactionsApplyResponseResultsItemStatusSerializer)
)]
[Serializable]
public readonly record struct DocRedactionsApplyResponseResultsItemStatus : IStringEnum
{
    public static readonly DocRedactionsApplyResponseResultsItemStatus Applied = new(
        Values.Applied
    );

    public static readonly DocRedactionsApplyResponseResultsItemStatus Unchanged = new(
        Values.Unchanged
    );

    public DocRedactionsApplyResponseResultsItemStatus(string value)
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
    public static DocRedactionsApplyResponseResultsItemStatus FromCustom(string value)
    {
        return new DocRedactionsApplyResponseResultsItemStatus(value);
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
        DocRedactionsApplyResponseResultsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocRedactionsApplyResponseResultsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocRedactionsApplyResponseResultsItemStatus value) =>
        value.Value;

    public static explicit operator DocRedactionsApplyResponseResultsItemStatus(string value) =>
        new(value);

    internal class DocRedactionsApplyResponseResultsItemStatusSerializer
        : JsonConverter<DocRedactionsApplyResponseResultsItemStatus>
    {
        public override DocRedactionsApplyResponseResultsItemStatus Read(
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
            return new DocRedactionsApplyResponseResultsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocRedactionsApplyResponseResultsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocRedactionsApplyResponseResultsItemStatus ReadAsPropertyName(
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
            return new DocRedactionsApplyResponseResultsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocRedactionsApplyResponseResultsItemStatus value,
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
