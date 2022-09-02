Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Parameter

    '### INI Speicherung
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (
ByVal lpApplicationName As String,
ByVal lpKeyName As String,
ByVal lpString As String,
ByVal lpFileName As String) _
As Integer

    Public sAppPath As String = Application.StartupPath
    Public cbGER As String
    Public cbENG As String
    Public SpracheZwischenspeicher As String
    Public MsgStart As String

    Public Pfad As String = Application.StartupPath & "\Scanner\GovCrypto_4_Windows\GovCrypto_4_Windows.bat"
    Public T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65, T66, T67, T68, T69, T70, T71, T72, T73, T74, T75, T76, T77, T78, T79, T80, T81, T82, T83, T84, T85, T86, T87, T88, T89, T90, T91, T92, T93, T94, T95, T96, T97, T98, T99, T100, T101, T102, T103, T104, T105, T106, T107, T108, T109, T110, T111, T112, T113, T114, T115, T116, T117, T118, T119, T120, T121, T122, T123, T124, T125, T126, T127, T128, T129, T130, T131, T132, T133, T134, T135, T136, T137, T138, T139, T140, T141, T142, T143, T144, T145, T146, T147, T148, T149, T150, T151, T152, T153, T154, T155, T156, T157, T158, T159, T160, T161, T162, T163, T164, T165, T166, T167, T168, T169, T170, T171, T172, T173, T174, T175, T176, T177, T178, T179, T180, T181, T182, T183, T184, T185, T186, T187, T188, T189, T190, T191, T192, T193, T194, T195, T196, T197, T198, T199, T200, T201, T202, T203, T204, T205, T206, T207, T208, T209, T210, T211, T212, T213, T214, T215, T216, T217, T218, T219, T220, T221, T222, T223, T224, T225, T226, T227, T228, T229, T230, T231, T232, T233, T234, T235, T236, T237, T238, T239, T240, T241, T242, T243, T244, T245, T246, T247, T248, T249, T250, T251, T252, T253, T254, T255, T256, T257, T258, T259, T260, T261, T262, T263, T264, T265, T266, T267, T268, T269, T270, T271, T272, T273, T274, T275, T276, T277, T278, T279, T280, T281, T282, T283, T284, T285, T286, T287, T288, T289, T290, T291, T292, T293, T294, T295, T296, T297, T298, T299, T300, T301 As String


    Private Sub rbGER_CheckedChanged(sender As Object, e As EventArgs) Handles rbGER.CheckedChanged

        If rbGER.Checked = True Then

            rbEng.Checked = False
            cbENG = "No"
            cbGER = "Yes"

            Me.BringToFront()

        End If

    End Sub

    Private Sub rbEng_CheckedChanged(sender As Object, e As EventArgs) Handles rbEng.CheckedChanged

        If rbEng.Checked = True Then

            rbGER.Checked = False
            cbENG = "Yes"
            cbGER = "No"

            Me.BringToFront()

        End If

    End Sub

    Private Sub Parameter_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Wert einem String zuordnen
        Dim sb As StringBuilder
        sb = New StringBuilder(1024)

        INI.Lesen("GovCrypto", "Profil1", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD1.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil2", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD2.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil3", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD3.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil4", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD4.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil5", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD5.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil6", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD6.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil7", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD7.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil8", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD8.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil9", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD9.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil10", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD10.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil11", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD11.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil12", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD12.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil13", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD13.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil14", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD14.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil15", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbD15.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil16", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO1.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil17", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO2.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil18", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO3.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil19", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO4.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil20", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO5.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil21", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO6.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil22", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO7.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil23", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO8.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil24", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO9.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil25", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO10.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil26", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO11.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil27", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO12.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil28", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO13.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil29", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO14.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil30", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbO15.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil31", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH1.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil32", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH2.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil33", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH3.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil34", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH4.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil35", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH5.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil36", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH6.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil37", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH7.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil38", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH8.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil39", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH9.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil40", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH10.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil41", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH11.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil42", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH12.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil43", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH13.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil44", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH14.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil45", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbH15.Text = sb.ToString
        INI.Lesen("GovCrypto", "Profil46", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        tbDrives.Text = sb.ToString

        INI.Lesen("GovCrypto", "Profil47", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        cbGER = sb.ToString
        INI.Lesen("GovCrypto", "Profil48", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        cbENG = sb.ToString


        If cbGER = "Yes" Then
            btnSave.Text = "speichern"
            btnDefault.Text = "zurücksetzen"
            btnClear.Text = "löschen"
            btnCancel.Text = "abbrechen"
            Me.Text = "Einstellungen"
            GroupBox2.Text = "Sprache"
            GroupBox3.Text = "Laufwerke (LW)"
            Label4.Text = "(LW trennen mit Leerzeichen, nicht Komma!)"
            rbGER.Checked = True
            rbEng.Checked = False
        End If

        If cbGER = "No" Then
            rbGER.Checked = False
            rbEng.Checked = True
        End If

        If cbGER = "" Then
            rbGER.Checked = False
            rbEng.Checked = True
        End If

        '### Beim erstmailgen Aufruf = Default
        If tbD1.Text = "" Then
            Call DefaultX()
        End If

        '###Neustart erfoderlich?
        SpracheZwischenspeicher = cbGER

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If cbGER = "Yes" Then MsgBox("Der Dateiinhalt aller Dateien im Ordnern Mozilla, Microsoft, Opera und Google im AppData-Ordner ""Local"" und ""Roaming"" werden nach den Begriffen gescannt.")
        If cbENG = "Yes" Then MsgBox("The file contents of all files in the Mozilla, Microsoft, Opera and Google folders in the AppData folder ""Local"" and ""Roaming"" are scanned for the parameters.")

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If cbGER = "Yes" Then MsgBox("Es wird das gesamte Dateisystem nach Dateinamen gescannt, die folgende Begriffe enthalten. * kann als Platzhalter verwendet werden.")
        If cbENG = "Yes" Then MsgBox("The entire file system is scanned for file names that contain the following parameters. * can be used as a placeholder.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDefault.Click

        Call DefaultX()

    End Sub

    Public Sub DefaultX()

        '### Default

        tbD1.Text = "*bitcoin*.exe"
        tbD2.Text = "wallet.dat"
        tbD3.Text = "*.wallet"
        tbD4.Text = "*electrum*.exe"
        tbD5.Text = "*atomic*.exe"
        tbD6.Text = "*UTC--*"
        tbD7.Text = "*exodus*.exe"
        tbD8.Text = "*ledger*.*"
        tbD9.Text = "*Seed*.*"
        tbD10.Text = "*Ethereum*.*"
        tbD11.Text = "*Krypto*.*"
        tbD12.Text = "*Crypto*.*"
        tbD13.Text = "*MetaMask*.*"
        tbD14.Text = "*Trezor*.*"
        tbD15.Text = "*Keepkey*.*"

        tbO1.Text = "coinbase.com"
        tbO2.Text = "binance.com"
        tbO3.Text = "kraken.com"
        tbO4.Text = "bitpanda.com"
        tbO5.Text = "ftx.com"
        tbO6.Text = "kucoin.com"
        tbO7.Text = "bitfinex.com"
        tbO8.Text = "bybit.com"
        tbO9.Text = "gemini.com"
        tbO10.Text = "crypto.com"
        tbO11.Text = "gate.io"
        tbO12.Text = "phemex.com"
        tbO13.Text = "myetherwallet.com"
        tbO14.Text = "bitcoin.de"
        tbO15.Text = "blockchain.com"

        tbH1.Text = "ledger.com"
        tbH2.Text = "trezor.io"
        tbH3.Text = "shapeshift.com"
        tbH4.Text = "Keepkey"
        tbH5.Text = "MetaMask"
        tbH6.Text = "Ellipal"
        tbH7.Text = "Trezor"
        tbH8.Text = "Bitbox"
        tbH9.Text = "SecuX"
        tbH10.Text = ""
        tbH11.Text = ""
        tbH12.Text = ""
        tbH13.Text = ""
        tbH14.Text = ""
        tbH15.Text = ""

        tbDrives.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Call BatchFile()

        Dim ScannerINI1 = tbD1.Text
        Dim ScannerINI2 = tbD2.Text
        Dim ScannerINI3 = tbD3.Text
        Dim ScannerINI4 = tbD4.Text
        Dim ScannerINI5 = tbD5.Text
        Dim ScannerINI6 = tbD6.Text
        Dim ScannerINI7 = tbD7.Text
        Dim ScannerINI8 = tbD8.Text
        Dim ScannerINI9 = tbD9.Text
        Dim ScannerINI10 = tbD10.Text
        Dim ScannerINI11 = tbD11.Text
        Dim ScannerINI12 = tbD12.Text
        Dim ScannerINI13 = tbD13.Text
        Dim ScannerINI14 = tbD14.Text
        Dim ScannerINI15 = tbD15.Text
        Dim ScannerINI16 = tbO1.Text
        Dim ScannerINI17 = tbO2.Text
        Dim ScannerINI18 = tbO3.Text
        Dim ScannerINI19 = tbO4.Text
        Dim ScannerINI20 = tbO5.Text
        Dim ScannerINI21 = tbO6.Text
        Dim ScannerINI22 = tbO7.Text
        Dim ScannerINI23 = tbO8.Text
        Dim ScannerINI24 = tbO9.Text
        Dim ScannerINI25 = tbO10.Text
        Dim ScannerINI26 = tbO11.Text
        Dim ScannerINI27 = tbO12.Text
        Dim ScannerINI28 = tbO13.Text
        Dim ScannerINI29 = tbO14.Text
        Dim ScannerINI30 = tbO15.Text
        Dim ScannerINI31 = tbH1.Text
        Dim ScannerINI32 = tbH2.Text
        Dim ScannerINI33 = tbH3.Text
        Dim ScannerINI34 = tbH4.Text
        Dim ScannerINI35 = tbH5.Text
        Dim ScannerINI36 = tbH6.Text
        Dim ScannerINI37 = tbH7.Text
        Dim ScannerINI38 = tbH8.Text
        Dim ScannerINI39 = tbH9.Text
        Dim ScannerINI40 = tbH10.Text
        Dim ScannerINI41 = tbH11.Text
        Dim ScannerINI42 = tbH12.Text
        Dim ScannerINI43 = tbH13.Text
        Dim ScannerINI44 = tbH14.Text
        Dim ScannerINI45 = tbH15.Text
        Dim ScannerINI46 = tbDrives.Text

        Dim ENG = cbENG
        Dim GER = cbGER


        WritePrivateProfileString("GovCrypto", "Profil1", ScannerINI1, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil2", ScannerINI2, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil3", ScannerINI3, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil4", ScannerINI4, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil5", ScannerINI5, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil6", ScannerINI6, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil7", ScannerINI7, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil8", ScannerINI8, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil9", ScannerINI9, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil10", ScannerINI10, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil11", ScannerINI11, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil12", ScannerINI12, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil13", ScannerINI13, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil14", ScannerINI14, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil15", ScannerINI15, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil16", ScannerINI16, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil17", ScannerINI17, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil18", ScannerINI18, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil19", ScannerINI19, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil20", ScannerINI20, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil21", ScannerINI21, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil22", ScannerINI22, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil23", ScannerINI23, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil24", ScannerINI24, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil25", ScannerINI25, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil26", ScannerINI26, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil27", ScannerINI27, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil28", ScannerINI28, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil29", ScannerINI29, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil30", ScannerINI30, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil31", ScannerINI31, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil32", ScannerINI32, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil33", ScannerINI33, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil34", ScannerINI34, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil35", ScannerINI35, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil36", ScannerINI36, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil37", ScannerINI37, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil38", ScannerINI38, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil39", ScannerINI39, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil40", ScannerINI40, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil41", ScannerINI41, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil42", ScannerINI42, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil43", ScannerINI43, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil44", ScannerINI44, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil45", ScannerINI45, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil46", ScannerINI46, sAppPath & "\Scanner\INI\SettingsGCY.ini")

        WritePrivateProfileString("GovCrypto", "Profil47", GER, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        WritePrivateProfileString("GovCrypto", "Profil48", ENG, sAppPath & "\Scanner\INI\SettingsGCY.ini")


        '### Hinweis auf Neustart
        If SpracheZwischenspeicher <> cbGER Then

            If cbGER = "No" Then MsgStart = "The language has been changed. GovCrypto needs to be restarted. Restart now?"
            If cbGER = "Yes" Then MsgStart = "Die Sprache wurde geändert. GovCrypto muss neu gestartet werden. Jetzt neu starten?"

            Select Case MessageBox.Show(MsgStart, "GovCrypto", MessageBoxButtons.YesNo)
                Case DialogResult.Yes

                    GovCrypto.Close()
                    GovCrypto.Show()
                    Me.Close()
                    Exit Sub

                Case Else

                    Me.Close()
                    Exit Sub

            End Select

        End If


        If cbGER = "Yes" Then MsgBox("Die Änderungen wurden gespeichert.")
        If cbGER = "No" Then MsgBox("The changes have been saved.")

        Me.Close()

    End Sub


    Public Sub BatchFile()


        If tbO1.TextLength > 0 Then
            T2 = "echo ### " & tbO1.Text & " ###"
            T3 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T4 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T5 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T6 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T7 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T8 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T9 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T10 = "findstr /s /i /m /o /offline " & """" & tbO1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO2.TextLength > 0 Then
            T11 = "echo ### " & tbO2.Text & " ###"
            T12 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T13 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T14 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T15 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T16 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T17 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T18 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T19 = "findstr /s /i /m /o /offline " & """" & tbO2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO3.TextLength > 0 Then
            T20 = "echo ### " & tbO3.Text & " ###"
            T21 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T22 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T23 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T24 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T25 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T26 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T27 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T28 = "findstr /s /i /m /o /offline " & """" & tbO3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbO4.TextLength > 0 Then
            T29 = "echo ### " & tbO4.Text & " ###"
            T30 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T31 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T32 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T33 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T34 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T35 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T36 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T37 = "findstr /s /i /m /o /offline " & """" & tbO4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO5.TextLength > 0 Then
            T38 = "echo ### " & tbO5.Text & " ###"
            T39 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T40 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T41 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T42 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T43 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T44 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T45 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T46 = "findstr /s /i /m /o /offline " & """" & tbO5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbO6.TextLength > 0 Then
            T47 = "echo ### " & tbO6.Text & " ###"
            T48 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T49 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T50 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T51 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T52 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T53 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T54 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T55 = "findstr /s /i /m /o /offline " & """" & tbO6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO7.TextLength > 0 Then
            T56 = "echo ### " & tbO7.Text & " ###"
            T57 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T58 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T59 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T60 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T61 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T62 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T63 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T64 = "findstr /s /i /m /o /offline " & """" & tbO7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO8.TextLength > 0 Then
            T65 = "echo ### " & tbO8.Text & " ###"
            T66 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T67 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T68 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T69 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T70 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T71 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T72 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T73 = "findstr /s /i /m /o /offline " & """" & tbO8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbO9.TextLength > 0 Then
            T74 = "echo ### " & tbO9.Text & " ###"
            T75 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T76 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T77 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T78 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T79 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T80 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T81 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T82 = "findstr /s /i /m /o /offline " & """" & tbO9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO10.TextLength > 0 Then
            T83 = "echo ### " & tbO10.Text & " ###"
            T84 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T85 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T86 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T87 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T88 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T89 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T90 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T91 = "findstr /s /i /m /o /offline " & """" & tbO10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbO11.TextLength > 0 Then
            T92 = "echo ### " & tbO11.Text & " ###"
            T93 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T94 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T95 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T96 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T97 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T98 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T99 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T100 = "findstr /s /i /m /o /offline " & """" & tbO11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO12.TextLength > 0 Then
            T101 = "echo ### " & tbO12.Text & " ###"
            T102 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T103 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T104 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T105 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T106 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T107 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T108 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T109 = "findstr /s /i /m /o /offline " & """" & tbO12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO13.TextLength > 0 Then
            T110 = "echo ### " & tbO13.Text & " ###"
            T111 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T112 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T113 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T114 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T115 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T116 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T117 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T118 = "findstr /s /i /m /o /offline " & """" & tbO13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbO14.TextLength > 0 Then
            T119 = "echo ### " & tbO14.Text & " ###"
            T120 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T121 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T122 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T123 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T124 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T125 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T126 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T127 = "findstr /s /i /m /o /offline " & """" & tbO14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbO15.TextLength > 0 Then
            T128 = "echo ### " & tbO15.Text & " ###"
            T129 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T130 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T131 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T132 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T133 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T134 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T135 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T136 = "findstr /s /i /m /o /offline " & """" & tbO15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If



        If tbH1.TextLength > 0 Then
            T137 = "echo ### " & tbH1.Text & " ###"
            T138 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T139 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T140 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T141 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T142 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T143 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T144 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T145 = "findstr /s /i /m /o /offline " & """" & tbH1.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH2.TextLength > 0 Then
            T146 = "echo ### " & tbH2.Text & " ###"
            T147 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T148 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T149 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T150 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T151 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T152 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T153 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T154 = "findstr /s /i /m /o /offline " & """" & tbH2.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH3.TextLength > 0 Then
            T155 = "echo ### " & tbH3.Text & " ###"
            T156 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T157 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T158 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T159 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T160 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T161 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T162 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T163 = "findstr /s /i /m /o /offline " & """" & tbH3.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbH4.TextLength > 0 Then
            T164 = "echo ### " & tbH4.Text & " ###"
            T165 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T166 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T167 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T168 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T169 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T170 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T171 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T172 = "findstr /s /i /m /o /offline " & """" & tbH4.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH5.TextLength > 0 Then
            T173 = "echo ### " & tbH5.Text & " ###"
            T174 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T175 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T176 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T177 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T178 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T179 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T180 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T181 = "findstr /s /i /m /o /offline " & """" & tbH5.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbH6.TextLength > 0 Then
            T182 = "echo ### " & tbH6.Text & " ###"
            T183 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T184 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T185 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T186 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T187 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T188 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T189 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T190 = "findstr /s /i /m /o /offline " & """" & tbH6.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH7.TextLength > 0 Then
            T191 = "echo ### " & tbH7.Text & " ###"
            T192 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T193 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T194 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T195 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T196 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T197 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T198 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T199 = "findstr /s /i /m /o /offline " & """" & tbH7.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH8.TextLength > 0 Then
            T200 = "echo ### " & tbH8.Text & " ###"
            T201 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T202 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T203 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T204 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T205 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T206 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T207 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T208 = "findstr /s /i /m /o /offline " & """" & tbH8.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbH9.TextLength > 0 Then
            T209 = "echo ### " & tbH9.Text & " ###"
            T210 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T211 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T212 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T213 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T214 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T215 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T216 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T217 = "findstr /s /i /m /o /offline " & """" & tbH9.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH10.TextLength > 0 Then
            T218 = "echo ### " & tbH10.Text & " ###"
            T219 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T220 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T221 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T222 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T223 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T224 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T225 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T226 = "findstr /s /i /m /o /offline " & """" & tbH10.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbH11.TextLength > 0 Then
            T227 = "echo ### " & tbH11.Text & " ###"
            T228 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T229 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T230 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T231 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T232 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T233 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T234 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T235 = "findstr /s /i /m /o /offline " & """" & tbH11.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH12.TextLength > 0 Then
            T236 = "echo ### " & tbH12.Text & " ###"
            T237 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T238 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T239 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T240 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T241 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T242 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T243 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T244 = "findstr /s /i /m /o /offline " & """" & tbH12.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH13.TextLength > 0 Then
            T245 = "echo ### " & tbH13.Text & " ###"
            T246 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T247 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T248 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T249 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T250 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T251 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T252 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T253 = "findstr /s /i /m /o /offline " & """" & tbH13.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If

        If tbH14.TextLength > 0 Then
            T254 = "echo ### " & tbH14.Text & " ###"
            T255 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T256 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T257 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T258 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T259 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T260 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T261 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T262 = "findstr /s /i /m /o /offline " & """" & tbH14.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbH15.TextLength > 0 Then
            T263 = "echo ### " & tbH15.Text & " ###"
            T264 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Local\Mozilla\*.*"""
            T265 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Mozilla\*.*"""
            T266 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Local\Microsoft\*.*"""
            T267 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Microsoft\*.*"""
            T268 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Local\Opera Software\*.*"""
            T269 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Opera Software\*.*"""
            T270 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Local\Google\*.*"""
            T271 = "findstr /s /i /m /o /offline " & """" & tbH15.Text & """" & " ""%USERPROFILE%\AppData\Roaming\Google\*.*"""
        End If


        If tbD1.TextLength > 0 Then
            T272 = "echo ### " & tbD1.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T273 = "dir /s /b %%d:\" & """" & tbD1.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD2.TextLength > 0 Then
            T274 = "echo ### " & tbD2.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T275 = "dir /s /b %%d:\" & """" & tbD2.Text & """" & vbNewLine & ")" & vbNewLine
        End If

        If tbD3.TextLength > 0 Then
            T276 = "echo ### " & tbD3.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T277 = "dir /s /b %%d:\" & """" & tbD3.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD4.TextLength > 0 Then
            T278 = "echo ### " & tbD4.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T279 = "dir /s /b %%d:\" & """" & tbD4.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD5.TextLength > 0 Then
            T280 = "echo ### " & tbD5.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T281 = "dir /s /b %%d:\" & """" & tbD5.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD6.TextLength > 0 Then
            T282 = "echo ### " & tbD6.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T283 = "dir /s /b %%d:\" & """" & tbD6.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD7.TextLength > 0 Then
            T284 = "echo ### " & tbD7.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T285 = "dir /s /b %%d:\" & """" & tbD7.Text & """" & vbNewLine & ")" & vbNewLine
        End If

        If tbD8.TextLength > 0 Then
            T286 = "echo ### " & tbD8.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T287 = "dir /s /b %%d:\" & """" & tbD8.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD9.TextLength > 0 Then
            T288 = "echo ### " & tbD9.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T289 = "dir /s /b %%d:\" & """" & tbD9.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD10.TextLength > 0 Then
            T290 = "echo ### " & tbD10.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T291 = "dir /s /b %%d:\" & """" & tbD10.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD11.TextLength > 0 Then
            T292 = "echo ### " & tbD11.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T293 = "dir /s /b %%d:\" & """" & tbD11.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD12.TextLength > 0 Then
            T294 = "echo ### " & tbD12.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T295 = "dir /s /b %%d:\" & """" & tbD12.Text & """" & vbNewLine & ")" & vbNewLine
        End If

        If tbD13.TextLength > 0 Then
            T296 = "echo ### " & tbD13.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T297 = "dir /s /b %%d:\" & """" & tbD13.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD14.TextLength > 0 Then
            T298 = "echo ### " & tbD14.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T299 = "dir /s /b %%d:\" & """" & tbD14.Text & """" & vbNewLine & ")" & vbNewLine
        End If


        If tbD15.TextLength > 0 Then
            T300 = "echo ### " & tbD15.Text & " ###" & vbNewLine & "for %%d in (%sDrives%) do ("
            T301 = "dir /s /b %%d:\" & """" & tbD15.Text & """" & vbNewLine & ")" & vbNewLine
        End If

        System.IO.File.Delete(Pfad)
        Dim rich As String = RichTextBox1.Text
        Dim TDrives As String = "       set sDrives=" & tbDrives.Text
        Dim rich2 As String = RichTextBox2.Text
        Dim enc As Text.Encoding = System.Text.Encoding.GetEncoding(1252) '1252 = ANSI
        Dim file As New StreamWriter(Pfad, True, enc)

        file.Write(rich)
        file.Write(TDrives)
        file.Write(rich2)

        file.WriteLine(T272)
        file.WriteLine(T273)
        file.WriteLine("echo\")
        file.WriteLine(T274)
        file.WriteLine(T275)
        file.WriteLine("echo\")
        file.WriteLine(T276)
        file.WriteLine(T277)
        file.WriteLine("echo\")
        file.WriteLine(T278)
        file.WriteLine(T279)
        file.WriteLine("echo\")
        file.WriteLine(T280)
        file.WriteLine(T281)
        file.WriteLine("echo\")
        file.WriteLine(T282)
        file.WriteLine(T283)
        file.WriteLine("echo\")
        file.WriteLine(T284)
        file.WriteLine(T285)
        file.WriteLine("echo\")
        file.WriteLine(T286)
        file.WriteLine(T287)
        file.WriteLine("echo\")
        file.WriteLine(T288)
        file.WriteLine(T289)
        file.WriteLine("echo\")
        file.WriteLine(T290)
        file.WriteLine(T291)
        file.WriteLine("echo\")
        file.WriteLine(T292)
        file.WriteLine(T293)
        file.WriteLine("echo\")
        file.WriteLine(T294)
        file.WriteLine(T295)
        file.WriteLine("echo\")
        file.WriteLine(T296)
        file.WriteLine(T297)
        file.WriteLine("echo\")
        file.WriteLine(T298)
        file.WriteLine(T299)
        file.WriteLine("echo\")
        file.WriteLine(T300)
        file.WriteLine(T301)

        file.WriteLine(")")
        file.WriteLine("echo ./. Software-Wallets search finished")
        file.WriteLine("echo\")
        file.WriteLine("echo ###############################################################################################")
        file.WriteLine("echo Online-Wallets")
        file.WriteLine("echo ###############################################################################################")
        file.WriteLine("echo\")
        file.WriteLine(T2)
        file.WriteLine(T3)
        file.WriteLine(T4)
        file.WriteLine(T5)
        file.WriteLine(T6)
        file.WriteLine(T7)
        file.WriteLine(T8)
        file.WriteLine(T9)
        file.WriteLine(T10)
        file.WriteLine("echo\")
        file.WriteLine(T11)
        file.WriteLine(T12)
        file.WriteLine(T13)
        file.WriteLine(T14)
        file.WriteLine(T15)
        file.WriteLine(T16)
        file.WriteLine(T17)
        file.WriteLine(T18)
        file.WriteLine(T19)
        file.WriteLine("echo\")
        file.WriteLine(T20)
        file.WriteLine(T21)
        file.WriteLine(T22)
        file.WriteLine(T23)
        file.WriteLine(T24)
        file.WriteLine(T25)
        file.WriteLine(T26)
        file.WriteLine(T27)
        file.WriteLine(T28)
        file.WriteLine("echo\")
        file.WriteLine(T29)
        file.WriteLine(T30)
        file.WriteLine(T31)
        file.WriteLine(T32)
        file.WriteLine(T33)
        file.WriteLine(T34)
        file.WriteLine(T35)
        file.WriteLine(T36)
        file.WriteLine(T37)
        file.WriteLine("echo\")
        file.WriteLine(T38)
        file.WriteLine(T39)
        file.WriteLine(T40)
        file.WriteLine(T41)
        file.WriteLine(T42)
        file.WriteLine(T43)
        file.WriteLine(T44)
        file.WriteLine(T45)
        file.WriteLine(T46)
        file.WriteLine("echo\")
        file.WriteLine(T47)
        file.WriteLine(T48)
        file.WriteLine(T49)
        file.WriteLine(T50)
        file.WriteLine(T51)
        file.WriteLine(T52)
        file.WriteLine(T53)
        file.WriteLine(T54)
        file.WriteLine(T55)
        file.WriteLine("echo\")
        file.WriteLine(T56)
        file.WriteLine(T57)
        file.WriteLine(T58)
        file.WriteLine(T59)
        file.WriteLine(T60)
        file.WriteLine(T61)
        file.WriteLine(T62)
        file.WriteLine(T63)
        file.WriteLine(T64)
        file.WriteLine("echo\")
        file.WriteLine(T65)
        file.WriteLine(T66)
        file.WriteLine(T67)
        file.WriteLine(T68)
        file.WriteLine(T69)
        file.WriteLine(T70)
        file.WriteLine(T71)
        file.WriteLine(T72)
        file.WriteLine(T73)
        file.WriteLine("echo\")
        file.WriteLine(T74)
        file.WriteLine(T75)
        file.WriteLine(T76)
        file.WriteLine(T77)
        file.WriteLine(T78)
        file.WriteLine(T79)
        file.WriteLine(T80)
        file.WriteLine(T81)
        file.WriteLine(T82)
        file.WriteLine("echo\")
        file.WriteLine(T83)
        file.WriteLine(T84)
        file.WriteLine(T85)
        file.WriteLine(T86)
        file.WriteLine(T87)
        file.WriteLine(T88)
        file.WriteLine(T89)
        file.WriteLine(T90)
        file.WriteLine(T91)
        file.WriteLine("echo\")
        file.WriteLine(T92)
        file.WriteLine(T93)
        file.WriteLine(T94)
        file.WriteLine(T95)
        file.WriteLine(T96)
        file.WriteLine(T97)
        file.WriteLine(T98)
        file.WriteLine(T99)
        file.WriteLine(T100)
        file.WriteLine("echo\")
        file.WriteLine(T101)
        file.WriteLine(T102)
        file.WriteLine(T103)
        file.WriteLine(T104)
        file.WriteLine(T105)
        file.WriteLine(T106)
        file.WriteLine(T107)
        file.WriteLine(T108)
        file.WriteLine(T109)
        file.WriteLine("echo\")
        file.WriteLine(T110)
        file.WriteLine(T111)
        file.WriteLine(T112)
        file.WriteLine(T113)
        file.WriteLine(T114)
        file.WriteLine(T115)
        file.WriteLine(T116)
        file.WriteLine(T117)
        file.WriteLine(T118)
        file.WriteLine("echo\")
        file.WriteLine(T119)
        file.WriteLine(T120)
        file.WriteLine(T121)
        file.WriteLine(T122)
        file.WriteLine(T123)
        file.WriteLine(T124)
        file.WriteLine(T125)
        file.WriteLine(T126)
        file.WriteLine(T127)
        file.WriteLine("echo\")
        file.WriteLine(T128)
        file.WriteLine(T129)
        file.WriteLine(T130)
        file.WriteLine(T131)
        file.WriteLine(T132)
        file.WriteLine(T133)
        file.WriteLine(T134)
        file.WriteLine(T135)
        file.WriteLine(T136)

        file.WriteLine("echo ./. Online-Wallets search finished")
        file.WriteLine("echo\")
        file.WriteLine("echo ###############################################################################################")
        file.WriteLine("echo Hardware-Wallets")
        file.WriteLine("echo ###############################################################################################")
        file.WriteLine("echo\")
        file.WriteLine(T137)
        file.WriteLine(T138)
        file.WriteLine(T139)
        file.WriteLine(T140)
        file.WriteLine(T141)
        file.WriteLine(T142)
        file.WriteLine(T143)
        file.WriteLine(T144)
        file.WriteLine(T145)
        file.WriteLine("echo\")
        file.WriteLine(T146)
        file.WriteLine(T147)
        file.WriteLine(T148)
        file.WriteLine(T149)
        file.WriteLine(T150)
        file.WriteLine(T151)
        file.WriteLine(T152)
        file.WriteLine(T153)
        file.WriteLine(T154)
        file.WriteLine("echo\")
        file.WriteLine(T155)
        file.WriteLine(T156)
        file.WriteLine(T157)
        file.WriteLine(T158)
        file.WriteLine(T159)
        file.WriteLine(T160)
        file.WriteLine(T161)
        file.WriteLine(T162)
        file.WriteLine(T163)
        file.WriteLine("echo\")
        file.WriteLine(T164)
        file.WriteLine(T165)
        file.WriteLine(T166)
        file.WriteLine(T167)
        file.WriteLine(T168)
        file.WriteLine(T169)
        file.WriteLine(T170)
        file.WriteLine(T171)
        file.WriteLine(T172)
        file.WriteLine("echo\")
        file.WriteLine(T173)
        file.WriteLine(T174)
        file.WriteLine(T175)
        file.WriteLine(T176)
        file.WriteLine(T177)
        file.WriteLine(T178)
        file.WriteLine(T179)
        file.WriteLine(T180)
        file.WriteLine(T181)
        file.WriteLine("echo\")
        file.WriteLine(T182)
        file.WriteLine(T183)
        file.WriteLine(T184)
        file.WriteLine(T185)
        file.WriteLine(T186)
        file.WriteLine(T187)
        file.WriteLine(T188)
        file.WriteLine(T189)
        file.WriteLine(T190)
        file.WriteLine("echo\")
        file.WriteLine(T191)
        file.WriteLine(T192)
        file.WriteLine(T193)
        file.WriteLine(T194)
        file.WriteLine(T195)
        file.WriteLine(T196)
        file.WriteLine(T197)
        file.WriteLine(T198)
        file.WriteLine(T199)
        file.WriteLine("echo\")
        file.WriteLine(T200)
        file.WriteLine(T201)
        file.WriteLine(T202)
        file.WriteLine(T203)
        file.WriteLine(T204)
        file.WriteLine(T205)
        file.WriteLine(T206)
        file.WriteLine(T207)
        file.WriteLine(T208)
        file.WriteLine("echo\")
        file.WriteLine(T209)
        file.WriteLine(T210)
        file.WriteLine(T211)
        file.WriteLine(T212)
        file.WriteLine(T213)
        file.WriteLine(T214)
        file.WriteLine(T215)
        file.WriteLine(T216)
        file.WriteLine(T217)
        file.WriteLine("echo\")
        file.WriteLine(T218)
        file.WriteLine(T219)
        file.WriteLine(T220)
        file.WriteLine(T221)
        file.WriteLine(T222)
        file.WriteLine(T223)
        file.WriteLine(T224)
        file.WriteLine(T225)
        file.WriteLine(T226)
        file.WriteLine("echo\")
        file.WriteLine(T227)
        file.WriteLine(T228)
        file.WriteLine(T229)
        file.WriteLine(T230)
        file.WriteLine(T231)
        file.WriteLine(T232)
        file.WriteLine(T233)
        file.WriteLine(T234)
        file.WriteLine(T235)
        file.WriteLine("echo\")
        file.WriteLine(T236)
        file.WriteLine(T237)
        file.WriteLine(T238)
        file.WriteLine(T239)
        file.WriteLine(T240)
        file.WriteLine(T241)
        file.WriteLine(T242)
        file.WriteLine(T243)
        file.WriteLine(T244)
        file.WriteLine("echo\")
        file.WriteLine(T245)
        file.WriteLine(T246)
        file.WriteLine(T247)
        file.WriteLine(T248)
        file.WriteLine(T249)
        file.WriteLine(T250)
        file.WriteLine(T251)
        file.WriteLine(T252)
        file.WriteLine(T253)
        file.WriteLine("echo\")
        file.WriteLine(T254)
        file.WriteLine(T255)
        file.WriteLine(T256)
        file.WriteLine(T257)
        file.WriteLine(T258)
        file.WriteLine(T259)
        file.WriteLine(T260)
        file.WriteLine(T261)
        file.WriteLine(T262)
        file.WriteLine("echo\")
        file.WriteLine(T263)
        file.WriteLine(T264)
        file.WriteLine(T265)
        file.WriteLine(T266)
        file.WriteLine(T267)
        file.WriteLine(T268)
        file.WriteLine(T269)
        file.WriteLine(T270)
        file.WriteLine(T271)

        file.WriteLine("echo ./. Hardware-Wallets search finished")
        file.WriteLine("echo\")
        file.WriteLine("echo\")
        file.WriteLine("echo ###############################################################################################")
        file.WriteLine("echo GovCrypto-Scan finish ...")
        file.WriteLine("echo ###############################################################################################")
        file.WriteLine("echo\")
        file.WriteLine("@ping -n 2 localhost> nul")
        file.WriteLine("exit")
        file.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        tbD1.Text = ""
        tbD2.Text = ""
        tbD3.Text = ""
        tbD4.Text = ""
        tbD5.Text = ""
        tbD6.Text = ""
        tbD7.Text = ""
        tbD8.Text = ""
        tbD9.Text = ""
        tbD10.Text = ""
        tbD11.Text = ""
        tbD12.Text = ""
        tbD13.Text = ""
        tbD14.Text = ""
        tbD15.Text = ""

        tbO1.Text = ""
        tbO2.Text = ""
        tbO3.Text = ""
        tbO4.Text = ""
        tbO5.Text = ""
        tbO6.Text = ""
        tbO7.Text = ""
        tbO8.Text = ""
        tbO9.Text = ""
        tbO10.Text = ""
        tbO11.Text = ""
        tbO12.Text = ""
        tbO13.Text = ""
        tbO14.Text = ""
        tbO15.Text = ""

        tbH1.Text = ""
        tbH2.Text = ""
        tbH3.Text = ""
        tbH4.Text = ""
        tbH5.Text = ""
        tbH6.Text = ""
        tbH7.Text = ""
        tbH8.Text = ""
        tbH9.Text = ""
        tbH10.Text = ""
        tbH11.Text = ""
        tbH12.Text = ""
        tbH13.Text = ""
        tbH14.Text = ""
        tbH15.Text = ""

    End Sub


End Class