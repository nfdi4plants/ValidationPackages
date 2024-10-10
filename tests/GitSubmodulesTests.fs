module GitSubmoduleTests

open System
open System.IO
open Xunit
open ValidationPackages.Tests

[<Fact>]
let ``ArcPrototype commit hash is correct`` () = 
    Assert.Equal(
        ReferenceObjects.General.expected_prototype_commit_hash, 
        TestObjects.prototypeCommitHash
    )
