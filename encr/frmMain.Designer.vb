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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbxInputBytes = New System.Windows.Forms.TextBox()
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
        Me.tbxOutputBytes = New System.Windows.Forms.TextBox()
        Me.tbpOptions = New System.Windows.Forms.TabPage()
        Me.clbOptions = New System.Windows.Forms.CheckedListBox()
        Me.tbxPassphrase = New System.Windows.Forms.TextBox()
        Me.tbxSourceFile = New System.Windows.Forms.TextBox()
        Me.tbcByteDisplay.SuspendLayout()
        Me.tbpInputBytes.SuspendLayout()
        Me.tbpOutputBytes.SuspendLayout()
        Me.tbpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxInputBytes
        '
        Me.tbxInputBytes.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInputBytes.Location = New System.Drawing.Point(0, 0)
        Me.tbxInputBytes.Multiline = True
        Me.tbxInputBytes.Name = "tbxInputBytes"
        Me.tbxInputBytes.ReadOnly = True
        Me.tbxInputBytes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxInputBytes.Size = New System.Drawing.Size(434, 275)
        Me.tbxInputBytes.TabIndex = 4
        '
        'btnSavePass
        '
        Me.btnSavePass.Enabled = False
        Me.btnSavePass.Location = New System.Drawing.Point(296, 36)
        Me.btnSavePass.Name = "btnSavePass"
        Me.btnSavePass.Size = New System.Drawing.Size(100, 20)
        Me.btnSavePass.TabIndex = 7
        Me.btnSavePass.Text = "Save..."
        Me.ttpInfo.SetToolTip(Me.btnSavePass, "Save Passphrase. UNSAFE!")
        Me.btnSavePass.UseVisualStyleBackColor = True
        '
        'btnChangeSource
        '
        Me.btnChangeSource.Location = New System.Drawing.Point(296, 8)
        Me.btnChangeSource.Name = "btnChangeSource"
        Me.btnChangeSource.Size = New System.Drawing.Size(100, 20)
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
        Me.cbxHashType.Location = New System.Drawing.Point(8, 64)
        Me.cbxHashType.Name = "cbxHashType"
        Me.cbxHashType.Size = New System.Drawing.Size(280, 21)
        Me.cbxHashType.TabIndex = 10
        Me.ttpInfo.SetToolTip(Me.cbxHashType, "Select the Hash Algorithm. Speeds according to http://www.cryptopp.com/benchmarks" & _
        ".html.")
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(296, 64)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(100, 22)
        Me.btnEncrypt.TabIndex = 11
        Me.btnEncrypt.Text = "Crypt."
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'tbcByteDisplay
        '
        Me.tbcByteDisplay.Controls.Add(Me.tbpInputBytes)
        Me.tbcByteDisplay.Controls.Add(Me.tbpOutputBytes)
        Me.tbcByteDisplay.Controls.Add(Me.tbpOptions)
        Me.tbcByteDisplay.Location = New System.Drawing.Point(8, 92)
        Me.tbcByteDisplay.Name = "tbcByteDisplay"
        Me.tbcByteDisplay.SelectedIndex = 0
        Me.tbcByteDisplay.Size = New System.Drawing.Size(388, 300)
        Me.tbcByteDisplay.TabIndex = 13
        '
        'tbpInputBytes
        '
        Me.tbpInputBytes.Controls.Add(Me.tbxInputBytes)
        Me.tbpInputBytes.Location = New System.Drawing.Point(4, 22)
        Me.tbpInputBytes.Name = "tbpInputBytes"
        Me.tbpInputBytes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInputBytes.Size = New System.Drawing.Size(436, 275)
        Me.tbpInputBytes.TabIndex = 0
        Me.tbpInputBytes.Text = "Input"
        Me.tbpInputBytes.UseVisualStyleBackColor = True
        '
        'tbpOutputBytes
        '
        Me.tbpOutputBytes.Controls.Add(Me.tbxOutputBytes)
        Me.tbpOutputBytes.Location = New System.Drawing.Point(4, 22)
        Me.tbpOutputBytes.Name = "tbpOutputBytes"
        Me.tbpOutputBytes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOutputBytes.Size = New System.Drawing.Size(436, 275)
        Me.tbpOutputBytes.TabIndex = 1
        Me.tbpOutputBytes.Text = "Output"
        Me.tbpOutputBytes.UseVisualStyleBackColor = True
        '
        'tbxOutputBytes
        '
        Me.tbxOutputBytes.BackColor = System.Drawing.SystemColors.Control
        Me.tbxOutputBytes.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOutputBytes.Location = New System.Drawing.Point(0, 0)
        Me.tbxOutputBytes.Multiline = True
        Me.tbxOutputBytes.Name = "tbxOutputBytes"
        Me.tbxOutputBytes.ReadOnly = True
        Me.tbxOutputBytes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxOutputBytes.Size = New System.Drawing.Size(434, 275)
        Me.tbxOutputBytes.TabIndex = 14
        '
        'tbpOptions
        '
        Me.tbpOptions.Controls.Add(Me.clbOptions)
        Me.tbpOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbpOptions.Name = "tbpOptions"
        Me.tbpOptions.Size = New System.Drawing.Size(380, 274)
        Me.tbpOptions.TabIndex = 2
        Me.tbpOptions.Text = "Options"
        Me.tbpOptions.UseVisualStyleBackColor = True
        '
        'clbOptions
        '
        Me.clbOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbOptions.FormattingEnabled = True
        Me.clbOptions.Items.AddRange(New Object() {"Allow short passphrases", "Warn on large files", "Remove existing *.encr extension", "Save to source folder", "Delete source (no undo!)"})
        Me.clbOptions.Location = New System.Drawing.Point(0, 0)
        Me.clbOptions.Name = "clbOptions"
        Me.clbOptions.Size = New System.Drawing.Size(380, 274)
        Me.clbOptions.TabIndex = 0
        '
        'tbxPassphrase
        '
        Me.tbxPassphrase.Location = New System.Drawing.Point(8, 36)
        Me.tbxPassphrase.Name = "tbxPassphrase"
        Me.tbxPassphrase.Size = New System.Drawing.Size(280, 20)
        Me.tbxPassphrase.TabIndex = 14
        '
        'tbxSourceFile
        '
        Me.tbxSourceFile.Location = New System.Drawing.Point(8, 8)
        Me.tbxSourceFile.Name = "tbxSourceFile"
        Me.tbxSourceFile.ReadOnly = True
        Me.tbxSourceFile.Size = New System.Drawing.Size(280, 20)
        Me.tbxSourceFile.TabIndex = 15
        Me.tbxSourceFile.Text = "Source File"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(402, 400)
        Me.Controls.Add(Me.tbxSourceFile)
        Me.Controls.Add(Me.tbxPassphrase)
        Me.Controls.Add(Me.tbcByteDisplay)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.cbxHashType)
        Me.Controls.Add(Me.btnChangeSource)
        Me.Controls.Add(Me.btnSavePass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.tbcByteDisplay.ResumeLayout(False)
        Me.tbpInputBytes.ResumeLayout(False)
        Me.tbpInputBytes.PerformLayout()
        Me.tbpOutputBytes.ResumeLayout(False)
        Me.tbpOutputBytes.PerformLayout()
        Me.tbpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxInputBytes As System.Windows.Forms.TextBox
    Friend WithEvents ttpInfo As System.Windows.Forms.ToolTip
    Friend WithEvents btnSavePass As System.Windows.Forms.Button
    Friend WithEvents btnChangeSource As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSavePassPhrase As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxHashType As System.Windows.Forms.ComboBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents tbcByteDisplay As System.Windows.Forms.TabControl
    Friend WithEvents tbpInputBytes As System.Windows.Forms.TabPage
    Friend WithEvents tbpOutputBytes As System.Windows.Forms.TabPage
    Friend WithEvents tbxOutputBytes As System.Windows.Forms.TextBox
    Friend WithEvents tbxPassphrase As System.Windows.Forms.TextBox
    Friend WithEvents tbxSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents tbpOptions As System.Windows.Forms.TabPage
    Friend WithEvents clbOptions As System.Windows.Forms.CheckedListBox

End Class
