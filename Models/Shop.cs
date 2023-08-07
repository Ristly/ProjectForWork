using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjectForWork.Models;

[XmlRoot(ElementName = "currency")]
public class Currency
{

    [XmlAttribute(AttributeName = "id")]
    public string Id { get; set; }

    [XmlAttribute(AttributeName = "rate")]
    public int Rate { get; set; }

    [XmlAttribute(AttributeName = "plus")]
    public int Plus { get; set; }
}

[XmlRoot(ElementName = "currencies")]
public class Currencies
{

    [XmlElement(ElementName = "currency")]
    public Currency Currency { get; set; }
}

[XmlRoot(ElementName = "category")]
public class Category
{

    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlText]
    public string Text { get; set; }

    [XmlAttribute(AttributeName = "parentId")]
    public int ParentId { get; set; }
}

[XmlRoot(ElementName = "categories")]
public class Categories
{

    [XmlElement(ElementName = "category")]
    public List<Category> Category { get; set; }
}

[XmlRoot(ElementName = "categoryId")]
public class CategoryId
{

    [XmlAttribute(AttributeName = "type")]
    public string Type { get; set; }

    [XmlText]
    public int Text { get; set; }
}

[XmlRoot(ElementName = "offer")]
public class Offer
{

    [XmlElement(ElementName = "url")]
    public string Url { get; set; }

    [XmlElement(ElementName = "price")]
    public int Price { get; set; }

    [XmlElement(ElementName = "currencyId")]
    public string CurrencyId { get; set; }

    [XmlElement(ElementName = "categoryId")]
    public CategoryId CategoryId { get; set; }

    [XmlElement(ElementName = "picture")]
    public string Picture { get; set; }

    [XmlElement(ElementName = "delivery")]
    public bool Delivery { get; set; }

    [XmlElement(ElementName = "local_delivery_cost")]
    public int LocalDeliveryCost { get; set; }

    [XmlElement(ElementName = "typePrefix")]
    public string TypePrefix { get; set; }

    [XmlElement(ElementName = "vendor")]
    public string Vendor { get; set; }

    [XmlElement(ElementName = "vendorCode")]
    public string VendorCode { get; set; }

    [XmlElement(ElementName = "model")]
    public string Model { get; set; }

    [XmlElement(ElementName = "description")]
    public string Description { get; set; }

    [XmlElement(ElementName = "manufacturer_warranty")]
    public bool ManufacturerWarranty { get; set; }

    [XmlElement(ElementName = "country_of_origin")]
    public string CountryOfOrigin { get; set; }

    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "type")]
    public string Type { get; set; }

    [XmlAttribute(AttributeName = "bid")]
    public int Bid { get; set; }

    [XmlAttribute(AttributeName = "cbid")]
    public int Cbid { get; set; }

    [XmlAttribute(AttributeName = "available")]
    public bool Available { get; set; }
    
    [XmlText]
    public string Text { get; set; }

    [XmlElement(ElementName = "author")]
    public string Author { get; set; }

    [XmlElement(ElementName = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "publisher")]
    public string Publisher { get; set; }

    [XmlElement(ElementName = "series")]
    public string Series { get; set; }

    [XmlElement(ElementName = "year")]
    public int Year { get; set; }

    [XmlElement(ElementName = "ISBN")]
    public string ISBN { get; set; }

    [XmlElement(ElementName = "volume")]
    public int Volume { get; set; }

    [XmlElement(ElementName = "part")]
    public int Part { get; set; }

    [XmlElement(ElementName = "language")]
    public string Language { get; set; }

    [XmlElement(ElementName = "binding")]
    public string Binding { get; set; }

    [XmlElement(ElementName = "page_extent")]
    public int PageExtent { get; set; }

    [XmlElement(ElementName = "downloadable")]
    public bool Downloadable { get; set; }

    [XmlElement(ElementName = "performed_by")]
    public string PerformedBy { get; set; }

    [XmlElement(ElementName = "performance_type")]
    public string PerformanceType { get; set; }

    [XmlElement(ElementName = "storage")]
    public string Storage { get; set; }

    [XmlElement(ElementName = "format")]
    public string Format { get; set; }

    [XmlElement(ElementName = "recording_length")]
    public string RecordingLength { get; set; }

    [XmlElement(ElementName = "artist")]
    public string Artist { get; set; }

    [XmlElement(ElementName = "title")]
    public string Title { get; set; }

    [XmlElement(ElementName = "media")]
    public string Media { get; set; }

    [XmlElement(ElementName = "starring")]
    public string Starring { get; set; }

    [XmlElement(ElementName = "director")]
    public string Director { get; set; }

    [XmlElement(ElementName = "originalName")]
    public string OriginalName { get; set; }

    [XmlElement(ElementName = "country")]
    public string Country { get; set; }

    [XmlElement(ElementName = "worldRegion")]
    public string WorldRegion { get; set; }

    [XmlElement(ElementName = "region")]
    public string Region { get; set; }

    [XmlElement(ElementName = "days")]
    public int Days { get; set; }

    [XmlElement(ElementName = "dataTour")]
    public List<string> DataTour { get; set; }

    [XmlElement(ElementName = "hotel_stars")]
    public string HotelStars { get; set; }

    [XmlElement(ElementName = "room")]
    public string Room { get; set; }

    [XmlElement(ElementName = "meal")]
    public string Meal { get; set; }

    [XmlElement(ElementName = "included")]
    public string Included { get; set; }

    [XmlElement(ElementName = "transport")]
    public string Transport { get; set; }

    [XmlElement(ElementName = "place")]
    public string Place { get; set; }

    [XmlElement(ElementName = "hall")]
    public Hall Hall { get; set; }

    [XmlElement(ElementName = "hall_part")]
    public string HallPart { get; set; }

    [XmlElement(ElementName = "date")]
    public string Date { get; set; }

    [XmlElement(ElementName = "is_premiere")]
    public int IsPremiere { get; set; }

    [XmlElement(ElementName = "is_kids")]
    public int IsKids { get; set; }
}

[XmlRoot(ElementName = "hall")]
public class Hall
{

    [XmlAttribute(AttributeName = "plan")]
    public string Plan { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "offers")]
public class Offers
{

    [XmlElement(ElementName = "offer")]
    public List<Offer> Offer { get; set; }
}

[XmlRoot(ElementName = "shop")]
public class Shop
{

    [XmlElement(ElementName = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "company")]
    public string Company { get; set; }

    [XmlElement(ElementName = "url")]
    public string Url { get; set; }

    [XmlElement(ElementName = "currencies")]
    public Currencies Currencies { get; set; }

    [XmlElement(ElementName = "categories")]
    public Categories Categories { get; set; }

    [XmlElement(ElementName = "local_delivery_cost")]
    public int LocalDeliveryCost { get; set; }

    [XmlElement(ElementName = "offers")]
    public Offers Offers { get; set; }
}

