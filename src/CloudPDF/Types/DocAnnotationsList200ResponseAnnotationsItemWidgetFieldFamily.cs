using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily.DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamilySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Text = new(
        Values.Text
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Checkbox =
        new(Values.Checkbox);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Radio =
        new(Values.Radio);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Combobox =
        new(Values.Combobox);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Listbox =
        new(Values.Listbox);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Pushbutton =
        new(Values.Pushbutton);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Signature =
        new(Values.Signature);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Unknown =
        new(Values.Unknown);

    public DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily(value);
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
        DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamilySerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemWidgetFieldFamily value,
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
