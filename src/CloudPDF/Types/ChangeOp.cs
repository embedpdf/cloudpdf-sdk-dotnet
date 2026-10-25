// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeOp.JsonConverter))]
[Serializable]
public record ChangeOp
{
    internal ChangeOp(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.AnnotationsCreate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.AnnotationsCreate value)
    {
        Type = "annotations.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.AnnotationsUpdate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.AnnotationsUpdate value)
    {
        Type = "annotations.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.AnnotationsDelete"/>.
    /// </summary>
    public ChangeOp(ChangeOp.AnnotationsDelete value)
    {
        Type = "annotations.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.AnnotationsReorder"/>.
    /// </summary>
    public ChangeOp(ChangeOp.AnnotationsReorder value)
    {
        Type = "annotations.reorder";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsSetValue"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsSetValue value)
    {
        Type = "forms.setValue";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsSetDisplay"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsSetDisplay value)
    {
        Type = "forms.setDisplay";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsSetAppearanceText"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsSetAppearanceText value)
    {
        Type = "forms.setAppearanceText";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsReset"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsReset value)
    {
        Type = "forms.reset";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsCreate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsCreate value)
    {
        Type = "forms.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsUpdate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsUpdate value)
    {
        Type = "forms.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsDelete"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsDelete value)
    {
        Type = "forms.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsAddWidget"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsAddWidget value)
    {
        Type = "forms.addWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsRemoveWidget"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsRemoveWidget value)
    {
        Type = "forms.removeWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsDeleteWidget"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsDeleteWidget value)
    {
        Type = "forms.deleteWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsReorderCalculations"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsReorderCalculations value)
    {
        Type = "forms.reorderCalculations";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsReorderWidgets"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsReorderWidgets value)
    {
        Type = "forms.reorderWidgets";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsUpdateWidget"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsUpdateWidget value)
    {
        Type = "forms.updateWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.FormsSetSignatureAppearance"/>.
    /// </summary>
    public ChangeOp(ChangeOp.FormsSetSignatureAppearance value)
    {
        Type = "forms.setSignatureAppearance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.MetadataUpdate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.MetadataUpdate value)
    {
        Type = "metadata.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.MetadataUpdateCustom"/>.
    /// </summary>
    public ChangeOp(ChangeOp.MetadataUpdateCustom value)
    {
        Type = "metadata.updateCustom";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.OutlineCreate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.OutlineCreate value)
    {
        Type = "outline.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.OutlineUpdate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.OutlineUpdate value)
    {
        Type = "outline.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.OutlineMove"/>.
    /// </summary>
    public ChangeOp(ChangeOp.OutlineMove value)
    {
        Type = "outline.move";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.OutlineDelete"/>.
    /// </summary>
    public ChangeOp(ChangeOp.OutlineDelete value)
    {
        Type = "outline.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.PagesRotate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.PagesRotate value)
    {
        Type = "pages.rotate";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.PagesReorder"/>.
    /// </summary>
    public ChangeOp(ChangeOp.PagesReorder value)
    {
        Type = "pages.reorder";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.PagesDelete"/>.
    /// </summary>
    public ChangeOp(ChangeOp.PagesDelete value)
    {
        Type = "pages.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.PagesInsertBlank"/>.
    /// </summary>
    public ChangeOp(ChangeOp.PagesInsertBlank value)
    {
        Type = "pages.insertBlank";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.PagesInsert"/>.
    /// </summary>
    public ChangeOp(ChangeOp.PagesInsert value)
    {
        Type = "pages.insert";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.AttachmentsCreate"/>.
    /// </summary>
    public ChangeOp(ChangeOp.AttachmentsCreate value)
    {
        Type = "attachments.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeOp with <see cref="ChangeOp.AttachmentsDelete"/>.
    /// </summary>
    public ChangeOp(ChangeOp.AttachmentsDelete value)
    {
        Type = "attachments.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "annotations.create"
    /// </summary>
    public bool IsAnnotationsCreate => Type == "annotations.create";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "annotations.update"
    /// </summary>
    public bool IsAnnotationsUpdate => Type == "annotations.update";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "annotations.delete"
    /// </summary>
    public bool IsAnnotationsDelete => Type == "annotations.delete";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "annotations.reorder"
    /// </summary>
    public bool IsAnnotationsReorder => Type == "annotations.reorder";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.setValue"
    /// </summary>
    public bool IsFormsSetValue => Type == "forms.setValue";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.setDisplay"
    /// </summary>
    public bool IsFormsSetDisplay => Type == "forms.setDisplay";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.setAppearanceText"
    /// </summary>
    public bool IsFormsSetAppearanceText => Type == "forms.setAppearanceText";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.reset"
    /// </summary>
    public bool IsFormsReset => Type == "forms.reset";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.create"
    /// </summary>
    public bool IsFormsCreate => Type == "forms.create";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.update"
    /// </summary>
    public bool IsFormsUpdate => Type == "forms.update";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.delete"
    /// </summary>
    public bool IsFormsDelete => Type == "forms.delete";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.addWidget"
    /// </summary>
    public bool IsFormsAddWidget => Type == "forms.addWidget";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.removeWidget"
    /// </summary>
    public bool IsFormsRemoveWidget => Type == "forms.removeWidget";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.deleteWidget"
    /// </summary>
    public bool IsFormsDeleteWidget => Type == "forms.deleteWidget";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.reorderCalculations"
    /// </summary>
    public bool IsFormsReorderCalculations => Type == "forms.reorderCalculations";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.reorderWidgets"
    /// </summary>
    public bool IsFormsReorderWidgets => Type == "forms.reorderWidgets";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.updateWidget"
    /// </summary>
    public bool IsFormsUpdateWidget => Type == "forms.updateWidget";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.setSignatureAppearance"
    /// </summary>
    public bool IsFormsSetSignatureAppearance => Type == "forms.setSignatureAppearance";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "metadata.update"
    /// </summary>
    public bool IsMetadataUpdate => Type == "metadata.update";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "metadata.updateCustom"
    /// </summary>
    public bool IsMetadataUpdateCustom => Type == "metadata.updateCustom";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "outline.create"
    /// </summary>
    public bool IsOutlineCreate => Type == "outline.create";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "outline.update"
    /// </summary>
    public bool IsOutlineUpdate => Type == "outline.update";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "outline.move"
    /// </summary>
    public bool IsOutlineMove => Type == "outline.move";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "outline.delete"
    /// </summary>
    public bool IsOutlineDelete => Type == "outline.delete";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "pages.rotate"
    /// </summary>
    public bool IsPagesRotate => Type == "pages.rotate";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "pages.reorder"
    /// </summary>
    public bool IsPagesReorder => Type == "pages.reorder";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "pages.delete"
    /// </summary>
    public bool IsPagesDelete => Type == "pages.delete";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "pages.insertBlank"
    /// </summary>
    public bool IsPagesInsertBlank => Type == "pages.insertBlank";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "pages.insert"
    /// </summary>
    public bool IsPagesInsert => Type == "pages.insert";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "attachments.create"
    /// </summary>
    public bool IsAttachmentsCreate => Type == "attachments.create";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "attachments.delete"
    /// </summary>
    public bool IsAttachmentsDelete => Type == "attachments.delete";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpAnnotationsCreate"/> if <see cref="Type"/> is 'annotations.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.create'.</exception>
    public CloudPDF.ChangeOpAnnotationsCreate AsAnnotationsCreate() =>
        IsAnnotationsCreate
            ? (CloudPDF.ChangeOpAnnotationsCreate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'annotations.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpAnnotationsUpdate"/> if <see cref="Type"/> is 'annotations.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.update'.</exception>
    public CloudPDF.ChangeOpAnnotationsUpdate AsAnnotationsUpdate() =>
        IsAnnotationsUpdate
            ? (CloudPDF.ChangeOpAnnotationsUpdate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'annotations.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpAnnotationsDelete"/> if <see cref="Type"/> is 'annotations.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.delete'.</exception>
    public CloudPDF.ChangeOpAnnotationsDelete AsAnnotationsDelete() =>
        IsAnnotationsDelete
            ? (CloudPDF.ChangeOpAnnotationsDelete)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'annotations.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpAnnotationsReorder"/> if <see cref="Type"/> is 'annotations.reorder', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.reorder'.</exception>
    public CloudPDF.ChangeOpAnnotationsReorder AsAnnotationsReorder() =>
        IsAnnotationsReorder
            ? (CloudPDF.ChangeOpAnnotationsReorder)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'annotations.reorder'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsSetValue"/> if <see cref="Type"/> is 'forms.setValue', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setValue'.</exception>
    public CloudPDF.ChangeOpFormsSetValue AsFormsSetValue() =>
        IsFormsSetValue
            ? (CloudPDF.ChangeOpFormsSetValue)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.setValue'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsSetDisplay"/> if <see cref="Type"/> is 'forms.setDisplay', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setDisplay'.</exception>
    public CloudPDF.ChangeOpFormsSetDisplay AsFormsSetDisplay() =>
        IsFormsSetDisplay
            ? (CloudPDF.ChangeOpFormsSetDisplay)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.setDisplay'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsSetAppearanceText"/> if <see cref="Type"/> is 'forms.setAppearanceText', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setAppearanceText'.</exception>
    public CloudPDF.ChangeOpFormsSetAppearanceText AsFormsSetAppearanceText() =>
        IsFormsSetAppearanceText
            ? (CloudPDF.ChangeOpFormsSetAppearanceText)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.setAppearanceText'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsReset"/> if <see cref="Type"/> is 'forms.reset', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.reset'.</exception>
    public CloudPDF.ChangeOpFormsReset AsFormsReset() =>
        IsFormsReset
            ? (CloudPDF.ChangeOpFormsReset)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.reset'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsCreate"/> if <see cref="Type"/> is 'forms.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.create'.</exception>
    public CloudPDF.ChangeOpFormsCreate AsFormsCreate() =>
        IsFormsCreate
            ? (CloudPDF.ChangeOpFormsCreate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsUpdate"/> if <see cref="Type"/> is 'forms.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.update'.</exception>
    public CloudPDF.ChangeOpFormsUpdate AsFormsUpdate() =>
        IsFormsUpdate
            ? (CloudPDF.ChangeOpFormsUpdate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsDelete"/> if <see cref="Type"/> is 'forms.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.delete'.</exception>
    public CloudPDF.ChangeOpFormsDelete AsFormsDelete() =>
        IsFormsDelete
            ? (CloudPDF.ChangeOpFormsDelete)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsAddWidget"/> if <see cref="Type"/> is 'forms.addWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.addWidget'.</exception>
    public CloudPDF.ChangeOpFormsAddWidget AsFormsAddWidget() =>
        IsFormsAddWidget
            ? (CloudPDF.ChangeOpFormsAddWidget)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.addWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsRemoveWidget"/> if <see cref="Type"/> is 'forms.removeWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.removeWidget'.</exception>
    public CloudPDF.ChangeOpFormsRemoveWidget AsFormsRemoveWidget() =>
        IsFormsRemoveWidget
            ? (CloudPDF.ChangeOpFormsRemoveWidget)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.removeWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsDeleteWidget"/> if <see cref="Type"/> is 'forms.deleteWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.deleteWidget'.</exception>
    public CloudPDF.ChangeOpFormsDeleteWidget AsFormsDeleteWidget() =>
        IsFormsDeleteWidget
            ? (CloudPDF.ChangeOpFormsDeleteWidget)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.deleteWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsReorderCalculations"/> if <see cref="Type"/> is 'forms.reorderCalculations', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.reorderCalculations'.</exception>
    public CloudPDF.ChangeOpFormsReorderCalculations AsFormsReorderCalculations() =>
        IsFormsReorderCalculations
            ? (CloudPDF.ChangeOpFormsReorderCalculations)Value!
            : throw new global::System.Exception(
                "ChangeOp.Type is not 'forms.reorderCalculations'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsReorderWidgets"/> if <see cref="Type"/> is 'forms.reorderWidgets', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.reorderWidgets'.</exception>
    public CloudPDF.ChangeOpFormsReorderWidgets AsFormsReorderWidgets() =>
        IsFormsReorderWidgets
            ? (CloudPDF.ChangeOpFormsReorderWidgets)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.reorderWidgets'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsUpdateWidget"/> if <see cref="Type"/> is 'forms.updateWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.updateWidget'.</exception>
    public CloudPDF.ChangeOpFormsUpdateWidget AsFormsUpdateWidget() =>
        IsFormsUpdateWidget
            ? (CloudPDF.ChangeOpFormsUpdateWidget)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'forms.updateWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpFormsSetSignatureAppearance"/> if <see cref="Type"/> is 'forms.setSignatureAppearance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setSignatureAppearance'.</exception>
    public CloudPDF.ChangeOpFormsSetSignatureAppearance AsFormsSetSignatureAppearance() =>
        IsFormsSetSignatureAppearance
            ? (CloudPDF.ChangeOpFormsSetSignatureAppearance)Value!
            : throw new global::System.Exception(
                "ChangeOp.Type is not 'forms.setSignatureAppearance'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpMetadataUpdate"/> if <see cref="Type"/> is 'metadata.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'metadata.update'.</exception>
    public CloudPDF.ChangeOpMetadataUpdate AsMetadataUpdate() =>
        IsMetadataUpdate
            ? (CloudPDF.ChangeOpMetadataUpdate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'metadata.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpMetadataUpdateCustom"/> if <see cref="Type"/> is 'metadata.updateCustom', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'metadata.updateCustom'.</exception>
    public CloudPDF.ChangeOpMetadataUpdateCustom AsMetadataUpdateCustom() =>
        IsMetadataUpdateCustom
            ? (CloudPDF.ChangeOpMetadataUpdateCustom)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'metadata.updateCustom'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpOutlineCreate"/> if <see cref="Type"/> is 'outline.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.create'.</exception>
    public CloudPDF.ChangeOpOutlineCreate AsOutlineCreate() =>
        IsOutlineCreate
            ? (CloudPDF.ChangeOpOutlineCreate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'outline.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpOutlineUpdate"/> if <see cref="Type"/> is 'outline.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.update'.</exception>
    public CloudPDF.ChangeOpOutlineUpdate AsOutlineUpdate() =>
        IsOutlineUpdate
            ? (CloudPDF.ChangeOpOutlineUpdate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'outline.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpOutlineMove"/> if <see cref="Type"/> is 'outline.move', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.move'.</exception>
    public CloudPDF.ChangeOpOutlineMove AsOutlineMove() =>
        IsOutlineMove
            ? (CloudPDF.ChangeOpOutlineMove)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'outline.move'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpOutlineDelete"/> if <see cref="Type"/> is 'outline.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.delete'.</exception>
    public CloudPDF.ChangeOpOutlineDelete AsOutlineDelete() =>
        IsOutlineDelete
            ? (CloudPDF.ChangeOpOutlineDelete)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'outline.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpPagesRotate"/> if <see cref="Type"/> is 'pages.rotate', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.rotate'.</exception>
    public CloudPDF.ChangeOpPagesRotate AsPagesRotate() =>
        IsPagesRotate
            ? (CloudPDF.ChangeOpPagesRotate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'pages.rotate'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpPagesReorder"/> if <see cref="Type"/> is 'pages.reorder', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.reorder'.</exception>
    public CloudPDF.ChangeOpPagesReorder AsPagesReorder() =>
        IsPagesReorder
            ? (CloudPDF.ChangeOpPagesReorder)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'pages.reorder'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpPagesDelete"/> if <see cref="Type"/> is 'pages.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.delete'.</exception>
    public CloudPDF.ChangeOpPagesDelete AsPagesDelete() =>
        IsPagesDelete
            ? (CloudPDF.ChangeOpPagesDelete)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'pages.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpPagesInsertBlank"/> if <see cref="Type"/> is 'pages.insertBlank', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.insertBlank'.</exception>
    public CloudPDF.ChangeOpPagesInsertBlank AsPagesInsertBlank() =>
        IsPagesInsertBlank
            ? (CloudPDF.ChangeOpPagesInsertBlank)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'pages.insertBlank'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpPagesInsert"/> if <see cref="Type"/> is 'pages.insert', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.insert'.</exception>
    public CloudPDF.ChangeOpPagesInsert AsPagesInsert() =>
        IsPagesInsert
            ? (CloudPDF.ChangeOpPagesInsert)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'pages.insert'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpAttachmentsCreate"/> if <see cref="Type"/> is 'attachments.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'attachments.create'.</exception>
    public CloudPDF.ChangeOpAttachmentsCreate AsAttachmentsCreate() =>
        IsAttachmentsCreate
            ? (CloudPDF.ChangeOpAttachmentsCreate)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'attachments.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeOpAttachmentsDelete"/> if <see cref="Type"/> is 'attachments.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'attachments.delete'.</exception>
    public CloudPDF.ChangeOpAttachmentsDelete AsAttachmentsDelete() =>
        IsAttachmentsDelete
            ? (CloudPDF.ChangeOpAttachmentsDelete)Value!
            : throw new global::System.Exception("ChangeOp.Type is not 'attachments.delete'");

    public T Match<T>(
        Func<CloudPDF.ChangeOpAnnotationsCreate, T> onAnnotationsCreate,
        Func<CloudPDF.ChangeOpAnnotationsUpdate, T> onAnnotationsUpdate,
        Func<CloudPDF.ChangeOpAnnotationsDelete, T> onAnnotationsDelete,
        Func<CloudPDF.ChangeOpAnnotationsReorder, T> onAnnotationsReorder,
        Func<CloudPDF.ChangeOpFormsSetValue, T> onFormsSetValue,
        Func<CloudPDF.ChangeOpFormsSetDisplay, T> onFormsSetDisplay,
        Func<CloudPDF.ChangeOpFormsSetAppearanceText, T> onFormsSetAppearanceText,
        Func<CloudPDF.ChangeOpFormsReset, T> onFormsReset,
        Func<CloudPDF.ChangeOpFormsCreate, T> onFormsCreate,
        Func<CloudPDF.ChangeOpFormsUpdate, T> onFormsUpdate,
        Func<CloudPDF.ChangeOpFormsDelete, T> onFormsDelete,
        Func<CloudPDF.ChangeOpFormsAddWidget, T> onFormsAddWidget,
        Func<CloudPDF.ChangeOpFormsRemoveWidget, T> onFormsRemoveWidget,
        Func<CloudPDF.ChangeOpFormsDeleteWidget, T> onFormsDeleteWidget,
        Func<CloudPDF.ChangeOpFormsReorderCalculations, T> onFormsReorderCalculations,
        Func<CloudPDF.ChangeOpFormsReorderWidgets, T> onFormsReorderWidgets,
        Func<CloudPDF.ChangeOpFormsUpdateWidget, T> onFormsUpdateWidget,
        Func<CloudPDF.ChangeOpFormsSetSignatureAppearance, T> onFormsSetSignatureAppearance,
        Func<CloudPDF.ChangeOpMetadataUpdate, T> onMetadataUpdate,
        Func<CloudPDF.ChangeOpMetadataUpdateCustom, T> onMetadataUpdateCustom,
        Func<CloudPDF.ChangeOpOutlineCreate, T> onOutlineCreate,
        Func<CloudPDF.ChangeOpOutlineUpdate, T> onOutlineUpdate,
        Func<CloudPDF.ChangeOpOutlineMove, T> onOutlineMove,
        Func<CloudPDF.ChangeOpOutlineDelete, T> onOutlineDelete,
        Func<CloudPDF.ChangeOpPagesRotate, T> onPagesRotate,
        Func<CloudPDF.ChangeOpPagesReorder, T> onPagesReorder,
        Func<CloudPDF.ChangeOpPagesDelete, T> onPagesDelete,
        Func<CloudPDF.ChangeOpPagesInsertBlank, T> onPagesInsertBlank,
        Func<CloudPDF.ChangeOpPagesInsert, T> onPagesInsert,
        Func<CloudPDF.ChangeOpAttachmentsCreate, T> onAttachmentsCreate,
        Func<CloudPDF.ChangeOpAttachmentsDelete, T> onAttachmentsDelete,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "annotations.create" => onAnnotationsCreate(AsAnnotationsCreate()),
            "annotations.update" => onAnnotationsUpdate(AsAnnotationsUpdate()),
            "annotations.delete" => onAnnotationsDelete(AsAnnotationsDelete()),
            "annotations.reorder" => onAnnotationsReorder(AsAnnotationsReorder()),
            "forms.setValue" => onFormsSetValue(AsFormsSetValue()),
            "forms.setDisplay" => onFormsSetDisplay(AsFormsSetDisplay()),
            "forms.setAppearanceText" => onFormsSetAppearanceText(AsFormsSetAppearanceText()),
            "forms.reset" => onFormsReset(AsFormsReset()),
            "forms.create" => onFormsCreate(AsFormsCreate()),
            "forms.update" => onFormsUpdate(AsFormsUpdate()),
            "forms.delete" => onFormsDelete(AsFormsDelete()),
            "forms.addWidget" => onFormsAddWidget(AsFormsAddWidget()),
            "forms.removeWidget" => onFormsRemoveWidget(AsFormsRemoveWidget()),
            "forms.deleteWidget" => onFormsDeleteWidget(AsFormsDeleteWidget()),
            "forms.reorderCalculations" => onFormsReorderCalculations(AsFormsReorderCalculations()),
            "forms.reorderWidgets" => onFormsReorderWidgets(AsFormsReorderWidgets()),
            "forms.updateWidget" => onFormsUpdateWidget(AsFormsUpdateWidget()),
            "forms.setSignatureAppearance" => onFormsSetSignatureAppearance(
                AsFormsSetSignatureAppearance()
            ),
            "metadata.update" => onMetadataUpdate(AsMetadataUpdate()),
            "metadata.updateCustom" => onMetadataUpdateCustom(AsMetadataUpdateCustom()),
            "outline.create" => onOutlineCreate(AsOutlineCreate()),
            "outline.update" => onOutlineUpdate(AsOutlineUpdate()),
            "outline.move" => onOutlineMove(AsOutlineMove()),
            "outline.delete" => onOutlineDelete(AsOutlineDelete()),
            "pages.rotate" => onPagesRotate(AsPagesRotate()),
            "pages.reorder" => onPagesReorder(AsPagesReorder()),
            "pages.delete" => onPagesDelete(AsPagesDelete()),
            "pages.insertBlank" => onPagesInsertBlank(AsPagesInsertBlank()),
            "pages.insert" => onPagesInsert(AsPagesInsert()),
            "attachments.create" => onAttachmentsCreate(AsAttachmentsCreate()),
            "attachments.delete" => onAttachmentsDelete(AsAttachmentsDelete()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.ChangeOpAnnotationsCreate> onAnnotationsCreate,
        Action<CloudPDF.ChangeOpAnnotationsUpdate> onAnnotationsUpdate,
        Action<CloudPDF.ChangeOpAnnotationsDelete> onAnnotationsDelete,
        Action<CloudPDF.ChangeOpAnnotationsReorder> onAnnotationsReorder,
        Action<CloudPDF.ChangeOpFormsSetValue> onFormsSetValue,
        Action<CloudPDF.ChangeOpFormsSetDisplay> onFormsSetDisplay,
        Action<CloudPDF.ChangeOpFormsSetAppearanceText> onFormsSetAppearanceText,
        Action<CloudPDF.ChangeOpFormsReset> onFormsReset,
        Action<CloudPDF.ChangeOpFormsCreate> onFormsCreate,
        Action<CloudPDF.ChangeOpFormsUpdate> onFormsUpdate,
        Action<CloudPDF.ChangeOpFormsDelete> onFormsDelete,
        Action<CloudPDF.ChangeOpFormsAddWidget> onFormsAddWidget,
        Action<CloudPDF.ChangeOpFormsRemoveWidget> onFormsRemoveWidget,
        Action<CloudPDF.ChangeOpFormsDeleteWidget> onFormsDeleteWidget,
        Action<CloudPDF.ChangeOpFormsReorderCalculations> onFormsReorderCalculations,
        Action<CloudPDF.ChangeOpFormsReorderWidgets> onFormsReorderWidgets,
        Action<CloudPDF.ChangeOpFormsUpdateWidget> onFormsUpdateWidget,
        Action<CloudPDF.ChangeOpFormsSetSignatureAppearance> onFormsSetSignatureAppearance,
        Action<CloudPDF.ChangeOpMetadataUpdate> onMetadataUpdate,
        Action<CloudPDF.ChangeOpMetadataUpdateCustom> onMetadataUpdateCustom,
        Action<CloudPDF.ChangeOpOutlineCreate> onOutlineCreate,
        Action<CloudPDF.ChangeOpOutlineUpdate> onOutlineUpdate,
        Action<CloudPDF.ChangeOpOutlineMove> onOutlineMove,
        Action<CloudPDF.ChangeOpOutlineDelete> onOutlineDelete,
        Action<CloudPDF.ChangeOpPagesRotate> onPagesRotate,
        Action<CloudPDF.ChangeOpPagesReorder> onPagesReorder,
        Action<CloudPDF.ChangeOpPagesDelete> onPagesDelete,
        Action<CloudPDF.ChangeOpPagesInsertBlank> onPagesInsertBlank,
        Action<CloudPDF.ChangeOpPagesInsert> onPagesInsert,
        Action<CloudPDF.ChangeOpAttachmentsCreate> onAttachmentsCreate,
        Action<CloudPDF.ChangeOpAttachmentsDelete> onAttachmentsDelete,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "annotations.create":
                onAnnotationsCreate(AsAnnotationsCreate());
                break;
            case "annotations.update":
                onAnnotationsUpdate(AsAnnotationsUpdate());
                break;
            case "annotations.delete":
                onAnnotationsDelete(AsAnnotationsDelete());
                break;
            case "annotations.reorder":
                onAnnotationsReorder(AsAnnotationsReorder());
                break;
            case "forms.setValue":
                onFormsSetValue(AsFormsSetValue());
                break;
            case "forms.setDisplay":
                onFormsSetDisplay(AsFormsSetDisplay());
                break;
            case "forms.setAppearanceText":
                onFormsSetAppearanceText(AsFormsSetAppearanceText());
                break;
            case "forms.reset":
                onFormsReset(AsFormsReset());
                break;
            case "forms.create":
                onFormsCreate(AsFormsCreate());
                break;
            case "forms.update":
                onFormsUpdate(AsFormsUpdate());
                break;
            case "forms.delete":
                onFormsDelete(AsFormsDelete());
                break;
            case "forms.addWidget":
                onFormsAddWidget(AsFormsAddWidget());
                break;
            case "forms.removeWidget":
                onFormsRemoveWidget(AsFormsRemoveWidget());
                break;
            case "forms.deleteWidget":
                onFormsDeleteWidget(AsFormsDeleteWidget());
                break;
            case "forms.reorderCalculations":
                onFormsReorderCalculations(AsFormsReorderCalculations());
                break;
            case "forms.reorderWidgets":
                onFormsReorderWidgets(AsFormsReorderWidgets());
                break;
            case "forms.updateWidget":
                onFormsUpdateWidget(AsFormsUpdateWidget());
                break;
            case "forms.setSignatureAppearance":
                onFormsSetSignatureAppearance(AsFormsSetSignatureAppearance());
                break;
            case "metadata.update":
                onMetadataUpdate(AsMetadataUpdate());
                break;
            case "metadata.updateCustom":
                onMetadataUpdateCustom(AsMetadataUpdateCustom());
                break;
            case "outline.create":
                onOutlineCreate(AsOutlineCreate());
                break;
            case "outline.update":
                onOutlineUpdate(AsOutlineUpdate());
                break;
            case "outline.move":
                onOutlineMove(AsOutlineMove());
                break;
            case "outline.delete":
                onOutlineDelete(AsOutlineDelete());
                break;
            case "pages.rotate":
                onPagesRotate(AsPagesRotate());
                break;
            case "pages.reorder":
                onPagesReorder(AsPagesReorder());
                break;
            case "pages.delete":
                onPagesDelete(AsPagesDelete());
                break;
            case "pages.insertBlank":
                onPagesInsertBlank(AsPagesInsertBlank());
                break;
            case "pages.insert":
                onPagesInsert(AsPagesInsert());
                break;
            case "attachments.create":
                onAttachmentsCreate(AsAttachmentsCreate());
                break;
            case "attachments.delete":
                onAttachmentsDelete(AsAttachmentsDelete());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpAnnotationsCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsCreate(out CloudPDF.ChangeOpAnnotationsCreate? value)
    {
        if (Type == "annotations.create")
        {
            value = (CloudPDF.ChangeOpAnnotationsCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpAnnotationsUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsUpdate(out CloudPDF.ChangeOpAnnotationsUpdate? value)
    {
        if (Type == "annotations.update")
        {
            value = (CloudPDF.ChangeOpAnnotationsUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpAnnotationsDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsDelete(out CloudPDF.ChangeOpAnnotationsDelete? value)
    {
        if (Type == "annotations.delete")
        {
            value = (CloudPDF.ChangeOpAnnotationsDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpAnnotationsReorder"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsReorder(out CloudPDF.ChangeOpAnnotationsReorder? value)
    {
        if (Type == "annotations.reorder")
        {
            value = (CloudPDF.ChangeOpAnnotationsReorder)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsSetValue"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetValue(out CloudPDF.ChangeOpFormsSetValue? value)
    {
        if (Type == "forms.setValue")
        {
            value = (CloudPDF.ChangeOpFormsSetValue)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsSetDisplay"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetDisplay(out CloudPDF.ChangeOpFormsSetDisplay? value)
    {
        if (Type == "forms.setDisplay")
        {
            value = (CloudPDF.ChangeOpFormsSetDisplay)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsSetAppearanceText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetAppearanceText(out CloudPDF.ChangeOpFormsSetAppearanceText? value)
    {
        if (Type == "forms.setAppearanceText")
        {
            value = (CloudPDF.ChangeOpFormsSetAppearanceText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsReset"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsReset(out CloudPDF.ChangeOpFormsReset? value)
    {
        if (Type == "forms.reset")
        {
            value = (CloudPDF.ChangeOpFormsReset)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsCreate(out CloudPDF.ChangeOpFormsCreate? value)
    {
        if (Type == "forms.create")
        {
            value = (CloudPDF.ChangeOpFormsCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsUpdate(out CloudPDF.ChangeOpFormsUpdate? value)
    {
        if (Type == "forms.update")
        {
            value = (CloudPDF.ChangeOpFormsUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsDelete(out CloudPDF.ChangeOpFormsDelete? value)
    {
        if (Type == "forms.delete")
        {
            value = (CloudPDF.ChangeOpFormsDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsAddWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsAddWidget(out CloudPDF.ChangeOpFormsAddWidget? value)
    {
        if (Type == "forms.addWidget")
        {
            value = (CloudPDF.ChangeOpFormsAddWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsRemoveWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsRemoveWidget(out CloudPDF.ChangeOpFormsRemoveWidget? value)
    {
        if (Type == "forms.removeWidget")
        {
            value = (CloudPDF.ChangeOpFormsRemoveWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsDeleteWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsDeleteWidget(out CloudPDF.ChangeOpFormsDeleteWidget? value)
    {
        if (Type == "forms.deleteWidget")
        {
            value = (CloudPDF.ChangeOpFormsDeleteWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsReorderCalculations"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsReorderCalculations(out CloudPDF.ChangeOpFormsReorderCalculations? value)
    {
        if (Type == "forms.reorderCalculations")
        {
            value = (CloudPDF.ChangeOpFormsReorderCalculations)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsReorderWidgets"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsReorderWidgets(out CloudPDF.ChangeOpFormsReorderWidgets? value)
    {
        if (Type == "forms.reorderWidgets")
        {
            value = (CloudPDF.ChangeOpFormsReorderWidgets)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsUpdateWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsUpdateWidget(out CloudPDF.ChangeOpFormsUpdateWidget? value)
    {
        if (Type == "forms.updateWidget")
        {
            value = (CloudPDF.ChangeOpFormsUpdateWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpFormsSetSignatureAppearance"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetSignatureAppearance(
        out CloudPDF.ChangeOpFormsSetSignatureAppearance? value
    )
    {
        if (Type == "forms.setSignatureAppearance")
        {
            value = (CloudPDF.ChangeOpFormsSetSignatureAppearance)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpMetadataUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsMetadataUpdate(out CloudPDF.ChangeOpMetadataUpdate? value)
    {
        if (Type == "metadata.update")
        {
            value = (CloudPDF.ChangeOpMetadataUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpMetadataUpdateCustom"/> and returns true if successful.
    /// </summary>
    public bool TryAsMetadataUpdateCustom(out CloudPDF.ChangeOpMetadataUpdateCustom? value)
    {
        if (Type == "metadata.updateCustom")
        {
            value = (CloudPDF.ChangeOpMetadataUpdateCustom)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpOutlineCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineCreate(out CloudPDF.ChangeOpOutlineCreate? value)
    {
        if (Type == "outline.create")
        {
            value = (CloudPDF.ChangeOpOutlineCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpOutlineUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineUpdate(out CloudPDF.ChangeOpOutlineUpdate? value)
    {
        if (Type == "outline.update")
        {
            value = (CloudPDF.ChangeOpOutlineUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpOutlineMove"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineMove(out CloudPDF.ChangeOpOutlineMove? value)
    {
        if (Type == "outline.move")
        {
            value = (CloudPDF.ChangeOpOutlineMove)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpOutlineDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineDelete(out CloudPDF.ChangeOpOutlineDelete? value)
    {
        if (Type == "outline.delete")
        {
            value = (CloudPDF.ChangeOpOutlineDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpPagesRotate"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesRotate(out CloudPDF.ChangeOpPagesRotate? value)
    {
        if (Type == "pages.rotate")
        {
            value = (CloudPDF.ChangeOpPagesRotate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpPagesReorder"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesReorder(out CloudPDF.ChangeOpPagesReorder? value)
    {
        if (Type == "pages.reorder")
        {
            value = (CloudPDF.ChangeOpPagesReorder)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpPagesDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesDelete(out CloudPDF.ChangeOpPagesDelete? value)
    {
        if (Type == "pages.delete")
        {
            value = (CloudPDF.ChangeOpPagesDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpPagesInsertBlank"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesInsertBlank(out CloudPDF.ChangeOpPagesInsertBlank? value)
    {
        if (Type == "pages.insertBlank")
        {
            value = (CloudPDF.ChangeOpPagesInsertBlank)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpPagesInsert"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesInsert(out CloudPDF.ChangeOpPagesInsert? value)
    {
        if (Type == "pages.insert")
        {
            value = (CloudPDF.ChangeOpPagesInsert)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpAttachmentsCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAttachmentsCreate(out CloudPDF.ChangeOpAttachmentsCreate? value)
    {
        if (Type == "attachments.create")
        {
            value = (CloudPDF.ChangeOpAttachmentsCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeOpAttachmentsDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsAttachmentsDelete(out CloudPDF.ChangeOpAttachmentsDelete? value)
    {
        if (Type == "attachments.delete")
        {
            value = (CloudPDF.ChangeOpAttachmentsDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ChangeOp(ChangeOp.AnnotationsCreate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.AnnotationsUpdate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.AnnotationsDelete value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.AnnotationsReorder value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsSetValue value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsSetDisplay value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsSetAppearanceText value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsReset value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsCreate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsUpdate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsDelete value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsAddWidget value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsRemoveWidget value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsDeleteWidget value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsReorderCalculations value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsReorderWidgets value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsUpdateWidget value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.FormsSetSignatureAppearance value) =>
        new(value);

    public static implicit operator ChangeOp(ChangeOp.MetadataUpdate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.MetadataUpdateCustom value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.OutlineCreate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.OutlineUpdate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.OutlineMove value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.OutlineDelete value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.PagesRotate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.PagesReorder value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.PagesDelete value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.PagesInsertBlank value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.PagesInsert value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.AttachmentsCreate value) => new(value);

    public static implicit operator ChangeOp(ChangeOp.AttachmentsDelete value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ChangeOp>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ChangeOp).IsAssignableFrom(typeToConvert);

        public override ChangeOp Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "annotations.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpAnnotationsCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpAnnotationsCreate"
                        ),
                "annotations.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpAnnotationsUpdate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpAnnotationsUpdate"
                        ),
                "annotations.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpAnnotationsDelete?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpAnnotationsDelete"
                        ),
                "annotations.reorder" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpAnnotationsReorder?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpAnnotationsReorder"
                        ),
                "forms.setValue" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsSetValue?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsSetValue"
                        ),
                "forms.setDisplay" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsSetDisplay?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsSetDisplay"
                        ),
                "forms.setAppearanceText" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsSetAppearanceText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsSetAppearanceText"
                        ),
                "forms.reset" => jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsReset?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.ChangeOpFormsReset"),
                "forms.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsCreate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsCreate"
                        ),
                "forms.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsUpdate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsUpdate"
                        ),
                "forms.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsDelete?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsDelete"
                        ),
                "forms.addWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsAddWidget?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsAddWidget"
                        ),
                "forms.removeWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsRemoveWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsRemoveWidget"
                        ),
                "forms.deleteWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsDeleteWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsDeleteWidget"
                        ),
                "forms.reorderCalculations" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsReorderCalculations?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsReorderCalculations"
                        ),
                "forms.reorderWidgets" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsReorderWidgets?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsReorderWidgets"
                        ),
                "forms.updateWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsUpdateWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsUpdateWidget"
                        ),
                "forms.setSignatureAppearance" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpFormsSetSignatureAppearance?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpFormsSetSignatureAppearance"
                        ),
                "metadata.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpMetadataUpdate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpMetadataUpdate"
                        ),
                "metadata.updateCustom" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpMetadataUpdateCustom?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpMetadataUpdateCustom"
                        ),
                "outline.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpOutlineCreate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpOutlineCreate"
                        ),
                "outline.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpOutlineUpdate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpOutlineUpdate"
                        ),
                "outline.move" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpOutlineMove?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpOutlineMove"
                        ),
                "outline.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpOutlineDelete?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpOutlineDelete"
                        ),
                "pages.rotate" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpPagesRotate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpPagesRotate"
                        ),
                "pages.reorder" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpPagesReorder?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpPagesReorder"
                        ),
                "pages.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpPagesDelete?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpPagesDelete"
                        ),
                "pages.insertBlank" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpPagesInsertBlank?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpPagesInsertBlank"
                        ),
                "pages.insert" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpPagesInsert?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpPagesInsert"
                        ),
                "attachments.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpAttachmentsCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpAttachmentsCreate"
                        ),
                "attachments.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeOpAttachmentsDelete?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeOpAttachmentsDelete"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ChangeOp(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOp value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "annotations.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.reorder" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.setValue" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.setDisplay" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.setAppearanceText" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "forms.reset" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.addWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.removeWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.deleteWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.reorderCalculations" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "forms.reorderWidgets" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.updateWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.setSignatureAppearance" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "metadata.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "metadata.updateCustom" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.move" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.rotate" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.reorder" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.insertBlank" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.insert" => JsonSerializer.SerializeToNode(value.Value, options),
                    "attachments.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "attachments.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override ChangeOp ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ChangeOp(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOp value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for annotations.create
    /// </summary>
    [Serializable]
    public struct AnnotationsCreate
    {
        public AnnotationsCreate(CloudPDF.ChangeOpAnnotationsCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpAnnotationsCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.AnnotationsCreate(
            CloudPDF.ChangeOpAnnotationsCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.update
    /// </summary>
    [Serializable]
    public struct AnnotationsUpdate
    {
        public AnnotationsUpdate(CloudPDF.ChangeOpAnnotationsUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpAnnotationsUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.AnnotationsUpdate(
            CloudPDF.ChangeOpAnnotationsUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.delete
    /// </summary>
    [Serializable]
    public struct AnnotationsDelete
    {
        public AnnotationsDelete(CloudPDF.ChangeOpAnnotationsDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpAnnotationsDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.AnnotationsDelete(
            CloudPDF.ChangeOpAnnotationsDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.reorder
    /// </summary>
    [Serializable]
    public struct AnnotationsReorder
    {
        public AnnotationsReorder(CloudPDF.ChangeOpAnnotationsReorder value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpAnnotationsReorder Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.AnnotationsReorder(
            CloudPDF.ChangeOpAnnotationsReorder value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setValue
    /// </summary>
    [Serializable]
    public struct FormsSetValue
    {
        public FormsSetValue(CloudPDF.ChangeOpFormsSetValue value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsSetValue Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsSetValue(
            CloudPDF.ChangeOpFormsSetValue value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setDisplay
    /// </summary>
    [Serializable]
    public struct FormsSetDisplay
    {
        public FormsSetDisplay(CloudPDF.ChangeOpFormsSetDisplay value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsSetDisplay Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsSetDisplay(
            CloudPDF.ChangeOpFormsSetDisplay value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setAppearanceText
    /// </summary>
    [Serializable]
    public struct FormsSetAppearanceText
    {
        public FormsSetAppearanceText(CloudPDF.ChangeOpFormsSetAppearanceText value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsSetAppearanceText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsSetAppearanceText(
            CloudPDF.ChangeOpFormsSetAppearanceText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.reset
    /// </summary>
    [Serializable]
    public struct FormsReset
    {
        public FormsReset(CloudPDF.ChangeOpFormsReset value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsReset Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsReset(CloudPDF.ChangeOpFormsReset value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.create
    /// </summary>
    [Serializable]
    public struct FormsCreate
    {
        public FormsCreate(CloudPDF.ChangeOpFormsCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsCreate(CloudPDF.ChangeOpFormsCreate value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.update
    /// </summary>
    [Serializable]
    public struct FormsUpdate
    {
        public FormsUpdate(CloudPDF.ChangeOpFormsUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsUpdate(CloudPDF.ChangeOpFormsUpdate value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.delete
    /// </summary>
    [Serializable]
    public struct FormsDelete
    {
        public FormsDelete(CloudPDF.ChangeOpFormsDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsDelete(CloudPDF.ChangeOpFormsDelete value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.addWidget
    /// </summary>
    [Serializable]
    public struct FormsAddWidget
    {
        public FormsAddWidget(CloudPDF.ChangeOpFormsAddWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsAddWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsAddWidget(
            CloudPDF.ChangeOpFormsAddWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.removeWidget
    /// </summary>
    [Serializable]
    public struct FormsRemoveWidget
    {
        public FormsRemoveWidget(CloudPDF.ChangeOpFormsRemoveWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsRemoveWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsRemoveWidget(
            CloudPDF.ChangeOpFormsRemoveWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.deleteWidget
    /// </summary>
    [Serializable]
    public struct FormsDeleteWidget
    {
        public FormsDeleteWidget(CloudPDF.ChangeOpFormsDeleteWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsDeleteWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsDeleteWidget(
            CloudPDF.ChangeOpFormsDeleteWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.reorderCalculations
    /// </summary>
    [Serializable]
    public struct FormsReorderCalculations
    {
        public FormsReorderCalculations(CloudPDF.ChangeOpFormsReorderCalculations value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsReorderCalculations Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsReorderCalculations(
            CloudPDF.ChangeOpFormsReorderCalculations value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.reorderWidgets
    /// </summary>
    [Serializable]
    public struct FormsReorderWidgets
    {
        public FormsReorderWidgets(CloudPDF.ChangeOpFormsReorderWidgets value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsReorderWidgets Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsReorderWidgets(
            CloudPDF.ChangeOpFormsReorderWidgets value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.updateWidget
    /// </summary>
    [Serializable]
    public struct FormsUpdateWidget
    {
        public FormsUpdateWidget(CloudPDF.ChangeOpFormsUpdateWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsUpdateWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsUpdateWidget(
            CloudPDF.ChangeOpFormsUpdateWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setSignatureAppearance
    /// </summary>
    [Serializable]
    public struct FormsSetSignatureAppearance
    {
        public FormsSetSignatureAppearance(CloudPDF.ChangeOpFormsSetSignatureAppearance value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpFormsSetSignatureAppearance Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.FormsSetSignatureAppearance(
            CloudPDF.ChangeOpFormsSetSignatureAppearance value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for metadata.update
    /// </summary>
    [Serializable]
    public struct MetadataUpdate
    {
        public MetadataUpdate(CloudPDF.ChangeOpMetadataUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpMetadataUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.MetadataUpdate(
            CloudPDF.ChangeOpMetadataUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for metadata.updateCustom
    /// </summary>
    [Serializable]
    public struct MetadataUpdateCustom
    {
        public MetadataUpdateCustom(CloudPDF.ChangeOpMetadataUpdateCustom value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpMetadataUpdateCustom Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.MetadataUpdateCustom(
            CloudPDF.ChangeOpMetadataUpdateCustom value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.create
    /// </summary>
    [Serializable]
    public struct OutlineCreate
    {
        public OutlineCreate(CloudPDF.ChangeOpOutlineCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpOutlineCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.OutlineCreate(
            CloudPDF.ChangeOpOutlineCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.update
    /// </summary>
    [Serializable]
    public struct OutlineUpdate
    {
        public OutlineUpdate(CloudPDF.ChangeOpOutlineUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpOutlineUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.OutlineUpdate(
            CloudPDF.ChangeOpOutlineUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.move
    /// </summary>
    [Serializable]
    public struct OutlineMove
    {
        public OutlineMove(CloudPDF.ChangeOpOutlineMove value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpOutlineMove Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.OutlineMove(CloudPDF.ChangeOpOutlineMove value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.delete
    /// </summary>
    [Serializable]
    public struct OutlineDelete
    {
        public OutlineDelete(CloudPDF.ChangeOpOutlineDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpOutlineDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.OutlineDelete(
            CloudPDF.ChangeOpOutlineDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.rotate
    /// </summary>
    [Serializable]
    public struct PagesRotate
    {
        public PagesRotate(CloudPDF.ChangeOpPagesRotate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpPagesRotate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.PagesRotate(CloudPDF.ChangeOpPagesRotate value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.reorder
    /// </summary>
    [Serializable]
    public struct PagesReorder
    {
        public PagesReorder(CloudPDF.ChangeOpPagesReorder value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpPagesReorder Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.PagesReorder(
            CloudPDF.ChangeOpPagesReorder value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.delete
    /// </summary>
    [Serializable]
    public struct PagesDelete
    {
        public PagesDelete(CloudPDF.ChangeOpPagesDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpPagesDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.PagesDelete(CloudPDF.ChangeOpPagesDelete value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.insertBlank
    /// </summary>
    [Serializable]
    public struct PagesInsertBlank
    {
        public PagesInsertBlank(CloudPDF.ChangeOpPagesInsertBlank value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpPagesInsertBlank Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.PagesInsertBlank(
            CloudPDF.ChangeOpPagesInsertBlank value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.insert
    /// </summary>
    [Serializable]
    public struct PagesInsert
    {
        public PagesInsert(CloudPDF.ChangeOpPagesInsert value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpPagesInsert Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.PagesInsert(CloudPDF.ChangeOpPagesInsert value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for attachments.create
    /// </summary>
    [Serializable]
    public struct AttachmentsCreate
    {
        public AttachmentsCreate(CloudPDF.ChangeOpAttachmentsCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpAttachmentsCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.AttachmentsCreate(
            CloudPDF.ChangeOpAttachmentsCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for attachments.delete
    /// </summary>
    [Serializable]
    public struct AttachmentsDelete
    {
        public AttachmentsDelete(CloudPDF.ChangeOpAttachmentsDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeOpAttachmentsDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeOp.AttachmentsDelete(
            CloudPDF.ChangeOpAttachmentsDelete value
        ) => new(value);
    }
}
