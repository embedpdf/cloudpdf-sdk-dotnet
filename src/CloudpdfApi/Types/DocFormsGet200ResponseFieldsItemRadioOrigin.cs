using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemRadioOrigin.DocFormsGet200ResponseFieldsItemRadioOriginSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemRadioOrigin : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemRadioOrigin Acroform = new(
        Values.Acroform
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioOrigin Recovered = new(
        Values.Recovered
    );

    public DocFormsGet200ResponseFieldsItemRadioOrigin(string value)
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
    public static DocFormsGet200ResponseFieldsItemRadioOrigin FromCustom(string value)
    {
        return new DocFormsGet200ResponseFieldsItemRadioOrigin(value);
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
        DocFormsGet200ResponseFieldsItemRadioOrigin value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemRadioOrigin value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsGet200ResponseFieldsItemRadioOrigin value) =>
        value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemRadioOrigin(string value) =>
        new(value);

    internal class DocFormsGet200ResponseFieldsItemRadioOriginSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemRadioOrigin>
    {
        public override DocFormsGet200ResponseFieldsItemRadioOrigin Read(
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
            return new DocFormsGet200ResponseFieldsItemRadioOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemRadioOrigin ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemRadioOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioOrigin value,
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
