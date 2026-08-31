// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.JsonConverter)
)]
[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination
{
    internal DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        string type,
        object? value
    )
    {
        Kind = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Xyz"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Xyz value
    )
    {
        Kind = "xyz";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Fit"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Fit value
    )
    {
        Kind = "fit";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitH"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitH value
    )
    {
        Kind = "fitH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitV"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitV value
    )
    {
        Kind = "fitV";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitR"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitR value
    )
    {
        Kind = "fitR";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitB"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitB value
    )
    {
        Kind = "fitB";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBh"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBh value
    )
    {
        Kind = "fitBH";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBv"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBv value
    )
    {
        Kind = "fitBV";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "xyz"
    /// </summary>
    public bool IsXyz => Kind == "xyz";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fit"
    /// </summary>
    public bool IsFit => Kind == "fit";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitH"
    /// </summary>
    public bool IsFitH => Kind == "fitH";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitV"
    /// </summary>
    public bool IsFitV => Kind == "fitV";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitR"
    /// </summary>
    public bool IsFitR => Kind == "fitR";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitB"
    /// </summary>
    public bool IsFitB => Kind == "fitB";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitBH"
    /// </summary>
    public bool IsFitBh => Kind == "fitBH";

    /// <summary>
    /// Returns true if <see cref="Kind"/> is "fitBV"
    /// </summary>
    public bool IsFitBv => Kind == "fitBV";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz"/> if <see cref="Kind"/> is 'xyz', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'xyz'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz AsXyz() =>
        IsXyz
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'xyz'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit"/> if <see cref="Kind"/> is 'fit', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fit'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit AsFit() =>
        IsFit
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fit'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH"/> if <see cref="Kind"/> is 'fitH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitH'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH AsFitH() =>
        IsFitH
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitH'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV"/> if <see cref="Kind"/> is 'fitV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitV'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV AsFitV() =>
        IsFitV
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitV'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR"/> if <see cref="Kind"/> is 'fitR', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitR'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR AsFitR() =>
        IsFitR
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitR'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB"/> if <see cref="Kind"/> is 'fitB', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitB'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB AsFitB() =>
        IsFitB
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitB'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh"/> if <see cref="Kind"/> is 'fitBH', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBH'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh AsFitBh() =>
        IsFitBh
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitBH'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv"/> if <see cref="Kind"/> is 'fitBV', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Kind"/> is not 'fitBV'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv AsFitBv() =>
        IsFitBv
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Kind is not 'fitBV'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz,
            T
        > onXyz,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit,
            T
        > onFit,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH,
            T
        > onFitH,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV,
            T
        > onFitV,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR,
            T
        > onFitR,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB,
            T
        > onFitB,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh,
            T
        > onFitBh,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv,
            T
        > onFitBv,
        Func<string, object?, T> onUnknown_
    )
    {
        return Kind switch
        {
            "xyz" => onXyz(AsXyz()),
            "fit" => onFit(AsFit()),
            "fitH" => onFitH(AsFitH()),
            "fitV" => onFitV(AsFitV()),
            "fitR" => onFitR(AsFitR()),
            "fitB" => onFitB(AsFitB()),
            "fitBH" => onFitBh(AsFitBh()),
            "fitBV" => onFitBv(AsFitBv()),
            _ => onUnknown_(Kind, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz> onXyz,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit> onFit,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH> onFitH,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV> onFitV,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR> onFitR,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB> onFitB,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh> onFitBh,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv> onFitBv,
        Action<string, object?> onUnknown_
    )
    {
        switch (Kind)
        {
            case "xyz":
                onXyz(AsXyz());
                break;
            case "fit":
                onFit(AsFit());
                break;
            case "fitH":
                onFitH(AsFitH());
                break;
            case "fitV":
                onFitV(AsFitV());
                break;
            case "fitR":
                onFitR(AsFitR());
                break;
            case "fitB":
                onFitB(AsFitB());
                break;
            case "fitBH":
                onFitBh(AsFitBh());
                break;
            case "fitBV":
                onFitBv(AsFitBv());
                break;
            default:
                onUnknown_(Kind, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz"/> and returns true if successful.
    /// </summary>
    public bool TryAsXyz(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz? value
    )
    {
        if (Kind == "xyz")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit"/> and returns true if successful.
    /// </summary>
    public bool TryAsFit(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit? value
    )
    {
        if (Kind == "fit")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitH(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH? value
    )
    {
        if (Kind == "fitH")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitV(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV? value
    )
    {
        if (Kind == "fitV")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitR(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR? value
    )
    {
        if (Kind == "fitR")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitB(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB? value
    )
    {
        if (Kind == "fitB")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBh(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh? value
    )
    {
        if (Kind == "fitBH")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv"/> and returns true if successful.
    /// </summary>
    public bool TryAsFitBv(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv? value
    )
    {
        if (Kind == "fitBV")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Xyz value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Fit value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitH value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitV value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitR value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitB value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBh value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBv value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("kind", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'kind'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'kind' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'kind' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'kind' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("kind");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "xyz" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz"
                        ),
                "fit" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit"
                        ),
                "fitH" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH"
                        ),
                "fitV" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV"
                        ),
                "fitR" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR"
                        ),
                "fitB" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB"
                        ),
                "fitBH" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh"
                        ),
                "fitBV" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Kind switch
                {
                    "xyz" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fit" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitH" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitV" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitR" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitB" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitBH" => JsonSerializer.SerializeToNode(value.Value, options),
                    "fitBV" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["kind"] = value.Kind;
            json.WriteTo(writer, options);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Kind);
        }
    }

    /// <summary>
    /// Discriminated union type for xyz
    /// </summary>
    [Serializable]
    public struct Xyz
    {
        public Xyz(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Xyz(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationXyz value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fit
    /// </summary>
    [Serializable]
    public struct Fit
    {
        public Fit(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.Fit(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFit value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitH
    /// </summary>
    [Serializable]
    public struct FitH
    {
        public FitH(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitH(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitH value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitV
    /// </summary>
    [Serializable]
    public struct FitV
    {
        public FitV(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitV(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitV value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitR
    /// </summary>
    [Serializable]
    public struct FitR
    {
        public FitR(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitR(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitR value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitB
    /// </summary>
    [Serializable]
    public struct FitB
    {
        public FitB(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitB(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitB value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBH
    /// </summary>
    [Serializable]
    public struct FitBh
    {
        public FitBh(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBh(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBh value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for fitBV
    /// </summary>
    [Serializable]
    public struct FitBv
    {
        public FitBv(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestination.FitBv(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLinkTargetGotoDestinationFitBv value
        ) => new(value);
    }
}
