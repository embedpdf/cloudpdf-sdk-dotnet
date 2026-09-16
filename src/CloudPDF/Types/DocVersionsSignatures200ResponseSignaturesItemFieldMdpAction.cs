using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction.DocVersionsSignatures200ResponseSignaturesItemFieldMdpActionSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction
    : IStringEnum
{
    public static readonly DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction All = new(
        Values.All
    );

    public static readonly DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction Include =
        new(Values.Include);

    public static readonly DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction Exclude =
        new(Values.Exclude);

    public DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction(string value)
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
    public static DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction FromCustom(
        string value
    )
    {
        return new DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction(value);
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
        DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction value
    ) => value.Value;

    public static explicit operator DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction(
        string value
    ) => new(value);

    internal class DocVersionsSignatures200ResponseSignaturesItemFieldMdpActionSerializer
        : JsonConverter<DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction>
    {
        public override DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction Read(
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
            return new DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction ReadAsPropertyName(
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
            return new DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignatures200ResponseSignaturesItemFieldMdpAction value,
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
        public const string All = "all";

        public const string Include = "include";

        public const string Exclude = "exclude";
    }
}
