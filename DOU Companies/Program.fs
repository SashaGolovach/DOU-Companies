open DOU_Companies
open ProcessHtmlFiles
open System
open XPlot.GoogleCharts
open System.IO

//let data = 
//    [
//        "ул. Амосова, 12", "ул. Амосова, 12"
//        "ул. Отакара Яроша, 18Д", "ул. Отакара Яроша, 18Д"
//        "ул. Шевченко 111a, 9 этаж, БЦ Legenda Class", "ул. Шевченко 111a, 9 этаж, БЦ Legenda Class"
//        "ул. Барикадная, 15а , этажи 8-12", "ул. Барикадная, 15а , этажи 8-12"
//        "ул. Леха Качинского, 7. 6й этаж БЦ Риальто", "ул. Леха Качинского, 7. 6й этаж БЦ Риальто"
//    ]
//    
//let options =
//  Options
//   (mapType = "normal") 
//data
//|> Chart.Map
//|> Chart.WithOptions options
//|> Chart.WithApiKey "AIzaSyDJ-Xr91-wOnT2hDfQ3SYdRjbo2ui9RrYI"
//|> Chart.Show


let links = File.ReadAllLines "App_Data/links.txt"
GetAllCompaniesLocationInfo links

Console.ReadKey ()