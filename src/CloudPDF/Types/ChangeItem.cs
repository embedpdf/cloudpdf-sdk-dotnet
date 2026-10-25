// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ChangeItem.JsonConverter))]
[Serializable]
public record ChangeItem
{
    internal ChangeItem(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.Skipped"/>.
    /// </summary>
    public ChangeItem(ChangeItem.Skipped value)
    {
        Type = "skipped";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AnnotationsCreate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AnnotationsCreate value)
    {
        Type = "annotations.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AnnotationsUpdate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AnnotationsUpdate value)
    {
        Type = "annotations.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AnnotationsDelete"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AnnotationsDelete value)
    {
        Type = "annotations.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AnnotationsReorder"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AnnotationsReorder value)
    {
        Type = "annotations.reorder";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AnnotationsRestore"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AnnotationsRestore value)
    {
        Type = "annotations.restore";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsSetValue"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsSetValue value)
    {
        Type = "forms.setValue";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsSetDisplay"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsSetDisplay value)
    {
        Type = "forms.setDisplay";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsSetAppearanceText"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsSetAppearanceText value)
    {
        Type = "forms.setAppearanceText";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsReset"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsReset value)
    {
        Type = "forms.reset";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsCreate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsCreate value)
    {
        Type = "forms.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsUpdate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsUpdate value)
    {
        Type = "forms.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsDelete"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsDelete value)
    {
        Type = "forms.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsRestore"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsRestore value)
    {
        Type = "forms.restore";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsSetSignatureAppearance"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsSetSignatureAppearance value)
    {
        Type = "forms.setSignatureAppearance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsAddWidget"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsAddWidget value)
    {
        Type = "forms.addWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsRemoveWidget"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsRemoveWidget value)
    {
        Type = "forms.removeWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsDeleteWidget"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsDeleteWidget value)
    {
        Type = "forms.deleteWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsRestoreWidget"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsRestoreWidget value)
    {
        Type = "forms.restoreWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsReorderWidgets"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsReorderWidgets value)
    {
        Type = "forms.reorderWidgets";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsReorderCalculations"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsReorderCalculations value)
    {
        Type = "forms.reorderCalculations";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.FormsUpdateWidget"/>.
    /// </summary>
    public ChangeItem(ChangeItem.FormsUpdateWidget value)
    {
        Type = "forms.updateWidget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.MetadataUpdate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.MetadataUpdate value)
    {
        Type = "metadata.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.MetadataUpdateCustom"/>.
    /// </summary>
    public ChangeItem(ChangeItem.MetadataUpdateCustom value)
    {
        Type = "metadata.updateCustom";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.OutlineCreate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.OutlineCreate value)
    {
        Type = "outline.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.OutlineUpdate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.OutlineUpdate value)
    {
        Type = "outline.update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.OutlineMove"/>.
    /// </summary>
    public ChangeItem(ChangeItem.OutlineMove value)
    {
        Type = "outline.move";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.OutlineDelete"/>.
    /// </summary>
    public ChangeItem(ChangeItem.OutlineDelete value)
    {
        Type = "outline.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.OutlineRestore"/>.
    /// </summary>
    public ChangeItem(ChangeItem.OutlineRestore value)
    {
        Type = "outline.restore";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.PagesRotate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.PagesRotate value)
    {
        Type = "pages.rotate";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.PagesReorder"/>.
    /// </summary>
    public ChangeItem(ChangeItem.PagesReorder value)
    {
        Type = "pages.reorder";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.PagesDelete"/>.
    /// </summary>
    public ChangeItem(ChangeItem.PagesDelete value)
    {
        Type = "pages.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.PagesInsertBlank"/>.
    /// </summary>
    public ChangeItem(ChangeItem.PagesInsertBlank value)
    {
        Type = "pages.insertBlank";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.PagesInsert"/>.
    /// </summary>
    public ChangeItem(ChangeItem.PagesInsert value)
    {
        Type = "pages.insert";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.PagesRestore"/>.
    /// </summary>
    public ChangeItem(ChangeItem.PagesRestore value)
    {
        Type = "pages.restore";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AttachmentsCreate"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AttachmentsCreate value)
    {
        Type = "attachments.create";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AttachmentsDelete"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AttachmentsDelete value)
    {
        Type = "attachments.delete";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ChangeItem with <see cref="ChangeItem.AttachmentsRestore"/>.
    /// </summary>
    public ChangeItem(ChangeItem.AttachmentsRestore value)
    {
        Type = "attachments.restore";
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
    /// Returns true if <see cref="Type"/> is "skipped"
    /// </summary>
    public bool IsSkipped => Type == "skipped";

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
    /// Returns true if <see cref="Type"/> is "annotations.restore"
    /// </summary>
    public bool IsAnnotationsRestore => Type == "annotations.restore";

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
    /// Returns true if <see cref="Type"/> is "forms.restore"
    /// </summary>
    public bool IsFormsRestore => Type == "forms.restore";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.setSignatureAppearance"
    /// </summary>
    public bool IsFormsSetSignatureAppearance => Type == "forms.setSignatureAppearance";

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
    /// Returns true if <see cref="Type"/> is "forms.restoreWidget"
    /// </summary>
    public bool IsFormsRestoreWidget => Type == "forms.restoreWidget";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.reorderWidgets"
    /// </summary>
    public bool IsFormsReorderWidgets => Type == "forms.reorderWidgets";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.reorderCalculations"
    /// </summary>
    public bool IsFormsReorderCalculations => Type == "forms.reorderCalculations";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "forms.updateWidget"
    /// </summary>
    public bool IsFormsUpdateWidget => Type == "forms.updateWidget";

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
    /// Returns true if <see cref="Type"/> is "outline.restore"
    /// </summary>
    public bool IsOutlineRestore => Type == "outline.restore";

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
    /// Returns true if <see cref="Type"/> is "pages.restore"
    /// </summary>
    public bool IsPagesRestore => Type == "pages.restore";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "attachments.create"
    /// </summary>
    public bool IsAttachmentsCreate => Type == "attachments.create";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "attachments.delete"
    /// </summary>
    public bool IsAttachmentsDelete => Type == "attachments.delete";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "attachments.restore"
    /// </summary>
    public bool IsAttachmentsRestore => Type == "attachments.restore";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemSkipped"/> if <see cref="Type"/> is 'skipped', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'skipped'.</exception>
    public CloudPDF.ChangeItemSkipped AsSkipped() =>
        IsSkipped
            ? (CloudPDF.ChangeItemSkipped)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'skipped'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAnnotationsCreate"/> if <see cref="Type"/> is 'annotations.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.create'.</exception>
    public CloudPDF.ChangeItemAnnotationsCreate AsAnnotationsCreate() =>
        IsAnnotationsCreate
            ? (CloudPDF.ChangeItemAnnotationsCreate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'annotations.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAnnotationsUpdate"/> if <see cref="Type"/> is 'annotations.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.update'.</exception>
    public CloudPDF.ChangeItemAnnotationsUpdate AsAnnotationsUpdate() =>
        IsAnnotationsUpdate
            ? (CloudPDF.ChangeItemAnnotationsUpdate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'annotations.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAnnotationsDelete"/> if <see cref="Type"/> is 'annotations.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.delete'.</exception>
    public CloudPDF.ChangeItemAnnotationsDelete AsAnnotationsDelete() =>
        IsAnnotationsDelete
            ? (CloudPDF.ChangeItemAnnotationsDelete)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'annotations.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAnnotationsReorder"/> if <see cref="Type"/> is 'annotations.reorder', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.reorder'.</exception>
    public CloudPDF.ChangeItemAnnotationsReorder AsAnnotationsReorder() =>
        IsAnnotationsReorder
            ? (CloudPDF.ChangeItemAnnotationsReorder)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'annotations.reorder'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAnnotationsRestore"/> if <see cref="Type"/> is 'annotations.restore', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'annotations.restore'.</exception>
    public CloudPDF.ChangeItemAnnotationsRestore AsAnnotationsRestore() =>
        IsAnnotationsRestore
            ? (CloudPDF.ChangeItemAnnotationsRestore)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'annotations.restore'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsSetValue"/> if <see cref="Type"/> is 'forms.setValue', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setValue'.</exception>
    public CloudPDF.ChangeItemFormsSetValue AsFormsSetValue() =>
        IsFormsSetValue
            ? (CloudPDF.ChangeItemFormsSetValue)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.setValue'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsSetDisplay"/> if <see cref="Type"/> is 'forms.setDisplay', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setDisplay'.</exception>
    public CloudPDF.ChangeItemFormsSetDisplay AsFormsSetDisplay() =>
        IsFormsSetDisplay
            ? (CloudPDF.ChangeItemFormsSetDisplay)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.setDisplay'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsSetAppearanceText"/> if <see cref="Type"/> is 'forms.setAppearanceText', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setAppearanceText'.</exception>
    public CloudPDF.ChangeItemFormsSetAppearanceText AsFormsSetAppearanceText() =>
        IsFormsSetAppearanceText
            ? (CloudPDF.ChangeItemFormsSetAppearanceText)Value!
            : throw new global::System.Exception(
                "ChangeItem.Type is not 'forms.setAppearanceText'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsReset"/> if <see cref="Type"/> is 'forms.reset', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.reset'.</exception>
    public CloudPDF.ChangeItemFormsReset AsFormsReset() =>
        IsFormsReset
            ? (CloudPDF.ChangeItemFormsReset)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.reset'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsCreate"/> if <see cref="Type"/> is 'forms.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.create'.</exception>
    public CloudPDF.ChangeItemFormsCreate AsFormsCreate() =>
        IsFormsCreate
            ? (CloudPDF.ChangeItemFormsCreate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsUpdate"/> if <see cref="Type"/> is 'forms.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.update'.</exception>
    public CloudPDF.ChangeItemFormsUpdate AsFormsUpdate() =>
        IsFormsUpdate
            ? (CloudPDF.ChangeItemFormsUpdate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsDelete"/> if <see cref="Type"/> is 'forms.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.delete'.</exception>
    public CloudPDF.ChangeItemFormsDelete AsFormsDelete() =>
        IsFormsDelete
            ? (CloudPDF.ChangeItemFormsDelete)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsRestore"/> if <see cref="Type"/> is 'forms.restore', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.restore'.</exception>
    public CloudPDF.ChangeItemFormsRestore AsFormsRestore() =>
        IsFormsRestore
            ? (CloudPDF.ChangeItemFormsRestore)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.restore'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsSetSignatureAppearance"/> if <see cref="Type"/> is 'forms.setSignatureAppearance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.setSignatureAppearance'.</exception>
    public CloudPDF.ChangeItemFormsSetSignatureAppearance AsFormsSetSignatureAppearance() =>
        IsFormsSetSignatureAppearance
            ? (CloudPDF.ChangeItemFormsSetSignatureAppearance)Value!
            : throw new global::System.Exception(
                "ChangeItem.Type is not 'forms.setSignatureAppearance'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsAddWidget"/> if <see cref="Type"/> is 'forms.addWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.addWidget'.</exception>
    public CloudPDF.ChangeItemFormsAddWidget AsFormsAddWidget() =>
        IsFormsAddWidget
            ? (CloudPDF.ChangeItemFormsAddWidget)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.addWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsRemoveWidget"/> if <see cref="Type"/> is 'forms.removeWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.removeWidget'.</exception>
    public CloudPDF.ChangeItemFormsRemoveWidget AsFormsRemoveWidget() =>
        IsFormsRemoveWidget
            ? (CloudPDF.ChangeItemFormsRemoveWidget)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.removeWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsDeleteWidget"/> if <see cref="Type"/> is 'forms.deleteWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.deleteWidget'.</exception>
    public CloudPDF.ChangeItemFormsDeleteWidget AsFormsDeleteWidget() =>
        IsFormsDeleteWidget
            ? (CloudPDF.ChangeItemFormsDeleteWidget)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.deleteWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsRestoreWidget"/> if <see cref="Type"/> is 'forms.restoreWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.restoreWidget'.</exception>
    public CloudPDF.ChangeItemFormsRestoreWidget AsFormsRestoreWidget() =>
        IsFormsRestoreWidget
            ? (CloudPDF.ChangeItemFormsRestoreWidget)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.restoreWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsReorderWidgets"/> if <see cref="Type"/> is 'forms.reorderWidgets', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.reorderWidgets'.</exception>
    public CloudPDF.ChangeItemFormsReorderWidgets AsFormsReorderWidgets() =>
        IsFormsReorderWidgets
            ? (CloudPDF.ChangeItemFormsReorderWidgets)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.reorderWidgets'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsReorderCalculations"/> if <see cref="Type"/> is 'forms.reorderCalculations', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.reorderCalculations'.</exception>
    public CloudPDF.ChangeItemFormsReorderCalculations AsFormsReorderCalculations() =>
        IsFormsReorderCalculations
            ? (CloudPDF.ChangeItemFormsReorderCalculations)Value!
            : throw new global::System.Exception(
                "ChangeItem.Type is not 'forms.reorderCalculations'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemFormsUpdateWidget"/> if <see cref="Type"/> is 'forms.updateWidget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'forms.updateWidget'.</exception>
    public CloudPDF.ChangeItemFormsUpdateWidget AsFormsUpdateWidget() =>
        IsFormsUpdateWidget
            ? (CloudPDF.ChangeItemFormsUpdateWidget)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'forms.updateWidget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemMetadataUpdate"/> if <see cref="Type"/> is 'metadata.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'metadata.update'.</exception>
    public CloudPDF.ChangeItemMetadataUpdate AsMetadataUpdate() =>
        IsMetadataUpdate
            ? (CloudPDF.ChangeItemMetadataUpdate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'metadata.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemMetadataUpdateCustom"/> if <see cref="Type"/> is 'metadata.updateCustom', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'metadata.updateCustom'.</exception>
    public CloudPDF.ChangeItemMetadataUpdateCustom AsMetadataUpdateCustom() =>
        IsMetadataUpdateCustom
            ? (CloudPDF.ChangeItemMetadataUpdateCustom)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'metadata.updateCustom'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemOutlineCreate"/> if <see cref="Type"/> is 'outline.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.create'.</exception>
    public CloudPDF.ChangeItemOutlineCreate AsOutlineCreate() =>
        IsOutlineCreate
            ? (CloudPDF.ChangeItemOutlineCreate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'outline.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemOutlineUpdate"/> if <see cref="Type"/> is 'outline.update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.update'.</exception>
    public CloudPDF.ChangeItemOutlineUpdate AsOutlineUpdate() =>
        IsOutlineUpdate
            ? (CloudPDF.ChangeItemOutlineUpdate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'outline.update'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemOutlineMove"/> if <see cref="Type"/> is 'outline.move', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.move'.</exception>
    public CloudPDF.ChangeItemOutlineMove AsOutlineMove() =>
        IsOutlineMove
            ? (CloudPDF.ChangeItemOutlineMove)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'outline.move'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemOutlineDelete"/> if <see cref="Type"/> is 'outline.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.delete'.</exception>
    public CloudPDF.ChangeItemOutlineDelete AsOutlineDelete() =>
        IsOutlineDelete
            ? (CloudPDF.ChangeItemOutlineDelete)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'outline.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemOutlineRestore"/> if <see cref="Type"/> is 'outline.restore', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'outline.restore'.</exception>
    public CloudPDF.ChangeItemOutlineRestore AsOutlineRestore() =>
        IsOutlineRestore
            ? (CloudPDF.ChangeItemOutlineRestore)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'outline.restore'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesRotate"/> if <see cref="Type"/> is 'pages.rotate', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.rotate'.</exception>
    public CloudPDF.ChangeItemPagesRotate AsPagesRotate() =>
        IsPagesRotate
            ? (CloudPDF.ChangeItemPagesRotate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'pages.rotate'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesReorder"/> if <see cref="Type"/> is 'pages.reorder', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.reorder'.</exception>
    public CloudPDF.ChangeItemPagesReorder AsPagesReorder() =>
        IsPagesReorder
            ? (CloudPDF.ChangeItemPagesReorder)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'pages.reorder'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesDelete"/> if <see cref="Type"/> is 'pages.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.delete'.</exception>
    public CloudPDF.ChangeItemPagesDelete AsPagesDelete() =>
        IsPagesDelete
            ? (CloudPDF.ChangeItemPagesDelete)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'pages.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesInsertBlank"/> if <see cref="Type"/> is 'pages.insertBlank', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.insertBlank'.</exception>
    public CloudPDF.ChangeItemPagesInsertBlank AsPagesInsertBlank() =>
        IsPagesInsertBlank
            ? (CloudPDF.ChangeItemPagesInsertBlank)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'pages.insertBlank'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesInsert"/> if <see cref="Type"/> is 'pages.insert', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.insert'.</exception>
    public CloudPDF.ChangeItemPagesInsert AsPagesInsert() =>
        IsPagesInsert
            ? (CloudPDF.ChangeItemPagesInsert)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'pages.insert'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemPagesRestore"/> if <see cref="Type"/> is 'pages.restore', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'pages.restore'.</exception>
    public CloudPDF.ChangeItemPagesRestore AsPagesRestore() =>
        IsPagesRestore
            ? (CloudPDF.ChangeItemPagesRestore)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'pages.restore'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAttachmentsCreate"/> if <see cref="Type"/> is 'attachments.create', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'attachments.create'.</exception>
    public CloudPDF.ChangeItemAttachmentsCreate AsAttachmentsCreate() =>
        IsAttachmentsCreate
            ? (CloudPDF.ChangeItemAttachmentsCreate)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'attachments.create'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAttachmentsDelete"/> if <see cref="Type"/> is 'attachments.delete', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'attachments.delete'.</exception>
    public CloudPDF.ChangeItemAttachmentsDelete AsAttachmentsDelete() =>
        IsAttachmentsDelete
            ? (CloudPDF.ChangeItemAttachmentsDelete)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'attachments.delete'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.ChangeItemAttachmentsRestore"/> if <see cref="Type"/> is 'attachments.restore', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'attachments.restore'.</exception>
    public CloudPDF.ChangeItemAttachmentsRestore AsAttachmentsRestore() =>
        IsAttachmentsRestore
            ? (CloudPDF.ChangeItemAttachmentsRestore)Value!
            : throw new global::System.Exception("ChangeItem.Type is not 'attachments.restore'");

    public T Match<T>(
        Func<CloudPDF.ChangeItemSkipped, T> onSkipped,
        Func<CloudPDF.ChangeItemAnnotationsCreate, T> onAnnotationsCreate,
        Func<CloudPDF.ChangeItemAnnotationsUpdate, T> onAnnotationsUpdate,
        Func<CloudPDF.ChangeItemAnnotationsDelete, T> onAnnotationsDelete,
        Func<CloudPDF.ChangeItemAnnotationsReorder, T> onAnnotationsReorder,
        Func<CloudPDF.ChangeItemAnnotationsRestore, T> onAnnotationsRestore,
        Func<CloudPDF.ChangeItemFormsSetValue, T> onFormsSetValue,
        Func<CloudPDF.ChangeItemFormsSetDisplay, T> onFormsSetDisplay,
        Func<CloudPDF.ChangeItemFormsSetAppearanceText, T> onFormsSetAppearanceText,
        Func<CloudPDF.ChangeItemFormsReset, T> onFormsReset,
        Func<CloudPDF.ChangeItemFormsCreate, T> onFormsCreate,
        Func<CloudPDF.ChangeItemFormsUpdate, T> onFormsUpdate,
        Func<CloudPDF.ChangeItemFormsDelete, T> onFormsDelete,
        Func<CloudPDF.ChangeItemFormsRestore, T> onFormsRestore,
        Func<CloudPDF.ChangeItemFormsSetSignatureAppearance, T> onFormsSetSignatureAppearance,
        Func<CloudPDF.ChangeItemFormsAddWidget, T> onFormsAddWidget,
        Func<CloudPDF.ChangeItemFormsRemoveWidget, T> onFormsRemoveWidget,
        Func<CloudPDF.ChangeItemFormsDeleteWidget, T> onFormsDeleteWidget,
        Func<CloudPDF.ChangeItemFormsRestoreWidget, T> onFormsRestoreWidget,
        Func<CloudPDF.ChangeItemFormsReorderWidgets, T> onFormsReorderWidgets,
        Func<CloudPDF.ChangeItemFormsReorderCalculations, T> onFormsReorderCalculations,
        Func<CloudPDF.ChangeItemFormsUpdateWidget, T> onFormsUpdateWidget,
        Func<CloudPDF.ChangeItemMetadataUpdate, T> onMetadataUpdate,
        Func<CloudPDF.ChangeItemMetadataUpdateCustom, T> onMetadataUpdateCustom,
        Func<CloudPDF.ChangeItemOutlineCreate, T> onOutlineCreate,
        Func<CloudPDF.ChangeItemOutlineUpdate, T> onOutlineUpdate,
        Func<CloudPDF.ChangeItemOutlineMove, T> onOutlineMove,
        Func<CloudPDF.ChangeItemOutlineDelete, T> onOutlineDelete,
        Func<CloudPDF.ChangeItemOutlineRestore, T> onOutlineRestore,
        Func<CloudPDF.ChangeItemPagesRotate, T> onPagesRotate,
        Func<CloudPDF.ChangeItemPagesReorder, T> onPagesReorder,
        Func<CloudPDF.ChangeItemPagesDelete, T> onPagesDelete,
        Func<CloudPDF.ChangeItemPagesInsertBlank, T> onPagesInsertBlank,
        Func<CloudPDF.ChangeItemPagesInsert, T> onPagesInsert,
        Func<CloudPDF.ChangeItemPagesRestore, T> onPagesRestore,
        Func<CloudPDF.ChangeItemAttachmentsCreate, T> onAttachmentsCreate,
        Func<CloudPDF.ChangeItemAttachmentsDelete, T> onAttachmentsDelete,
        Func<CloudPDF.ChangeItemAttachmentsRestore, T> onAttachmentsRestore,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "skipped" => onSkipped(AsSkipped()),
            "annotations.create" => onAnnotationsCreate(AsAnnotationsCreate()),
            "annotations.update" => onAnnotationsUpdate(AsAnnotationsUpdate()),
            "annotations.delete" => onAnnotationsDelete(AsAnnotationsDelete()),
            "annotations.reorder" => onAnnotationsReorder(AsAnnotationsReorder()),
            "annotations.restore" => onAnnotationsRestore(AsAnnotationsRestore()),
            "forms.setValue" => onFormsSetValue(AsFormsSetValue()),
            "forms.setDisplay" => onFormsSetDisplay(AsFormsSetDisplay()),
            "forms.setAppearanceText" => onFormsSetAppearanceText(AsFormsSetAppearanceText()),
            "forms.reset" => onFormsReset(AsFormsReset()),
            "forms.create" => onFormsCreate(AsFormsCreate()),
            "forms.update" => onFormsUpdate(AsFormsUpdate()),
            "forms.delete" => onFormsDelete(AsFormsDelete()),
            "forms.restore" => onFormsRestore(AsFormsRestore()),
            "forms.setSignatureAppearance" => onFormsSetSignatureAppearance(
                AsFormsSetSignatureAppearance()
            ),
            "forms.addWidget" => onFormsAddWidget(AsFormsAddWidget()),
            "forms.removeWidget" => onFormsRemoveWidget(AsFormsRemoveWidget()),
            "forms.deleteWidget" => onFormsDeleteWidget(AsFormsDeleteWidget()),
            "forms.restoreWidget" => onFormsRestoreWidget(AsFormsRestoreWidget()),
            "forms.reorderWidgets" => onFormsReorderWidgets(AsFormsReorderWidgets()),
            "forms.reorderCalculations" => onFormsReorderCalculations(AsFormsReorderCalculations()),
            "forms.updateWidget" => onFormsUpdateWidget(AsFormsUpdateWidget()),
            "metadata.update" => onMetadataUpdate(AsMetadataUpdate()),
            "metadata.updateCustom" => onMetadataUpdateCustom(AsMetadataUpdateCustom()),
            "outline.create" => onOutlineCreate(AsOutlineCreate()),
            "outline.update" => onOutlineUpdate(AsOutlineUpdate()),
            "outline.move" => onOutlineMove(AsOutlineMove()),
            "outline.delete" => onOutlineDelete(AsOutlineDelete()),
            "outline.restore" => onOutlineRestore(AsOutlineRestore()),
            "pages.rotate" => onPagesRotate(AsPagesRotate()),
            "pages.reorder" => onPagesReorder(AsPagesReorder()),
            "pages.delete" => onPagesDelete(AsPagesDelete()),
            "pages.insertBlank" => onPagesInsertBlank(AsPagesInsertBlank()),
            "pages.insert" => onPagesInsert(AsPagesInsert()),
            "pages.restore" => onPagesRestore(AsPagesRestore()),
            "attachments.create" => onAttachmentsCreate(AsAttachmentsCreate()),
            "attachments.delete" => onAttachmentsDelete(AsAttachmentsDelete()),
            "attachments.restore" => onAttachmentsRestore(AsAttachmentsRestore()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.ChangeItemSkipped> onSkipped,
        Action<CloudPDF.ChangeItemAnnotationsCreate> onAnnotationsCreate,
        Action<CloudPDF.ChangeItemAnnotationsUpdate> onAnnotationsUpdate,
        Action<CloudPDF.ChangeItemAnnotationsDelete> onAnnotationsDelete,
        Action<CloudPDF.ChangeItemAnnotationsReorder> onAnnotationsReorder,
        Action<CloudPDF.ChangeItemAnnotationsRestore> onAnnotationsRestore,
        Action<CloudPDF.ChangeItemFormsSetValue> onFormsSetValue,
        Action<CloudPDF.ChangeItemFormsSetDisplay> onFormsSetDisplay,
        Action<CloudPDF.ChangeItemFormsSetAppearanceText> onFormsSetAppearanceText,
        Action<CloudPDF.ChangeItemFormsReset> onFormsReset,
        Action<CloudPDF.ChangeItemFormsCreate> onFormsCreate,
        Action<CloudPDF.ChangeItemFormsUpdate> onFormsUpdate,
        Action<CloudPDF.ChangeItemFormsDelete> onFormsDelete,
        Action<CloudPDF.ChangeItemFormsRestore> onFormsRestore,
        Action<CloudPDF.ChangeItemFormsSetSignatureAppearance> onFormsSetSignatureAppearance,
        Action<CloudPDF.ChangeItemFormsAddWidget> onFormsAddWidget,
        Action<CloudPDF.ChangeItemFormsRemoveWidget> onFormsRemoveWidget,
        Action<CloudPDF.ChangeItemFormsDeleteWidget> onFormsDeleteWidget,
        Action<CloudPDF.ChangeItemFormsRestoreWidget> onFormsRestoreWidget,
        Action<CloudPDF.ChangeItemFormsReorderWidgets> onFormsReorderWidgets,
        Action<CloudPDF.ChangeItemFormsReorderCalculations> onFormsReorderCalculations,
        Action<CloudPDF.ChangeItemFormsUpdateWidget> onFormsUpdateWidget,
        Action<CloudPDF.ChangeItemMetadataUpdate> onMetadataUpdate,
        Action<CloudPDF.ChangeItemMetadataUpdateCustom> onMetadataUpdateCustom,
        Action<CloudPDF.ChangeItemOutlineCreate> onOutlineCreate,
        Action<CloudPDF.ChangeItemOutlineUpdate> onOutlineUpdate,
        Action<CloudPDF.ChangeItemOutlineMove> onOutlineMove,
        Action<CloudPDF.ChangeItemOutlineDelete> onOutlineDelete,
        Action<CloudPDF.ChangeItemOutlineRestore> onOutlineRestore,
        Action<CloudPDF.ChangeItemPagesRotate> onPagesRotate,
        Action<CloudPDF.ChangeItemPagesReorder> onPagesReorder,
        Action<CloudPDF.ChangeItemPagesDelete> onPagesDelete,
        Action<CloudPDF.ChangeItemPagesInsertBlank> onPagesInsertBlank,
        Action<CloudPDF.ChangeItemPagesInsert> onPagesInsert,
        Action<CloudPDF.ChangeItemPagesRestore> onPagesRestore,
        Action<CloudPDF.ChangeItemAttachmentsCreate> onAttachmentsCreate,
        Action<CloudPDF.ChangeItemAttachmentsDelete> onAttachmentsDelete,
        Action<CloudPDF.ChangeItemAttachmentsRestore> onAttachmentsRestore,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "skipped":
                onSkipped(AsSkipped());
                break;
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
            case "annotations.restore":
                onAnnotationsRestore(AsAnnotationsRestore());
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
            case "forms.restore":
                onFormsRestore(AsFormsRestore());
                break;
            case "forms.setSignatureAppearance":
                onFormsSetSignatureAppearance(AsFormsSetSignatureAppearance());
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
            case "forms.restoreWidget":
                onFormsRestoreWidget(AsFormsRestoreWidget());
                break;
            case "forms.reorderWidgets":
                onFormsReorderWidgets(AsFormsReorderWidgets());
                break;
            case "forms.reorderCalculations":
                onFormsReorderCalculations(AsFormsReorderCalculations());
                break;
            case "forms.updateWidget":
                onFormsUpdateWidget(AsFormsUpdateWidget());
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
            case "outline.restore":
                onOutlineRestore(AsOutlineRestore());
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
            case "pages.restore":
                onPagesRestore(AsPagesRestore());
                break;
            case "attachments.create":
                onAttachmentsCreate(AsAttachmentsCreate());
                break;
            case "attachments.delete":
                onAttachmentsDelete(AsAttachmentsDelete());
                break;
            case "attachments.restore":
                onAttachmentsRestore(AsAttachmentsRestore());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemSkipped"/> and returns true if successful.
    /// </summary>
    public bool TryAsSkipped(out CloudPDF.ChangeItemSkipped? value)
    {
        if (Type == "skipped")
        {
            value = (CloudPDF.ChangeItemSkipped)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAnnotationsCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsCreate(out CloudPDF.ChangeItemAnnotationsCreate? value)
    {
        if (Type == "annotations.create")
        {
            value = (CloudPDF.ChangeItemAnnotationsCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAnnotationsUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsUpdate(out CloudPDF.ChangeItemAnnotationsUpdate? value)
    {
        if (Type == "annotations.update")
        {
            value = (CloudPDF.ChangeItemAnnotationsUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAnnotationsDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsDelete(out CloudPDF.ChangeItemAnnotationsDelete? value)
    {
        if (Type == "annotations.delete")
        {
            value = (CloudPDF.ChangeItemAnnotationsDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAnnotationsReorder"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsReorder(out CloudPDF.ChangeItemAnnotationsReorder? value)
    {
        if (Type == "annotations.reorder")
        {
            value = (CloudPDF.ChangeItemAnnotationsReorder)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAnnotationsRestore"/> and returns true if successful.
    /// </summary>
    public bool TryAsAnnotationsRestore(out CloudPDF.ChangeItemAnnotationsRestore? value)
    {
        if (Type == "annotations.restore")
        {
            value = (CloudPDF.ChangeItemAnnotationsRestore)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsSetValue"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetValue(out CloudPDF.ChangeItemFormsSetValue? value)
    {
        if (Type == "forms.setValue")
        {
            value = (CloudPDF.ChangeItemFormsSetValue)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsSetDisplay"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetDisplay(out CloudPDF.ChangeItemFormsSetDisplay? value)
    {
        if (Type == "forms.setDisplay")
        {
            value = (CloudPDF.ChangeItemFormsSetDisplay)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsSetAppearanceText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetAppearanceText(out CloudPDF.ChangeItemFormsSetAppearanceText? value)
    {
        if (Type == "forms.setAppearanceText")
        {
            value = (CloudPDF.ChangeItemFormsSetAppearanceText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsReset"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsReset(out CloudPDF.ChangeItemFormsReset? value)
    {
        if (Type == "forms.reset")
        {
            value = (CloudPDF.ChangeItemFormsReset)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsCreate(out CloudPDF.ChangeItemFormsCreate? value)
    {
        if (Type == "forms.create")
        {
            value = (CloudPDF.ChangeItemFormsCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsUpdate(out CloudPDF.ChangeItemFormsUpdate? value)
    {
        if (Type == "forms.update")
        {
            value = (CloudPDF.ChangeItemFormsUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsDelete(out CloudPDF.ChangeItemFormsDelete? value)
    {
        if (Type == "forms.delete")
        {
            value = (CloudPDF.ChangeItemFormsDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsRestore"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsRestore(out CloudPDF.ChangeItemFormsRestore? value)
    {
        if (Type == "forms.restore")
        {
            value = (CloudPDF.ChangeItemFormsRestore)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsSetSignatureAppearance"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsSetSignatureAppearance(
        out CloudPDF.ChangeItemFormsSetSignatureAppearance? value
    )
    {
        if (Type == "forms.setSignatureAppearance")
        {
            value = (CloudPDF.ChangeItemFormsSetSignatureAppearance)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsAddWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsAddWidget(out CloudPDF.ChangeItemFormsAddWidget? value)
    {
        if (Type == "forms.addWidget")
        {
            value = (CloudPDF.ChangeItemFormsAddWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsRemoveWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsRemoveWidget(out CloudPDF.ChangeItemFormsRemoveWidget? value)
    {
        if (Type == "forms.removeWidget")
        {
            value = (CloudPDF.ChangeItemFormsRemoveWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsDeleteWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsDeleteWidget(out CloudPDF.ChangeItemFormsDeleteWidget? value)
    {
        if (Type == "forms.deleteWidget")
        {
            value = (CloudPDF.ChangeItemFormsDeleteWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsRestoreWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsRestoreWidget(out CloudPDF.ChangeItemFormsRestoreWidget? value)
    {
        if (Type == "forms.restoreWidget")
        {
            value = (CloudPDF.ChangeItemFormsRestoreWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsReorderWidgets"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsReorderWidgets(out CloudPDF.ChangeItemFormsReorderWidgets? value)
    {
        if (Type == "forms.reorderWidgets")
        {
            value = (CloudPDF.ChangeItemFormsReorderWidgets)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsReorderCalculations"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsReorderCalculations(
        out CloudPDF.ChangeItemFormsReorderCalculations? value
    )
    {
        if (Type == "forms.reorderCalculations")
        {
            value = (CloudPDF.ChangeItemFormsReorderCalculations)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemFormsUpdateWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsFormsUpdateWidget(out CloudPDF.ChangeItemFormsUpdateWidget? value)
    {
        if (Type == "forms.updateWidget")
        {
            value = (CloudPDF.ChangeItemFormsUpdateWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemMetadataUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsMetadataUpdate(out CloudPDF.ChangeItemMetadataUpdate? value)
    {
        if (Type == "metadata.update")
        {
            value = (CloudPDF.ChangeItemMetadataUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemMetadataUpdateCustom"/> and returns true if successful.
    /// </summary>
    public bool TryAsMetadataUpdateCustom(out CloudPDF.ChangeItemMetadataUpdateCustom? value)
    {
        if (Type == "metadata.updateCustom")
        {
            value = (CloudPDF.ChangeItemMetadataUpdateCustom)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemOutlineCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineCreate(out CloudPDF.ChangeItemOutlineCreate? value)
    {
        if (Type == "outline.create")
        {
            value = (CloudPDF.ChangeItemOutlineCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemOutlineUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineUpdate(out CloudPDF.ChangeItemOutlineUpdate? value)
    {
        if (Type == "outline.update")
        {
            value = (CloudPDF.ChangeItemOutlineUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemOutlineMove"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineMove(out CloudPDF.ChangeItemOutlineMove? value)
    {
        if (Type == "outline.move")
        {
            value = (CloudPDF.ChangeItemOutlineMove)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemOutlineDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineDelete(out CloudPDF.ChangeItemOutlineDelete? value)
    {
        if (Type == "outline.delete")
        {
            value = (CloudPDF.ChangeItemOutlineDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemOutlineRestore"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutlineRestore(out CloudPDF.ChangeItemOutlineRestore? value)
    {
        if (Type == "outline.restore")
        {
            value = (CloudPDF.ChangeItemOutlineRestore)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesRotate"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesRotate(out CloudPDF.ChangeItemPagesRotate? value)
    {
        if (Type == "pages.rotate")
        {
            value = (CloudPDF.ChangeItemPagesRotate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesReorder"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesReorder(out CloudPDF.ChangeItemPagesReorder? value)
    {
        if (Type == "pages.reorder")
        {
            value = (CloudPDF.ChangeItemPagesReorder)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesDelete(out CloudPDF.ChangeItemPagesDelete? value)
    {
        if (Type == "pages.delete")
        {
            value = (CloudPDF.ChangeItemPagesDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesInsertBlank"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesInsertBlank(out CloudPDF.ChangeItemPagesInsertBlank? value)
    {
        if (Type == "pages.insertBlank")
        {
            value = (CloudPDF.ChangeItemPagesInsertBlank)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesInsert"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesInsert(out CloudPDF.ChangeItemPagesInsert? value)
    {
        if (Type == "pages.insert")
        {
            value = (CloudPDF.ChangeItemPagesInsert)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemPagesRestore"/> and returns true if successful.
    /// </summary>
    public bool TryAsPagesRestore(out CloudPDF.ChangeItemPagesRestore? value)
    {
        if (Type == "pages.restore")
        {
            value = (CloudPDF.ChangeItemPagesRestore)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAttachmentsCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAttachmentsCreate(out CloudPDF.ChangeItemAttachmentsCreate? value)
    {
        if (Type == "attachments.create")
        {
            value = (CloudPDF.ChangeItemAttachmentsCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAttachmentsDelete"/> and returns true if successful.
    /// </summary>
    public bool TryAsAttachmentsDelete(out CloudPDF.ChangeItemAttachmentsDelete? value)
    {
        if (Type == "attachments.delete")
        {
            value = (CloudPDF.ChangeItemAttachmentsDelete)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.ChangeItemAttachmentsRestore"/> and returns true if successful.
    /// </summary>
    public bool TryAsAttachmentsRestore(out CloudPDF.ChangeItemAttachmentsRestore? value)
    {
        if (Type == "attachments.restore")
        {
            value = (CloudPDF.ChangeItemAttachmentsRestore)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ChangeItem(ChangeItem.Skipped value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AnnotationsCreate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AnnotationsUpdate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AnnotationsDelete value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AnnotationsReorder value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AnnotationsRestore value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsSetValue value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsSetDisplay value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsSetAppearanceText value) =>
        new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsReset value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsCreate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsUpdate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsDelete value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsRestore value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsSetSignatureAppearance value) =>
        new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsAddWidget value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsRemoveWidget value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsDeleteWidget value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsRestoreWidget value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsReorderWidgets value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsReorderCalculations value) =>
        new(value);

    public static implicit operator ChangeItem(ChangeItem.FormsUpdateWidget value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.MetadataUpdate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.MetadataUpdateCustom value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.OutlineCreate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.OutlineUpdate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.OutlineMove value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.OutlineDelete value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.OutlineRestore value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.PagesRotate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.PagesReorder value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.PagesDelete value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.PagesInsertBlank value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.PagesInsert value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.PagesRestore value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AttachmentsCreate value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AttachmentsDelete value) => new(value);

    public static implicit operator ChangeItem(ChangeItem.AttachmentsRestore value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ChangeItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ChangeItem).IsAssignableFrom(typeToConvert);

        public override ChangeItem Read(
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
                "skipped" => jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemSkipped?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.ChangeItemSkipped"),
                "annotations.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAnnotationsCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAnnotationsCreate"
                        ),
                "annotations.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAnnotationsUpdate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAnnotationsUpdate"
                        ),
                "annotations.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAnnotationsDelete?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAnnotationsDelete"
                        ),
                "annotations.reorder" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAnnotationsReorder?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAnnotationsReorder"
                        ),
                "annotations.restore" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAnnotationsRestore?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAnnotationsRestore"
                        ),
                "forms.setValue" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsSetValue?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsSetValue"
                        ),
                "forms.setDisplay" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsSetDisplay?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsSetDisplay"
                        ),
                "forms.setAppearanceText" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsSetAppearanceText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsSetAppearanceText"
                        ),
                "forms.reset" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsReset?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsReset"
                        ),
                "forms.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsCreate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsCreate"
                        ),
                "forms.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsUpdate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsUpdate"
                        ),
                "forms.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsDelete?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsDelete"
                        ),
                "forms.restore" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsRestore?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsRestore"
                        ),
                "forms.setSignatureAppearance" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsSetSignatureAppearance?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsSetSignatureAppearance"
                        ),
                "forms.addWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsAddWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsAddWidget"
                        ),
                "forms.removeWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsRemoveWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsRemoveWidget"
                        ),
                "forms.deleteWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsDeleteWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsDeleteWidget"
                        ),
                "forms.restoreWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsRestoreWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsRestoreWidget"
                        ),
                "forms.reorderWidgets" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsReorderWidgets?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsReorderWidgets"
                        ),
                "forms.reorderCalculations" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsReorderCalculations?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsReorderCalculations"
                        ),
                "forms.updateWidget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemFormsUpdateWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemFormsUpdateWidget"
                        ),
                "metadata.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemMetadataUpdate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemMetadataUpdate"
                        ),
                "metadata.updateCustom" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemMetadataUpdateCustom?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemMetadataUpdateCustom"
                        ),
                "outline.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemOutlineCreate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemOutlineCreate"
                        ),
                "outline.update" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemOutlineUpdate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemOutlineUpdate"
                        ),
                "outline.move" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemOutlineMove?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemOutlineMove"
                        ),
                "outline.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemOutlineDelete?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemOutlineDelete"
                        ),
                "outline.restore" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemOutlineRestore?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemOutlineRestore"
                        ),
                "pages.rotate" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesRotate?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesRotate"
                        ),
                "pages.reorder" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesReorder?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesReorder"
                        ),
                "pages.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesDelete?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesDelete"
                        ),
                "pages.insertBlank" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesInsertBlank?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesInsertBlank"
                        ),
                "pages.insert" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesInsert?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesInsert"
                        ),
                "pages.restore" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemPagesRestore?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemPagesRestore"
                        ),
                "attachments.create" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAttachmentsCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAttachmentsCreate"
                        ),
                "attachments.delete" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAttachmentsDelete?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAttachmentsDelete"
                        ),
                "attachments.restore" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.ChangeItemAttachmentsRestore?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.ChangeItemAttachmentsRestore"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ChangeItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItem value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "skipped" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.reorder" => JsonSerializer.SerializeToNode(value.Value, options),
                    "annotations.restore" => JsonSerializer.SerializeToNode(value.Value, options),
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
                    "forms.restore" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.setSignatureAppearance" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "forms.addWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.removeWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.deleteWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.restoreWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.reorderWidgets" => JsonSerializer.SerializeToNode(value.Value, options),
                    "forms.reorderCalculations" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "forms.updateWidget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "metadata.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "metadata.updateCustom" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.move" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "outline.restore" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.rotate" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.reorder" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.insertBlank" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.insert" => JsonSerializer.SerializeToNode(value.Value, options),
                    "pages.restore" => JsonSerializer.SerializeToNode(value.Value, options),
                    "attachments.create" => JsonSerializer.SerializeToNode(value.Value, options),
                    "attachments.delete" => JsonSerializer.SerializeToNode(value.Value, options),
                    "attachments.restore" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override ChangeItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ChangeItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItem value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for skipped
    /// </summary>
    [Serializable]
    public struct Skipped
    {
        public Skipped(CloudPDF.ChangeItemSkipped value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemSkipped Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.Skipped(CloudPDF.ChangeItemSkipped value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.create
    /// </summary>
    [Serializable]
    public struct AnnotationsCreate
    {
        public AnnotationsCreate(CloudPDF.ChangeItemAnnotationsCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAnnotationsCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AnnotationsCreate(
            CloudPDF.ChangeItemAnnotationsCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.update
    /// </summary>
    [Serializable]
    public struct AnnotationsUpdate
    {
        public AnnotationsUpdate(CloudPDF.ChangeItemAnnotationsUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAnnotationsUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AnnotationsUpdate(
            CloudPDF.ChangeItemAnnotationsUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.delete
    /// </summary>
    [Serializable]
    public struct AnnotationsDelete
    {
        public AnnotationsDelete(CloudPDF.ChangeItemAnnotationsDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAnnotationsDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AnnotationsDelete(
            CloudPDF.ChangeItemAnnotationsDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.reorder
    /// </summary>
    [Serializable]
    public struct AnnotationsReorder
    {
        public AnnotationsReorder(CloudPDF.ChangeItemAnnotationsReorder value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAnnotationsReorder Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AnnotationsReorder(
            CloudPDF.ChangeItemAnnotationsReorder value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for annotations.restore
    /// </summary>
    [Serializable]
    public struct AnnotationsRestore
    {
        public AnnotationsRestore(CloudPDF.ChangeItemAnnotationsRestore value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAnnotationsRestore Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AnnotationsRestore(
            CloudPDF.ChangeItemAnnotationsRestore value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setValue
    /// </summary>
    [Serializable]
    public struct FormsSetValue
    {
        public FormsSetValue(CloudPDF.ChangeItemFormsSetValue value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsSetValue Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsSetValue(
            CloudPDF.ChangeItemFormsSetValue value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setDisplay
    /// </summary>
    [Serializable]
    public struct FormsSetDisplay
    {
        public FormsSetDisplay(CloudPDF.ChangeItemFormsSetDisplay value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsSetDisplay Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsSetDisplay(
            CloudPDF.ChangeItemFormsSetDisplay value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setAppearanceText
    /// </summary>
    [Serializable]
    public struct FormsSetAppearanceText
    {
        public FormsSetAppearanceText(CloudPDF.ChangeItemFormsSetAppearanceText value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsSetAppearanceText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsSetAppearanceText(
            CloudPDF.ChangeItemFormsSetAppearanceText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.reset
    /// </summary>
    [Serializable]
    public struct FormsReset
    {
        public FormsReset(CloudPDF.ChangeItemFormsReset value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsReset Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsReset(
            CloudPDF.ChangeItemFormsReset value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.create
    /// </summary>
    [Serializable]
    public struct FormsCreate
    {
        public FormsCreate(CloudPDF.ChangeItemFormsCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsCreate(
            CloudPDF.ChangeItemFormsCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.update
    /// </summary>
    [Serializable]
    public struct FormsUpdate
    {
        public FormsUpdate(CloudPDF.ChangeItemFormsUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsUpdate(
            CloudPDF.ChangeItemFormsUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.delete
    /// </summary>
    [Serializable]
    public struct FormsDelete
    {
        public FormsDelete(CloudPDF.ChangeItemFormsDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsDelete(
            CloudPDF.ChangeItemFormsDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.restore
    /// </summary>
    [Serializable]
    public struct FormsRestore
    {
        public FormsRestore(CloudPDF.ChangeItemFormsRestore value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsRestore Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsRestore(
            CloudPDF.ChangeItemFormsRestore value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.setSignatureAppearance
    /// </summary>
    [Serializable]
    public struct FormsSetSignatureAppearance
    {
        public FormsSetSignatureAppearance(CloudPDF.ChangeItemFormsSetSignatureAppearance value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsSetSignatureAppearance Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsSetSignatureAppearance(
            CloudPDF.ChangeItemFormsSetSignatureAppearance value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.addWidget
    /// </summary>
    [Serializable]
    public struct FormsAddWidget
    {
        public FormsAddWidget(CloudPDF.ChangeItemFormsAddWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsAddWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsAddWidget(
            CloudPDF.ChangeItemFormsAddWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.removeWidget
    /// </summary>
    [Serializable]
    public struct FormsRemoveWidget
    {
        public FormsRemoveWidget(CloudPDF.ChangeItemFormsRemoveWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsRemoveWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsRemoveWidget(
            CloudPDF.ChangeItemFormsRemoveWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.deleteWidget
    /// </summary>
    [Serializable]
    public struct FormsDeleteWidget
    {
        public FormsDeleteWidget(CloudPDF.ChangeItemFormsDeleteWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsDeleteWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsDeleteWidget(
            CloudPDF.ChangeItemFormsDeleteWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.restoreWidget
    /// </summary>
    [Serializable]
    public struct FormsRestoreWidget
    {
        public FormsRestoreWidget(CloudPDF.ChangeItemFormsRestoreWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsRestoreWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsRestoreWidget(
            CloudPDF.ChangeItemFormsRestoreWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.reorderWidgets
    /// </summary>
    [Serializable]
    public struct FormsReorderWidgets
    {
        public FormsReorderWidgets(CloudPDF.ChangeItemFormsReorderWidgets value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsReorderWidgets Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsReorderWidgets(
            CloudPDF.ChangeItemFormsReorderWidgets value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.reorderCalculations
    /// </summary>
    [Serializable]
    public struct FormsReorderCalculations
    {
        public FormsReorderCalculations(CloudPDF.ChangeItemFormsReorderCalculations value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsReorderCalculations Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsReorderCalculations(
            CloudPDF.ChangeItemFormsReorderCalculations value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for forms.updateWidget
    /// </summary>
    [Serializable]
    public struct FormsUpdateWidget
    {
        public FormsUpdateWidget(CloudPDF.ChangeItemFormsUpdateWidget value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemFormsUpdateWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.FormsUpdateWidget(
            CloudPDF.ChangeItemFormsUpdateWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for metadata.update
    /// </summary>
    [Serializable]
    public struct MetadataUpdate
    {
        public MetadataUpdate(CloudPDF.ChangeItemMetadataUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemMetadataUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.MetadataUpdate(
            CloudPDF.ChangeItemMetadataUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for metadata.updateCustom
    /// </summary>
    [Serializable]
    public struct MetadataUpdateCustom
    {
        public MetadataUpdateCustom(CloudPDF.ChangeItemMetadataUpdateCustom value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemMetadataUpdateCustom Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.MetadataUpdateCustom(
            CloudPDF.ChangeItemMetadataUpdateCustom value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.create
    /// </summary>
    [Serializable]
    public struct OutlineCreate
    {
        public OutlineCreate(CloudPDF.ChangeItemOutlineCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemOutlineCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.OutlineCreate(
            CloudPDF.ChangeItemOutlineCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.update
    /// </summary>
    [Serializable]
    public struct OutlineUpdate
    {
        public OutlineUpdate(CloudPDF.ChangeItemOutlineUpdate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemOutlineUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.OutlineUpdate(
            CloudPDF.ChangeItemOutlineUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.move
    /// </summary>
    [Serializable]
    public struct OutlineMove
    {
        public OutlineMove(CloudPDF.ChangeItemOutlineMove value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemOutlineMove Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.OutlineMove(
            CloudPDF.ChangeItemOutlineMove value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.delete
    /// </summary>
    [Serializable]
    public struct OutlineDelete
    {
        public OutlineDelete(CloudPDF.ChangeItemOutlineDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemOutlineDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.OutlineDelete(
            CloudPDF.ChangeItemOutlineDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for outline.restore
    /// </summary>
    [Serializable]
    public struct OutlineRestore
    {
        public OutlineRestore(CloudPDF.ChangeItemOutlineRestore value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemOutlineRestore Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.OutlineRestore(
            CloudPDF.ChangeItemOutlineRestore value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.rotate
    /// </summary>
    [Serializable]
    public struct PagesRotate
    {
        public PagesRotate(CloudPDF.ChangeItemPagesRotate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesRotate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.PagesRotate(
            CloudPDF.ChangeItemPagesRotate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.reorder
    /// </summary>
    [Serializable]
    public struct PagesReorder
    {
        public PagesReorder(CloudPDF.ChangeItemPagesReorder value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesReorder Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.PagesReorder(
            CloudPDF.ChangeItemPagesReorder value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.delete
    /// </summary>
    [Serializable]
    public struct PagesDelete
    {
        public PagesDelete(CloudPDF.ChangeItemPagesDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.PagesDelete(
            CloudPDF.ChangeItemPagesDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.insertBlank
    /// </summary>
    [Serializable]
    public struct PagesInsertBlank
    {
        public PagesInsertBlank(CloudPDF.ChangeItemPagesInsertBlank value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesInsertBlank Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.PagesInsertBlank(
            CloudPDF.ChangeItemPagesInsertBlank value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.insert
    /// </summary>
    [Serializable]
    public struct PagesInsert
    {
        public PagesInsert(CloudPDF.ChangeItemPagesInsert value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesInsert Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.PagesInsert(
            CloudPDF.ChangeItemPagesInsert value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for pages.restore
    /// </summary>
    [Serializable]
    public struct PagesRestore
    {
        public PagesRestore(CloudPDF.ChangeItemPagesRestore value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemPagesRestore Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.PagesRestore(
            CloudPDF.ChangeItemPagesRestore value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for attachments.create
    /// </summary>
    [Serializable]
    public struct AttachmentsCreate
    {
        public AttachmentsCreate(CloudPDF.ChangeItemAttachmentsCreate value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAttachmentsCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AttachmentsCreate(
            CloudPDF.ChangeItemAttachmentsCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for attachments.delete
    /// </summary>
    [Serializable]
    public struct AttachmentsDelete
    {
        public AttachmentsDelete(CloudPDF.ChangeItemAttachmentsDelete value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAttachmentsDelete Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AttachmentsDelete(
            CloudPDF.ChangeItemAttachmentsDelete value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for attachments.restore
    /// </summary>
    [Serializable]
    public struct AttachmentsRestore
    {
        public AttachmentsRestore(CloudPDF.ChangeItemAttachmentsRestore value)
        {
            Value = value;
        }

        internal CloudPDF.ChangeItemAttachmentsRestore Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ChangeItem.AttachmentsRestore(
            CloudPDF.ChangeItemAttachmentsRestore value
        ) => new(value);
    }
}
