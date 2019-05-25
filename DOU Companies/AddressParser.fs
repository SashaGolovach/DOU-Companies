namespace DOU_Companies

open System
open System.Collections.Generic
open System.IO
open Newtonsoft.Json
open FSharp.Data

module AddressParser =
    let mutable i = 0
    let apiKey  = "AIzaSyDJ-Xr91-wOnT2hDfQ3SYdRjbo2ui9RrYI"
    let url = "https://maps.googleapis.com/maps/api/geocode/json?key={0}&address={1}"
    type coordinatesProvider = JsonProvider<"""https://maps.googleapis.com/maps/api/geocode/json?key=AIzaSyDJ-Xr91-wOnT2hDfQ3SYdRjbo2ui9RrYI&address=test""">

    let trimStr (s:string) =
        s.Replace("(показать на карте)", "")
        
    let GetAddressCoordinates (address : string) =
        let c = coordinatesProvider.Load (String.Format(url, apiKey, trimStr address))
        if c.Status.Equals "OK" then
            Console.WriteLine i
            i <- i + 1
            let location = c.Results.[0].Geometry.Location
            location.Lat.ToString() + ", " + location.Lng.ToString()
        else
            ""
        
    let ConvertAddressesToLatLongFormat (addresses : seq<string>) =
        addresses
        |> Seq.map (fun s -> GetAddressCoordinates s)
        
    let GetCompanyCoordinates =
        let addressesObject = File.ReadAllText "../../../App_Data/addresses.json"
        let data = JsonConvert.DeserializeObject<Dictionary<string, seq<string>>>(addressesObject)
        let coordinatesData = new Dictionary<string, seq<string>>()
        for companyName in data.Keys do
            coordinatesData.Add(companyName, ConvertAddressesToLatLongFormat data.[companyName])
        let coordinatesSerialized = JsonConvert.SerializeObject(coordinatesData)
        Console.WriteLine "completed"
        File.WriteAllText("coordinates.json", coordinatesSerialized)

