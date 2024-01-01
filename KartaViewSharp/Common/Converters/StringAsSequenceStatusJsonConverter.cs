using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.Common.Converters;

internal class StringAsSequenceStatusJsonConverter : JsonConverter<SequenceStatus>
{
    public override SequenceStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "FINISHED" => SequenceStatus.Finished,
            "NEW" => SequenceStatus.New,
            "VIDEO_SPLIT" => SequenceStatus.VideoSplit,
            "UPLOAD_FINISHED" => SequenceStatus.UploadFinished,
            "PROCESSING_FINISHED" => SequenceStatus.ProcessingFinished,
            "PROCESSING_FAILED" => SequenceStatus.ProcessingFailed,
            "UPLOADING" => SequenceStatus.Uploading,
            "PROCESSING" => SequenceStatus.Processing,
            "FAILED" => SequenceStatus.Failed,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        SequenceStatus value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            SequenceStatus.Finished => "FINISHED",
            SequenceStatus.New => "NEW",
            SequenceStatus.VideoSplit => "VIDEO_SPLIT",
            SequenceStatus.UploadFinished => "UPLOAD_FINISHED",
            SequenceStatus.ProcessingFinished => "PROCESSING_FINISHED",
            SequenceStatus.ProcessingFailed => "PROCESSING_FAILED",
            SequenceStatus.Uploading => "UPLOADING",
            SequenceStatus.Processing => "PROCESSING",
            SequenceStatus.Failed => "FAILED",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}