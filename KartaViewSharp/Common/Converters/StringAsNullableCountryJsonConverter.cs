using System.Text.Json;
using System.Text.Json.Serialization;
using ISO3166;

namespace KartaViewSharp.Common.Converters;

internal class StringAsNullableCountryJsonConverter : JsonConverter<Country?>
{
    public override Country? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value == null ? null : Country.List.SingleOrDefault(x => x.TwoLetterCode == value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        Country? value,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(value?.TwoLetterCode);
}