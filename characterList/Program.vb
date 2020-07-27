Imports System

Module Program

    '2. Write a Visual Basic function that will reverse the words in a string *without* using arrays.  For example, the string
    '"I am  a man" should be returned as "man a  am I".  Note the double spaces in "am  a".

    Sub Main(args As String())
        Dim container As New CharacterContainer
        container.AddCharacter(New CharacterObject("I"))
        container.AddCharacter(New CharacterObject(" "))
        container.AddCharacter(New CharacterObject("a"))
        container.AddCharacter(New CharacterObject("m"))
        container.AddCharacter(New CharacterObject(" "))
        container.AddCharacter(New CharacterObject(" "))
        container.AddCharacter(New CharacterObject("a"))
        container.AddCharacter(New CharacterObject(" "))
        container.AddCharacter(New CharacterObject("m"))
        container.AddCharacter(New CharacterObject("a"))
        container.AddCharacter(New CharacterObject("n"))
        container.printSentence()
    End Sub
End Module

