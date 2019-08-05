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

let dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "../../../../App_Data/Reviews")
let files = dirInfo.GetFiles ()
let companyScores = new Dictionary<string, string>()

for f in files do
    try
        let score = GetCompanyScore (f.FullName)
        let result = companyScores.TryAdd(f.Name, score)
        printfn "%s" f.Name
    with
    | _ -> ()

let scoresSerialized = JsonConvert.SerializeObject(companyScores)
File.WriteAllText("../../../App_Data/CompanyReviews/scores.json", scoresSerialized)

Console.ReadKey ()