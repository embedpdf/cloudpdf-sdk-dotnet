// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItem.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItem
{
    internal DocAnnotationsList200ResponseAnnotationsItem(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Highlight"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Highlight value
    )
    {
        Subtype = "highlight";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Underline"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Underline value
    )
    {
        Subtype = "underline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Squiggly"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Squiggly value
    )
    {
        Subtype = "squiggly";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Strikeout"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Strikeout value
    )
    {
        Subtype = "strikeout";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Circle"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Circle value
    )
    {
        Subtype = "circle";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Square"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Square value
    )
    {
        Subtype = "square";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Polygon"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polygon value
    )
    {
        Subtype = "polygon";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Polyline"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polyline value
    )
    {
        Subtype = "polyline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Line"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Line value
    )
    {
        Subtype = "line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Link"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Link value
    )
    {
        Subtype = "link";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Ink"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Ink value
    )
    {
        Subtype = "ink";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.FreeText"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FreeText value
    )
    {
        Subtype = "free-text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Caret"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Caret value
    )
    {
        Subtype = "caret";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Text"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Text value
    )
    {
        Subtype = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Stamp"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Stamp value
    )
    {
        Subtype = "stamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.FileAttachment"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FileAttachment value
    )
    {
        Subtype = "file-attachment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Widget"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Widget value
    )
    {
        Subtype = "widget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Redact"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Redact value
    )
    {
        Subtype = "redact";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Unsupported"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Unsupported value
    )
    {
        Subtype = "unsupported";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("subtype")]
    public string Subtype { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "highlight"
    /// </summary>
    public bool IsHighlight => Subtype == "highlight";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "underline"
    /// </summary>
    public bool IsUnderline => Subtype == "underline";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "squiggly"
    /// </summary>
    public bool IsSquiggly => Subtype == "squiggly";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "strikeout"
    /// </summary>
    public bool IsStrikeout => Subtype == "strikeout";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "circle"
    /// </summary>
    public bool IsCircle => Subtype == "circle";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "square"
    /// </summary>
    public bool IsSquare => Subtype == "square";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "polygon"
    /// </summary>
    public bool IsPolygon => Subtype == "polygon";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "polyline"
    /// </summary>
    public bool IsPolyline => Subtype == "polyline";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "line"
    /// </summary>
    public bool IsLine => Subtype == "line";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "link"
    /// </summary>
    public bool IsLink => Subtype == "link";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "ink"
    /// </summary>
    public bool IsInk => Subtype == "ink";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "free-text"
    /// </summary>
    public bool IsFreeText => Subtype == "free-text";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "caret"
    /// </summary>
    public bool IsCaret => Subtype == "caret";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "text"
    /// </summary>
    public bool IsText => Subtype == "text";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "stamp"
    /// </summary>
    public bool IsStamp => Subtype == "stamp";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "file-attachment"
    /// </summary>
    public bool IsFileAttachment => Subtype == "file-attachment";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "widget"
    /// </summary>
    public bool IsWidget => Subtype == "widget";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "redact"
    /// </summary>
    public bool IsRedact => Subtype == "redact";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unsupported"
    /// </summary>
    public bool IsUnsupported => Subtype == "unsupported";

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight"/> if <see cref="Subtype"/> is 'highlight', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'highlight'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight AsHighlight() =>
        IsHighlight
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'highlight'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline"/> if <see cref="Subtype"/> is 'underline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'underline'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline AsUnderline() =>
        IsUnderline
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'underline'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly"/> if <see cref="Subtype"/> is 'squiggly', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'squiggly'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly AsSquiggly() =>
        IsSquiggly
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'squiggly'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout"/> if <see cref="Subtype"/> is 'strikeout', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'strikeout'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout AsStrikeout() =>
        IsStrikeout
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'strikeout'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle"/> if <see cref="Subtype"/> is 'circle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'circle'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle AsCircle() =>
        IsCircle
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'circle'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare"/> if <see cref="Subtype"/> is 'square', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'square'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare AsSquare() =>
        IsSquare
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'square'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon"/> if <see cref="Subtype"/> is 'polygon', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polygon'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon AsPolygon() =>
        IsPolygon
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'polygon'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline"/> if <see cref="Subtype"/> is 'polyline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polyline'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline AsPolyline() =>
        IsPolyline
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'polyline'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine"/> if <see cref="Subtype"/> is 'line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'line'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine AsLine() =>
        IsLine
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'line'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink"/> if <see cref="Subtype"/> is 'link', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'link'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink AsLink() =>
        IsLink
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'link'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk"/> if <see cref="Subtype"/> is 'ink', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'ink'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk AsInk() =>
        IsInk
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'ink'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText"/> if <see cref="Subtype"/> is 'free-text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'free-text'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText AsFreeText() =>
        IsFreeText
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'free-text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret"/> if <see cref="Subtype"/> is 'caret', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'caret'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret AsCaret() =>
        IsCaret
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'caret'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText"/> if <see cref="Subtype"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'text'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText AsText() =>
        IsText
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp"/> if <see cref="Subtype"/> is 'stamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'stamp'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp AsStamp() =>
        IsStamp
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'stamp'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment"/> if <see cref="Subtype"/> is 'file-attachment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'file-attachment'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment AsFileAttachment() =>
        IsFileAttachment
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'file-attachment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget"/> if <see cref="Subtype"/> is 'widget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'widget'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget AsWidget() =>
        IsWidget
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'widget'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact"/> if <see cref="Subtype"/> is 'redact', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'redact'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact AsRedact() =>
        IsRedact
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'redact'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported"/> if <see cref="Subtype"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unsupported'.</exception>
    public CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight, T> onHighlight,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline, T> onUnderline,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly, T> onSquiggly,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout, T> onStrikeout,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle, T> onCircle,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare, T> onSquare,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon, T> onPolygon,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline, T> onPolyline,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine, T> onLine,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink, T> onLink,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk, T> onInk,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText, T> onFreeText,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret, T> onCaret,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText, T> onText,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp, T> onStamp,
        Func<
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment,
            T
        > onFileAttachment,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget, T> onWidget,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact, T> onRedact,
        Func<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported, T> onUnsupported,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "highlight" => onHighlight(AsHighlight()),
            "underline" => onUnderline(AsUnderline()),
            "squiggly" => onSquiggly(AsSquiggly()),
            "strikeout" => onStrikeout(AsStrikeout()),
            "circle" => onCircle(AsCircle()),
            "square" => onSquare(AsSquare()),
            "polygon" => onPolygon(AsPolygon()),
            "polyline" => onPolyline(AsPolyline()),
            "line" => onLine(AsLine()),
            "link" => onLink(AsLink()),
            "ink" => onInk(AsInk()),
            "free-text" => onFreeText(AsFreeText()),
            "caret" => onCaret(AsCaret()),
            "text" => onText(AsText()),
            "stamp" => onStamp(AsStamp()),
            "file-attachment" => onFileAttachment(AsFileAttachment()),
            "widget" => onWidget(AsWidget()),
            "redact" => onRedact(AsRedact()),
            "unsupported" => onUnsupported(AsUnsupported()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight> onHighlight,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline> onUnderline,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly> onSquiggly,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout> onStrikeout,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle> onCircle,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare> onSquare,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon> onPolygon,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline> onPolyline,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine> onLine,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink> onLink,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk> onInk,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText> onFreeText,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret> onCaret,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText> onText,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp> onStamp,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment> onFileAttachment,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget> onWidget,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact> onRedact,
        Action<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported> onUnsupported,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
            case "highlight":
                onHighlight(AsHighlight());
                break;
            case "underline":
                onUnderline(AsUnderline());
                break;
            case "squiggly":
                onSquiggly(AsSquiggly());
                break;
            case "strikeout":
                onStrikeout(AsStrikeout());
                break;
            case "circle":
                onCircle(AsCircle());
                break;
            case "square":
                onSquare(AsSquare());
                break;
            case "polygon":
                onPolygon(AsPolygon());
                break;
            case "polyline":
                onPolyline(AsPolyline());
                break;
            case "line":
                onLine(AsLine());
                break;
            case "link":
                onLink(AsLink());
                break;
            case "ink":
                onInk(AsInk());
                break;
            case "free-text":
                onFreeText(AsFreeText());
                break;
            case "caret":
                onCaret(AsCaret());
                break;
            case "text":
                onText(AsText());
                break;
            case "stamp":
                onStamp(AsStamp());
                break;
            case "file-attachment":
                onFileAttachment(AsFileAttachment());
                break;
            case "widget":
                onWidget(AsWidget());
                break;
            case "redact":
                onRedact(AsRedact());
                break;
            case "unsupported":
                onUnsupported(AsUnsupported());
                break;
            default:
                onUnknown_(Subtype, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight"/> and returns true if successful.
    /// </summary>
    public bool TryAsHighlight(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight? value
    )
    {
        if (Subtype == "highlight")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnderline(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline? value
    )
    {
        if (Subtype == "underline")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquiggly(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly? value
    )
    {
        if (Subtype == "squiggly")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout"/> and returns true if successful.
    /// </summary>
    public bool TryAsStrikeout(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout? value
    )
    {
        if (Subtype == "strikeout")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle"/> and returns true if successful.
    /// </summary>
    public bool TryAsCircle(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle? value
    )
    {
        if (Subtype == "circle")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquare(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare? value
    )
    {
        if (Subtype == "square")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolygon(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon? value
    )
    {
        if (Subtype == "polygon")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolyline(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline? value
    )
    {
        if (Subtype == "polyline")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine"/> and returns true if successful.
    /// </summary>
    public bool TryAsLine(out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine? value)
    {
        if (Subtype == "line")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink"/> and returns true if successful.
    /// </summary>
    public bool TryAsLink(out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink? value)
    {
        if (Subtype == "link")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk"/> and returns true if successful.
    /// </summary>
    public bool TryAsInk(out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk? value)
    {
        if (Subtype == "ink")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFreeText(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText? value
    )
    {
        if (Subtype == "free-text")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret"/> and returns true if successful.
    /// </summary>
    public bool TryAsCaret(out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret? value)
    {
        if (Subtype == "caret")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText? value)
    {
        if (Subtype == "text")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsStamp(out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp? value)
    {
        if (Subtype == "stamp")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFileAttachment(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment? value
    )
    {
        if (Subtype == "file-attachment")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsWidget(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget? value
    )
    {
        if (Subtype == "widget")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact"/> and returns true if successful.
    /// </summary>
    public bool TryAsRedact(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact? value
    )
    {
        if (Subtype == "redact")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported? value
    )
    {
        if (Subtype == "unsupported")
        {
            value = (CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Highlight value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Underline value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Squiggly value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Strikeout value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Circle value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Square value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polygon value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polyline value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Line value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Link value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Ink value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FreeText value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Caret value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Text value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Stamp value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FileAttachment value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Widget value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Redact value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItem).IsAssignableFrom(typeToConvert);

        public override DocAnnotationsList200ResponseAnnotationsItem Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("subtype", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'subtype'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'subtype' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'subtype' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'subtype' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("subtype");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "highlight" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight"
                        ),
                "underline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline"
                        ),
                "squiggly" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly"
                        ),
                "strikeout" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout"
                        ),
                "circle" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle"
                        ),
                "square" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare"
                        ),
                "polygon" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon"
                        ),
                "polyline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline"
                        ),
                "line" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine"
                        ),
                "link" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink"
                        ),
                "ink" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk"
                        ),
                "free-text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText"
                        ),
                "caret" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret"
                        ),
                "text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText"
                        ),
                "stamp" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp"
                        ),
                "file-attachment" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment"
                        ),
                "widget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget"
                        ),
                "redact" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItem value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "highlight" => JsonSerializer.SerializeToNode(value.Value, options),
                    "underline" => JsonSerializer.SerializeToNode(value.Value, options),
                    "squiggly" => JsonSerializer.SerializeToNode(value.Value, options),
                    "strikeout" => JsonSerializer.SerializeToNode(value.Value, options),
                    "circle" => JsonSerializer.SerializeToNode(value.Value, options),
                    "square" => JsonSerializer.SerializeToNode(value.Value, options),
                    "polygon" => JsonSerializer.SerializeToNode(value.Value, options),
                    "polyline" => JsonSerializer.SerializeToNode(value.Value, options),
                    "line" => JsonSerializer.SerializeToNode(value.Value, options),
                    "link" => JsonSerializer.SerializeToNode(value.Value, options),
                    "ink" => JsonSerializer.SerializeToNode(value.Value, options),
                    "free-text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "caret" => JsonSerializer.SerializeToNode(value.Value, options),
                    "text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "stamp" => JsonSerializer.SerializeToNode(value.Value, options),
                    "file-attachment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "widget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "redact" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unsupported" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override DocAnnotationsList200ResponseAnnotationsItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Subtype);
        }
    }

    /// <summary>
    /// Discriminated union type for highlight
    /// </summary>
    [Serializable]
    public struct Highlight
    {
        public Highlight(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Highlight(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemHighlight value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for underline
    /// </summary>
    [Serializable]
    public struct Underline
    {
        public Underline(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Underline(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnderline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for squiggly
    /// </summary>
    [Serializable]
    public struct Squiggly
    {
        public Squiggly(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Squiggly(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquiggly value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for strikeout
    /// </summary>
    [Serializable]
    public struct Strikeout
    {
        public Strikeout(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Strikeout(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStrikeout value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for circle
    /// </summary>
    [Serializable]
    public struct Circle
    {
        public Circle(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Circle(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCircle value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for square
    /// </summary>
    [Serializable]
    public struct Square
    {
        public Square(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Square(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemSquare value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polygon
    /// </summary>
    [Serializable]
    public struct Polygon
    {
        public Polygon(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Polygon(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolygon value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polyline
    /// </summary>
    [Serializable]
    public struct Polyline
    {
        public Polyline(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Polyline(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemPolyline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for line
    /// </summary>
    [Serializable]
    public struct Line
    {
        public Line(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Line(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLine value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for link
    /// </summary>
    [Serializable]
    public struct Link
    {
        public Link(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Link(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemLink value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for ink
    /// </summary>
    [Serializable]
    public struct Ink
    {
        public Ink(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Ink(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemInk value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for free-text
    /// </summary>
    [Serializable]
    public struct FreeText
    {
        public FreeText(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.FreeText(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFreeText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for caret
    /// </summary>
    [Serializable]
    public struct Caret
    {
        public Caret(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Caret(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemCaret value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Text(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for stamp
    /// </summary>
    [Serializable]
    public struct Stamp
    {
        public Stamp(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Stamp(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemStamp value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for file-attachment
    /// </summary>
    [Serializable]
    public struct FileAttachment
    {
        public FileAttachment(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.FileAttachment(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemFileAttachment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for widget
    /// </summary>
    [Serializable]
    public struct Widget
    {
        public Widget(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Widget(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for redact
    /// </summary>
    [Serializable]
    public struct Redact
    {
        public Redact(CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact value)
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Redact(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemRedact value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported value
        )
        {
            Value = value;
        }

        internal CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Unsupported(
            CloudpdfApi.DocAnnotationsList200ResponseAnnotationsItemUnsupported value
        ) => new(value);
    }
}
