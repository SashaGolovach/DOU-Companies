open System

open FSharp.Data

let url = 
  "https://en.wikipedia.org/wiki/" +
    "2017_FIA_Formula_One_World_Championship"
    
type F1_2017 = HtmlProvider<"../data/2017_F1.htm">

// Download the latest market depth information
let f1Calendar = 
  F1_2017.Load(url).Tables.``Season calendar``

// Look at the most recent row. Note the 'Date' property
// is of type 'DateTime' and 'Open' has a type 'decimal'
let firstRow = f1Calendar.Rows |> Seq.head
let round = firstRow.Round
let grandPrix = firstRow.``Grand Prix``
let date = firstRow.Date

// Print the bid / offer volumes for each row
for row in f1Calendar.Rows do
  printfn "Race, round %A is hosted at %A on %A" 
    row.Round row.``Grand Prix`` row.Date