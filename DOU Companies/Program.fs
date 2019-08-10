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
open GoogleNLP.Implementations
open System.Linq
open FSharp.Data.Sql
open FSharp.Data.Sql.Providers
open MySql.Data

//let serializedText = File.ReadAllText("App_Data/CompanyReviews/scores.json")
//let companyScores = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedText)
//
//let serializedText1 = File.ReadAllText("../../../App_Data/CompanyReviews/analysedReviews.json")
//let analysedReviews = JsonConvert.DeserializeObject<Dictionary<string, decimal[]>>(serializedText1)
//
//let serializedText2 = File.ReadAllText("../../../App_Data/CompanyReviews/reviews.json")
//let originalReviews = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(serializedText2)
//
//let reviewsPieChart () = 
//    let mutable negativeReviewsCount = 0
//    let mutable neutralReviewsCount = 0
//    let mutable positiveReviewsCount = 0
//
//    for kvp in analysedReviews do 
//        negativeReviewsCount <- negativeReviewsCount + kvp.Value.ToList().Where(fun r -> r < 0m).Count()
//        positiveReviewsCount <- positiveReviewsCount + kvp.Value.ToList().Where(fun r -> r > 0m).Count()
//        neutralReviewsCount <- neutralReviewsCount + kvp.Value.ToList().Where(fun r -> r = 0m).Count()
//
//    let data =[
//        "Positive", positiveReviewsCount
//        "Negative", negativeReviewsCount
//        "Neutral", neutralReviewsCount
//    ]
//
//    data |> Chart.Pie
//    |> Chart.WithTitle "Reviews"
//    |> Chart.WithLegend true
//    |> Chart.Show
//
//let getReviewsCount () = 
//    let mutable count = 0
//    for kvp in originalReviews do
//        count <- count + kvp.Value.Length
//    Console.WriteLine(count)
//
//let getMaxScoreReview () = 
//    let mutable text = ""
//    let mutable score = 0m
//    for kvp in originalReviews do
//        for i = 0 to analysedReviews.[kvp.Key].Length - 1 do
//            if analysedReviews.[kvp.Key].[i] > score then 
//                text <- originalReviews.[kvp.Key].[i]
//                score <- analysedReviews.[kvp.Key].[i]
//    Console.WriteLine(score)
//    text
    
let sales = ["GlobalLogic", 1204; "SoftServe", 456; "EPAM Systems", 292; "Miratech", 199]
let expenses = ["GlobalLogic", 1420; "SoftServe", 338; "EPAM Systems", 273; "Miratech", 179]
// mr - 0.025693161030904202 gl - -0.011468710260296843 ss - 0.04299559551845038 ep - 0.020500595995510292
let options =
    Options(
        title = "",
        hAxis =
            Axis(
                title = "Company",
                titleTextStyle = TextStyle(color = "red")
            )
    )
 
[sales; expenses]
|> Chart.Column
|> Chart.WithOptions options
|> Chart.WithLabels ["Positive"; "Negative"]
|> Chart.Show

Console.ReadKey ()