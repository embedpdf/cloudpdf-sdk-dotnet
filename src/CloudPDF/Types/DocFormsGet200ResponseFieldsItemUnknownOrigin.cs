using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemUnknownOrigin.DocFormsGet200ResponseFieldsItemUnknownOriginSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemUnknownOrigin : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemUnknownOrigin Acroform = new(
        Values.Acroform
    );

    public static readonly DocFormsGet200ResponseFieldsItemUnknownOrigin Recovered = new(
        Values.Recovered
    );

    public DocFormsGet200ResponseFieldsItemUnknownOrigin(string value)
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
    public static DocFormsGet200ResponseFieldsItemUnknownOrigin FromCustom(string value)
    {
        return new DocFormsGet200ResponseFieldsItemUnknownOrigin(value);
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
        DocFormsGet200ResponseFieldsItemUnknownOrigin value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemUnknownOrigin value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsGet200ResponseFieldsItemUnknownOrigin value) =>
        value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemUnknownOrigin(string value) =>
        new(value);

    internal class DocFormsGet200ResponseFieldsItemUnknownOriginSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemUnknownOrigin>
    {
        public override DocFormsGet200ResponseFieldsItemUnknownOrigin Read(
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
            return new DocFormsGet200ResponseFieldsItemUnknownOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemUnknownOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemUnknownOrigin ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemUnknownOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemUnknownOrigin value,
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
        public const string Acroform = "acroform";

        public const string Recovered = "recovered";
    }
}
