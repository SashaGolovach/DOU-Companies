namespace DOU_Companies

open System.Collections.Generic
open System.IO
open Newtonsoft.Json
open FSharp.Data
open System.Linq

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

    let GetHtmlReviewsNodes (document : HtmlDocument) = 
        document.Descendants ["div"]
        |> Seq.filter (fun div -> 
            div.TryGetAttribute("class").IsSome && div.TryGetAttribute("class").Value.Value() = "l-text b-typo")

    let GetReviewsFromFile (fileName:string) = 
        let document = HtmlDocument.Load fileName
        let reviewsNodes = GetHtmlReviewsNodes document
        let reviews = seq { for r in reviewsNodes -> HtmlNodeExtensions.InnerText(r)}
        reviews 

    let ProcessReviewsFiles = 
        let companyReviews = new Dictionary<string, string[]>()
        let dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "../../../../App_Data/Reviews")
        let files = dirInfo.GetFiles ()
        for f in files do
            try
                let reviews = GetReviewsFromFile (f.FullName)
                let result = companyReviews.TryAdd(f.Name, Seq.toArray reviews)
                printfn "%s" f.Name
            with
            | _ -> ()
        let reviewsSerialized = JsonConvert.SerializeObject(companyReviews)
        File.WriteAllText("../../../App_Data/CompanyReviews/reviews.json", reviewsSerialized)

    let GetCompanyScore (fileName:string) = 
        let document = HtmlDocument.Load fileName
        let scoreNodes = document.Descendants ["h3"] |> 
            Seq.filter (fun h3 -> 
                h3.TryGetAttribute("class").IsSome && h3.TryGetAttribute("class").Value.Value() = "g-h3")
        let scoreList = Seq.toList scoreNodes
        if scoreList.Length > 0 then 
            HtmlNodeExtensions.InnerText(scoreList.FirstOrDefault())
        else 
            ""