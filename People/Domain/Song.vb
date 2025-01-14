﻿Public Class Song
    Public Property idSong As Integer
    Public Property sName As String
    Public Property album As Album
    Public Property length As Integer
    Public ReadOnly Property SongDAO As SongDAO

    Public Sub New()
        Me.SongDAO = New SongDAO
    End Sub

    Public Sub New(id As Integer)
        Me.SongDAO = New SongDAO
        Me.idSong = id
    End Sub

    Public Sub New(name As String)
        Me.SongDAO = New SongDAO
        Me.sName = name
    End Sub

    Public Sub ReadAllSongs(path As String)
        Me.SongDAO.ReadAll(path)
    End Sub

    Public Sub ReadAllSongsByAlbum(path As String, album As Album)
        Me.SongDAO.ReadAllByAlbum(album, path)
    End Sub

    Public Sub ReadSong()
        Me.SongDAO.Read(Me)
    End Sub

    Public Sub ReadSearcher(chain As String)
        Me.SongDAO.ReadSearcher(chain)
    End Sub

    Public Sub ReadSongsSort()
        Me.SongDAO.ReadSongsSort()
    End Sub

    Public Function InsertSong() As Integer
        Return Me.SongDAO.Insert(Me)
    End Function

    Public Function Delete() As Integer
        Return Me.SongDAO.Delete(Me)
    End Function

    Public Function UpdateSong() As Integer
        Return Me.SongDAO.update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.sName
    End Function
End Class
