<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.lblInputDirectory = New System.Windows.Forms.Label()
        Me.lblOutputDirectory = New System.Windows.Forms.Label()
        Me.tbxByteShow = New System.Windows.Forms.TextBox()
        Me.pbrProgress = New System.Windows.Forms.ProgressBar()
        Me.tbxPassphrase = New System.Windows.Forms.TextBox()
        Me.btnSavePass = New System.Windows.Forms.Button()
        Me.btnChangeSource = New System.Windows.Forms.Button()
        Me.btnCHangeTarget = New System.Windows.Forms.Button()
        Me.ttpInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxHashType = New System.Windows.Forms.ComboBox()
        Me.fbdOutputDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSavePassPhrase = New System.Windows.Forms.SaveFileDialog()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInputDirectory
        '
        Me.lblInputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInputDirectory.Location = New System.Drawing.Point(12, 9)
        Me.lblInputDirectory.Name = "lblInputDirectory"
        Me.lblInputDirectory.Size = New System.Drawing.Size(345, 20)
        Me.lblInputDirectory.TabIndex = 1
        Me.lblInputDirectory.Text = "Source File"
        Me.lblInputDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttpInfo.SetToolTip(Me.lblInputDirectory, "Source File.")
        '
        'lblOutputDirectory
        '
        Me.lblOutputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputDirectory.Location = New System.Drawing.Point(12, 35)
        Me.lblOutputDirectory.Name = "lblOutputDirectory"
        Me.lblOutputDirectory.Size = New System.Drawing.Size(345, 20)
        Me.lblOutputDirectory.TabIndex = 2
        Me.lblOutputDirectory.Text = "Output Directory"
        Me.lblOutputDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttpInfo.SetToolTip(Me.lblOutputDirectory, "Output directory.")
        '
        'tbxByteShow
        '
        Me.tbxByteShow.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxByteShow.Location = New System.Drawing.Point(12, 116)
        Me.tbxByteShow.Multiline = True
        Me.tbxByteShow.Name = "tbxByteShow"
        Me.tbxByteShow.ReadOnly = True
        Me.tbxByteShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxByteShow.Size = New System.Drawing.Size(444, 251)
        Me.tbxByteShow.TabIndex = 4
        '
        'pbrProgress
        '
        Me.pbrProgress.Location = New System.Drawing.Point(13, 373)
        Me.pbrProgress.Name = "pbrProgress"
        Me.pbrProgress.Size = New System.Drawing.Size(443, 23)
        Me.pbrProgress.TabIndex = 5
        '
        'tbxPassphrase
        '
        Me.tbxPassphrase.Location = New System.Drawing.Point(13, 62)
        Me.tbxPassphrase.Name = "tbxPassphrase"
        Me.tbxPassphrase.Size = New System.Drawing.Size(344, 20)
        Me.tbxPassphrase.TabIndex = 6
        Me.ttpInfo.SetToolTip(Me.tbxPassphrase, "Passphrase. Longer passphrases DON'T make the encryption more safe. Use slower ha" & _
        "shes instead. However, a too easy passphrase can be guessed.")
        '
        'btnSavePass
        '
        Me.btnSavePass.Location = New System.Drawing.Point(362, 61)
        Me.btnSavePass.Name = "btnSavePass"
        Me.btnSavePass.Size = New System.Drawing.Size(93, 20)
        Me.btnSavePass.TabIndex = 7
        Me.btnSavePass.Text = "Save..."
        Me.ttpInfo.SetToolTip(Me.btnSavePass, "Save Passphrase. UNSAFE!")
        Me.btnSavePass.UseVisualStyleBackColor = True
        '
        'btnChangeSource
        '
        Me.btnChangeSource.Location = New System.Drawing.Point(363, 9)
        Me.btnChangeSource.Name = "btnChangeSource"
        Me.btnChangeSource.Size = New System.Drawing.Size(93, 20)
        Me.btnChangeSource.TabIndex = 8
        Me.btnChangeSource.Text = "Change..."
        Me.ttpInfo.SetToolTip(Me.btnChangeSource, "Change Source File")
        Me.btnChangeSource.UseVisualStyleBackColor = True
        '
        'btnCHangeTarget
        '
        Me.btnCHangeTarget.Location = New System.Drawing.Point(363, 35)
        Me.btnCHangeTarget.Name = "btnCHangeTarget"
        Me.btnCHangeTarget.Size = New System.Drawing.Size(93, 20)
        Me.btnCHangeTarget.TabIndex = 9
        Me.btnCHangeTarget.Text = "Change..."
        Me.ttpInfo.SetToolTip(Me.btnCHangeTarget, "Change Output Directory")
        Me.btnCHangeTarget.UseVisualStyleBackColor = True
        '
        'ttpInfo
        '
        Me.ttpInfo.IsBalloon = True
        '
        'cbxHashType
        '
        Me.cbxHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHashType.FormattingEnabled = True
        Me.cbxHashType.Items.AddRange(New Object() {"MD5 - 255 MiB/s", "RIPEMD160 - 106 MiB/s", "SHA1 - 153 MiB/s", "SHA256 - 111 MiB/s", "SHA384 - unknown, around 105 MiB/s", "SHA512 - 99 MiB/s"})
        Me.cbxHashType.Location = New System.Drawing.Point(13, 89)
        Me.cbxHashType.Name = "cbxHashType"
        Me.cbxHashType.Size = New System.Drawing.Size(246, 21)
        Me.cbxHashType.TabIndex = 10
        Me.ttpInfo.SetToolTip(Me.cbxHashType, "Select the Hash Algorithm. Speeds according to http://www.cryptopp.com/benchmarks" & _
        ".html.")
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(364, 88)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(91, 22)
        Me.btnEncrypt.TabIndex = 11
        Me.btnEncrypt.Text = "Encrypt!"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(265, 89)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(92, 22)
        Me.btnDecrypt.TabIndex = 12
        Me.btnDecrypt.Text = "Decrypt!"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 408)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.cbxHashType)
        Me.Controls.Add(Me.btnCHangeTarget)
        Me.Controls.Add(Me.btnChangeSource)
        Me.Controls.Add(Me.btnSavePass)
        Me.Controls.Add(Me.tbxPassphrase)
        Me.Controls.Add(Me.pbrProgress)
        Me.Controls.Add(Me.tbxByteShow)
        Me.Controls.Add(Me.lblOutputDirectory)
        Me.Controls.Add(Me.lblInputDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "encr"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInputDirectory As System.Windows.Forms.Label
    Friend WithEvents lblOutputDirectory As System.Windows.Forms.Label
    Friend WithEvents tbxByteShow As System.Windows.Forms.TextBox
    Friend WithEvents pbrProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents ttpInfo As System.Windows.Forms.ToolTip
    Friend WithEvents tbxPassphrase As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePass As System.Windows.Forms.Button
    Friend WithEvents btnChangeSource As System.Windows.Forms.Button
    Friend WithEvents btnCHangeTarget As System.Windows.Forms.Button
    Friend WithEvents fbdOutputDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSavePassPhrase As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxHashType As System.Windows.Forms.ComboBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button

End Class
