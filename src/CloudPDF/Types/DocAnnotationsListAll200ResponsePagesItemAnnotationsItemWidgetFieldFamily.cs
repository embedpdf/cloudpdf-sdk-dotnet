using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamilySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Text =
        new(Values.Text);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Checkbox =
        new(Values.Checkbox);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Radio =
        new(Values.Radio);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Combobox =
        new(Values.Combobox);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Listbox =
        new(Values.Listbox);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Pushbutton =
        new(Values.Pushbutton);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Signature =
        new(Values.Signature);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Unknown =
        new(Values.Unknown);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamilySerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidgetFieldFamily value,
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
