using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseRestrictionsItemSource.DocVersionsAnalysisResponseRestrictionsItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseRestrictionsItemSource : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseRestrictionsItemSource Docmdp = new(
        Values.Docmdp
    );

    public static readonly DocVersionsAnalysisResponseRestrictionsItemSource Fieldmdp = new(
        Values.Fieldmdp
    );

    public static readonly DocVersionsAnalysisResponseRestrictionsItemSource Lock = new(
        Values.Lock
    );

    public DocVersionsAnalysisResponseRestrictionsItemSource(string value)
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
    public static DocVersionsAnalysisResponseRestrictionsItemSource FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseRestrictionsItemSource(value);
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
        DocVersionsAnalysisResponseRestrictionsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysisResponseRestrictionsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsAnalysisResponseRestrictionsItemSource value
    ) => value.Value;

    public static explicit operator DocVersionsAnalysisResponseRestrictionsItemSource(
        string value
    ) => new(value);

    internal class DocVersionsAnalysisResponseRestrictionsItemSourceSerializer
        : JsonConverter<DocVersionsAnalysisResponseRestrictionsItemSource>
    {
        public override DocVersionsAnalysisResponseRestrictionsItemSource Read(
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
            return new DocVersionsAnalysisResponseRestrictionsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseRestrictionsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseRestrictionsItemSource ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseRestrictionsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseRestrictionsItemSource value,
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
        public const string Docmdp = "docmdp";

        public const string Fieldmdp = "fieldmdp";

        public const string Lock = "lock";
    }
}
