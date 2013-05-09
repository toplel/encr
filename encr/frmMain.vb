Imports System.Security.Cryptography
Imports System.IO
Imports System.Math
Imports System.Text

Public Class frmMain


#Region "IO OPS"
    Private _currentHash As Hash
    Private _sourceBytes() As Byte
    Private _outBytes() As Byte

    Private _passphrase() As Byte
    Private _passphraseHash() As Byte
    Private _passphraseSeed As Integer

    Enum Hash As Integer
        MD5 = 0
        RIPEMD160 = 1
        SHA1 = 2
        SHA256 = 3
        SHA384 = 4
        SHA512 = 5
    End Enum

    Private Sub loadFile(_fileName As String)
        Try
            Dim _fileStream As New FileStream(_fileName, FileMode.Open)
            Dim _binaryReader As BinaryReader = New BinaryReader(_fileStream)
            _sourceBytes = _binaryReader.ReadBytes(DirectCast(_fileStream.Length, Int64))

#If DEBUG Then 'SHOW THE LOADED FILE'S SIZE IN BYTES
            MsgBox(_sourceBytes.LongLength)
#End If

        Catch _e As Exception
            handleErrors(_e)
        End Try
    End Sub

    Private Sub saveFile(_fileName As String)
        If Not IsNothing(_outBytes) Then
            Try
                Dim _fileStream As New FileStream(_fileName, FileMode.Create)
                Dim _binaryReader As BinaryReader = New BinaryReader(_fileStream)
                _fileStream.Write(_outBytes, 0, _outBytes.Length)
                _fileStream.Close()

#If DEBUG Then 'SHOW THE LOADED FILE'S SIZE IN BYTES
                MsgBox(_outBytes.LongLength)
#End If

            Catch _e As Exception
                handleErrors(_e)
            End Try
        End If
    End Sub

    Private Sub handleErrors(_error As Exception)
        'THIS DOES NOT HANDLE THE ERRORS! IT'S A DEBUGGING HELP TO FEEDBACK EXCEPTIONS TO THE DEVELOPPER.
#If DEBUG Then
        MsgBox(_error.ToString, MsgBoxStyle.Critical, "Errors Occured!")
#Else
        MsgBox("An error occured, the programm could not complete the last action.", MsgBoxStyle.Critical, "Errors Occured!")
#End If
        'LOGGING GOES HERE.
        'LOGGING IS UNSAFE
    End Sub

#End Region


#Region "ACTUAL ENCRYPTION PROCESS"

    Private Function hashSomething(_someThing As Byte()) As Byte()
        Select Case _currentHash
            Case Hash.MD5
                Dim _MD5 As New MD5Cng
                Return _MD5.ComputeHash(_someThing)
            Case Hash.RIPEMD160
                Dim _RIPEMD160 As New RIPEMD160Managed
                Return _RIPEMD160.ComputeHash(_someThing)
            Case Hash.SHA1
                Dim _SHA1 As New SHA1Cng
                Return _SHA1.ComputeHash(_someThing)
            Case Hash.SHA256
                Dim _sha256 As New SHA256Cng
                Return _sha256.ComputeHash(_someThing)
            Case Hash.SHA384
                Dim _sha384 As New SHA384Cng
                Return _sha384.ComputeHash(_someThing)
            Case Hash.SHA512
                Dim _sha512 As New SHA512Cng
                Return _sha512.ComputeHash(_someThing)
                'Case ... ' CALL OTHER HASH FUNCTIONS HERE
        End Select
    End Function

    Private Sub encrypt()
        lockUI(True)
        _passphraseHash = hashSomething(_passphrase)

        Dim _seed(3) As Byte 'THIS IS RIDICULOUSLY STUPID, THIS HAS TO BE CHANGED!!!
        _seed(0) = _passphrase(0) 'BUT WHATEVER, LET'S GET THIS RUNNING FIRST.
        _seed(1) = _passphrase(1)
        _seed(2) = _passphrase(_passphrase.Length - 2)
        _seed(3) = _passphrase(_passphrase.Length - 1)

        Dim _seedInt As Int32 = BitConverter.ToInt32(_seed, 0)

        Dim _keyBytes() As Byte

        Dim _chunkKey() As Byte 'THIS IS UGLY.

        Array.Resize(_outBytes, _sourceBytes.Length)
        _outBytes.Initialize()

        For _x As Int32 = 0 To Ceiling(_sourceBytes.Length / _passphraseHash.Length) 'BUILD THE KEY BYTES.

            _seedInt += _passphraseHash(_x Mod _passphraseHash.Length)
            _chunkKey = hashSomething(BitConverter.GetBytes(_seedInt))

            If Not IsNothing(_keyBytes) Then 'THIS IS UGLY AS F**K
                Dim _keyBytesOldLength As Integer
                _keyBytesOldLength = _keyBytes.Length
                Array.Resize(_keyBytes, _keyBytesOldLength + _chunkKey.Length)
                Array.Copy(_chunkKey, 0, _keyBytes, _keyBytesOldLength, _chunkKey.Length)
            Else 'ONLY FOR THE FIRST LOOP
                _keyBytes = _chunkKey
            End If

            'If _x Mod 131072 = 0 Then updateProgressBar(_x / Ceiling(_sourceBytes.Length / _passphraseHash.Length)) 'SLOOOOW
            Application.DoEvents()  'DON'T F**KIN FREEZE!
        Next

#If DEBUG Then
        MsgBox(_keyBytes.Length)
        MsgBox(_sourceBytes.Length)
#End If

        For _x As Int64 = 0 To _sourceBytes.Length - 1 'XOR THE KEY AND THE SOURCE
            Dim _sourceByte As Byte = _sourceBytes(_x)
            Dim _keyByte As Byte = _keyBytes(_x)
            _outBytes(_x) = _sourceByte Xor _keyByte
            'If _x Mod 131072 = 0 Then updateProgressBar(_x / _sourceBytes.Length) 'SLOOOOW
            Application.DoEvents() 'DON'T F**KIN FREEZE!
        Next

#If DEBUG Then
        MsgBox(_outBytes.Length)
        MsgBox(_sourceBytes.Length)
#End If

        saveFile(ofdOpenFile.FileName & ".encr")
        updateProgressBar(0)
        lockUI(False)
    End Sub


#End Region


#Region "UI INTERACTION"


    Private Sub cbxHashType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxHashType.SelectedIndexChanged
        _currentHash = cbxHashType.SelectedIndex


#If DEBUG Then 'SHOW THE HASH NAME ON CHANGE. COMPLETELY USELESS.
        MsgBox(_currentHash.ToString)
#End If


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxHashType.SelectedIndex = 0

    End Sub

    Private Sub btnChangeSource_Click(sender As Object, e As EventArgs) Handles btnChangeSource.Click

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not ofdOpenFile.FileName = "" Then
                lblInputDirectory.Text = ofdOpenFile.FileName
                loadFile(ofdOpenFile.FileName)
            End If
        End If
    End Sub

    Private Sub updateProgressBar(_progress As Single)
        pbrProgress.Value = Int(pbrProgress.Maximum * _progress)
    End Sub

    Private Sub lockUI(_lock As Boolean)
        If _lock = True Then
            btnChangeSource.Enabled = False
            btnEncrypt.Enabled = False
            cbxHashType.Enabled = False
        Else
            btnChangeSource.Enabled = True
            btnEncrypt.Enabled = True
            cbxHashType.Enabled = True
        End If
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        If Not IsNothing(_sourceBytes) Then
            If Not tbxPassphrase.Text = "" Then
                encrypt()
            End If
        End If
    End Sub

    Private Sub tbxPassphrase_TextChanged(sender As Object, e As EventArgs) Handles tbxPassphrase.TextChanged
        _passphrase = Encoding.UTF8.GetBytes(tbxPassphrase.Text)
    End Sub

#End Region

End Class
