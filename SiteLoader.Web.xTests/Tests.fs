module Tests

open System
open Xunit

[<Fact>]
let ``My test`` () =
    Assert.True(true)

let ``My failed test`` () =
    Assert.True(false)