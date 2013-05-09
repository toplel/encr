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
        Me.tbxInputBytes = New System.Windows.Forms.TextBox()
        Me.pbrProgress = New System.Windows.Forms.ProgressBar()
        Me.tbxPassphrase = New System.Windows.Forms.TextBox()
        Me.btnSavePass = New System.Windows.Forms.Button()
        Me.btnChangeSource = New System.Windows.Forms.Button()
        Me.ttpInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxHashType = New System.Windows.Forms.ComboBox()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSavePassPhrase = New System.Windows.Forms.SaveFileDialog()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.tbcByteDisplay = New System.Windows.Forms.TabControl()
        Me.tbpInputBytes = New System.Windows.Forms.TabPage()
        Me.tbpOutputBytes = New System.Windows.Forms.TabPage()
        Me.tbxOutBytes = New System.Windows.Forms.TextBox()
        Me.tbcByteDisplay.SuspendLayout()
        Me.tbpInputBytes.SuspendLayout()
        Me.tbpOutputBytes.SuspendLayout()
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
        'tbxInputBytes
        '
        Me.tbxInputBytes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInputBytes.Location = New System.Drawing.Point(0, 0)
        Me.tbxInputBytes.Multiline = True
        Me.tbxInputBytes.Name = "tbxInputBytes"
        Me.tbxInputBytes.ReadOnly = True
        Me.tbxInputBytes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxInputBytes.Size = New System.Drawing.Size(434, 252)
        Me.tbxInputBytes.TabIndex = 4
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
        Me.tbxPassphrase.Location = New System.Drawing.Point(12, 35)
        Me.tbxPassphrase.Name = "tbxPassphrase"
        Me.tbxPassphrase.Size = New System.Drawing.Size(344, 20)
        Me.tbxPassphrase.TabIndex = 6
        Me.ttpInfo.SetToolTip(Me.tbxPassphrase, "Passphrase. Longer passphrases DON'T make the encryption more safe. Use slower ha" & _
        "shes instead. However, a too easy passphrase can be guessed.")
        '
        'btnSavePass
        '
        Me.btnSavePass.Enabled = False
        Me.btnSavePass.Location = New System.Drawing.Point(362, 35)
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
        'ttpInfo
        '
        Me.ttpInfo.IsBalloon = True
        '
        'cbxHashType
        '
        Me.cbxHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHashType.FormattingEnabled = True
        Me.cbxHashType.Items.AddRange(New Object() {"MD5 - 255 MiB/s", "RIPEMD160 - 106 MiB/s", "SHA1 - 153 MiB/s", "SHA256 - 111 MiB/s", "SHA384 - unknown, around 105 MiB/s", "SHA512 - 99 MiB/s"})
        Me.cbxHashType.Location = New System.Drawing.Point(13, 61)
        Me.cbxHashType.Name = "cbxHashType"
        Me.cbxHashType.Size = New System.Drawing.Size(343, 21)
        Me.cbxHashType.TabIndex = 10
        Me.ttpInfo.SetToolTip(Me.cbxHashType, "Select the Hash Algorithm. Speeds according to http://www.cryptopp.com/benchmarks" & _
        ".html.")
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(364, 61)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(91, 22)
        Me.btnEncrypt.TabIndex = 11
        Me.btnEncrypt.Text = "Crypt."
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'tbcByteDisplay
        '
        Me.tbcByteDisplay.Controls.Add(Me.tbpInputBytes)
        Me.tbcByteDisplay.Controls.Add(Me.tbpOutputBytes)
        Me.tbcByteDisplay.Enabled = False
        Me.tbcByteDisplay.Location = New System.Drawing.Point(13, 89)
        Me.tbcByteDisplay.Name = "tbcByteDisplay"
        Me.tbcByteDisplay.SelectedIndex = 0
        Me.tbcByteDisplay.Size = New System.Drawing.Size(442, 278)
        Me.tbcByteDisplay.TabIndex = 13
        '
        'tbpInputBytes
        '
        Me.tbpInputBytes.Controls.Add(Me.tbxInputBytes)
        Me.tbpInputBytes.Location = New System.Drawing.Point(4, 22)
        Me.tbpInputBytes.Name = "tbpInputBytes"
        Me.tbpInputBytes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInputBytes.Size = New System.Drawing.Size(434, 252)
        Me.tbpInputBytes.TabIndex = 0
        Me.tbpInputBytes.Text = "Input"
        Me.tbpInputBytes.UseVisualStyleBackColor = True
        '
        'tbpOutputBytes
        '
        Me.tbpOutputBytes.Controls.Add(Me.tbxOutBytes)
        Me.tbpOutputBytes.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutputBytes.Name = "tbpOutputBytes"
        Me.tbpOutputBytes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutputBytes.Size = New System.Drawing.Size(434, 252)
        Me.tbpOutputBytes.TabIndex = 1
        Me.tbpOutputBytes.Text = "Output"
        Me.tbpOutputBytes.UseVisualStyleBackColor = True
        '
        'tbxOutBytes
        '
        Me.tbxOutBytes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOutBytes.Location = New System.Drawing.Point(0, 0)
        Me.tbxOutBytes.Multiline = True
        Me.tbxOutBytes.Name = "tbxOutBytes"
        Me.tbxOutBytes.ReadOnly = True
        Me.tbxOutBytes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxOutBytes.Size = New System.Drawing.Size(434, 252)
        Me.tbxOutBytes.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 408)
        Me.Controls.Add(Me.tbcByteDisplay)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.cbxHashType)
        Me.Controls.Add(Me.btnChangeSource)
        Me.Controls.Add(Me.btnSavePass)
        Me.Controls.Add(Me.tbxPassphrase)
        Me.Controls.Add(Me.pbrProgress)
        Me.Controls.Add(Me.lblInputDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "encr"
        Me.tbcByteDisplay.ResumeLayout(False)
        Me.tbpInputBytes.ResumeLayout(False)
        Me.tbpInputBytes.PerformLayout()
        Me.tbpOutputBytes.ResumeLayout(False)
        Me.tbpOutputBytes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInputDirectory As System.Windows.Forms.Label
    Friend WithEvents tbxInputBytes As System.Windows.Forms.TextBox
    Friend WithEvents pbrProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents ttpInfo As System.Windows.Forms.ToolTip
    Friend WithEvents tbxPassphrase As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePass As System.Windows.Forms.Button
    Friend WithEvents btnChangeSource As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSavePassPhrase As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxHashType As System.Windows.Forms.ComboBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents tbcByteDisplay As System.Windows.Forms.TabControl
    Friend WithEvents tbpInputBytes As System.Windows.Forms.TabPage
    Friend WithEvents tbpOutputBytes As System.Windows.Forms.TabPage
    Friend WithEvents tbxOutBytes As System.Windows.Forms.TextBox

End Class
