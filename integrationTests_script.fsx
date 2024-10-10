#r "nuget: Xunit"
#r "nuget: Fake.DotNet.Cli"


open Xunit
open Fake.Core


let runTool (tool: string) (args: string []) (dir:string) =
    CreateProcess.fromRawCommand tool args
    |> CreateProcess.withWorkingDirectory dir
    |> CreateProcess.redirectOutput
    |> Proc.run


//let result = runTool "dotnet" [|"fsi"; @"C:\Repos\nfdi4plants\arc-validation-packages\validation_packages\invenio\invenio@3.0.0.fsx"|] @"C:\Repos\nfdi4plants\arc-validation-packages\tests\fixtures\testARC_empty\"
let result = runTool "dotnet" [|"fsi"; @"C:\Repos\nfdi4plants\arc-validation-packages\validation_packages\invenio\invenio@3.0.0.fsx"|] @"C:\Repos\nfdi4plants\arc-validation-packages\tests\fixtures\testARC_emptyContactsColumn\"