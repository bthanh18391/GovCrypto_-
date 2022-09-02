Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text


Public Class GovCrypto

    Private WithEvents myProcess As Process
    Private WithEvents _Process2 As Process
    Private eventHandled As TaskCompletionSource(Of Boolean)
    Public Shared ReadOnly Property LocalUserAppDataPath As String
    Public ReadOnly Property CancellationPending As Boolean

    Public PID As Integer
    Public sAppPath As String = Application.StartupPath
    Public st As String


    ' #### INI - Deklaration der Speichern-Funktion
    ' https://boschert-consulting.com/vb-net-einstellungen-in-ini-datei-speichern-und-auslesen/
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (
ByVal lpApplicationName As String,
ByVal lpKeyName As String,
ByVal lpString As String,
ByVal lpFileName As String) _
As Integer


    Private Sub Goycrypto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Wert einem String zuordnen
        Dim sb As StringBuilder
        sb = New StringBuilder(1024)

        INI.Lesen("GovCrypto", "Profil47", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        Parameter.cbGER = sb.ToString
        INI.Lesen("GovCrypto", "Profil48", "", sb, sb.Capacity, sAppPath & "\Scanner\INI\SettingsGCY.ini")
        Parameter.cbENG = sb.ToString


        '### Form umbenennen
        If Parameter.cbENG = "No" Then
            btnHelp.Text = "Hilfe"
            btnParameter.Text = "Einstellungen"
            Me.Text = "Krypto-Scanner"
        End If

        Call ListLoad1()

    End Sub

    Private Sub ListLoad1()

        Try

            '### Standartext #####

            If Parameter.cbGER = "Yes" Then
                st = "#####################################=# G o v C r y p t o // Kryptowaehrungs-Scanner #=#####################################= =GovCrypto durchsucht den Computer der Zielperson nach Indizien fuer die Nutzung von Kryptowaehrungen.=GovCrypto scannt das gesamte Dateisystem, inkl. Netzlaufwerke um zu analysieren, ob es Anzeichen fuer die Nutzung=von Kryptowaehrungen gibt.==Unter ""Einstellungen"" koennen Sie den Suchfilter eintragen.==Der Scanvorgang kann einige Zeit in Anspruch nehmen. Sollten Treffer angezeigt werden, stellen diese nur=ein Indiz fuer die Nutzung von Kryptowaehrungen dar. Sollte eine Bitcoin Software-Wallet gefunden werden,=wird diese am Ende des Scanvorgangs automatisch selektiert. =Treffer koennen mit einem Doppelklick geoeffnet werden.  ==Folgende Hash-Typen kommen für die Entschluesselung von Software-Wallets mit GovCracker (www.govcrack.com) in Betracht:==Bitcoin-Wallet: 11300=Ethereum-Wallet: 15600, 15700, 16300=Electrum-Wallet: 16600, 21700, 21800=MyBlockchain-Wallet: 12700, 15200 ,18800=MetaMask-Wallet: 26600=Exodus-Wallet: 28200==Folgende Indizien konnten auf dem System lokalisiert werden:"
            End If

            If Parameter.cbENG = "Yes" Then
                st = "####################################=# G o v C r y p t o // Cryptocurrencies-Scanner #=####################################= =GovCrypto searches the target persons computer for evidence of the use of cryptocurrencies.=GovCrypto scans the entire file system, including network drives, to check whether there are file name=that indicate the use of cryptocurrencies.==You can enter the search filter under ""Settings"".==The scanning process may take some time. If hits are displayed, these are only an indication of=the use of crypto currency. If a Bitcoin Desktop-Wallet is found, it will be selected automatically at=the end of the scanning process. =Hits can be opened with a double click. ==The following hash types can be considered for decrypting software wallets with GovCracker (www.govcrack.com):==Bitcoin-Wallet: 11300=Ethereum-Wallet: 15600, 15700, 16300=Electrum-Wallet: 16600, 21700, 21800=MyBlockchain-Wallet: 12700, 15200 ,18800=MetaMask-Wallet: 26600=Exodus-Wallet: 28200==The following indications could be located on the system:"
            End If

            If Parameter.cbENG = "" Then
                st = "####################################=# G o v C r y p t o // Cryptocurrencies-Scanner #=###################################= =GovCrypto searches the target persons computer for evidence of the use of cryptocurrencies.=GovCrypto scans the entire file system, including network drives, to check whether there are file name=that indicate the use of cryptocurrencies.==You can enter the search filter under ""Settings"".==The scanning process may take some time. If hits are displayed, these are only an indication of=the use of crypto currency. If a Bitcoin Desktop-Wallet is found, it will be selected automatically at=the end of the scanning process. =Hits can be opened with a double click. ==The following hash types can be considered for decrypting software wallets with GovCracker (www.govcrack.com):==Bitcoin-Wallet: 11300=Ethereum-Wallet: 15600, 15700, 16300=Electrum-Wallet: 16600, 21700, 21800=MyBlockchain-Wallet: 12700, 15200 ,18800=MetaMask-Wallet: 26600=Exodus-Wallet: 28200==The following indications could be located on the system:"
            End If

            '### Standardtext wird auf die Items aufgeteilt durch =-Zeichen
            Dim words As String() = st.Split(New Char() {"="c})
            Dim word As String
            For Each word In words
                ListBox1.Items.Add(word)
            Next

        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        '### Der Backgroundworker durchsucht alle Laufwerke und fügt die Treffer der Listbox hinzu

        Try

            Dim start_info As New ProcessStartInfo()
            Dim proc As New Process
            Dim std_out As System.IO.StreamReader

            '### CMD läuft versteckt
            start_info.FileName = ("cmd.exe")
            start_info.Verb = "runas"
            start_info.UseShellExecute = False
            start_info.CreateNoWindow = True
            start_info.RedirectStandardOutput = True
            start_info.WindowStyle = ProcessWindowStyle.Hidden
            start_info.WorkingDirectory = Application.StartupPath & "\Scanner\GovCrypto_4_Windows"
            start_info.Arguments = ("/k " & """" & Application.StartupPath & "\Scanner\GovCrypto_4_Windows\GovCrypto_4_Windows.bat" & """")
            'start_info.Arguments = (Param)
            proc.StartInfo = start_info
            proc.Start()

            PID = proc.Id

            std_out = proc.StandardOutput

            '### Schleife wird ausgeführt. Bei CancelP wird die Schleife verlassen. Letzte Eintrag wird autom. selek., damit die Liste autom. nach unten scrollt
            Do
                If Me.BackgroundWorker1.CancellationPending Then Exit Do

                Dim line As String = std_out.ReadLine()

                ListBox1.Invoke(Sub()

                                    'Streamen in die Listbox
                                    Try
                                        ListBox1.Items.Add(line)
                                        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                                    Catch ex As Exception
                                        'nothing / Nötig für den PID Abbruch
                                    End Try

                                End Sub)

            Loop While proc.HasExited = False

        Catch ex As Exception
        End Try


    End Sub


    Public Sub Folder()

        '### Prüfen ob GovCrypto_4_Windows.bat vorhanden ist
        If System.IO.File.Exists(Application.StartupPath & "\Scanner\GovCrypto_4_Windows\GovCrypto_4_Windows.bat") Then
            'nothing
        Else

            If Not IO.Directory.Exists(Application.StartupPath & "\Scanner\GovCrypto_4_Windows\") Then
                IO.Directory.CreateDirectory(Application.StartupPath & "\Scanner\GovCrypto_4_Windows\")
                IO.Directory.CreateDirectory(Application.StartupPath & "\Scanner\INI\")
                ' Ordner wurde korrekt erstellt!
            End If

            Call Parameter.DefaultX()
            Call Parameter.BatchFile()

            System.Threading.Thread.Sleep(500)

        End If

    End Sub
    Private Sub StartKryptoBtn_Click(sender As Object, e As EventArgs) Handles btnStart.Click


        Try
            '### Prüfen ob GovCrypto_4_Windows.bat vorhanden ist
            Call Folder()


            '### Es wird die Form neu geladen, da ansonsten bei einem erneuten Start der Worker noch läuft
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            Me.Show()

            '### Für Neustart Listbox löschen
            ListBox1.Items.Clear()

            Call ListLoad1()

            '### Worker starten
            Me.BackgroundWorker1.RunWorkerAsync()

            '### Radar einblenden
            Radar.Visible = True

            '### Buttons aktivieren
            btnStart.Enabled = False
            btnStop.Enabled = True
            btnParameter.Enabled = False

        Catch ex As Exception
            'nothing
        End Try

        If Parameter.cbENG = "No" Then
            btnHelp.Text = "Hilfe"
            btnParameter.Text = "Einstellungen"
            Me.Text = "Krypto-Scanner"
        End If

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        '### Background worker wird gestoppt. Er läuft aber solange weiter, bis er einen nächsten Treffer hat. Daher der Umweg über Neustart
        Me.BackgroundWorker1.CancelAsync()

        '### Radar abschalten
        Radar.Visible = False

        '### Msgbox
        If Parameter.cbENG = "No" Then MsgBox("Der Scannvorgang wurde abgebrochen.", vbOKOnly, "GovCrypto")
        If Parameter.cbENG = "Yes" Then MsgBox("The scanning process was canceled.", vbOKOnly, "GovCrypto")

        '### Start Button wieder aktivieren
        btnStart.Enabled = True
        btnParameter.Enabled = True

        Call PIDX()

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        '### Select Item in Textbox darstellen
        Me.tbOutput.Text = Me.ListBox1.SelectedItem
    End Sub


    Private Sub tboutput_TextChanged(sender As Object, e As EventArgs) Handles tbOutput.TextChanged

        '### Ende überwachen durch Textbox1
        Try

            If tbOutput.Text = "GovCrypto-Scan finish ..." Then

                Me.BackgroundWorker1.CancelAsync()

                btnStart.Enabled = True
                btnParameter.Enabled = True

                Dim DateBatch As String = Format(Now, "yyyyMMdd_HHmmss")
                Dim sav As String = (Application.StartupPath & "\Scanner\GovCryptoScan_" & DateBatch & ".txt")
                Dim text As String = ""

                '### Listbox wird in txt gespeichert
                For Each Litem As String In ListBox1.Items
                    text &= vbCrLf & Litem
                Next
                IO.File.WriteAllText(sav, text)

                '### Radar ausblenden
                Radar.Visible = False

                '### Sollte eine Wallet.dat vorhanden sein, dann selektieren
                Dim searchstring As String = "wallet.dat"
                Dim Index As Integer = (Array.FindIndex(ListBox1.Items.Cast(Of Object).Select(Function(o) ListBox1.GetItemText(o)).ToArray, Function(s) s Like String.Format("*{0}", searchstring)))

                If searchstring <> String.Empty Then
                    If Index <> -1 Then
                        ListBox1.SetSelected(Index, True)
                    End If
                End If

                '### Msgbox
                If Parameter.cbENG = "No" Then MsgBox("Scanvorgang abgeschlossen. Die Ergebnisse wurden in den GovCrack-Ordner ""Scanner"" exportiert.")
                If Parameter.cbENG = "Yes" Then MsgBox("The scanning process is finished. The results were exported to the GovCrack-Folder ""Scanner"".")

            End If

        Catch ex As Exception
            'nothing
        End Try

    End Sub


    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick

        Dim para As String
        para = ListBox1.SelectedItem

        '### CMD läuft versteckt
        Dim process As New Process()
        process.StartInfo.FileName = "notepad.exe"
        process.StartInfo.WorkingDirectory = Application.StartupPath
        process.StartInfo.Arguments = ("""" & para & """")
        process.Start()

    End Sub

    Private Sub btnHelp_Click_2(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.Show()
    End Sub

    Private Sub btnParameter_Click_2(sender As Object, e As EventArgs) Handles btnParameter.Click

        '### Prüfen ob GovCrypto_4_Windows.bat vorhanden ist
        Call Folder()

        Parameter.Show()

    End Sub

    Private Sub GovCrypto_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Call PIDX()

    End Sub

    Private Sub PIDX()

        Try
            Dim aProcess As System.Diagnostics.Process
            aProcess = System.Diagnostics.Process.GetProcessById(PID)
            aProcess.Kill()
        Catch ex As Exception
            'nothing
        End Try

    End Sub

End Class
