open DOU_Companies
open ProcessHtmlFiles
open AddressParser
open System
open System
open System.Collections.Generic
open XPlot.GoogleCharts
open System.IO
open Newtonsoft.Json

let temp = 
    [
        "ул. Амосова, 12", "ул. Амосова, 12"
        "ул. Отакара Яроша, 18Д", "ул. Отакара Яроша, 18Д"
    ]

//let options =
//  Options
//   (mapType = "normal") 
//Seq.take 5 addresses
//|> Chart.Map
//|> Chart.WithOptions options
//|> Chart.WithApiKey "AIzaSyDJ-Xr91-wOnT2hDfQ3SYdRjbo2ui9RrYI"
//|> Chart.Show

GetCompanyCoordinates

Console.ReadKey ()