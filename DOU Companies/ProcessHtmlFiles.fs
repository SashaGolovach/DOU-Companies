namespace DOU_Companies

open System.Collections.Generic
open System.IO
open Newtonsoft.Json
open FSharp.Data

module ProcessHtmlFiles =
    let GetCompaniesLinks (companiesHtmlFile: string, linkFileName: string) =
        let companiesResult = HtmlDocument.Load companiesHtmlFile
        let links = 
            companiesResult.Descendants ["a"]
            |> Seq.filter (fun a -> 
                a.TryGetAttribute("class")
                |> Option.map (fun cls ->
                    cls.Value()) = Some "cn-a")
            |> Seq.choose (fun x -> 
                x.TryGetAttribute("href")
                |> Option.map (fun a -> a.Value())
            )
        File.WriteAllLines(linkFileName, links)
        
    let GetCompanieLocations (doc: HtmlDocument) =
        let linkElements = 
            doc.Descendants ["div"]
            |> Seq.filter (fun div -> 
                div.TryGetAttribute("class")
                |> Option.map (fun cls ->
                    cls.Value()) = Some "address")
            |> Seq.toArray
        let links = [|for div in linkElements -> div.InnerText()|] 
        links
        
    let GetAllCompaniesLocationInfo (links: seq<string>) =
        let addresses = new Dictionary<string, string[]>()
        for l in links do
            try
                let doc = HtmlDocument.Load (l + "offices/")
                let splittedUrl = l.Split '/'
                let name = splittedUrl.[splittedUrl.Length - 2]
                addresses.TryAdd(name, GetCompanieLocations (doc))
                printfn "%s" l
            with
            | _ -> ()
            
        let addressesSerialized = JsonConvert.SerializeObject(addresses)
        File.WriteAllText("addresses.json", addressesSerialized)