module invenio


open ValidationPackages.Tests
open TestUtils

open Xunit
open ARCExpect

open System.IO
open System


//let arcDir = Path.Combine(__SOURCE_DIRECTORY__, "fixtures", "ArcPrototype")

//let absoluteDirectoryPaths = FileSystem.parseARCFileSystem arcDir

//let investigationMetadata = 
//    absoluteDirectoryPaths
//    |> Investigation.parseMetadataSheetsFromTokens() arcDir 
//    |> List.concat 

//// Investigation has title
//let expectedTitleCvPExists =
//    investigationMetadata 
//    |> List.exists (
//        fun ip -> 
//            Param.getCvAccession ip = "INVMSO:00000009" && 
//            Param.getValueAsString ip |> String.IsNullOrWhiteSpace |> not && 
//            match Param.getParamValue ip with | CvValue x -> x.Accession = "AGMO:00000001" | _ -> false
//    )

//Assert.True expectedTitleCvPExists


type BaseTool_Fixture(scriptName : string, version : string, arcfolder : string) =

    let result = runTool "dotnet" [|"fsi"; $"../../validation_packages/{scriptName}/{scriptName}@{version}.fsx"|] $"fixtures/{arcfolder}"

    let arcExpectValidationResult = ARCExpect.ValidationSummary.fromJson (File.ReadAllText $"fixtures/{arcfolder}/.arc-validate-results/{scriptName}@{version}/validation_summary.json")

    interface IDisposable with
        override this.Dispose() =
            Directory.Delete($"fixtures/{arcfolder}/.arc-validate-results/{scriptName}@{version}/", true)

    member this.Result = result

    member this.ArcExpectValidationResult = arcExpectValidationResult


type ArcPrototype_Fixture() =

    inherit BaseTool_Fixture("invenio", "3.0.0", "ArcPrototype")


type ArcPrototype() =

    let tool_fixture = new ArcPrototype_Fixture()

    interface IClassFixture<ArcPrototype_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.invenio.ArcPrototype.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.invenio.ArcPrototype.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)


type testARC_empty_Fixture() =

    inherit BaseTool_Fixture("invenio", "3.0.0", "testARC_empty")


type testARC_empty() =

    let tool_fixture = new testARC_empty_Fixture()

    interface IClassFixture<testARC_empty_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.invenio.testARC_empty.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.invenio.testARC_empty.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)


type testARC_emptyContactsColumn_Fixture() =

    inherit BaseTool_Fixture("invenio", "3.0.0", "testARC_emptyContactsColumn")


type testARC_emptyContactsColumn() =

    let tool_fixture = new testARC_emptyContactsColumn_Fixture()

    interface IClassFixture<testARC_emptyContactsColumn_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.invenio.testARC_emptyContactsColumn.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.invenio.testARC_emptyContactsColumn.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)


type testARC_shiftedContactsCells_Fixture() =

    inherit BaseTool_Fixture("invenio", "3.0.0", "testARC_shiftedContactsCells")


type testARC_shiftedContactsCells() =

    let tool_fixture = new testARC_shiftedContactsCells_Fixture()

    interface IClassFixture<testARC_shiftedContactsCells_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.invenio.testARC_shiftedContactsCells.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.invenio.testARC_shiftedContactsCells.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)


type testARC_shiftedTitleCell_Fixture() =

    inherit BaseTool_Fixture("invenio", "3.0.0", "testARC_shiftedTitleCell")


type testARC_shiftedTitleCell() =

    let tool_fixture = new testARC_shiftedTitleCell_Fixture()

    interface IClassFixture<testARC_shiftedTitleCell_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.invenio.testARC_shiftedTitleCell.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.invenio.testARC_shiftedTitleCell.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)


type testARC_wrongEmail_Fixture() =

    inherit BaseTool_Fixture("invenio", "3.0.0", "testARC_wrongEmail")


type testARC_wrongEmail() =

    let tool_fixture = new testARC_wrongEmail_Fixture()

    interface IClassFixture<testARC_wrongEmail_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.invenio.testARC_wrongEmail.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.invenio.testARC_wrongEmail.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)