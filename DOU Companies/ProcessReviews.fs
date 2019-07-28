namespace DOU_Companies

open FSharp.Data
open System 
open ReviewsTranslator.Implementations
open ReviewsTranslator.Interfaces

module ProcessReviews =
    let translator = new GoogleTranslator()

    let TranslateText (text: string) = 
        let resultTask = translator.Translate text
        resultTask.Wait()
        resultTask.Result
