open DOU_Companies
open ProcessHtmlFiles
open AddressParser
open System
open System.Collections.Generic
open XPlot.GoogleCharts
open System.IO
open Newtonsoft.Json
open ProcessReviews
open FSharp.Data
open System.Threading

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

let GetTranslatedString text = 
    Http.RequestString("http://localhost:9999", body = FormValues ["text", text])

let originalReviews = File.ReadAllText("../../../App_Data/CompanyReviews/reviews.json")
let reviewsSerializedText = File.ReadAllText("../../../App_Data/CompanyReviews/translatedReviews.json")

let companyReviews = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(reviewsSerializedText)
let originalCompanyReviews = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(originalReviews)

let mutable ableToTranslate = true

for kvp in companyReviews do
    let reviews = kvp.Value
    for i = 0 to reviews.Length - 1 do
        let formattedString = String.Format("{0} id: {1} done", kvp.Key, i)
        printfn "%s" formattedString
        if ableToTranslate then
            if String.IsNullOrEmpty(reviews.[i]) then
                let translatedString = GetTranslatedString originalCompanyReviews.[kvp.Key].[i]
                if translatedString = "Exit" then
                    ableToTranslate <- false
                else 
                    reviews.[i] <- translatedString
            Thread.Sleep 1500

let translatedReviewsSerialized = JsonConvert.SerializeObject companyReviews
File.WriteAllText("../../../App_Data/CompanyReviews/translatedReviews1.json", translatedReviewsSerialized)

Console.ReadKey ()