using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeItemSkippedOp.ChangeItemSkippedOpSerializer))]
[Serializable]
public readonly record struct ChangeItemSkippedOp : IStringEnum
{
    public static readonly ChangeItemSkippedOp AnnotationsCreate = new(Values.AnnotationsCreate);

    public static readonly ChangeItemSkippedOp AnnotationsUpdate = new(Values.AnnotationsUpdate);

    public static readonly ChangeItemSkippedOp AnnotationsDelete = new(Values.AnnotationsDelete);

    public static readonly ChangeItemSkippedOp AnnotationsReorder = new(Values.AnnotationsReorder);

    public static readonly ChangeItemSkippedOp FormsSetValue = new(Values.FormsSetValue);

    public static readonly ChangeItemSkippedOp FormsSetDisplay = new(Values.FormsSetDisplay);

    public static readonly ChangeItemSkippedOp FormsSetAppearanceText = new(
        Values.FormsSetAppearanceText
    );

    public static readonly ChangeItemSkippedOp FormsReset = new(Values.FormsReset);

    public static readonly ChangeItemSkippedOp FormsCreate = new(Values.FormsCreate);

    public static readonly ChangeItemSkippedOp FormsUpdate = new(Values.FormsUpdate);

    public static readonly ChangeItemSkippedOp FormsDelete = new(Values.FormsDelete);

    public static readonly ChangeItemSkippedOp FormsAddWidget = new(Values.FormsAddWidget);

    public static readonly ChangeItemSkippedOp FormsRemoveWidget = new(Values.FormsRemoveWidget);

    public static readonly ChangeItemSkippedOp FormsDeleteWidget = new(Values.FormsDeleteWidget);

    public static readonly ChangeItemSkippedOp FormsReorderCalculations = new(
        Values.FormsReorderCalculations
    );

    public static readonly ChangeItemSkippedOp FormsReorderWidgets = new(
        Values.FormsReorderWidgets
    );

    public static readonly ChangeItemSkippedOp FormsUpdateWidget = new(Values.FormsUpdateWidget);

    public static readonly ChangeItemSkippedOp FormsSetSignatureAppearance = new(
        Values.FormsSetSignatureAppearance
    );

    public static readonly ChangeItemSkippedOp MetadataUpdate = new(Values.MetadataUpdate);

    public static readonly ChangeItemSkippedOp MetadataUpdateCustom = new(
        Values.MetadataUpdateCustom
    );

    public static readonly ChangeItemSkippedOp AnnotationsRestore = new(Values.AnnotationsRestore);

    public static readonly ChangeItemSkippedOp FormsRestore = new(Values.FormsRestore);

    public ChangeItemSkippedOp(string value)
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
    public static ChangeItemSkippedOp FromCustom(string value)
    {
        return new ChangeItemSkippedOp(value);
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

    public static bool operator ==(ChangeItemSkippedOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChangeItemSkippedOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemSkippedOp value) => value.Value;

    public static explicit operator ChangeItemSkippedOp(string value) => new(value);

    internal class ChangeItemSkippedOpSerializer : JsonConverter<ChangeItemSkippedOp>
    {
        public override ChangeItemSkippedOp Read(
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
            return new ChangeItemSkippedOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemSkippedOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemSkippedOp ReadAsPropertyName(
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
            return new ChangeItemSkippedOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemSkippedOp value,
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
        public const string AnnotationsCreate = "annotations.create";

        public const string AnnotationsUpdate = "annotations.update";

        public const string AnnotationsDelete = "annotations.delete";

        public const string AnnotationsReorder = "annotations.reorder";

        public const string FormsSetValue = "forms.setValue";

        public const string FormsSetDisplay = "forms.setDisplay";

        public const string FormsSetAppearanceText = "forms.setAppearanceText";

        public const string FormsReset = "forms.reset";

        public const string FormsCreate = "forms.create";

        public const string FormsUpdate = "forms.update";

        public const string FormsDelete = "forms.delete";

        public const string FormsAddWidget = "forms.addWidget";

        public const string FormsRemoveWidget = "forms.removeWidget";

        public const string FormsDeleteWidget = "forms.deleteWidget";

        public const string FormsReorderCalculations = "forms.reorderCalculations";

        public const string FormsReorderWidgets = "forms.reorderWidgets";

        public const string FormsUpdateWidget = "forms.updateWidget";

        public const string FormsSetSignatureAppearance = "forms.setSignatureAppearance";

        public const string MetadataUpdate = "metadata.update";

        public const string MetadataUpdateCustom = "metadata.updateCustom";

        public const string AnnotationsRestore = "annotations.restore";

        public const string FormsRestore = "forms.restore";
    }
}
