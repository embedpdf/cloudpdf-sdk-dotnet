using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FormFieldPatchFamily.FormFieldPatchFamilySerializer))]
[Serializable]
public readonly record struct FormFieldPatchFamily : IStringEnum
{
    public static readonly FormFieldPatchFamily Text = new(Values.Text);

    public static readonly FormFieldPatchFamily Checkbox = new(Values.Checkbox);

    public static readonly FormFieldPatchFamily Radio = new(Values.Radio);

    public static readonly FormFieldPatchFamily Combobox = new(Values.Combobox);

    public static readonly FormFieldPatchFamily Listbox = new(Values.Listbox);

    public static readonly FormFieldPatchFamily Pushbutton = new(Values.Pushbutton);

    public static readonly FormFieldPatchFamily Signature = new(Values.Signature);

    public FormFieldPatchFamily(string value)
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
    public static FormFieldPatchFamily FromCustom(string value)
    {
        return new FormFieldPatchFamily(value);
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

    public static bool operator ==(FormFieldPatchFamily value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FormFieldPatchFamily value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FormFieldPatchFamily value) => value.Value;

    public static explicit operator FormFieldPatchFamily(string value) => new(value);

    internal class FormFieldPatchFamilySerializer : JsonConverter<FormFieldPatchFamily>
    {
        public override FormFieldPatchFamily Read(
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
            return new FormFieldPatchFamily(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FormFieldPatchFamily value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FormFieldPatchFamily ReadAsPropertyName(
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
            return new FormFieldPatchFamily(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FormFieldPatchFamily value,
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
