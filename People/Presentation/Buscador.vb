﻿Public Class Buscador

    Private Sub BuscadorTextBox_TextChanged(sender As Object, e As EventArgs) Handles BuscadorTextBox.TextChanged
        Dim song As Song
        Dim artist As Artist
        Dim album As Album

        Dim s As Song = New Song
        Dim a As Artist = New Artist
        Dim al As Album = New Album
        ListSongs.Items.Clear()
        ListArtists.Items.Clear()
        ListAlbums.Items.Clear()
        If BuscadorTextBox.Text <> "" Then
            Try
                s.ReadSearcher(BuscadorTextBox.Text)
                a.ReadSearcher(BuscadorTextBox.Text)
                al.ReadSearcher(BuscadorTextBox.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            For Each song In s.SongDAO.songs
                ListSongs.Items.Add(song.sName)
            Next
            For Each artist In a.ArtistDAO.Artists
                ListArtists.Items.Add(artist.aName)
            Next
            For Each album In al.AlbumDAO.Albums
                ListAlbums.Items.Add(album.aName)
            Next
        End If

    End Sub


End Class