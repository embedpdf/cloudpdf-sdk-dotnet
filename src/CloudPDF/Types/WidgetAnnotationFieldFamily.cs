using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationFieldFamily.WidgetAnnotationFieldFamilySerializer))]
[Serializable]
public readonly record struct WidgetAnnotationFieldFamily : IStringEnum
{
    public static readonly WidgetAnnotationFieldFamily Text = new(Values.Text);

    public static readonly WidgetAnnotationFieldFamily Checkbox = new(Values.Checkbox);

    public static readonly WidgetAnnotationFieldFamily Radio = new(Values.Radio);

    public static readonly WidgetAnnotationFieldFamily Combobox = new(Values.Combobox);

    public static readonly WidgetAnnotationFieldFamily Listbox = new(Values.Listbox);

    public static readonly WidgetAnnotationFieldFamily Pushbutton = new(Values.Pushbutton);

    public static readonly WidgetAnnotationFieldFamily Signature = new(Values.Signature);

    public static readonly WidgetAnnotationFieldFamily Unknown = new(Values.Unknown);

    public WidgetAnnotationFieldFamily(string value)
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
    public static WidgetAnnotationFieldFamily FromCustom(string value)
    {
        return new WidgetAnnotationFieldFamily(value);
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

    public static bool operator ==(WidgetAnnotationFieldFamily value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationFieldFamily value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationFieldFamily value) => value.Value;

    public static explicit operator WidgetAnnotationFieldFamily(string value) => new(value);

    internal class WidgetAnnotationFieldFamilySerializer
        : JsonConverter<WidgetAnnotationFieldFamily>
    {
        public override WidgetAnnotationFieldFamily Read(
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
            return new WidgetAnnotationFieldFamily(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationFieldFamily value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationFieldFamily ReadAsPropertyName(
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
            return new WidgetAnnotationFieldFamily(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationFieldFamily value,
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
