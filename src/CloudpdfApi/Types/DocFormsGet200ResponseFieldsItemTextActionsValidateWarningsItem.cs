using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem.DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem(string value)
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
    public static DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem(value);
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
        DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItemSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem>
    {
        public override DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem Read(
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
            return new DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextActionsValidateWarningsItem value,
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
