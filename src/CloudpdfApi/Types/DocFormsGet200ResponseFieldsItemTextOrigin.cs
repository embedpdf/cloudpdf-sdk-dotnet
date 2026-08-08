using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemTextOrigin.DocFormsGet200ResponseFieldsItemTextOriginSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemTextOrigin : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemTextOrigin Acroform = new(
        Values.Acroform
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextOrigin Recovered = new(
        Values.Recovered
    );

    public DocFormsGet200ResponseFieldsItemTextOrigin(string value)
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
    public static DocFormsGet200ResponseFieldsItemTextOrigin FromCustom(string value)
    {
        return new DocFormsGet200ResponseFieldsItemTextOrigin(value);
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
        DocFormsGet200ResponseFieldsItemTextOrigin value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemTextOrigin value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsGet200ResponseFieldsItemTextOrigin value) =>
        value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemTextOrigin(string value) =>
        new(value);

    internal class DocFormsGet200ResponseFieldsItemTextOriginSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemTextOrigin>
    {
        public override DocFormsGet200ResponseFieldsItemTextOrigin Read(
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
            return new DocFormsGet200ResponseFieldsItemTextOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemTextOrigin ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemTextOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextOrigin value,
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
