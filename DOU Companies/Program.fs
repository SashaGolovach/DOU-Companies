open DOU_Companies
open ProcessHtmlFiles
open AddressParser
open System
open System.Collections.Generic
open XPlot.GoogleCharts
open System.IO
open Newtonsoft.Json
open ProcessReviews

//let temp = 
//    [|
//        "Lat , Long", "Name"
//        "50,4223641 , 30,5059538", "ул. Амосова, 12"
//        "49,8505318 , 23,991378", "ул. Отакара Яроша, 18Д"
//    |]
////
////let coordinatesText = File.ReadAllText("App_Data/coordinates.json")
////let coordinates = JsonConvert.DeserializeObject<Dictionary<string, seq<string>>> (coordinatesText)
////
////let data = [|for companyName in coordinates.Keys do
////                 for c in coordinates.[companyName] -> (c, companyName)|]
//let addressesText = File.ReadAllText("App_Data/addresses.json")
//let addresses = JsonConvert.DeserializeObject<Dictionary<string, seq<string>>> (addressesText)
//let data = [|for companyName in addresses.Keys do
//                for address in addresses.[companyName] -> (trimStr(address), companyName)|]
//let options =
//  Options
//   ()//(mapType = "normal", region = "UA")

//let test = [|
//    "Country", "Population"
//    "ул. Амосова, 12", "China: 1,363,800,000"
//    "ул. Отакара Яроша, 18Д", "India: 1,242,620,000"
//|]
//data
//|> Chart.Geo
//|> Chart.WithOptions options
//|> Chart.WithApiKey "AIzaSyDJ-Xr91-wOnT2hDfQ3SYdRjbo2ui9RrYI"
//|> Chart.Show

let reviewsSerializedText = File.ReadAllText("../../../App_Data/CompanyReviews/reviews.json")
let companyReviews = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(reviewsSerializedText)
for kvp in companyReviews do
    let reviews = kvp.Value
    for i = 0 to reviews.Length - 1 do
        let formattedString = String.Format("{0} id: {1}", kvp.Key, i)
        printfn "%s" formattedString
        if String.IsNullOrEmpty(reviews.[i]) then
            ()
        else
            reviews.[i] <- TranslateText reviews.[i]

let translatedReviewsSerialized = JsonConvert.SerializeObject companyReviews
File.WriteAllText("../../../App_Data/CompanyReviews/translatedReviews.json", translatedReviewsSerialized)

Console.ReadKey ()