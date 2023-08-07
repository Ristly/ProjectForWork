using Android.App;
using Android.Content;
using Android.Net.Wifi.Aware;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Nio;
using Newtonsoft.Json;
using ProjectForWork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace ProjectForWork;

public class ShopDataManager
{
    public Shop? Shop { get; set; }



    public async Task SetShopData()
    {
        WebRequest request;
        request = WebRequest.Create("https://yastatic.net/market-export/_/partner/help/YML.xml");
        request.Method = "GET";

       
        request.ContentType = "application/xml";
        var response = (await request.GetResponseAsync())
            .GetResponseStream();
        XmlDocument xmlDocument = new XmlDocument();
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        using (XmlReader rs = XmlReader.Create(response, new XmlReaderSettings() { DtdProcessing = DtdProcessing.Parse }))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Shop));
            rs.ReadToFollowing("shop");
            Shop = (Shop)serializer.Deserialize(rs)!;
        }
    }

    public List<string>? GetOffersIds()
        =>  Shop is null? null : Shop.Offers.Offer.Select(x => x.Id.ToString()).ToList();



    public string? GetOfferByIdAsync(string id)
        => Shop is null ? null : JsonConvert.SerializeObject(Shop.Offers.Offer.FirstOrDefault(x => x.Id.ToString() == id));

}