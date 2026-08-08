using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem.DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem(string value)
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
    public static DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem(value);
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
        DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItemSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem>
    {
        public override DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem Read(
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
            return new DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemComboboxActionsKeystrokeWarningsItem value,
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
