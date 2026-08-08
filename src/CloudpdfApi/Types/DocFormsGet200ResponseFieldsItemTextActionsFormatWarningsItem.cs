using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem.DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem(string value)
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
    public static DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem(value);
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
        DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItemSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem>
    {
        public override DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem Read(
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
            return new DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextActionsFormatWarningsItem value,
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
        public const string CycleDropped = "cycle-dropped";

        public const string MalformedNext = "malformed-next";

        public const string Incomplete = "incomplete";
    }
}
