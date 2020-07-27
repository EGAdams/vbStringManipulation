Public Class CharacterContainer

    Private characterCount As Integer = 0
    Private lastPrintedValue As Char
    Public beginningCharacter As CharacterObject
    Public currentCharacterPointer As CharacterObject = beginningCharacter

    Public Sub AddCharacter(newCharacter As CharacterObject)
        newCharacter.previousCharacter = currentCharacterPointer
        currentCharacterPointer = newCharacter
        characterCount += 1
    End Sub

    Public Sub printContents()
        For count = 0 To characterCount
            If currentCharacterPointer IsNot Nothing Then
                Console.Write(currentCharacterPointer.value)
                lastPrintedValue = currentCharacterPointer.value
                currentCharacterPointer = currentCharacterPointer.previousCharacter
            End If
        Next
    End Sub

    Public Sub cleanup()
        currentCharacterPointer.previousCharacter = Nothing
    End Sub

    Public Sub printSentence()
        Dim innerContainer As New CharacterContainer
        For count = 0 To characterCount
            If currentCharacterPointer IsNot Nothing Then
                innerContainer.AddCharacter(New CharacterObject(currentCharacterPointer.value))
                If currentCharacterPointer.previousCharacter IsNot Nothing Then
                    If currentCharacterPointer.previousCharacter.value = " " Then
                        innerContainer.printContents()
                        If currentCharacterPointer.previousCharacter.value = " " And
                           currentCharacterPointer.previousCharacter.previousCharacter.value <> " " And
                           currentCharacterPointer.value <> " " And
                           innerContainer.lastPrintedValue <> " " Then
                            Console.Write(" ")
                        End If
                        innerContainer = New CharacterContainer
                    End If
                End If
                If currentCharacterPointer.previousCharacter IsNot Nothing Then
                    currentCharacterPointer = currentCharacterPointer.previousCharacter
                Else
                    innerContainer.cleanup()
                    innerContainer.printContents()
                    currentCharacterPointer = currentCharacterPointer.previousCharacter
                End If
            End If
        Next
    End Sub
End Class

