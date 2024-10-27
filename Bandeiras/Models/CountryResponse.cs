using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bandeiras.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    [Serializable]
    public class CountryResponse : ICloneable
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("tld")]
        public List<string> Tld { get; set; }

        [JsonPropertyName("cca2")]
        public string Cca2 { get; set; }

        [JsonPropertyName("ccn3")]
        public string Ccn3 { get; set; }

        [JsonPropertyName("cca3")]
        public string Cca3 { get; set; }

        [JsonPropertyName("cioc")]
        public string Cioc { get; set; }

        [JsonPropertyName("independent")]
        public bool Independent { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("unMember")]
        public bool UnMember { get; set; }

        [JsonPropertyName("currencies")]
        public Currencies Currencies { get; set; }

        [JsonPropertyName("idd")]
        public Idd Idd { get; set; }

        [JsonPropertyName("capital")]
        public List<string> Capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public List<string> AltSpellings { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonPropertyName("languages")]
        public Languages Languages { get; set; }

        [JsonPropertyName("translations")]
        public Translations Translations { get; set; }

        [JsonPropertyName("latlng")]
        public List<decimal> Latlng { get; set; }

        [JsonPropertyName("landlocked")]
        public bool Landlocked { get; set; }

        [JsonPropertyName("borders")]
        public List<string> Borders { get; set; }

        [JsonPropertyName("area")]
        public decimal Area { get; set; }

        [JsonPropertyName("demonyms")]
        public Demonyms Demonyms { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("maps")]
        public Maps Maps { get; set; }

        [JsonPropertyName("population")]
        public int Population { get; set; }

        [JsonPropertyName("fifa")]
        public string Fifa { get; set; }

        [JsonPropertyName("car")]
        public Car Car { get; set; }

        [JsonPropertyName("timezones")]
        public List<string> Timezones { get; set; }

        [JsonPropertyName("continents")]
        public List<string> Continents { get; set; }

        [JsonPropertyName("flags")]
        public Flags Flags { get; set; }

        [JsonPropertyName("coatOfArms")]
        public CoatOfArms CoatOfArms { get; set; }

        [JsonPropertyName("startOfWeek")]
        public string StartOfWeek { get; set; }

        [JsonPropertyName("capitalInfo")]
        public CapitalInfo CapitalInfo { get; set; }

        [JsonPropertyName("postalCode")]
        public PostalCode PostalCode { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    [Serializable]
    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("nativeName")]
        public NativeName NativeName { get; set; }
        public string TranslatedName { get; set; }
    }

    [Serializable]
    public class NativeName
    {
        [JsonPropertyName("ara")]
        public Ara Ara { get; set; }
    }

    [Serializable]
    public class Ara
    {
        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }
    }

    [Serializable]
    public class Por
    {
        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }
    }

    [Serializable]
    public class Currencies
    {
        [JsonPropertyName("SAR")]
        public SAR SAR { get; set; }
    }

    [Serializable]
    public class SAR
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }

    [Serializable]
    public class Idd
    {
        [JsonPropertyName("root")]
        public string Root { get; set; }

        [JsonPropertyName("suffixes")]
        public List<string> Suffixes { get; set; }
    }

    [Serializable]
    public class Languages
    {
        [JsonPropertyName("ara")]
        public string Ara { get; set; }
    }

    [Serializable]
    public class Translations
    {
        [JsonPropertyName("ara")]
        public Ara Ara { get; set; }

        // tradução estranha (melhor usar google tradutor)
        [JsonPropertyName("por")]
        public Por Por { get; set; }
    }

    [Serializable]
    public class Demonyms
    {
        [JsonPropertyName("eng")]
        public Eng Eng { get; set; }

        [JsonPropertyName("fra")]
        public Fra Fra { get; set; }
    }

    [Serializable]
    public class Eng
    {
        [JsonPropertyName("f")]
        public string F { get; set; }

        [JsonPropertyName("m")]
        public string M { get; set; }
    }

    [Serializable]
    public class Fra
    {
        [JsonPropertyName("f")]
        public string F { get; set; }

        [JsonPropertyName("m")]
        public string M { get; set; }
    }

    [Serializable]
    public class Maps
    {
        [JsonPropertyName("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonPropertyName("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

    [Serializable]
    public class Car
    {
        [JsonPropertyName("signs")]
        public List<string> Signs { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }
    }

    [Serializable]
    public class Flags
    {
        [JsonPropertyName("png")]
        public string Png { get; set; }

        [JsonPropertyName("svg")]
        public string Svg { get; set; }

        [JsonPropertyName("alt")]
        public string Alt { get; set; }

        public byte[] PngBytes { get; set; }
    }

    [Serializable]
    public class CoatOfArms
    {
        [JsonPropertyName("png")]
        public string Png { get; set; }

        [JsonPropertyName("svg")]
        public string Svg { get; set; }
    }

    [Serializable]
    public class CapitalInfo
    {
        [JsonPropertyName("latlng")]
        public List<decimal> Latlng { get; set; }
    }

    [Serializable]
    public class PostalCode
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("regex")]
        public string Regex { get; set; }
    }

}
