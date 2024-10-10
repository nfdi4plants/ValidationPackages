namespace ValidationPackages.Tests.ReferenceObjects

open System.IO
open ARCExpect


[<AutoOpen>]
module General =

    let expected_prototype_commit_hash = "2635598d9ea365c7ce545a9f279cca39af3de5df"


module invenio =

    module ArcPrototype =

        let validationResultCritical =
            ValidationResult.create(10,10,0,0)

        let validationResultNonCritical =
            ValidationResult.create(0,0,0,0)


    module testARC_empty =

        let validationResultCritical =
            ValidationResult.create(10,4,6,0)

        let validationResultNonCritical =
            ValidationResult.create(0,0,0,0)


    module testARC_emptyContactsColumn =

        let validationResultCritical =
            ValidationResult.create(10,6,4,0)

        let validationResultNonCritical =
            ValidationResult.create(0,0,0,0)


    module testARC_shiftedContactsCells =

        let validationResultCritical =
            ValidationResult.create(10,9,1,0)

        let validationResultNonCritical =
            ValidationResult.create(0,0,0,0)


    module testARC_shiftedTitleCell =

        let validationResultCritical =
            ValidationResult.create(10,10,0,0)

        let validationResultNonCritical =
            ValidationResult.create(0,0,0,0)


    module testARC_wrongEmail =

        let validationResultCritical =
            ValidationResult.create(10,9,1,0)

        let validationResultNonCritical =
            ValidationResult.create(0,0,0,0)