module ena_1_0_0


open ValidationPackages.Tests
open TestUtils

open Xunit
open ARCExpect

open System.IO
open System


type BaseTool_Fixture(scriptName : string, version : string, arcfolder : string) =

    let result = runTool "dotnet" [|"fsi"; $"../../validation_packages/{scriptName}/{scriptName}@{version}.fsx"|] $"fixtures/{arcfolder}"

    let arcExpectValidationResult = ARCExpect.ValidationSummary.fromJson (File.ReadAllText $"fixtures/{arcfolder}/.arc-validate-results/{scriptName}@{version}/validation_summary.json")

    let jUnitResult = JUnitResults.fromJUnitFile $"fixtures/{arcfolder}/.arc-validate-results/{scriptName}@{version}/validation_report.xml"

    let jUnitExpected = JUnitResults.fromJUnitFile $"fixtures/validationReport/{scriptName}/{version}/{arcfolder}/validation_report.xml"

    interface IDisposable with
        override this.Dispose() =
            Directory.Delete($"fixtures/{arcfolder}/.arc-validate-results/{scriptName}@{version}/", true)

    member this.Result = result

    member this.ArcExpectValidationResult = arcExpectValidationResult

    member this.JUnitResult = jUnitResult

    member this.JUnitExpected = jUnitExpected


type testARC_enaComplete_Fixture() =

    inherit BaseTool_Fixture("ena", "1.0.0", "testARC_enaComplete")


type testARC_enaComplete() =

    let tool_fixture = new testARC_enaComplete_Fixture()

    interface IClassFixture<testARC_enaComplete_Fixture>

    member this.Fixture with get() = tool_fixture

    [<Fact>]
    member this.``result Exitcode is 0`` () =
        Assert.Equal(0, this.Fixture.Result.ExitCode)

    [<Fact>]
    member this.``validation_summary JSON is equal`` () =
        Assert.Equal(ReferenceObjects.ena.``1_0_0``.testARC_enaComplete.validationResultCritical, this.Fixture.ArcExpectValidationResult.Critical)
        Assert.Equal(ReferenceObjects.ena.``1_0_0``.testARC_enaComplete.validationResultNonCritical, this.Fixture.ArcExpectValidationResult.NonCritical)

    [<Fact>]
    member this.``validation_report XML is equal`` () =
        Assert.Equal(this.Fixture.JUnitExpected, this.Fixture.JUnitResult)