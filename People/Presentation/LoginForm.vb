﻿Public Class loginForm
    Property ofdPath1 As OpenFileDialog = New OpenFileDialog
    Dim filePath As String
    Dim user As User
    Dim s As Song
    Dim a As Artist
    Dim al As Album

    Private Sub ChooseDB_Click(sender As Object, e As EventArgs) Handles ChooseDB.Click
        ofdPath1.Filter = "Microsoft Access Database (.accdb)|*.accdb"
        Try
            If ofdPath1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                filePath = ofdPath1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        loginBtt.Enabled = True
        ComboBox.Enabled = True
    End Sub

    Private Sub loginBtt_Click(sender As Object, e As EventArgs) Handles loginBtt.Click
        Dim u As User = New User
        Dim usr As User = New User
        Dim check As Boolean
        Try
            u.ReadAllUsers(filePath)
            For Each user In u.UserDAO.Users
                If user.Email = TextBoxEmail.Text Then
                    check = True
                    usr = New User(TextBoxEmail.Text)
                End If
            Next
            usr.ReadUser()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If check = True Then
            Me.Hide()
            Dim b As SearcherForm = New SearcherForm(usr, filePath)
            b.Show()
        Else
            MessageBox.Show("Login incorrect")
        End If
    End Sub
    Private Sub readallSongs()
        Dim song As Song
        s = New Song
        Try
            Me.s.ReadAllSongs(filePath)
            For Each song In Me.s.SongDAO.songs
                ListBox.Items.Add(song)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub readallArtist()
        Dim artist As Artist
        a = New Artist
        Try
            Me.a.ReadAllArtists(filePath)
            For Each artist In Me.a.ArtistDAO.Artists
                ListBox.Items.Add(artist)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub readallArtistCombo()
        Dim artist As Artist
        a = New Artist
        Try
            Me.a.ReadAllArtists(filePath)
            For Each artist In Me.a.ArtistDAO.Artists
                ArtistBox.Items.Add(artist)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub readallAlbums()
        Dim album As Album
        al = New Album
        Try
            Me.al.ReadAllAlbums(filePath)
            For Each album In Me.al.AlbumDAO.Albums
                ListBox.Items.Add(album)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub readallAlbumsCombo()
        Dim album As Album
        al = New Album
        Try
            Me.al.ReadAllAlbums(filePath)
            For Each album In Me.al.AlbumDAO.Albums
                albumBox.Items.Add(album)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub readallUsers()
        Dim u As User
        user = New User
        Try
            Me.user.ReadAllUsers(filePath)
            For Each u In Me.user.UserDAO.Users
                ListBox.Items.Add(u)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub readSong()
        Dim song As Song
        Try
            song = CType(ListBox.SelectedItem, Song)
            song.ReadSong()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        nameBox.Text = song.sName
        song.album.ReadAlbum()
        albumBox.Text = song.album.aName
        lengthBox.Text = CType(song.length, String)
    End Sub

    Public Sub readAlbum()
        Dim album As Album
        Try
            album = CType(ListBox.SelectedItem, Album)
            album.ReadAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        albumBox.Text = album.aName
        relaseDateBox.Text = album.releaseDate
        album.artist.ReadArtist()
        coverBox.Text = album.cover
        artistBox.Text = album.artist.aName
    End Sub

    Public Sub readArtist()
        Dim artist As Artist
        Try
            artist = CType(ListBox.SelectedItem, Artist)
            artist.ReadArtist()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        artistBox.Text = artist.aName
        countryBox.Text = artist.country
        imageBox.Text = artist.image
    End Sub

    Public Sub readuser()
        Dim user As User
        Try
            user = CType(ListBox.SelectedItem, User)
            user.ReadUser()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        emailBox.Text = user.Email
        nameBox.Text = user.uName
        surnameBox.Text = user.uSurname
        birthDateBox.Text = user.birthdate
    End Sub

    Public Sub deleteUser()
        Dim user As User
        Try
            user = CType(ListBox.SelectedItem, User)
            user.DeleteUser()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()
    End Sub

    Public Sub deleteArtist(aName As String)
        Dim artist As Artist
        Try
            artist = CType(ListBox.SelectedItem, Artist)
            artist.DeleteArtist()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()
    End Sub

    Public Sub deleteAlbum(aName As String)
        Dim album As Album
        Try
            album = CType(ListBox.SelectedItem, Album)
            album.DeleteAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()
    End Sub
    Private Sub deleteSong(sName As String)
        Dim song As Song
        Try
            song = CType(ListBox.SelectedItem, Song)
            song.Delete()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        clearBoxes()
    End Sub

    Private Sub insertUser()
        Me.user = New User(emailBox.Text)
        user.uName = nameBox.Text
        user.uSurname = surnameBox.Text
        user.birthdate = birthDateBox.Text
        Try
            user.insertUser()
            ListBox.Items.Add(user)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub insertArtist()
        Me.a = New Artist()
        a.aName = ArtistBox.Text
        a.country = countryBox.Text
        a.image = imageBox.Text
        Try
            a.InsertArtist()
            ListBox.Items.Add(a)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub insertAlbum()
        Me.al = New Album()
        al.aName = albumBox.Text
        al.releaseDate = relaseDateBox.Text
        al.artist = CType(ArtistBox.SelectedItem, Artist)
        Try
            al.InsertAlbum()
            ListBox.Items.Add(al)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub insertSong()
        Me.s = New Song()
        s.sName = nameBox.Text
        s.album = CType(albumBox.SelectedItem, Album)
        Try
            s.length = CType(lengthBox.Text, Integer)
            s.InsertSong()
            ListBox.Items.Add(s)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub updateSong(sName As String)
        Me.s = New Song()
        Dim song = CType(ListBox.SelectedItem, Song)
        s.sName = nameBox.Text
        s.idSong = song.idSong
        Try
            s.length = CType(lengthBox.Text, Integer)
            s.UpdateSong()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        clearBoxes()
        ListBox.Items.Clear()
        readallSongs()
    End Sub

    Private Sub updateAlbum(aName As String)
        Me.al = New Album()
        Dim album As Album
        album = CType(ListBox.SelectedItem, Album)
        al.aName = albumBox.Text
        al.releaseDate = relaseDateBox.Text
        al.cover = coverBox.Text
        al.idAlbum = album.idAlbum
        Try
            al.updateAlbum()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        clearBoxes()
        ListBox.Items.Clear()
        readallAlbums()
    End Sub

    Private Sub updateUser(email As String)
        Me.user = New User(email)
        user.uName = nameBox.Text
        user.uSurname = surnameBox.Text
        user.birthdate = birthDateBox.Text
        Try
            user.updateUser()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        clearBoxes()
        ListBox.Items.Clear()
        readallUsers()
    End Sub

    Private Sub updateArtist(aName As String)
        Me.a = New Artist()
        Dim artist As Artist
        artist = CType(ListBox.SelectedItem, Artist)
        a.aName = artistBox.Text
        a.country = countryBox.Text
        a.image = imageBox.Text
        a.idArtist = artist.idArtist
        Try
            a.updateArtist()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        clearBoxes()
        ListBox.Items.Clear()
        readallArtist()
    End Sub

    Private Sub updateBtt_Click(sender As Object, e As EventArgs) Handles updateBtt.Click
        If ListBox.SelectedIndex >= 0 Then
            Select Case ComboBox.SelectedIndex
                Case 0
                    updateSong(ListBox.SelectedItem.ToString)
                    clearBoxes()
                Case 1
                    updateAlbum(ListBox.SelectedItem.ToString)
                    clearBoxes()
                Case 2
                    updateArtist(ListBox.SelectedItem.ToString)
                    clearBoxes()
                Case 3
                    updateUser(emailBox.Text)
                    clearBoxes()
            End Select
        End If
    End Sub

    Private Sub deleteBtt_Click(sender As Object, e As EventArgs) Handles deleteBtt.Click
        If ListBox.SelectedIndex >= 0 Then
            Select Case ComboBox.SelectedIndex
                Case 0
                    deleteSong(ListBox.SelectedItem.ToString)
                    ListBox.Items.RemoveAt(ListBox.SelectedIndex)
                Case 1
                    deleteAlbum(ListBox.SelectedItem.ToString)
                    ListBox.Items.RemoveAt(ListBox.SelectedIndex)
                Case 2
                    deleteArtist(ListBox.SelectedItem.ToString)
                    ListBox.Items.RemoveAt(ListBox.SelectedIndex)
                Case 3
                    deleteUser()
                    ListBox.Items.RemoveAt(ListBox.SelectedIndex)
            End Select
        End If
    End Sub
    Private Sub insertBtt_Click(sender As Object, e As EventArgs) Handles insertBtt.Click
        Select Case ComboBox.SelectedIndex
            Case 0
                If albumBox.SelectedIndex >= 0 Then
                    insertSong()
                    clearBoxes()
                    initSongBox()
                    readallAlbumsCombo()
                Else
                    MessageBox.Show("Please select an Album")
                    initSongBox()
                    readallAlbumsCombo()
                End If
            Case 1
                If ArtistBox.SelectedIndex >= 0 Then
                    insertAlbum()
                    clearBoxes()
                    initAlbumBox()
                    readallArtistCombo()
                Else
                    MessageBox.Show("Please select an artist")
                    initAlbumBox()
                    readallArtistCombo()
                End If
            Case 2
                insertArtist()
                clearBoxes()
            Case 3
                insertUser()
                clearBoxes()
        End Select
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        If ListBox.SelectedItem IsNot Nothing Then
            clearBoxes()
            insertBtt.Enabled = False
            deleteBtt.Enabled = True
            updateBtt.Enabled = True
            Select Case ComboBox.SelectedIndex
                Case 0
                    readSong()
                    albumBox.Enabled = False
                Case 1
                    readAlbum()
                    ArtistBox.Enabled = False
                Case 2
                    readArtist()
                Case 3
                    readuser()
                    emailBox.Enabled = False
            End Select
        End If
    End Sub
    Private Sub ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedValueChanged
        resetLabels()
        ListBox.Items.Clear()
        clearBoxes()
        Select Case ComboBox.SelectedIndex
            Case 0
                initSongBox()
                readallSongs()
                readallAlbumsCombo()
            Case 1
                initAlbumBox()
                readallAlbums()
                readallArtistCombo()
            Case 2
                initArtistBox()
                readallArtist()
            Case 3
                initUserBox()
                readallUsers()
        End Select
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginBtt.Enabled = False
        ComboBox.Items.Add("Song")
        ComboBox.Items.Add("Album")
        ComboBox.Items.Add("Artist")
        ComboBox.Items.Add("User")
        resetLabels()
        updateBtt.Enabled = False
        deleteBtt.Enabled = False
        ComboBox.Enabled = False
    End Sub

    Public Sub clearBoxes()
        nameBox.Clear()
        relaseDateBox.Clear()
        ArtistBox.ResetText()
        ArtistBox.Items.Clear()
        albumBox.ResetText()
        albumBox.Items.Clear()
        nameBox.Clear()
        countryBox.Clear()
        coverBox.Clear()
        emailBox.Clear()
        birthDateBox.Clear()
        surnameBox.Clear()
        lengthBox.Clear()
        imageBox.Clear()
        albumBox.DropDownStyle = ComboBoxStyle.DropDown
        ArtistBox.DropDownStyle = ComboBoxStyle.DropDown

    End Sub
    Private Sub initSongBox()
        nameBox.Enabled = True
        nameLabel.Enabled = True
        albumBox.Enabled = True
        albumLabel.Enabled = True
        lengthBox.Enabled = True
        lengthLabel.Enabled = True
        albumBox.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub initAlbumBox()
        albumBox.Enabled = True
        albumLabel.Enabled = True
        relaseDateBox.Enabled = True
        relaseLabel.Enabled = True
        ArtistBox.Enabled = True
        artistLabel.Enabled = True
        coverBox.Enabled = True
        coverLabel.Enabled = True
        ArtistBox.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub initArtistBox()
        ArtistBox.Enabled = True
        artistLabel.Enabled = True
        countryBox.Enabled = True
        countryLabel.Enabled = True
        imageBox.Enabled = True
        imageLabel.Enabled = True
    End Sub
    Private Sub initUserBox()
        emailBox.Enabled = True
        EmailLabel.Enabled = True
        nameBox.Enabled = True
        nameLabel.Enabled = True
        surnameBox.Enabled = True
        surnameLabel.Enabled = True
        birthDateBox.Enabled = True
        birthdateLabel.Enabled = True
    End Sub
    Private Sub resetLabels()
        nameBox.Enabled = False
        nameLabel.Enabled = False
        birthDateBox.Enabled = False
        birthdateLabel.Enabled = False
        relaseDateBox.Enabled = False
        relaseLabel.Enabled = False
        artistBox.Enabled = False
        artistLabel.Enabled = False
        albumBox.Enabled = False
        albumLabel.Enabled = False
        coverBox.Enabled = False
        coverLabel.Enabled = False
        countryBox.Enabled = False
        countryLabel.Enabled = False
        emailBox.Enabled = False
        EmailLabel.Enabled = False
        surnameBox.Enabled = False
        surnameLabel.Enabled = False
        lengthBox.Enabled = False
        lengthLabel.Enabled = False
        imageBox.Enabled = False
        imageLabel.Enabled = False
    End Sub

    Private Sub ClearBtt_Click(sender As Object, e As EventArgs) Handles ClearBtt.Click
        clearBoxes()
        insertBtt.Enabled = True
        updateBtt.Enabled = False
        deleteBtt.Enabled = False
        Select Case ComboBox.SelectedIndex
            Case 0
                initSongBox()
                readallAlbumsCombo()
            Case 1
                initAlbumBox()
                readallArtistCombo()
            Case 2
                initArtistBox()
            Case 3
                initUserBox()
        End Select

    End Sub

End Class