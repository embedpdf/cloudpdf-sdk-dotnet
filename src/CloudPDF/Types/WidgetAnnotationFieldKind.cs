using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationFieldKind.WidgetAnnotationFieldKindSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationFieldKind : IStringEnum
{
    public static readonly WidgetAnnotationFieldKind Text = new(Values.Text);

    public static readonly WidgetAnnotationFieldKind Checkbox = new(Values.Checkbox);

    public static readonly WidgetAnnotationFieldKind Radio = new(Values.Radio);

    public static readonly WidgetAnnotationFieldKind Combobox = new(Values.Combobox);

    public static readonly WidgetAnnotationFieldKind Listbox = new(Values.Listbox);

    public static readonly WidgetAnnotationFieldKind Pushbutton = new(Values.Pushbutton);

    public static readonly WidgetAnnotationFieldKind Signature = new(Values.Signature);

    public static readonly WidgetAnnotationFieldKind Unknown = new(Values.Unknown);

    public WidgetAnnotationFieldKind(string value)
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
    public static WidgetAnnotationFieldKind FromCustom(string value)
    {
        return new WidgetAnnotationFieldKind(value);
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

    public static bool operator ==(WidgetAnnotationFieldKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationFieldKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationFieldKind value) => value.Value;

    public static explicit operator WidgetAnnotationFieldKind(string value) => new(value);

    internal class WidgetAnnotationFieldKindSerializer : JsonConverter<WidgetAnnotationFieldKind>
    {
        public override WidgetAnnotationFieldKind Read(
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
            return new WidgetAnnotationFieldKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationFieldKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationFieldKind ReadAsPropertyName(
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
            return new WidgetAnnotationFieldKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationFieldKind value,
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
        public const string Text = "text";

        public const string Checkbox = "checkbox";

        public const string Radio = "radio";

        public const string Combobox = "combobox";

        public const string Listbox = "listbox";

        public const string Pushbutton = "pushbutton";

        public const string Signature = "signature";

        public const string Unknown = "unknown";
    }
}
