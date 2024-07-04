namespace HCRD.Rope


type Rope =
    | Node of weigth: int
    | Lead of weight: int * content: string

[<AutoOpen>]
module Rope =
    ()
