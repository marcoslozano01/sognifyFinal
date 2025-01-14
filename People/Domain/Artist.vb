﻿Public Class Artist
    Public Property idArtist As Integer
    Public Property aName As String
    Public Property country As String
    Public Property image As String
    Public ReadOnly Property ArtistDAO As ArtistDAO
    Public Property user As User
    Public Property artist As Artist
    Public Property favDate As String

    Public Sub New()
        Me.ArtistDAO = New ArtistDAO
    End Sub

    Public Sub New(id As Integer)
        Me.ArtistDAO = New ArtistDAO
        Me.idArtist = id
    End Sub

    Public Sub New(user As User, artist As Artist)
        Me.ArtistDAO = New ArtistDAO
        Me.artist = artist
        Me.user = user
    End Sub

    Public Sub ReadAllArtists(path As String)
        Me.ArtistDAO.ReadAllArtist(path)
    End Sub

    Public Sub ReadArtist()
        Me.ArtistDAO.ReadArtist(Me)
    End Sub

    Public Sub ReadArtistsSort()
        Me.ArtistDAO.ReadArtistsSort()
    End Sub

    Public Sub ReadArtistsDate(iniDate As Date, endDate As Date)
        Me.ArtistDAO.ReadArtistsDate(Me, iniDate, endDate)
    End Sub

    Public Sub ReadAllFavArtists(path As String)
        Me.ArtistDAO.ReadAllFavArtist(path)
    End Sub

    Public Function ReadFavArtist() As Integer
        Return Me.ArtistDAO.ReadFavArtist(Me)
    End Function

    Public Sub ReadSearcher(chain As String)
        Me.ArtistDAO.ReadSearcher(chain)
    End Sub

    Public Function InsertArtist() As Integer
        Return Me.ArtistDAO.Insert(Me)
    End Function

    Public Function InsertArtistFav() As Integer
        Return Me.ArtistDAO.InsertFav(Me)
    End Function

    Public Function DeleteArtist() As Integer
        Return Me.ArtistDAO.Delete(Me)
    End Function

    Public Function DeleteArtistFav() As Integer
        Return Me.ArtistDAO.DeleteFav(Me)
    End Function
    Public Function updateArtist() As Integer
        Return Me.ArtistDAO.update(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.aName
    End Function

End Class
