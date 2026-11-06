using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldPatchKind.FormFieldPatchKindSerializer))]
[Serializable]
public readonly record struct FormFieldPatchKind : IStringEnum
{
    public static readonly FormFieldPatchKind Text = new(Values.Text);

    public static readonly FormFieldPatchKind Checkbox = new(Values.Checkbox);

    public static readonly FormFieldPatchKind Radio = new(Values.Radio);

    public static readonly FormFieldPatchKind Combobox = new(Values.Combobox);

    public static readonly FormFieldPatchKind Listbox = new(Values.Listbox);

    public static readonly FormFieldPatchKind Pushbutton = new(Values.Pushbutton);

    public static readonly FormFieldPatchKind Signature = new(Values.Signature);

    public FormFieldPatchKind(string value)
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
    public static FormFieldPatchKind FromCustom(string value)
    {
        return new FormFieldPatchKind(value);
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

    public static bool operator ==(FormFieldPatchKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldPatchKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldPatchKind value) => value.Value;

    public static explicit operator FormFieldPatchKind(string value) => new(value);

    internal class FormFieldPatchKindSerializer : JsonConverter<FormFieldPatchKind>
    {
        public override FormFieldPatchKind Read(
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
            return new FormFieldPatchKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldPatchKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldPatchKind ReadAsPropertyName(
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
            return new FormFieldPatchKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldPatchKind value,
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
    }
}
