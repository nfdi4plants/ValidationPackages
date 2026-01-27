namespace ValidationPackages.Tests.ReferenceObjects

open ARCExpect


[<AutoOpen>]
module General =

    let expected_prototype_commit_hash = "7eeb05fd77292550568c0720d0631c3e64f46abf"


module invenio =

    module ``3_0_0`` =

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


    module ``3_0_1`` =

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
                ValidationResult.create(10,6,4,0)

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


    module ``3_0_2`` =

        module ArcPrototype =

            let validationResultCritical =
                ValidationResult.create(12,11,1,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_empty =

            let validationResultCritical =
                ValidationResult.create(12,5,7,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_emptyContactsColumn =

            let validationResultCritical =
                ValidationResult.create(12,7,5,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_shiftedContactsCells =

            let validationResultCritical =
                ValidationResult.create(12,7,5,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_shiftedTitleCell =

            let validationResultCritical =
                ValidationResult.create(12,11,1,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_wrongEmail =

            let validationResultCritical =
                ValidationResult.create(12,10,2,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_correctOrcid =

            let validationResultCritical =
                ValidationResult.create(12,12,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


    module ``3_1_0`` =

        module ArcPrototype =

            let validationResultCritical =
                ValidationResult.create(17,15,2,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_empty =

            let validationResultCritical =
                ValidationResult.create(17,10,7,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_emptyContactsColumn =

            let validationResultCritical =
                ValidationResult.create(17,11,6,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_shiftedContactsCells =

            let validationResultCritical =
                ValidationResult.create(17,11,6,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_shiftedTitleCell =

            let validationResultCritical =
                ValidationResult.create(17,15,2,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_wrongEmail =

            let validationResultCritical =
                ValidationResult.create(17,15,2,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_correctOrcid =

            let validationResultCritical =
                ValidationResult.create(17,17,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_licenseMissing =

            let validationResultCritical =
                ValidationResult.create(17,16,1,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


module pride =

    module ``1_0_3`` =

        module testARC_proteomicsCorrect =

            let validationResultCritical =
                ValidationResult.create(22,22,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


    module ``1_0_4`` =

        module testARC_proteomicsCorrect =

            let validationResultCritical =
                ValidationResult.create(23,23,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_proteomicsModifValueMissing =

            let validationResultCritical =
                ValidationResult.create(23,22,1,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


    module ``1_0_5`` =

        module testARC_proteomicsCorrect =

            let validationResultCritical =
                ValidationResult.create(23,23,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_proteomicsModifValueMissing =

            let validationResultCritical =
                ValidationResult.create(23,22,1,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


        module testARC_proteomicsAlternativeTerms =

            let validationResultCritical =
                ValidationResult.create(23,23,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)


module ena =

    module ``1_0_0`` =

        module testARC_enaComplete =

            let validationResultCritical =
                ValidationResult.create(13,13,0,0)

            let validationResultNonCritical =
                ValidationResult.create(0,0,0,0)