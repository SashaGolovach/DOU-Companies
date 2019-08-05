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

let serializedText = File.ReadAllText("../../../App_Data/CompanyReviews/scores.json")
let companyScores = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedText)

let serializedText1 = File.ReadAllText("../../../App_Data/CompanyReviews/analysedReviews.json")
let analysedReviews = JsonConvert.DeserializeObject<Dictionary<string, decimal[]>>(serializedText1)

let mutable negativeReviewsCount = 0
let mutable neutralReviewsCount = 0
let mutable positiveReviewsCount = 0

for kvp in analysedReviews do 
    negativeReviewsCount <- negativeReviewsCount + kvp.Value.ToList().Where(fun r -> r < 0m).Count()
    positiveReviewsCount <- positiveReviewsCount + kvp.Value.ToList().Where(fun r -> r > 0m).Count()
    neutralReviewsCount <- neutralReviewsCount + kvp.Value.ToList().Where(fun r -> r = 0m).Count()

let data =[
    "Positive", positiveReviewsCount
    "Negative", negativeReviewsCount
    "Neutral", neutralReviewsCount
]

data |> Chart.Pie
|> Chart.WithTitle "Reviews"
|> Chart.WithLegend true
|> Chart.Show

Console.ReadKey ()