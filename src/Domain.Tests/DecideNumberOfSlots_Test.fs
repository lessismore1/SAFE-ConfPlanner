module DecideNumberOfSlotsTest

open NUnit.Framework

open Commands
open Events
open Testbase


[<Test>]
let ``Number of slots can be decided`` () =
  Given
    [
      NumberOfSlotsDecided 2
    ]
  |> When (DecideNumberOfSlots 5)
  |> ThenExpect [ NumberOfSlotsDecided 5 ]
