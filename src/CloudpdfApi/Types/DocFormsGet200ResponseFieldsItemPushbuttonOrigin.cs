using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemPushbuttonOrigin.DocFormsGet200ResponseFieldsItemPushbuttonOriginSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemPushbuttonOrigin : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemPushbuttonOrigin Acroform = new(
        Values.Acroform
    );

    public static readonly DocFormsGet200ResponseFieldsItemPushbuttonOrigin Recovered = new(
        Values.Recovered
    );

    public DocFormsGet200ResponseFieldsItemPushbuttonOrigin(string value)
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
    public static DocFormsGet200ResponseFieldsItemPushbuttonOrigin FromCustom(string value)
    {
        return new DocFormsGet200ResponseFieldsItemPushbuttonOrigin(value);
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
        DocFormsGet200ResponseFieldsItemPushbuttonOrigin value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemPushbuttonOrigin value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemPushbuttonOrigin value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemPushbuttonOrigin(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemPushbuttonOriginSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemPushbuttonOrigin>
    {
        public override DocFormsGet200ResponseFieldsItemPushbuttonOrigin Read(
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
            return new DocFormsGet200ResponseFieldsItemPushbuttonOrigin(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemPushbuttonOrigin value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemPushbuttonOrigin ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemPushbuttonOrigin(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemPushbuttonOrigin value,
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
