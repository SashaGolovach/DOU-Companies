open DOU_Companies
open ProcessHtmlFiles
open System
open XPlot.GoogleCharts

let data =
    [
        "ул. Амосова, 12", "China: 1,363,800,000"
        "ул. Отакара Яроша, 18Д", "India: 1,242,620,000"
        "ул. Шевченко 111a, 9 этаж, БЦ Legenda Class", "US: 317,842,000"
        "ул. Барикадная, 15а , этажи 8-12", "Indonesia: 247,424,598"
        "ул. Леха Качинского, 7. 6й этаж БЦ Риальто", "Brazil: 201,032,714"
    ]
    
let options =
  Options
   (  displayMode = "markers", region="UA",
      colorAxis = ColorAxis(colors = [|"green"; "blue"|]) ) 
data
|> Chart.Geo
|> Chart.WithLabels ["Population"; "Area"]
|> Chart.WithOptions options
|> Chart.WithApiKey "AIzaSyDJ-Xr91-wOnT2hDfQ3SYdRjbo2ui9RrYI"
|> Chart.Show

GetAllCompaniesLocations
Console.ReadKey ()