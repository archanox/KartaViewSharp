﻿using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V1.Enums;

namespace KartaViewSharp.Common.Converters;

internal class StringAsUserCategoryJsonConverter : JsonConverter<UserCategory>
{
    public override UserCategory Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        reader.GetString() switch
        {
            "REGULAR" => UserCategory.Regular,
            "DRIVER" => UserCategory.Driver,
            "INTERNAL" => UserCategory.Internal,
            _ => throw new ArgumentOutOfRangeException()
        };

    public override void Write(
        Utf8JsonWriter writer,
        UserCategory value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            UserCategory.Regular => "REGULAR",
            UserCategory.Driver => "DRIVER",
            UserCategory.Internal => "INTERNAL",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        });
    }
}