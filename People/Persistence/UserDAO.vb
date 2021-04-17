﻿Public Class UserDAO

    Public ReadOnly Property Users As Collection

    Public Sub New()
        Me.Users = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim u As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM USERS ORDER BY Email")
        For Each aux In col
            u = New User(aux(1).ToString)
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthdate = aux(4).ToString
            Me.Users.Add(u)
        Next
    End Sub


    Public Sub Read(ByRef u As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM USERS WHERE Email='" & u.Email & "';")
        For Each aux In col
            u.uName = aux(2).ToString
            u.uSurname = aux(3).ToString
            u.birthdate = aux(4).ToString
        Next
    End Sub

    Public Function Delete(ByVal u As User) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM USERS WHERE Email='" & u.Email & "';")
    End Function
End Class