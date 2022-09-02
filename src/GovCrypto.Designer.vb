<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GovCrypto
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GovCrypto))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.btnParameter = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Radar = New System.Windows.Forms.PictureBox()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        CType(Me.Radar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(981, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 25)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1126, 579)
        Me.ListBox1.TabIndex = 8
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'btnParameter
        '
        Me.btnParameter.Location = New System.Drawing.Point(981, 74)
        Me.btnParameter.Name = "btnParameter"
        Me.btnParameter.Size = New System.Drawing.Size(112, 25)
        Me.btnParameter.TabIndex = 10
        Me.btnParameter.Text = "Settings"
        Me.btnParameter.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(981, 105)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(112, 25)
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Radar
        '
        Me.Radar.BackColor = System.Drawing.Color.Black
        Me.Radar.Image = CType(resources.GetObject("Radar.Image"), System.Drawing.Image)
        Me.Radar.Location = New System.Drawing.Point(990, 136)
        Me.Radar.Name = "Radar"
        Me.Radar.Size = New System.Drawing.Size(94, 43)
        Me.Radar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Radar.TabIndex = 13
        Me.Radar.TabStop = False
        Me.Radar.Visible = False
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(12, 533)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(212, 20)
        Me.tbOutput.TabIndex = 12
        Me.tbOutput.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(981, 43)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(112, 25)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'GovCrypto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1126, 579)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnParameter)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Radar)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GovCrypto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GovCrypto - Cryptocurrency Scanner by www.govcrack.com"
        CType(Me.Radar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStart As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnParameter As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents Radar As PictureBox
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents btnStop As Button
End Class
