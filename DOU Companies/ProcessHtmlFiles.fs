namespace DOU_Companies

open System.IO
open FSharp.Data

module ProcessHtmlFiles =
    let GetCompaniesLinks () =
        let companiesResult = HtmlDocument.Load "../../../App_Data/companies.html"
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
        File.WriteAllLines("App_Data/links.txt", links)
        
    let GetAllCompaniesLocations =
        let companiesResult = HtmlDocument.Load "../../../App_Data/a.html"
        let linkElements = 
            companiesResult.Descendants ["div"]
            |> Seq.filter (fun div -> 
                div.TryGetAttribute("class")
                |> Option.map (fun cls ->
                    cls.Value()) = Some "address")
            |> Seq.toArray
        let links = [|for div in linkElements -> div.InnerText()|] 
        File.WriteAllLines("App_Data/adresses.txt", links)
        

