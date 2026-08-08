using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem.DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem(string value)
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
    public static DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem(value);
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
        DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItemSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem>
    {
        public override DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem Read(
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
            return new DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemPushbuttonActionsKeystrokeWarningsItem value,
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
