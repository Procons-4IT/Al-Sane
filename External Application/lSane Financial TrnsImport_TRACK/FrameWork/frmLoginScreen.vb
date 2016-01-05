Imports System.IO
Imports System.Diagnostics.Process
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLoginScreen
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If

        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReferesh As System.Windows.Forms.Button
    Friend WithEvents txtServerPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtDBUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cmbCompanyDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyPWD As System.Windows.Forms.TextBox
    Friend WithEvents txtSBOUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    '  Friend WithEvents Show_Click As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents fldFolderBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LocalLicenseServer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbServertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbServertype = New System.Windows.Forms.ComboBox
        Me.btnReferesh = New System.Windows.Forms.Button
        Me.txtServerPwd = New System.Windows.Forms.TextBox
        Me.txtDBUserName = New System.Windows.Forms.TextBox
        Me.txtServerName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LocalLicenseServer = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDirectory = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.cmbCompanyDB = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCompanyPWD = New System.Windows.Forms.TextBox
        Me.txtSBOUserName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.fldFolderBrowse = New System.Windows.Forms.FolderBrowserDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label16)
        Me.Frame1.Controls.Add(Me.cmbServertype)
        Me.Frame1.Controls.Add(Me.btnReferesh)
        Me.Frame1.Controls.Add(Me.txtServerPwd)
        Me.Frame1.Controls.Add(Me.txtDBUserName)
        Me.Frame1.Controls.Add(Me.txtServerName)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(327, 158)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Local Server Details"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(15, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Server Type"
        '
        'cmbServertype
        '
        Me.cmbServertype.Items.AddRange(New Object() {"2005", "2008"})
        Me.cmbServertype.Location = New System.Drawing.Point(132, 98)
        Me.cmbServertype.Name = "cmbServertype"
        Me.cmbServertype.Size = New System.Drawing.Size(152, 22)
        Me.cmbServertype.TabIndex = 21
        '
        'btnReferesh
        '
        Me.btnReferesh.Location = New System.Drawing.Point(121, 127)
        Me.btnReferesh.Name = "btnReferesh"
        Me.btnReferesh.Size = New System.Drawing.Size(163, 23)
        Me.btnReferesh.TabIndex = 4
        Me.btnReferesh.Text = "Refresh/Update Company List"
        '
        'txtServerPwd
        '
        Me.txtServerPwd.Location = New System.Drawing.Point(132, 72)
        Me.txtServerPwd.Name = "txtServerPwd"
        Me.txtServerPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtServerPwd.Size = New System.Drawing.Size(152, 20)
        Me.txtServerPwd.TabIndex = 3
        '
        'txtDBUserName
        '
        Me.txtDBUserName.Location = New System.Drawing.Point(132, 48)
        Me.txtDBUserName.Name = "txtDBUserName"
        Me.txtDBUserName.Size = New System.Drawing.Size(152, 20)
        Me.txtDBUserName.TabIndex = 2
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(132, 24)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(152, 20)
        Me.txtServerName.TabIndex = 1
        Me.txtServerName.Text = "(local)"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = " User Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Server"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.LocalLicenseServer)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDirectory)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.cmbCompanyDB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCompanyPWD)
        Me.GroupBox1.Controls.Add(Me.txtSBOUserName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(331, 177)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'LocalLicenseServer
        '
        Me.LocalLicenseServer.Location = New System.Drawing.Point(136, 16)
        Me.LocalLicenseServer.Name = "LocalLicenseServer"
        Me.LocalLicenseServer.Size = New System.Drawing.Size(152, 20)
        Me.LocalLicenseServer.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(16, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 20)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "SBO License Server"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Log Directory"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(132, 119)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(152, 20)
        Me.txtDirectory.TabIndex = 17
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(285, 118)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "..."
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(93, 148)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(152, 23)
        Me.btnConnect.TabIndex = 10
        Me.btnConnect.Text = "Test Local Connection"
        '
        'cmbCompanyDB
        '
        Me.cmbCompanyDB.Location = New System.Drawing.Point(132, 42)
        Me.cmbCompanyDB.Name = "cmbCompanyDB"
        Me.cmbCompanyDB.Size = New System.Drawing.Size(152, 22)
        Me.cmbCompanyDB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Company DB"
        '
        'txtCompanyPWD
        '
        Me.txtCompanyPWD.Location = New System.Drawing.Point(132, 92)
        Me.txtCompanyPWD.Name = "txtCompanyPWD"
        Me.txtCompanyPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCompanyPWD.Size = New System.Drawing.Size(152, 20)
        Me.txtCompanyPWD.TabIndex = 7
        '
        'txtSBOUserName
        '
        Me.txtSBOUserName.Location = New System.Drawing.Point(132, 68)
        Me.txtSBOUserName.Name = "txtSBOUserName"
        Me.txtSBOUserName.Size = New System.Drawing.Size(152, 20)
        Me.txtSBOUserName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SBO User Name"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1, Me.MenuItem3})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Service Log File"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "BP Log File"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Exit"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 399)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Export Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(144, 399)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmLoginScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(341, 430)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmLoginScreen"
        Me.Text = "Choose Company Database"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region "Declaration"
    Public oCompany As SAPbobsCOM.Company
    Public oTarget As SAPbobsCOM.Company
    Public localcurrency, systemcurrency As String
    Dim objPC = New clsMain
    Dim sValue As String
    Dim sPath As String

#End Region

#Region "API Calls"

    '****************************************************************************
    'Type              :   Function     
    'Name              :   WritePrivateProfileString
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   Standard API declarations for INI access
    '****************************************************************************

    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
#End Region

#Region "Function for Read INI File"

    '****************************************************************************
    'Type              :   Function    
    'Name              :   INIRead
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To Read INI File
    '****************************************************************************

    Public Overloads Function INIRead(ByVal INIPath As String, _
        ByVal SectionName As String, ByVal KeyName As String, _
        ByVal DefaultValue As String) As String
        Dim n As Int32
        Dim sData As String
        sData = Space$(1024)
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
        sData, sData.Length, INIPath)
        If n > 0 Then
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
        End If
    End Function
#End Region

#Region "To Read INI File"

    '****************************************************************************
    'Type              :   Function     
    'Name              :   INIRead
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To Read INI File
    '****************************************************************************

    Public Overloads Function INIRead(ByVal INIPath As String, _
    ByVal SectionName As String, ByVal KeyName As String) As String
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    Public Overloads Function INIRead(ByVal INIPath As String, _
    ByVal SectionName As String) As String
        ' overload 2 returns all keys in a given section of the given file 
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    Public Overloads Function INIRead(ByVal INIPath As String) As String
        ' overload 3 returns all section names given just path 
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function
#End Region

#Region "To write INI File"

    '****************************************************************************
    'Type              :   Procedure     
    'Name              :   INIWrite
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To write INI File 
    '****************************************************************************

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, _
       ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    Public Overloads Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, _
    ByVal KeyName As String) ' delete single line from section 
        Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    End Sub

    Public Overloads Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        ' delete section from INI file 
        Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    End Sub


#End Region

#Region "To Save Details in ini File"
    '****************************************************************************
    'Type              :   Procedure     
    'Name              :   WriteiniFile
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To Save Details in ini File
    '****************************************************************************
    Private Sub WriteiniFile()
        sPath = System.Windows.Forms.Application.StartupPath & "\ConnectionInfo.ini"
        INIWrite(sPath, "SqlServer", "Key1-1", txtServerName.Text) ' build INI file 
        INIWrite(sPath, "SQLUID", "Key1-2", txtDBUserName.Text)
        INIWrite(sPath, "SQLPWD", "Key1-3", txtServerPwd.Text)
        INIWrite(sPath, "ServerType", "Key1-S1", strLocalServertype)
        INIWrite(sPath, "SAPCompany", "Key1-4", strSAPCompany) ' cmbCompanyDB.SelectedText)
        INIWrite(sPath, "SAPUID", "Key1-5", txtSBOUserName.Text)
        INIWrite(sPath, "SAPPWD", "Key1-6", txtCompanyPWD.Text)
        INIWrite(sPath, "LogFile", "Key1-9", txtDirectory.Text)
        INIWrite(sPath, "LocalLicense", "Key1-17", LocalLicenseServer.Text)
    End Sub

#End Region

#Region "To Read ini File"

    '****************************************************************************
    'Type              :   Procedure     
    'Name              :   ReadiniFile
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To Read ini File
    '****************************************************************************

    Private Sub ReadiniFile()
        sPath = System.Windows.Forms.Application.StartupPath & "\ConnectionInfo.ini"
        sValue = INIRead(sPath, "SqlServer", "key1-1", "")
        txtServerName.Text = sValue
        strSQLServer = sValue
        sValue = INIRead(sPath, "SQLUID", "Key1-2", "")
        txtDBUserName.Text = sValue
        strSQLUID = sValue
        sValue = INIRead(sPath, "SQLPWD", "Key1-3", "")
        txtServerPwd.Text = sValue
        strSQLPWD = sValue

        sValue = INIRead(sPath, "ServerType", "Key1-S1", "")
        cmbServertype.Text = sValue
        strLocalServertype = sValue

        sValue = INIRead(sPath, "SAPCompany", "Key1-4", "")
        cmbCompanyDB.SelectedText = sValue
        strSAPCompany = sValue
        sValue = INIRead(sPath, "SAPUID", "Key1-5", "")
        txtSBOUserName.Text = sValue
        strSAPUID = sValue
        sValue = INIRead(sPath, "SAPPWD", "Key1-6", "")
        txtCompanyPWD.Text = sValue
        strSAPPWD = sValue
        strSAPPWD = sValue
        sValue = INIRead(sPath, "ImportDir", "Key1-7", "")
        '  txtDirectory.Text = sValue
        strExportFilePaty = sValue
        strExportDirectory = sValue
        'sValue = INIRead(sPath, "ExportFile", "Key1-8", "")
        'strFileStart = sValue
        sValue = INIRead(sPath, "LogFile", "Key1-9", "")
        strErrorLogPath = sValue
        txtDirectory.Text = strErrorLogPath

        sValue = INIRead(sPath, "LocalLicense", "Key1-17", "")
        LocalLicenseServer.Text = sValue
        strLocalLicensserver = sValue

        sValue = INIRead(sPath, "Email_FromAddress", "Key1-18", "")
        Email_FromAddress = sValue

        sValue = INIRead(sPath, "Email_ToAddres", "Key1-19", "")
        Email_ToAddres = sValue

        'sValue = INIRead(sPath, "Email_CCAddres", "Key1-22", "")
        'Email_CCAddres = sValue


        sValue = INIRead(sPath, "Email_ExchangeServer", "Key1-20", "")
        Email_ExchangeServer = sValue

        sValue = INIRead(sPath, "EmailOption", "Key1-21", "")
        If sValue = "0" Then
            blnEmail = False
        Else
            blnEmail = True
        End If

    End Sub

#End Region

#Region "Get DBInformation from XML"

    '****************************************************************************
    'Type              :   Function     
    'Name              :   GetConInfo
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To Get DBInformation from XML
    '****************************************************************************

    Public Function GetConInfo() As String
        Dim objXMLDoc As New System.Xml.XmlDocument
        Dim objNode As Xml.XmlNode
        Dim intLoop As Integer
        Dim strConn, strserver, strDb, strUID, strPwd As String
        objXMLDoc.Load(System.Windows.Forms.Application.StartupPath & "\ConnectionInfo.xml")
        With objXMLDoc.GetElementsByTagName("Parameter")
            For intLoop = 0 To .Count - 1
                objNode = .Item(intLoop)
                If objNode.Attributes("Type").Value = "SBOServer" Then
                    strserver = objNode.Attributes("Value").Value
                ElseIf objNode.Attributes("Type").Value = "Database" Then
                    strDb = objNode.Attributes("Value").Value
                ElseIf objNode.Attributes("Type").Value = "DBUser" Then
                    strUID = objNode.Attributes("Value").Value
                ElseIf objNode.Attributes("Type").Value = "DBPass" Then
                    strPwd = objNode.Attributes("Value").Value
                End If
            Next
        End With
        strConn = "Database=" & strDb & ";Server=" & strserver & ";uid=" & strUID & ";Pwd=" & strPwd & ";"
        Return strConn
    End Function


#End Region

#Region "Events"

    Private Sub frmLoginScreen_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub frmLoginScreen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        System.GC.Collect()
        End
    End Sub

#Region "Check Duplicate process"
    Private Function CheckDuplicateProcess() As Boolean
        Dim MatchingNames As System.Diagnostics.Process()
        Dim TargetName As String
        TargetName = System.Diagnostics.Process.GetCurrentProcess.ProcessName

        MatchingNames = System.Diagnostics.Process.GetProcessesByName(TargetName)
        If (MatchingNames.Length = 1) Then
            Return True

        Else
            Return False
        End If



    End Function

    Public Function PrevInstance() As Boolean
        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

    Function SendInvoiceEmail(ByVal ToAddress As String, ByVal Subject As String, ByVal Body As String, ByVal afilename As String) As Boolean
        Try
            ReadiniFile()
            Dim mm As New System.Net.Mail.MailMessage(Email_FromAddress, ToAddress)
            mm.Subject = Subject
            mm.Body = Body
            mm.IsBodyHtml = False
            If Email_BCCAddres <> "" Then
                mm.Bcc.Add(Email_BCCAddres)
            End If
            Dim atta As New System.Net.Mail.Attachment(afilename)
            mm.Attachments.Add(atta)
            Dim smtp As New System.Net.Mail.SmtpClient
            smtp.Host = Email_ExchangeServer
            smtp.Send(mm)
        Catch ex As Exception
            WriteErrorlog("Error Occured:Invoice sending ", strErrorFileName)
            Return False
        End Try
        Return True
    End Function

    '****************************************************************************
    'Type              :   Procedure     
    'Name              :   
    'Parameter         :   
    'Return Value      : 
    'Author            :   DEV-3
    'Created Date      :   
    'Last Modified By  : 
    'Modified Date     : 
    'Purpose           :   To Handle Events
    '****************************************************************************
    Private Sub frmLoginScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strPath, strFilename, strMessage As String
        Try
            If CheckDuplicateProcess() = False Then
                End
            End If
            '  End
            ReadiniFile()
            strPath = strErrorLogPath ' System.Windows.Forms.Application.StartupPath
            If Directory.Exists(strErrorLogPath) Then
            Else
                Directory.CreateDirectory(strErrorLogPath)
            End If
            If Not Directory.Exists(strExportDirectory) Then
                Directory.CreateDirectory(strExportDirectory)
            End If
            'WMS_Import_20110221_Monday.txt
            Dim stdate, stday, strTime, strFileName1 As String
            'stdate = Now.ToString("yyyyMMdd")
            'stday = Now.ToString("dddd")
            'strFilename = Now.ToLongDateString
            'strFilename = stdate & "_" & stday

            strTime = Now.ToShortTimeString.Replace(":", "")
            strFileName1 = Now.Date.ToString("dd-MM-yyyy")
            strFileName1 = strFileName1 ' & strTime

            strPath = strPath & "\ALSane_Import_" & strFileName1 & ".txt"
            strErrorFileName = strPath
            WriteErrorHeader(strPath, "Process Starting..")
            If connectLocalCompany() = False Then
                strMessage = ("Connection to SAP B1 failed. Check the ConnectionInfo.ini ")
                WriteErrorlog(strMessage, strPath)
                End
            Else
                sPath = strErrorFileName
                Me.Hide()
                Me.Hide()
                WriteErrorlog("Import Processing...", sPath)
                Try
                    'export()
                    Import()
                Catch ex As Exception
                    strMessage = (ex.Message)
                    WriteErrorlog(strMessage, sPath)
                End Try
               
                'WriteErrorlog("Export Mater Data Completed", sPath)
                'WriteErrorlog("Export Documents Started...", sPath)
                'Try
                '    ExportDocuments()
                'Catch ex As Exception
                '    strMessage = (ex.Message)
                '    WriteErrorlog(strMessage, strPath)
                'End Try

                ' WriteErrorlog("Export Documents Completed", sPath)
                sPath = strErrorFileName
                WriteErrorlog("Export Process Completed", sPath)
                End
            End If
        Catch ex As Exception
            strMessage = (ex.Message)
            WriteErrorlog(strMessage, strErrorFileName)
            'MsgBox(strMessage)
            End
        End Try
    End Sub

#Region "Check the Filepaths"
    Private Function ValidateFilePaths() As Boolean
        Dim strMessage, strpath, strFilename As String
        strpath = strErrorLogPath ' System.Windows.Forms.Application.StartupPath

        If Directory.Exists(strpath) = False Then
            strMessage = "Error Log file direcory does not exists. check the connectionInfo.ini"
            MsgBox(strMessage)
            Return False
        End If


        If Directory.Exists(strpath) = False Then
            Directory.CreateDirectory(strpath)
            'strMessage = ("Export Directory does not exist. Check the connectionInfo.ini")
            'WriteErrorlog(strMessage, strpath)
            'MsgBox(strMessage)
            'Return False
        End If

        strFilename = Now.ToLongDateString



        If Directory.Exists(strExportFilePaty) = False Then
            strMessage = ("Export Directory does not exist. Check the connectionInfo.ini")
            WriteErrorlog(strMessage, strpath)
            MsgBox(strMessage)
            Return False
        End If
        'If strFileStart = "" Then
        '    strMessage = "Export File Name is missing"
        '    MsgBox(strMessage)
        '    Return False
        'End If

        Return True
    End Function
#End Region

#Region "Import WMS Implementation Files"

#Region "Import"
    'Private Sub Import()
    '    Dim strvalue, strTime, strFileName1 As String
    '    Dim stpath As String
    '    ReadiniFile()
    '    stpath = strExportDirectory
    '    strTime = Now.ToShortTimeString.Replace(":", "")
    '    strFileName1 = Now.Date.ToString("ddMMyyyy")
    '    strFileName1 = strFileName1 & strTime
    '    strImportErrorLog = strErrorLogPath 
    '    If Directory.Exists(strImportErrorLog) = False Then
    '        Directory.CreateDirectory(strImportErrorLog)
    '    End If
    '    strImportErrorLog = strImportErrorLog & "\Import_" & strFileName1 & ".txt"
    '    WriteErrorHeader(strImportErrorLog, "Import Reading files Processing...")
    '    Try
    '        If ReadImportFiles() = False Then
    '            End
    '        End If
    '    Catch ex As Exception
    '        '  oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
    '        ' Exit Sub
    '    End Try
    '    WriteErrorHeader(strImportErrorLog, "Import Reading files Process Completed....")
    '    WriteErrorHeader(strImportErrorLog, "Document Creation Processing...")
    '    ImportASNFiles(stpath, objMainCompany)
    '    ImportADJFiles(stpath, objMainCompany)
    '    ImportSOFiles(stpath, objMainCompany)
    '    ImportHOLDFiles(stpath, objMainCompany)
    '    WriteErrorHeader(strImportErrorLog, "Document Creation Process Completed....")
    'End Sub

    Private Function getCompany(ByVal strCompany As String, ByVal strUID As String, ByVal strPWD As String) As Boolean
        sPath = strErrorLogPath
        oTarget = New SAPbobsCOM.Company
        Try
            ReadiniFile()

            oCompany = New SAPbobsCOM.Company
            oCompany.Server = strSQLServer
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
            If strLocalServertype = "2005" Then
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2005
            Else
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
            End If

            oCompany.LicenseServer = LocalLicenseServer.Text ' "Compaq-PC:30000"
            oCompany.DbUserName = strSQLUID
            oCompany.DbPassword = strSQLPWD
            oCompany.CompanyDB = strCompany
            oCompany.UserName = strUID
            oCompany.Password = strPWD

            ' sPath = strErrorFileName

            ' WriteErrorlog("Connection to local SAP B1 server started", sPath)
            If oCompany.Connected = True Then
                If (objPC.Initialise(oCompany)) Then
                Else
                    'MsgBox("Error in Connection")
                    WriteErrorlog("Error in Connection to Local Server", sPath)
                    Return False
                End If
                ' WriteiniFile()
                oTarget = oCompany

                Return True
            Else
                If oCompany.Connect <> 0 Then
                    'MsgBox("Connection to SAP B1 failed. Error Description :" & oCompany.GetLastErrorDescription)
                    WriteErrorlog("Connection to Local SAP B1  Company :  " & cmbCompanyDB.Text & " failed : Error Description :" & oCompany.GetLastErrorDescription, sPath)
                    Return False
                Else
                    ' WriteiniFile()
                    '     MsgBox("Local SAP B1 Company Connected successfully")
                    sPath = strErrorFileName
                    ' WriteErrorlog("Local SAP B1 Company :  " & cmbCompanyDB.Text & " Company Connected successfully", sPath)
                    oTarget = oCompany
                    'oTarget = objRemoteCompany
                    Return True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteErrorlog(ex.Message, sPath)
            Return False
        End Try
        Return True
    End Function
    Private Sub Import()
        Dim strvalue As String
        Dim stpath, strComp, strUID, strpwd As String
        Try
            
            Dim strTime, strFileName1 As String
            ReadiniFile()
            stpath = strExportDirectory
            stpath = strExportDirectory
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFileName1 = Now.Date.ToString("ddMMyyyy")
            strFileName1 = strFileName1 ' & strTime
            strImportErrorLog = strErrorLogPath
            strImportErrorLog = strErrorFileName

            'If Directory.Exists(strImportErrorLog) = False Then
            '    Directory.CreateDirectory(strImportErrorLog)
            'End If
            strImportErrorLog = strImportErrorLog ' & "\ALSane_Import_" & strFileName1 & ".txt"
            WriteErrorHeader(strImportErrorLog, "Import Reading files Processing...")
            Try
                If ReadImportFiles(strImportErrorLog) = False Then
                    Try
                        SendInvoiceEmail(Email_ToAddres, "Import Log fle", "Import Log File", strErrorFileName)
                    Catch ex As Exception
                    End Try
                    End
                End If
            Catch ex As Exception
            End Try
            WriteErrorHeader(strImportErrorLog, "Import Reading files Process Completed....")
            Try
                SendInvoiceEmail(Email_ToAddres, "Import Log fle", "Import Log File", strErrorFileName)
            Catch ex As Exception
            End Try
            End
            'WriteErrorHeader(strImportErrorLog, "Document Creation Processing...")
            'Dim otemprs As SAPbobsCOM.Recordset
            'otemprs = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            'otemprs.DoQuery("Select * from [@Z_DBMapping] order by Convert(Numeric,Code) ")
            'If otemprs.RecordCount > 0 Then
            '    For intRow As Integer = 0 To otemprs.RecordCount - 1
            '        strComp = otemprs.Fields.Item("U_DBName").Value
            '        strUID = otemprs.Fields.Item("U_SAPUID").Value
            '        strpwd = otemprs.Fields.Item("U_SAPPWD").Value
            '        If getCompany(strComp, strUID, strpwd) = True Then
            '            objRemoteCompany = oTarget
            '            WriteErrorlog("Database Name :==> " & objRemoteCompany.CompanyDB, strErrorFileName)
            '            objRemoteCompany = oTarget
            '            Try
            '                ImportSOFiles(stpath, objRemoteCompany)
            '            Catch ex As Exception
            '            End Try

            '            Try
            '                ImportSOSTFiles(stpath, objRemoteCompany)
            '            Catch ex As Exception
            '            End Try
            '            Try
            '                ImportASNFiles(stpath, objRemoteCompany)
            '            Catch ex As Exception
            '            End Try
            '            Try
            '                ImportADJFiles(stpath, objRemoteCompany)
            '            Catch ex As Exception
            '            End Try

            '            Try
            '                ImportHOLDFiles(stpath, objRemoteCompany)
            '            Catch ex As Exception
            '            End Try

            '        End If
            '        otemprs.MoveNext()
            '    Next
            'Else
            '    If 1 = 1 Then
            '        objMainCompany = objMainCompany
            '        WriteErrorlog("Database Name :==> " & objMainCompany.CompanyDB, strErrorFileName)
            '        Try
            '            ImportSOFiles(stpath, objMainCompany)
            '        Catch ex As Exception
            '        End Try
            '        Try
            '            ImportASNFiles(stpath, objMainCompany)
            '        Catch ex As Exception
            '        End Try
            '        Try
            '            ImportADJFiles(stpath, objMainCompany)
            '        Catch ex As Exception
            '        End Try

            '        Try
            '            ImportHOLDFiles(stpath, objMainCompany)
            '        Catch ex As Exception
            '        End Try
            '    End If
            'End If
            ' WriteErrorHeader(strImportErrorLog, "Document Creation Process Completed....")

        Catch ex As Exception
            ' oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub
#End Region

#Region "Validate Folder path"
    Private Function validateFolderPaths(ByVal aPath As String, ByVal choice As String) As Boolean
        Dim strFolder As String
        Select Case choice
           
            Case "UDT"
                strFolder = aPath & "\Import\XSO_Export"
                If Directory.Exists(aPath & "\Import\XSO_Export") = False Then
                    WriteErrorlog("Folder does not exist: " & strFolder, strImportErrorLog)
                    Return False
                End If
                strFolder = aPath & "\Import\XASN_Export"
                If Directory.Exists(strFolder) = False Then
                    WriteErrorlog("Folder does not exist: " & strFolder, strImportErrorLog)
                End If
                strFolder = aPath & "\Import\XINV_Export"
                If Directory.Exists(strFolder) = False Then
                   WriteErrorlog("Folder does not exist: " & strFolder, strImportErrorLog)
                End If
                strFolder = aPath & "\Import\XHOL_Export"
                If Directory.Exists(strFolder) = False Then
                    WriteErrorlog("Folder does not exist: " & strFolder, strImportErrorLog)
                End If
        End Select
        Return True
    End Function
#End Region

#Region "Read Import files"
    Private Function ReadImportFiles(ByVal aPath As String) As Boolean
        Dim strvalue As String
        Dim stpath, strImpLogFolder As String
        ' strImpLogFolder = System.Windows.Forms.Application.StartupPath & "\ImportLog.txt"
        strImpLogFolder = strImportErrorLog
        stpath = strExportDirectory
        'If validateFolderPaths(stpath, "UDT") = False Then
        '    Return False
        'End If
        sPath = aPath
        Try
        
            ReadALSane(stpath, sPath)
        Catch ex As Exception

        End Try




        Return True
    End Function
#Region "Get MaxCode"
    Public Function getMaxCode(ByVal sTable As String, ByVal sColumn As String) As String
        Dim oRS As SAPbobsCOM.Recordset
        Dim MaxCode As Integer
        Dim sCode As String
        Dim strSQL As String
        Try
            strSQL = "SELECT MAX(CAST(" & sColumn & " AS Numeric)) FROM [" & sTable & "]"
            ExecuteSQL(oRS, strSQL)

            If Convert.ToString(oRS.Fields.Item(0).Value).Length > 0 Then
                MaxCode = oRS.Fields.Item(0).Value + 1
            Else
                MaxCode = 1
            End If

            sCode = Format(MaxCode, "00000000")
            Return sCode
        Catch ex As Exception
            Throw ex
        Finally
            oRS = Nothing
        End Try
    End Function
#Region "Execute Query"
    Public Sub ExecuteSQL(ByRef oRecordSet As SAPbobsCOM.Recordset, ByVal SQL As String)
        Try
            If oRecordSet Is Nothing Then
                oRecordSet = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            End If

            oRecordSet.DoQuery(SQL)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#End Region
#Region "GetDatetimevalue"
    Public Function GetDateTimeValue(ByVal DateString As String) As DateTime
        Dim objBridge As SAPbobsCOM.SBObob
        objBridge = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
        Return objBridge.Format_StringToDate(DateString).Fields.Item(0).Value
    End Function

#End Region

    Private Sub readSOImport(ByVal aFolderpath As String, ByVal aPath As String)
        Dim di As New IO.DirectoryInfo(aFolderpath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.txt")
        Dim fi As IO.FileInfo
        Dim strStorekey, strSokey, strSuccessFile, strErrorFile, strsuccessfolder, strErrorfolder, strLineno, strImpDocType, strType, strdate, strOrderKey, strShipdate, strSKU, strQty, strbatch, strmfgdate, strexpdate as String 
        Dim dtShipdate, dtMfrDate, dtExpDate As Date
        Dim sr As IO.StreamReader
        Dim YEAR, MONTH, DAY, DATE1, strFilename, linje As String
        Dim oDelrec As SAPbobsCOM.Recordset
        Try
            strImportErrorLog = strErrorFileName
            WriteErrorlog("Reading shipment files...", strImportErrorLog)
            strsuccessfolder = aFolderpath
            strsuccessfolder = aFolderpath & "\Success"
            strErrorfolder = aFolderpath & "\Error"
            If Directory.Exists(strsuccessfolder) = False Then
                Directory.CreateDirectory(strsuccessfolder)
            End If
            If Directory.Exists(strErrorfolder) = False Then
                Directory.CreateDirectory(strErrorfolder)
            End If
            For Each fi In aryFi
                strFilename = fi.FullName
                strSuccessFile = strsuccessfolder & "\" & fi.Name
                strErrorFile = strErrorfolder & "\" & fi.Name
                sr = New StreamReader(fi.FullName, System.Text.Encoding.Default) 'IO.File.OpenText(fil)
                sPath = aPath
                Dim strLIneStrin As String()
                Try
                   ' WriteErrorlog("Reading Shipment File Processing...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Reading Shipment File Processing...File Name : " & fi.Name, strImportErrorLog)
                    'oApplication.Utilities.WriteErrorlog("File Name : " & fi.Name, sPath)
                    Dim oRec, oRecUpdate As SAPbobsCOM.Recordset
                    oRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oRecUpdate = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oRec.DoQuery("Select * from [@Z_DABT_XSO] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    If oRec.RecordCount > 0 Then
                        oRec.DoQuery("Delete  from [@Z_DABT_XSO] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    End If
                    Do While (sr.Peek <> -1)
                        linje = ""
                        linje = sr.ReadLine()
                        strLIneStrin = linje.Split(vbTab)
                        If strLIneStrin.Length > 0 Then
                            strStorekey = strLIneStrin.GetValue(0)
                            strSokey = strLIneStrin.GetValue(1)
                            strType = strLIneStrin.GetValue(2)
                            If strType = "R" Then
                                strImpDocType = "R"
                            Else
                                strImpDocType = "INVTRN"
                            End If
                            strOrderKey = strLIneStrin.GetValue(3)
                            strShipdate = strLIneStrin.GetValue(4)
                            strSKU = strLIneStrin.GetValue(5)
                            strQty = strLIneStrin.GetValue(6)
                            strbatch = strLIneStrin.GetValue(7)
                            strmfgdate = strLIneStrin.GetValue(8)
                            strexpdate = strLIneStrin.GetValue(9)
                            strLineno = strLIneStrin.GetValue(10)
                            strdate = strShipdate
                            strdate = strdate.ToString.Replace("-", "")
                            DAY = strdate.Substring(0, 2)
                            MONTH = strdate.Substring(2, 2)
                            YEAR = strdate.Substring(4, 4)
                            DATE1 = DAY & MONTH & YEAR
                            dtShipdate = GetDateTimeValue(DATE1)
                            strdate = strmfgdate
                            If strdate <> "" Then

                                strdate = strdate.ToString.Replace("-", "")
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtMfrDate = GetDateTimeValue(DATE1)
                            End If
                            strdate = strexpdate
                            If strdate <> "" Then
                                strdate = strdate.ToString.Replace("-", "")
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtExpDate = GetDateTimeValue(DATE1)
                            End If
                            Dim oUsertable As SAPbobsCOM.UserTable
                            Dim strsql, sCode, strUpdateQuery As String
                            strsql = getMaxCode("@Z_DABT_XSO", "CODE")
                            oUsertable = objMainCompany.UserTables.Item("Z_DABT_XSO")
                            oUsertable.Code = strsql
                            oUsertable.Name = strsql & "M"
                            ' oUsertable.UserFields.Fields.Item("U_Z_DocType").Value = "SO"
                            oUsertable.UserFields.Fields.Item("U_Z_StoreKey").Value = strStorekey
                            oUsertable.UserFields.Fields.Item("U_Z_SAPDocKey").Value = strSokey
                            oUsertable.UserFields.Fields.Item("U_Z_Type").Value = strType
                            oUsertable.UserFields.Fields.Item("U_Z_ImpDocType").Value = strImpDocType
                            oUsertable.UserFields.Fields.Item("U_Z_OrderKey").Value = strOrderKey
                            oUsertable.UserFields.Fields.Item("U_Z_Receiptdate").Value = dtShipdate
                            oUsertable.UserFields.Fields.Item("U_Z_SKU").Value = strSKU
                            oUsertable.UserFields.Fields.Item("U_Z_Quantity").Value = CDbl(strQty)
                            oUsertable.UserFields.Fields.Item("U_Z_BatchNo").Value = strbatch
                            oUsertable.UserFields.Fields.Item("U_Z_MfrDate").Value = dtMfrDate
                            oUsertable.UserFields.Fields.Item("U_Z_ExpDate").Value = dtExpDate
                            oUsertable.UserFields.Fields.Item("U_Z_LineNo").Value = strLineno
                            oUsertable.UserFields.Fields.Item("U_Z_FileName").Value = fi.Name
                            oUsertable.UserFields.Fields.Item("U_Z_Imported").Value = "N"
                            oUsertable.UserFields.Fields.Item("U_Z_ImpMethod").Value = "M"
                            If oUsertable.Add <> 0 Then
                                MsgBox(objMainCompany.GetLastErrorDescription)
                                WriteErrorlog("Error --> " & objMainCompany.GetLastErrorDescription & " File Name : " & fi.Name, sPath)
                                oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                oDelrec.DoQuery("Delete from [@Z_DABT_XSO] where Name like '%M' and U_Z_Filename='" & fi.Name & "'")
                            End If
                        End If
                    Loop
                    oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oDelrec.DoQuery("Update [@Z_DABT_XSO] set Name=code where name like '%M' and U_Z_Filename='" & fi.Name & "'")
                    sr.Close()
                    If File.Exists(strSuccessFile) Then
                        File.Delete(strSuccessFile)
                    End If
                    File.Move(fi.FullName, strSuccessFile)
                    'WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", sPath)
                    WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", strImportErrorLog)

                    'Return True
                Catch ex As Exception

                    ' oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                    WriteErrorlog("Reading SO File Failed...File Name : " & fi.Name, strImportErrorLog)
                    WriteErrorlog("Error -> " & ex.Message, strImportErrorLog)
                    sr.Close()
                    If File.Exists(strErrorFile) Then
                        File.Delete(strErrorFile)
                    End If
                    File.Move(fi.FullName, strErrorFile)
                    WriteErrorlog("Reading SO file failed: Filename : " & fi.Name & " Moved to Error folder", strImportErrorLog)
                    ' Return False
                End Try
            Next

            ' oApplication.Utilities.Message("Reading Shipment file completed...", SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            WriteErrorlog("Reading Shipment file completed", strImportErrorLog)
           
        Catch ex As Exception
            WriteErrorlog("Error--:" & ex.Message, strImportErrorLog)
        End Try
    End Sub
  

    Private Sub readASNImport(ByVal aFolderpath As String, ByVal apath As String)
        Dim di As New IO.DirectoryInfo(aFolderpath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.csv")
        Dim fi As IO.FileInfo
        Dim strStorekey, Desgfolder, strsokey, strOrderKey, strSuccessFile, strErrorFile, strsuccessfolder, strErrorfolder, strLineno, strImpDocType, strType, strdate, strShipdate, strSKU, strQty, strbatch, strmfgdate, strexpdate, strSusr1, strSur2, strholdcode As String
        Dim dtShipdate, dtMfrDate, dtExpDate As Date
        Dim sr As IO.StreamReader
        Dim YEAR, MONTH, DAY, DATE1, strFilename, linje As String
        Dim oDelrec As SAPbobsCOM.Recordset
        Try
            ' oApplication.Utilities.Message("Reading ASN files...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorlog("Reading ASN Files...", strImportErrorLog)
            strsuccessfolder = aFolderpath
            strsuccessfolder = aFolderpath & "\Success"
            strErrorfolder = aFolderpath & "\Error"
            If Directory.Exists(strsuccessfolder) = False Then
                Directory.CreateDirectory(strsuccessfolder)
            End If
            If Directory.Exists(strErrorfolder) = False Then
                Directory.CreateDirectory(strErrorfolder)
            End If

            For Each fi In aryFi
                strFilename = fi.FullName
                strSuccessFile = strsuccessfolder & "\" & fi.Name
                strErrorFile = strErrorfolder & "\" & fi.Name
                sr = New StreamReader(fi.FullName, System.Text.Encoding.Default) 'IO.File.OpenText(fil)
                sPath = apath
                'If File.Exists(sPath) Then
                '    File.Delete(sPath)
                'End If
                Dim strLIneStrin As String()
                Try
                    Dim oRec, oRecUpdate As SAPbobsCOM.Recordset
                    '    WriteErrorlog("Reading ASN File Processing...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Reading ASN File Processing...File Name : " & fi.Name, strImportErrorLog)
                    oRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oRecUpdate = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oRec.DoQuery("Select * from [@Z_DABT_XASN] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    If oRec.RecordCount > 0 Then
                        oRec.DoQuery("Delete from [@Z_DABT_XASN] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    End If
                    Do While (sr.Peek <> -1)
                        linje = ""
                        linje = sr.ReadLine()
                        strLIneStrin = linje.Split(vbTab)
                        If strLIneStrin.Length > 0 Then
                            strStorekey = strLIneStrin.GetValue(0)
                            strsokey = strLIneStrin.GetValue(1)
                            strType = strLIneStrin.GetValue(2)
                            If strType = "" Then
                                strImpDocType = ""
                            End If
                            strImpDocType = "ST"
                            Select Case strType.ToUpper
                                Case "NORMAL"
                                    strImpDocType = "GRPO"
                                Case "I"
                                    strImpDocType = "GRPO"
                                Case "RETRUN ORDER"
                                    strImpDocType = "RETURNS"
                                Case "OR"
                                    strImpDocType = "RETURNS"
                                Case "RETURN INVOICE"
                                    strImpDocType = "ARCR"
                                Case "IR"
                                    strImpDocType = "ARCR"
                                Case "TRN"
                                    strImpDocType = "ST"
                                Case "TRS"
                                    strImpDocType = "ST"
                            End Select

                            strShipdate = strLIneStrin.GetValue(3)
                            strSKU = strLIneStrin.GetValue(4)
                            strQty = strLIneStrin.GetValue(5)
                            strbatch = strLIneStrin.GetValue(6)
                            strmfgdate = strLIneStrin.GetValue(7)
                            strexpdate = strLIneStrin.GetValue(8)
                            strSusr1 = strLIneStrin.GetValue(9)
                            strSur2 = strLIneStrin.GetValue(10)
                            strholdcode = strLIneStrin.GetValue(11)
                            strLineno = strLIneStrin.GetValue(12)

                            strdate = strShipdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtShipdate = GetDateTimeValue(DATE1)

                            End If

                            strdate = strmfgdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtMfrDate = GetDateTimeValue(DATE1)
                            End If

                            strdate = strexpdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtExpDate = GetDateTimeValue(DATE1)
                            End If
                            Dim oUsertable As SAPbobsCOM.UserTable
                            Dim strsql As String
                            strsql = getMaxCode("@Z_DABT_XASN", "CODE")
                            oUsertable = objMainCompany.UserTables.Item("Z_DABT_XASN")
                            oUsertable.Code = strsql
                            oUsertable.Name = strsql & "M"
                            'oUsertable.UserFields.Fields.Item("U_Z_DocType").Value = "ASN"
                            oUsertable.UserFields.Fields.Item("U_Z_StoreKey").Value = strStorekey
                            oUsertable.UserFields.Fields.Item("U_Z_SAPDocKey").Value = strsokey
                            oUsertable.UserFields.Fields.Item("U_Z_Type").Value = strType
                            oUsertable.UserFields.Fields.Item("U_Z_ImpDocType").Value = strImpDocType
                            oUsertable.UserFields.Fields.Item("U_Z_Receiptdate").Value = dtShipdate
                            oUsertable.UserFields.Fields.Item("U_Z_SKU").Value = strSKU
                            oUsertable.UserFields.Fields.Item("U_Z_Quantity").Value = CDbl(strQty)
                            oUsertable.UserFields.Fields.Item("U_Z_BatchNo").Value = strbatch
                            oUsertable.UserFields.Fields.Item("U_Z_MfrDate").Value = dtMfrDate
                            oUsertable.UserFields.Fields.Item("U_Z_ExpDate").Value = dtExpDate
                            oUsertable.UserFields.Fields.Item("U_Z_LineNo").Value = strLineno
                            oUsertable.UserFields.Fields.Item("U_Z_Susr").Value = strSusr1
                            oUsertable.UserFields.Fields.Item("U_Z_Susr2").Value = strSur2
                            oUsertable.UserFields.Fields.Item("U_Z_HoldCode").Value = strholdcode
                            oUsertable.UserFields.Fields.Item("U_Z_FileName").Value = fi.Name
                            oUsertable.UserFields.Fields.Item("U_Z_Imported").Value = "N"

                            oUsertable.UserFields.Fields.Item("U_Z_ImpMethod").Value = "M"
                            If oUsertable.Add <> 0 Then
                                MsgBox(objMainCompany.GetLastErrorDescription)
                                oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                oDelrec.DoQuery("Delete from [@Z_DABT_XASN] where Name like '%M' and U_Z_Filename='" & fi.Name & "'")
                            End If
                        End If


                    Loop
                    oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oDelrec.DoQuery("Update [@Z_DABT_XASN] set Name=code where name like '%M' and U_Z_Filename='" & fi.Name & "'")

                    sr.Close()
                    File.Move(fi.FullName, strSuccessFile)

                    WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", strImportErrorLog)

                    'Return True
                Catch ex As Exception
                    'Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                    WriteErrorlog("Reading ADN File Failed...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Error -> " & ex.Message, sPath)
                    WriteErrorlog("Reading ADN file Failed...File Name : " & fi.Name, strImportErrorLog)
                    WriteErrorlog("Error -> " & ex.Message, strImportErrorLog)
                    sr.Close()
                    If File.Exists(strErrorFile) Then
                        File.Delete(strErrorFile)
                    End If
                    File.Move(fi.FullName, strErrorFile)
                    WriteErrorlog("Reading SO file failed: Filename : " & fi.Name & " Moved to Error folder", strImportErrorLog)

                    ' Return False
                End Try
            Next
            ' Message("Reading ASN Import completed...", SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            WriteErrorlog("Reading ADN File Completed", strImportErrorLog)

        Catch ex As Exception
            WriteErrorlog(ex.Message, strImportErrorLog)
        End Try
    End Sub

    Private Sub readADJImport(ByVal aFolderpath As String, ByVal apath As String)
        Dim di As New IO.DirectoryInfo(aFolderpath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.csv")
        Dim fi As IO.FileInfo
        Dim strStorekey, strsokey, strwhs, strImpDocType, strSuccessFile, strErrorFile, strsuccessfolder, strErrorfolder, strremarks, strType, strdate, strOrderKey, strShipdate, strSKU, strQty, strbatch, strmfgdate, strexpdate, strSusr1, strSur2, strholdcode As String
        Dim dtShipdate, dtMfrDate, dtExpDate As Date
        Dim sr As IO.StreamReader
        Dim YEAR, MONTH, DAY, DATE1, strFilename, linje As String
        Dim oDelrec As SAPbobsCOM.Recordset
        Try
            WriteErrorlog("Reading ADJ Files processing..", strImportErrorLog)
            strsuccessfolder = aFolderpath
            strsuccessfolder = aFolderpath & "\Success"
            strErrorfolder = aFolderpath & "\Error"
            If Directory.Exists(strsuccessfolder) = False Then
                Directory.CreateDirectory(strsuccessfolder)
            End If
            If Directory.Exists(strErrorfolder) = False Then
                Directory.CreateDirectory(strErrorfolder)
            End If

            For Each fi In aryFi
                strFilename = fi.FullName
                strSuccessFile = strsuccessfolder & "\" & fi.Name
                strErrorFile = strErrorfolder & "\" & fi.Name
                sr = New StreamReader(fi.FullName, System.Text.Encoding.Default) 'IO.File.OpenText(fil)
                sPath = apath 'System.Windows.Forms.Application.StartupPath & "\ImportLog.txt"

                Dim strLIneStrin As String()
                Try
                    'WriteErrorlog("File Name : " & strFilename, sPath)
                    'WriteErrorlog("Import Process Starting.....", sPath)
                    WriteErrorlog("Reading Adjustment File Processing...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Reading Adjustment File Processing...File Name : " & fi.Name, strImportErrorLog)
                    Dim oRec, oRecUpdate, oTemp As SAPbobsCOM.Recordset
                    oRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oTemp = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oTemp.DoQuery("SELECT T0.[DfltWhs] FROM OADM T0")
                    strwhs = oTemp.Fields.Item(0).Value

                    oRecUpdate = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oRec.DoQuery("Select * from [@Z_DABT_XADJ] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    If oRec.RecordCount > 0 Then
                        oRec.DoQuery("Delete from [@Z_DABT_XADJ] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    End If
                    Do While (sr.Peek <> -1)
                        linje = ""
                        linje = sr.ReadLine()
                        strLIneStrin = linje.Split(vbTab)
                        If strLIneStrin.Length > 7 Then
                            strStorekey = strLIneStrin.GetValue(0)
                            strsokey = strLIneStrin.GetValue(1)
                            strSKU = strLIneStrin.GetValue(2)
                            strbatch = strLIneStrin.GetValue(3)
                            strmfgdate = strLIneStrin.GetValue(4)
                            strexpdate = strLIneStrin.GetValue(5)
                            strQty = strLIneStrin.GetValue(6)
                            If strQty.Contains("-") Then
                                strImpDocType = "Goods Issue"
                            Else
                                strImpDocType = "Goods Recipt"
                            End If
                            strremarks = strLIneStrin.GetValue(7)

                            strdate = strmfgdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtMfrDate = GetDateTimeValue(DATE1)
                            End If


                            strdate = strexpdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtExpDate = GetDateTimeValue(DATE1)
                            End If
                            Dim oUsertable As SAPbobsCOM.UserTable
                            Dim strsql As String
                            strsql = getMaxCode("@Z_DABT_XADJ", "CODE")
                            oUsertable = objMainCompany.UserTables.Item("Z_DABT_XADJ")
                            oUsertable.Code = strsql
                            oUsertable.Name = strsql & "M"
                            oUsertable.UserFields.Fields.Item("U_Z_StoreKey").Value = strStorekey
                            oUsertable.UserFields.Fields.Item("U_Z_Adjkey").Value = strsokey
                            oUsertable.UserFields.Fields.Item("U_Z_ImpDocType").Value = strImpDocType
                            oUsertable.UserFields.Fields.Item("U_Z_SKU").Value = strSKU
                            oUsertable.UserFields.Fields.Item("U_Z_Remarks").Value = strremarks
                            oUsertable.UserFields.Fields.Item("U_Z_BatchNo").Value = strbatch
                            oUsertable.UserFields.Fields.Item("U_Z_Quantity").Value = CDbl(strQty)
                            oUsertable.UserFields.Fields.Item("U_Z_MfrDate").Value = dtMfrDate
                            oUsertable.UserFields.Fields.Item("U_Z_ExpDate").Value = dtExpDate
                            oUsertable.UserFields.Fields.Item("U_Z_Whs").Value = strwhs
                            oUsertable.UserFields.Fields.Item("U_Z_FileName").Value = fi.Name
                            oUsertable.UserFields.Fields.Item("U_Z_Imported").Value = "N"
                            oUsertable.UserFields.Fields.Item("U_Z_ImpMethod").Value = "M"
                            If oUsertable.Add <> 0 Then
                                MsgBox(objMainCompany.GetLastErrorDescription)
                                oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                oDelrec.DoQuery("Delete from [@Z_DABT_XADJ] where Name like '%M' and U_Z_Filename='" & fi.Name & "'")
                            End If
                        End If
                    Loop
                    oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oDelrec.DoQuery("Update [@Z_DABT_XADJ] set Name=code where name like '%M' and U_Z_Filename='" & fi.Name & "'")
                    sr.Close()
                    File.Move(fi.FullName, strSuccessFile)
                    WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", sPath)
                    WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", strImportErrorLog)

                    'Return True
                Catch ex As Exception
                    ' Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                    WriteErrorlog("Reading ADJ File Failed...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Error -> " & ex.Message, sPath)
                    WriteErrorlog("Reading ADJ File Failed...File Name : " & fi.Name, strImportErrorLog)
                    WriteErrorlog("Error -> " & ex.Message, strImportErrorLog)
                    sr.Close()
                    If File.Exists(strErrorFile) Then
                        File.Delete(strErrorFile)
                    End If
                    File.Move(fi.FullName, strErrorFile)
                    WriteErrorlog("Reading SO file failed: Filename : " & fi.Name & " Moved to Error folder", strImportErrorLog)

                    ' Return False
                End Try
            Next
            ' Message("Reading Adjustment file completed...", SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            WriteErrorlog("Reading Adjustment file completed", strImportErrorLog)

        Catch ex As Exception
            WriteErrorlog(ex.Message, strImportErrorLog)
        End Try
    End Sub

    Private Sub readHOLImport(ByVal aFolderpath As String, ByVal apath As String)
        Dim di As New IO.DirectoryInfo(aFolderpath)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.csv")
        Dim fi As IO.FileInfo
        Dim strStorekey, strsokey, strfrmwhs, strtowhs, strwhs, strImpDocType, strSuccessFile, strErrorFile, strsuccessfolder, strErrorfolder, strremarks, strType, strdate, strOrderKey, strShipdate, strSKU, strQty, strbatch, strmfgdate, strexpdate, strSusr1, strSur2, strholdcode As String
        Dim dtShipdate, dtMfrDate, dtExpDate As Date
        Dim sr As IO.StreamReader
        Dim YEAR, MONTH, DAY, DATE1, strFilename, linje As String
        Dim oDelrec As SAPbobsCOM.Recordset
        Try
            WriteErrorlog("Reading HOLD Files processing..", strImportErrorLog)
            strsuccessfolder = aFolderpath
            strsuccessfolder = aFolderpath & "\Success"
            strErrorfolder = aFolderpath & "\Error"
            If Directory.Exists(strsuccessfolder) = False Then
                Directory.CreateDirectory(strsuccessfolder)
            End If
            If Directory.Exists(strErrorfolder) = False Then
                Directory.CreateDirectory(strErrorfolder)
            End If

            For Each fi In aryFi
                strFilename = fi.FullName
                strSuccessFile = strsuccessfolder & "\" & fi.Name
                strErrorFile = strErrorfolder & "\" & fi.Name
                sr = New StreamReader(fi.FullName, System.Text.Encoding.Default) 'IO.File.OpenText(fil)
                sPath = apath 'System.Windows.Forms.Application.StartupPath & "\ImportLog.txt"

                Dim strLIneStrin As String()
                Try
                    'WriteErrorlog("File Name : " & strFilename, sPath)
                    'WriteErrorlog("Import Process Starting.....", sPath)
                    WriteErrorlog("Reading HOLD File Processing...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Reading HOLD File Processing...File Name : " & fi.Name, strImportErrorLog)
                    Dim oRec, oRecUpdate, oTemp As SAPbobsCOM.Recordset
                    oRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oTemp = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oTemp.DoQuery("SELECT T0.[DfltWhs] FROM OADM T0")
                    strwhs = oTemp.Fields.Item(0).Value
                    oRecUpdate = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oRec.DoQuery("Select * from [@Z_DABT_XHOL] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    If oRec.RecordCount > 0 Then
                        oRec.DoQuery("Delete from [@Z_DABT_XHOL] where U_Z_FileName='" & fi.Name & "' and U_Z_Imported='N'")
                    End If
                    Do While (sr.Peek <> -1)
                        linje = ""
                        linje = sr.ReadLine()
                        strLIneStrin = linje.Split(vbTab)
                        If strLIneStrin.Length > 7 Then
                            strfrmwhs = strLIneStrin.GetValue(0)
                            strtowhs = strLIneStrin.GetValue(1)
                            strremarks = strLIneStrin.GetValue(2)
                            strSKU = strLIneStrin.GetValue(3)
                            strbatch = strLIneStrin.GetValue(4)
                            strmfgdate = strLIneStrin.GetValue(5)
                            strexpdate = strLIneStrin.GetValue(6)
                            strQty = strLIneStrin.GetValue(7)

                            strdate = strmfgdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtMfrDate = GetDateTimeValue(DATE1)
                            End If
                            strQty = strQty
                            strdate = strexpdate.Replace("-", "")
                            If strdate <> "" Then
                                DAY = strdate.Substring(0, 2)
                                MONTH = strdate.Substring(2, 2)
                                YEAR = strdate.Substring(4, 4)
                                DATE1 = DAY & MONTH & YEAR
                                dtExpDate = GetDateTimeValue(DATE1)
                            End If
                            strImpDocType = "ST"
                            Dim oUsertable As SAPbobsCOM.UserTable
                            Dim strsql As String
                            strsql = getMaxCode("@Z_DABT_XHOL", "CODE")
                            oUsertable = objMainCompany.UserTables.Item("Z_DABT_XHOL")
                            oUsertable.Code = strsql
                            oUsertable.Name = strsql & "M"
                            oUsertable.UserFields.Fields.Item("U_Z_FrmWhs").Value = strfrmwhs
                            oUsertable.UserFields.Fields.Item("U_Z_ToWhs").Value = strtowhs
                            oUsertable.UserFields.Fields.Item("U_Z_ImpDocType").Value = strImpDocType
                            oUsertable.UserFields.Fields.Item("U_Z_SKU").Value = strSKU
                            oUsertable.UserFields.Fields.Item("U_Z_Remarks").Value = strremarks
                            oUsertable.UserFields.Fields.Item("U_Z_BatchNo").Value = strbatch
                            oUsertable.UserFields.Fields.Item("U_Z_Quantity").Value = CDbl(strQty)
                            oUsertable.UserFields.Fields.Item("U_Z_MfrDate").Value = dtMfrDate
                            oUsertable.UserFields.Fields.Item("U_Z_ExpDate").Value = dtExpDate

                            oUsertable.UserFields.Fields.Item("U_Z_FileName").Value = fi.Name
                            oUsertable.UserFields.Fields.Item("U_Z_Imported").Value = "N"
                            oUsertable.UserFields.Fields.Item("U_Z_ImpMethod").Value = "M"
                            If oUsertable.Add <> 0 Then
                                MsgBox(objMainCompany.GetLastErrorDescription)
                                oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                oDelrec.DoQuery("Delete from [@Z_DABT_XHOL] where Name like '%M' and U_Z_Filename='" & fi.Name & "'")
                            End If
                        End If
                    Loop
                    oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    oDelrec.DoQuery("Update [@Z_DABT_XHOL] set Name=code where name like '%M' and U_Z_Filename='" & fi.Name & "'")
                    sr.Close()
                    File.Move(fi.FullName, strSuccessFile)
                    WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", sPath)
                    WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", strImportErrorLog)

                    'Return True
                Catch ex As Exception
                    '  Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                    WriteErrorlog("Reading HOLD File Failed...File Name : " & fi.Name, sPath)
                    WriteErrorlog("Error -> " & ex.Message, sPath)
                    WriteErrorlog("Reading HOLD File Failed...File Name : " & fi.Name, strImportErrorLog)
                    WriteErrorlog("Error -> " & ex.Message, strImportErrorLog)
                    sr.Close()
                    If File.Exists(strErrorFile) Then
                        File.Delete(strErrorFile)
                    End If
                    File.Move(fi.FullName, strErrorFile)
                    WriteErrorlog("Reading HOLD file failed: Filename : " & fi.Name & " Moved to Error folder", strImportErrorLog)

                    ' Return False
                End Try
            Next
            ' Message("Reading HOLD file completed...", SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            WriteErrorlog("Reading HOLD file completed", strImportErrorLog)

        Catch ex As Exception
            WriteErrorlog(ex.Message, strImportErrorLog)
        End Try
    End Sub

#End Region

#Region "Import Documents"

    Public Sub ImportASNFiles(ByVal apath As String, ByVal aCompany As SAPbobsCOM.Company)
        ImportASN_GRPOFiles(apath, aCompany)
        ImportASNRETURNSFiles(apath, aCompany)
        ImportASNARCRFiles(apath, aCompany)
        ImportASNSTFiles(apath, aCompany)
    End Sub

    Public Sub ImportASN_GRPOFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strDeg, strerrorfodler, strSQL, strSQL1, strDocKey As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime As String
            Dim oDocument As SAPbobsCOM.Documents
            Dim blnLineExists As Boolean
            'objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\ASN Import"
            strPath = strPath & "\Import\ASN Import"
            strDeg = strPath & "\Import\ASN Import\Success"
            strExportFilePaty = strPath
            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XASN_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"
            ' Message("Processing XASN-GRPO Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "XASN Import GRPO Starting..")
            WriteErrorlog("XASN-GRPO Import starting...", strImportErrorLog)
            Dim stStore As String
            stStore = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_SAPDocKey,''),Count(*) from   [@Z_DABT_XASN] where U_Z_Storekey='" & stStore & "' and  U_Z_Imported='N'  and U_Z_ImpDocType ='GRPO' group by U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_SAPDocKey,'')"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No Records to Import...", strImportErrorLog)
                WriteErrorlog("XASN-GRPO Import Completed...", strImportErrorLog)
                Exit Sub
            End If

            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strDocType = oTempRec.Fields.Item(1).Value
                'Message("Processing XASN Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & "  data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                strSQL1 = "Select * from [@Z_DABT_XASN] where U_Z_Storekey='" & stStore & "' and  isnull(U_Z_SAPDocKey,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                If strDocType = "GRPO" Then
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDrafts)
                    oDocument.DocObjectCode = SAPbobsCOM.BoObjectTypes.oPurchaseDeliveryNotes
                    oTempLines.DoQuery(strSQL1)
                    blnLineExists = False
                    For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                        oSourceDocument.DoQuery("Select * from OPOR where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_SAPDockey").Value)
                        If oSourceDocument.RecordCount > 0 Then
                            oDocument.CardCode = oSourceDocument.Fields.Item("CardCode").Value
                            oDocument.DocDate = oTempLines.Fields.Item("U_Z_Receiptdate").Value
                            If intLoop > 0 Then
                                oDocument.Lines.Add()
                            End If
                            oDocument.Lines.SetCurrentLine(intLoop)
                            oDocument.Lines.BaseType = 22
                            oDocument.Lines.BaseEntry = oSourceDocument.Fields.Item("DocEntry").Value
                            oDocument.Lines.BaseLine = oTempLines.Fields.Item("U_Z_Lineno").Value
                            oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                            blnLineExists = True
                        Else
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Purchase order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strErrorLog)
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Purchase order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strImportErrorLog)
                        End If
                        oTempLines.MoveNext()
                    Next
                    If blnLineExists = True Then
                        If oDocument.Add <> 0 Then
                            '  oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                        Else
                            Dim strdocCode As String
                            objRemoteCompany.GetNewObjectCode(strdocCode)
                            If oDocument.GetByKey(strdocCode) Then
                                otempLines1.DoQuery("Update [@Z_DABT_XASN] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & stStore & "' and  U_Z_SAPDocKey='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Draft - GRPO Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Draft - GRPO Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                            End If
                        End If
                    End If
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "XASN-GRPO Import Completed..")
            WriteErrorlog("XASN-GRPO Import Completed", strImportErrorLog)
        Catch ex As Exception
            'oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub

    Public Sub ImportASNARCRFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strDeg, strerrorfodler, strSQL, strSQL1, strDocKey As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime As String
            Dim oDocument As SAPbobsCOM.Documents
            Dim blnLineExists As Boolean
            ' objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)


            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\ASN Import"
            strPath = strPath & "\Import\ASN Import"
            strDeg = strPath & "\Import\ASN Import\Success"
            strExportFilePaty = strPath
            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XASN_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"

            'Message("Processing XASN-ARCR Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "XASN-ARCR Import Starting..")
            WriteErrorlog("XASN-ARCR Import starting...", strImportErrorLog)
            Dim ststore As String = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_Susr,''),Count(*) from   [@Z_DABT_XASN] where U_Z_Storekey='" & ststore & "' and  U_Z_Imported='N' and U_Z_ImpDocType='ARCR' group by U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_Susr,'')"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No Records to Import...", strImportErrorLog)
                WriteErrorlog("XASN Import Completed...", strImportErrorLog)
                Exit Sub
            End If
            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strDocType = oTempRec.Fields.Item(1).Value
                '  Message("Processing XASN-ARCR Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & "  data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                strSQL1 = "Select * from [@Z_DABT_XASN] where U_Z_Storekey='" & ststore & "' and  isnull(U_Z_Susr,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                If strDocType = "ARCR" Then
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDrafts)
                    oDocument.DocObjectCode = SAPbobsCOM.BoObjectTypes.oCreditNotes
                    oTempLines.DoQuery(strSQL1)
                    blnLineExists = False
                    For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                        oSourceDocument.DoQuery("Select * from OINV where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_Susr").Value)
                        If oSourceDocument.RecordCount > 0 Then
                            oDocument.CardCode = oSourceDocument.Fields.Item("CardCode").Value
                            oDocument.DocDate = Now.Date
                            oDocument.DocDueDate = Now.Date
                            If intLoop > 0 Then
                                oDocument.Lines.Add()
                            End If
                            oDocument.Lines.SetCurrentLine(intLoop)
                            oDocument.Lines.BaseType = 13
                            oDocument.Lines.BaseEntry = oSourceDocument.Fields.Item("DocEntry").Value
                            oDocument.Lines.BaseLine = oTempLines.Fields.Item("U_Z_Lineno").Value
                            'oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                            oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                            'oDocument.Lines.WarehouseCode = oTempLines.Fields.Item("U_Z_Storekey").Value
                            blnLineExists = True
                        Else
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & "  Sales Invoice does not exits : FileName =" & strFileName & " : Invoice No : " & oTempLines.Fields.Item("U_Z_Susr").Value, strErrorLog)
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & "  Sales Invoice does not exits : FileName =" & strFileName & " : Invoice No : " & oTempLines.Fields.Item("U_Z_Susr").Value, strImportErrorLog)
                        End If
                        oTempLines.MoveNext()
                    Next
                    If blnLineExists = True Then
                        If oDocument.Add <> 0 Then
                            ' oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                        Else
                            Dim strdocCode As String
                            objRemoteCompany.GetNewObjectCode(strdocCode)
                            If oDocument.GetByKey(strdocCode) Then
                                otempLines1.DoQuery("Update [@Z_DABT_XASN] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & ststore & "' and  isnull(U_Z_Susr,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " -  Draft - AR-Credit Memo Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " - Draft - AR-Credit Memo Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                            End If
                        End If
                    End If
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "XASN-ARCR Import Completed..")
            WriteErrorlog("XASN-ARCR Import Completed", strImportErrorLog)
        Catch ex As Exception
            'oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub

    Public Sub ImportASNRETURNSFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strDeg, strerrorfodler, strSQL, strSQL1, strDocKey As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime As String
            Dim oDocument As SAPbobsCOM.Documents
            Dim blnLineExists As Boolean
            '  objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)


            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\ASN Import"
            strPath = strPath & "\Import\ASN Import"
            strDeg = strPath & "\Import\ASN Import\Success"
            strExportFilePaty = strPath

            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XASN_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"

            ' Message("Processing XASN-RETURNS Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "XASN-RETURNS Import Starting..")
            WriteErrorlog("XASN-RETURNS Import starting...", strImportErrorLog)
            Dim stStore As String = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_Susr,''),Count(*) from   [@Z_DABT_XASN] where U_Z_Storekey='" & stStore & "' and  U_Z_Imported='N' and U_Z_ImpDocType='RETURNS' group by U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_Susr,'')"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No Records to Import...", strImportErrorLog)
                WriteErrorlog("XASN-RETURNS Completed...", strImportErrorLog)
                Exit Sub
            End If

            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strDocType = oTempRec.Fields.Item(1).Value
                'Message("Processing XASN-Returns Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & "  data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                strSQL1 = "Select * from [@Z_DABT_XASN] where U_Z_Storekey='" & stStore & "' and  isnull(U_Z_Susr,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                If strDocType = "RETURNS" Then
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oReturns)
                    oTempLines.DoQuery(strSQL1)
                    blnLineExists = False
                    For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                        ' oSourceDocument.DoQuery("Select * from OPOR where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_SAPDockey").Value)
                        If 1 = 1 Then
                            oDocument.CardCode = oTempLines.Fields.Item("U_Z_Susr").Value
                            oDocument.DocDate = Now.Date ' oTempLines.Fields.Item("U_Z_Receiptdate").Value
                            If intLoop > 0 Then
                                oDocument.Lines.Add()
                            End If
                            oDocument.Lines.SetCurrentLine(intLoop)
                            oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                            oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                            Dim otemp As SAPbobsCOM.Recordset
                            otemp = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                            otemp.DoQuery("Select T0.[DfltWhs] from OADM T0")
                            oDocument.Lines.WarehouseCode = otemp.Fields.Item(0).Value
                            blnLineExists = True
                        Else
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Purchase order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strErrorLog)
                        End If
                        oTempLines.MoveNext()
                    Next
                    If blnLineExists = True Then
                        If oDocument.Add <> 0 Then
                            'oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                        Else
                            Dim strdocCode As String
                            objRemoteCompany.GetNewObjectCode(strdocCode)
                            If oDocument.GetByKey(strdocCode) Then
                                otempLines1.DoQuery("Update [@Z_DABT_XASN] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & stStore & "' and  isnull(U_Z_Susr,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Return Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Return Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                            End If
                        End If
                    End If
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "XASN -Returns Import Completed..")
            WriteErrorlog("XASN-Returns Import Completed", strImportErrorLog)
        Catch ex As Exception
            'oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub


    Public Sub ImportASNSTFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument, oWhsrec As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strDeg, strerrorfodler, strSQL, strSQL1, strDocKey, strType As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime, strFromwhs, strToWhs As String
            Dim oDocument As SAPbobsCOM.StockTransfer
            Dim blnLineExists As Boolean

            '  objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oWhsrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)


            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\ASN Import"
            strPath = strPath & "\Import\ASN Import"
            strDeg = strPath & "\Import\ASN Import\Success"
            strExportFilePaty = strPath

            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XASN_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"


            ' Message("Processing XASN-RETURNS Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "XASN-ST Import Starting..")
            WriteErrorlog("XASN-ST Import starting...", strImportErrorLog)
            Dim stStore As String = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,U_Z_Type,U_Z_ImpDocType,Count(*) from   [@Z_DABT_XASN] where U_Z_Storekey='" & stStore & "' and  U_Z_Imported='N' and U_Z_ImpDocType='ST' group by U_Z_FileName,U_Z_Type,U_Z_ImpDocType"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No Records to Import...", strImportErrorLog)
                WriteErrorlog("XASN-RETURNS Completed...", strImportErrorLog)
                Exit Sub
            End If

            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strType = oTempRec.Fields.Item(1).Value
                strDocType = oTempRec.Fields.Item(2).Value
                oWhsrec.DoQuery("Select * from [@Z_DABT_ST] where U_Z_Storekey='" & stStore & "' and U_Z_Type='" & strType & "'")
                If oWhsrec.RecordCount > 0 Then
                    strFromwhs = oWhsrec.Fields.Item("U_Z_FrmWhs").Value
                    strToWhs = oWhsrec.Fields.Item("U_Z_ToWhs").Value
                    'Message("Processing XASN-Returns Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                    WriteErrorlog("Importing FileName--> " & strFileName & "  data", strErrorLog)
                    WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                    strSQL1 = "Select * from [@Z_DABT_XASN] where U_Z_Type='" & strType & "' and  U_Z_Storekey='" & stStore & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                    If strDocType = "ST" Then
                        oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer)
                        oTempLines.DoQuery(strSQL1)
                        blnLineExists = False
                        For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                            ' oSourceDocument.DoQuery("Select * from OPOR where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_SAPDockey").Value)
                            If 1 = 1 Then
                                oDocument.FromWarehouse = strFromwhs ' oTempLines.Fields.Item("U_Z_FrmWhs").Value
                                'oDocument.Comments = oTempLines.Fields.Item("U_Z_Remarks").Value
                                If intLoop > 0 Then
                                    oDocument.Lines.Add()
                                End If
                                oDocument.Lines.SetCurrentLine(intLoop)
                                oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                                oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                                oDocument.Lines.WarehouseCode = strToWhs 'oTempLines.Fields.Item("U_Z_ToWhs").Value
                                blnLineExists = True
                            Else
                                ' WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Purchase order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strErrorLog)
                            End If
                            oTempLines.MoveNext()
                        Next
                        If blnLineExists = True Then
                            If oDocument.Add <> 0 Then
                                'oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                                WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                                WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                            Else
                                Dim strdocCode As String
                                objRemoteCompany.GetNewObjectCode(strdocCode)
                                If oDocument.GetByKey(strdocCode) Then
                                    otempLines1.DoQuery("Update [@Z_DABT_XASN] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & stStore & "' and  U_Z_Type='" & strType & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                    WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Stock Transfer Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                    WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Stock Transfer Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                                End If
                            End If
                        End If
                    End If
                Else
                    WriteErrorlog("Importing FileName--> " & strFileName & " data completed : Warehouse details missing for the type : " & strType & " : storekey : " & stStore, strErrorLog)
                    WriteErrorlog("Importing FileName--> " & strFileName & " data completed : Warehouse details missing for the type : " & strType & " : storekey : " & stStore, strImportErrorLog)
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
           WriteErrorHeader(strErrorLog, "XASN -Returns Import Completed..")
            WriteErrorlog("XASN-Returns Import Completed", strImportErrorLog)
        Catch ex As Exception
            'oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub

    Public Sub ImportSOSTFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument, oWhsrec As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strDeg, strerrorfodler, strSQL, strSQL1, strDocKey, strType As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime, strFromwhs, strToWhs As String
            Dim oDocument As SAPbobsCOM.StockTransfer
            Dim blnLineExists As Boolean

            '  objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oWhsrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)


            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\ASO Import"
            strPath = strPath & "\Import\ASO Import"
            strDeg = strPath & "\Import\ASO Import\Success"
            strExportFilePaty = strPath

            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XASO_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"


            ' Message("Processing XASN-RETURNS Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "XASO-ST Import Starting..")
            WriteErrorlog("XASO-ST Import starting...", strImportErrorLog)
            Dim stStore As String = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,U_Z_Type,U_Z_ImpDocType,Count(*) from   [@Z_DABT_XSO] where U_Z_Storekey='" & stStore & "' and  U_Z_Imported='N' and U_Z_ImpDocType='INVTRN' group by U_Z_FileName,U_Z_Type,U_Z_ImpDocType"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No Records to Import...", strImportErrorLog)
                WriteErrorlog("XASO-ST Completed...", strImportErrorLog)
                Exit Sub
            End If

            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strType = oTempRec.Fields.Item(1).Value
                strDocType = oTempRec.Fields.Item(2).Value
                oWhsrec.DoQuery("Select * from [@Z_DABT_ST] where U_Z_Storekey='" & stStore & "' and U_Z_Type='" & strType & "'")
                'Message("Processing XASN-Returns Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & "  data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                If oWhsrec.RecordCount > 0 Then
                    strFromwhs = oWhsrec.Fields.Item("U_Z_FrmWhs").Value
                    strToWhs = oWhsrec.Fields.Item("U_Z_ToWhs").Value
               
                    strSQL1 = "Select * from [@Z_DABT_XSO] where U_Z_Storekey='" & stStore & "' and U_Z_Type='" & strType & "'and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                    If strDocType = "INVTRN" Then
                        oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer)
                        oTempLines.DoQuery(strSQL1)
                        blnLineExists = False
                        For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                            ' oSourceDocument.DoQuery("Select * from OPOR where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_SAPDockey").Value)
                            If 1 = 1 Then
                                oDocument.FromWarehouse = strFromwhs ' oTempLines.Fields.Item("U_Z_FrmWhs").Value
                                ' oDocument.Comments = oTempLines.Fields.Item("U_Z_Remarks").Value
                                If intLoop > 0 Then
                                    oDocument.Lines.Add()
                                End If
                                oDocument.Lines.SetCurrentLine(intLoop)
                                oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                                oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                                oDocument.Lines.WarehouseCode = strToWhs 'oTempLines.Fields.Item("U_Z_ToWhs").Value
                                blnLineExists = True
                            Else
                                ' WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Purchase order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strErrorLog)
                            End If
                            oTempLines.MoveNext()
                        Next
                        If blnLineExists = True Then
                            If oDocument.Add <> 0 Then
                                'oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                                WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                                WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                            Else
                                Dim strdocCode As String
                                objRemoteCompany.GetNewObjectCode(strdocCode)
                                If oDocument.GetByKey(strdocCode) Then
                                    otempLines1.DoQuery("Update [@Z_DABT_XSO] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & stStore & "' and  U_Z_Type='" & strType & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                    WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Stock Transfer Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                    WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Stock Transfer Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                                End If
                            End If
                        End If
                    End If
                Else
                    WriteErrorlog("Importing FileName--> " & strFileName & " data completed : Warehouse details missing for the type : " & strType & " : storekey : " & stStore, strErrorLog)
                    WriteErrorlog("Importing FileName--> " & strFileName & " data completed : Warehouse details missing for the type : " & strType & " : storekey : " & stStore, strImportErrorLog)
                End If

                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "XASO -ST Import Completed..")
            WriteErrorlog("XASO-ST Import Completed", strImportErrorLog)
        Catch ex As Exception
            'oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub


    Public Sub ImportHOLDFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strDeg, strerrorfodler, strSQL, strSQL1, strDocKey As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime As String
            Dim oDocument As SAPbobsCOM.StockTransfer
            Dim blnLineExists As Boolean
            ' objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)


            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\HOLD Import"
            strPath = strPath & "\Import\HOLD Import"
            strDeg = strPath & "\Import\HOLD Import\Success"
            strExportFilePaty = strPath
            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XHOL_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"

            'Message("Processing XHOLD Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "XHOLD Import Starting..")
            WriteErrorlog("XHOLD starting...", strImportErrorLog)


            Dim strFrom, strTo As String
            strSQL = "Select DfltWhs from OADM"
            oTempRec.DoQuery(strSQL)
            strFrom = oTempRec.Fields.Item(0).Value
            strSQL = "Select WhsCode from OWHS where U_Damaged='Y'"
            oTempRec.DoQuery(strSQL)
            If oTempRec.RecordCount > 0 Then
                strTo = oTempRec.Fields.Item(0).Value
            Else
                WriteErrorlog("Damaged warehouse is not defined....", strErrorLog)
                WriteErrorlog("Damaged warehouse is not defined....", strImportErrorLog)
                Exit Sub
            End If
            strSQL = "select U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_FrmWhs,''),Count(*) from   [@Z_DABT_XHOL] where U_Z_Imported='N' and U_Z_ImpDocType='ST' group by U_Z_FileName,U_Z_ImpDocType,isnull(U_Z_FrmWhs,'')"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No Records to Import...", strImportErrorLog)
                WriteErrorlog("XHOLD Import Completed...", strImportErrorLog)
                Exit Sub
            End If
            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strDocType = oTempRec.Fields.Item(1).Value
                ' Message("Processing XHOLD Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & "  data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                strSQL1 = "Select * from [@Z_DABT_XHOL] where isnull(U_Z_FrmWhs,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                If strDocType = "ST" Then
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer)
                    oTempLines.DoQuery(strSQL1)
                    blnLineExists = False
                    For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                        ' oSourceDocument.DoQuery("Select * from OINV where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_Susr").Value)
                        If 1 = 1 Then
                            oDocument.FromWarehouse = strFrom ' oTempLines.Fields.Item("U_Z_FrmWhs").Value
                            oDocument.Comments = oTempLines.Fields.Item("U_Z_Remarks").Value
                            If intLoop > 0 Then
                                oDocument.Lines.Add()
                            End If
                            oDocument.Lines.SetCurrentLine(intLoop)
                            oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                            oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                            oDocument.Lines.WarehouseCode = strTo 'oTempLines.Fields.Item("U_Z_ToWhs").Value
                            blnLineExists = True
                        End If
                        oTempLines.MoveNext()
                    Next
                    If blnLineExists = True Then
                        If oDocument.Add <> 0 Then
                            ' oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                        Else
                            Dim strdocCode As String
                            objRemoteCompany.GetNewObjectCode(strdocCode)
                            If oDocument.GetByKey(strdocCode) Then
                                otempLines1.DoQuery("Update [@Z_DABT_XHOL] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where isnull(U_Z_FrmWhs,'')='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Stock Transfer Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Stock Transfer Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                            End If
                        End If
                    End If
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "XHOLD Import Completed..")
            WriteErrorlog("XHOLDImport Completed", strImportErrorLog)
        Catch ex As Exception
            ' oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub

    Public Sub ImportADJFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strSQL, strSQL1, strDocKey, sPath As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime As String
            Dim oDocument As SAPbobsCOM.Documents
            Dim blnLineExists As Boolean
            Dim dblQuantity As Double
            'objMainCompany = aCOMP
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            sPath = System.Windows.Forms.Application.StartupPath & "\ImportLog.txt"

            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\INV Import"
            strPath = strPath & "\Import\INV Import"
            strExportFilePaty = strPath
            'If Directory.Exists(strPath) = False Then
            '    Directory.CreateDirectory(strPath)
            'End If
            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XINV_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"

            'If Directory.Exists(strExportFilePaty) = False Then
            '    Directory.CreateDirectory(strPath)
            'End If
            'Message("Processing Adjustment file Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            WriteErrorHeader(strErrorLog, "Adjustment files Import Starting..")
            WriteErrorlog("Import Inventory adjustment processing...", strImportErrorLog)
            Dim stStore As String = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,U_Z_ImpDocType, Count(*) from   [@Z_DABT_XADJ] where  U_Z_Storekey='" & stStore & "' and  U_Z_Imported='N' group by U_Z_FileName,U_Z_ImpDocType"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No records to Import", strImportErrorLog)
                Exit Sub
            End If

            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strDocType = oTempRec.Fields.Item(1).Value
                '  Message("Processing Adjustment files Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                strSQL1 = "Select * from [@Z_DABT_XADJ] where U_Z_Storekey='" & stStore & "' and  Convert(Numeric,isnull(U_Z_Adjkey,'0'))<>0 and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                If strDocType = "Goods Recipt" Then
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry)
                Else
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit)
                End If
                oTempLines.DoQuery(strSQL1)
                blnLineExists = False
                For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                    If 1 = 1 Then
                        oDocument.DocDate = Now.Date
                        oDocument.Comments = oTempLines.Fields.Item("U_Z_Remarks").Value
                        If intLoop > 0 Then
                            oDocument.Lines.Add()
                        End If
                        dblQuantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                        If dblQuantity < 0 Then
                            dblQuantity = dblQuantity * -1
                        End If
                        oDocument.Lines.SetCurrentLine(intLoop)
                        oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                        oDocument.Lines.Quantity = dblQuantity
                        oDocument.Lines.WarehouseCode = oTempLines.Fields.Item("U_Z_Whs").Value
                        blnLineExists = True
                    End If
                    oTempLines.MoveNext()
                Next
                If blnLineExists = True Then
                    If oDocument.Add <> 0 Then
                        'oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                        WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                        WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                    Else
                        Dim strdocCode As String
                        objRemoteCompany.GetNewObjectCode(strdocCode)
                        If oDocument.GetByKey(strdocCode) Then
                            otempLines1.DoQuery("Update [@Z_DABT_XADJ] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & stStore & "' and  U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & ":" & strDocType & " Document Created successfully. " & oDocument.DocNum, strErrorLog)
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " :" & strDocType & " Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                        End If
                    End If
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "Adjustment files Import Completed..")
            WriteErrorlog("Import Adjustment files completed...", strImportErrorLog)
        Catch ex As Exception
            ' oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub

    Public Sub ImportSOFiles(ByVal apath As String, ByVal aCOMP As SAPbobsCOM.Company)
        Try
            Dim oTempRec, oTempLines, otempLines1, oSourceDocument As SAPbobsCOM.Recordset
            Dim strFileName, strDocType, strSQL, strSQL1, strDocKey As String
            Dim strPath, strFilename1, strMessage, strExportFilePaty, strErrorLog, strTime As String
            Dim oDocument As SAPbobsCOM.Documents
            Dim blnLineExists As Boolean
            ' MsgBox(objMainCompany.CompanyDB.ToString)
            ' MsgBox(objRemoteCompany.CompanyDB.ToString)
            oTempRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempLines = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            otempLines1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oSourceDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            strPath = apath ' System.Windows.Forms.Application.StartupPath
            strTime = Now.ToShortTimeString.Replace(":", "")
            strFilename1 = Now.Date.ToString("ddMMyyyy")
            strFilename1 = strFilename1 & strTime
            strErrorLog = ""

            strErrorLog = strPath & "\Logs\ASO Import"
            strPath = strPath & "\Import\ASO Import"
            strExportFilePaty = strPath
            If Directory.Exists(strErrorLog) = False Then
                Directory.CreateDirectory(strErrorLog)
            End If
            strFilename1 = "Import XSO_" & strFilename1
            strErrorLog = strErrorLog & "\" & strFilename1 & ".txt"
            WriteErrorHeader(strErrorLog, "XSOport Starting..")
            WriteErrorlog("Import XSO Processing...", strImportErrorLog)
            Dim stStore As String
            stStore = getStoreKey(objRemoteCompany)
            strSQL = "select U_Z_FileName,isnull(U_Z_ImpDocType,'R'),U_Z_SAPDocKey,Count(*) from   [@Z_DABT_XSO] where U_Z_ImpDocType='R' and U_Z_Imported='N' and U_Z_Storekey='" & stStore & "' group by U_Z_FileName,U_Z_ImpDocType,U_Z_SAPDocKey"
            oTempRec.DoQuery(strSQL)
            otempLines1.DoQuery(strSQL)
            If otempLines1.RecordCount <= 0 Then
                WriteErrorlog("No records to Import", strErrorLog)
                WriteErrorlog("No records to Import", strImportErrorLog)
                Exit Sub
            End If

            For intRow As Integer = 0 To oTempRec.RecordCount - 1
                strFileName = oTempRec.Fields.Item(0).Value
                strDocType = oTempRec.Fields.Item(1).Value
                ' Message("Processing XSO Importing...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data", strImportErrorLog)
                strSQL1 = "Select * from [@Z_DABT_XSO] where  U_Z_SAPDocKey='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Storekey='" & stStore & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'"
                If strDocType = "R" Then
                    oDocument = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
                    oTempLines.DoQuery(strSQL1)
                    blnLineExists = False
                    For intLoop As Integer = 0 To oTempLines.RecordCount - 1
                        oSourceDocument.DoQuery("Select * from ORDR where DocStatus='O' and DocNum=" & oTempLines.Fields.Item("U_Z_SAPDockey").Value)
                        If oSourceDocument.RecordCount > 0 Then
                            oDocument.CardCode = oSourceDocument.Fields.Item("CardCode").Value
                            oDocument.DocDate = oTempLines.Fields.Item("U_Z_Receiptdate").Value
                            If intLoop > 0 Then
                                oDocument.Lines.Add()
                            End If
                            oDocument.Lines.SetCurrentLine(intLoop)
                            oDocument.Lines.BaseType = 17
                            oDocument.Lines.BaseEntry = oSourceDocument.Fields.Item("DocEntry").Value
                            '  oDocument.Lines.ItemCode = oTempLines.Fields.Item("U_Z_SKU").Value
                            oDocument.Lines.Quantity = oTempLines.Fields.Item("U_Z_Quantity").Value
                            oDocument.Lines.BaseLine = oTempLines.Fields.Item("U_Z_Lineno").Value
                            ' oDocument.Lines.WarehouseCode = oTempLines.Fields.Item("U_Z_Storekey").Value
                            blnLineExists = True
                        Else
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Sales order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strErrorLog)
                            WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & " Sales order does not exits : FileName =" & strFileName & " : Order No : " & oTempLines.Fields.Item("U_Z_SAPDockey").Value, strImportErrorLog)
                        End If
                        oTempLines.MoveNext()
                    Next
                    If blnLineExists = True Then
                        If oDocument.Add <> 0 Then
                            ' oApplication.Utilities.Message(objMainCompany.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strErrorLog)
                            WriteErrorlog(objRemoteCompany.GetLastErrorDescription & " : FileName =" & strFileName, strImportErrorLog)
                        Else
                            Dim strdocCode As String
                            objRemoteCompany.GetNewObjectCode(strdocCode)
                            If oDocument.GetByKey(strdocCode) Then
                                otempLines1.DoQuery("Update [@Z_DABT_XSO] set U_Z_Imported='Y',U_Z_SAPDocNum='" & oDocument.DocNum & "',U_Z_Impmethod='A' where U_Z_Storekey='" & stStore & "' and  U_Z_SAPDocKey='" & oTempRec.Fields.Item(2).Value & "' and U_Z_Imported='N' and U_Z_Filename='" & strFileName & "' and U_Z_ImpDocType='" & strDocType & "'")
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & "    Invoice Document Created successfully. " & oDocument.DocNum, strErrorLog)
                                WriteErrorlog("DatabaseName name :  " & objRemoteCompany.CompanyDB & "    Invoice Document Created successfully. " & oDocument.DocNum, strImportErrorLog)
                            End If
                        End If
                    End If
                End If
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strErrorLog)
                WriteErrorlog("Importing FileName--> " & strFileName & " data completed", strImportErrorLog)
                oTempRec.MoveNext()
            Next
            WriteErrorHeader(strErrorLog, "XSO Import Completed..")
            WriteErrorlog("Import XSO completed...", strImportErrorLog)
        Catch ex As Exception
            ' oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)

        End Try
    End Sub
#End Region

#Region "Get StoreKey"
    Public Function getStoreKey(ByVal aComp As SAPbobsCOM.Company) As String
        Dim stStorekey As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = aComp.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select isnull(U_Z_Storekey,'') from OADM")
        Return oTemp.Fields.Item(0).Value
    End Function
#End Region
#End Region

    Private Sub btnReferesh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferesh.Click
        Try
            If txtServerName.Text = "" Then
                MsgBox("Enter Server")
                Exit Sub
            End If
            If txtDBUserName.Text = "" Then
                MsgBox("Enter UserName")
                Exit Sub
            End If
            If txtServerPwd.Text = "" Then
                MsgBox("Enter Password")
                Exit Sub
            End If
            strLocalServertype = cmbServertype.Text
            oCompany = New SAPbobsCOM.Company
            oCompany.Server = txtServerName.Text
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
            If strLocalServertype = "2005" Then
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2005
            Else
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
            End If
            oCompany.DbUserName = txtDBUserName.Text
            oCompany.DbPassword = txtServerPwd.Text
            Dim oRecordSet As SAPbobsCOM.Recordset
            Dim lErrCode As Long
            Dim sErrMsg As String
            oRecordSet = Me.oCompany.GetCompanyList
            Me.oCompany.GetLastError(lErrCode, sErrMsg)
            If lErrCode <> 0 Then
                MsgBox(sErrMsg)
                Exit Sub
            Else
                cmbCompanyDB.Items.Clear()
                Do Until oRecordSet.EoF = True
                    cmbCompanyDB.Items.Add(oRecordSet.Fields.Item(0).Value)
                    oRecordSet.MoveNext()
                Loop
                btnConnect.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Connection to Server =" & txtServerName.Text & ".  Failed")
            Exit Sub
        End Try
    End Sub

#Region "Write into ErrorLog File"
    Private Sub WriteErrorHeader(ByVal apath As String, ByVal strMessage As String)
        Dim aSw As System.IO.StreamWriter
        Dim aMessage As String
        aMessage = Now.ToLocalTime & "---" & strMessage
        If File.Exists(apath) Then
        End If
        aSw = New StreamWriter(apath, True)
        aSw.WriteLine(aMessage)
        aSw.Flush()
        aSw.Close()
    End Sub
    Private Sub WriteErrorlog(ByVal aMessage As String, ByVal aPath As String)
        '  aPath = strErrorFileName
        Dim aSw As System.IO.StreamWriter
        If File.Exists(aPath) Then
        End If
        aSw = New StreamWriter(aPath, True)
        aMessage = Now.ToLocalTime & "---" & aMessage
        aSw.WriteLine(aMessage)
        aSw.Flush()
        aSw.Close()
    End Sub
#End Region

#Region "exportSO"
    Private Function GetSalesOrders() As String
        Dim oSalesRec As SAPbobsCOM.Recordset
        oSalesRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim strsql As String
        strsql = "SELECT convert(nvarchar(12),dbo.ORDR.DocNum) AS DocumentNoV1, dbo.ORDR.CardCode AS CustomerCode, "
        strsql = strsql & "       convert(nvarchar(10),dbo.ORDR.DocDate,112) AS DocumentDate, '' "
        strsql = strsql & " AS DeliveryDate, coalesce(dbo.ORDR.NumAtCard,'') AS CustomerRef, "
        strsql = strsql & " convert(nvarchar(12),dbo.RDR1.LineNum) as LineNum, dbo.RDR1.ItemCode, "
        strsql = strsql & " dbo.RDR1.Dscription AS ItemDesc, "
        strsql = strsql & " coalesce(dbo.[@MORPHI].Name,'') AS Presentation, convert(nvarchar(12),convert(int,round(dbo.RDR1.Quantity,0))), "
        strsql = strsql & " '' AS PickedQuantity, '' "
        strsql = strsql & " AS ExpDate, '' AS Batch FROM   dbo.ORDR INNER JOIN  dbo.RDR1 ON dbo.ORDR.DocEntry = dbo.RDR1.DocEntry left outer JOIN "
        strsql = strsql & " dbo.[@MORPHI] ON dbo.RDR1.U_TYPE = dbo.[@MORPHI].Code where u_mantisst='N'ORDER BY dbo.DocumentNoV1, dbo.RDR1.LineNum"
        oSalesRec.DoQuery(strsql)
        If oSalesRec.RecordCount > 0 Then
            Return strsql
        Else
            Return ""
        End If
        Return ""
    End Function
#End Region



#Region "Impot BP Master"
    Private Sub ImportBPMaster()
        Dim FileName, strItem As String
        Dim Ecount As Long
        Dim ii As Long
        Dim objMainItem, objRemoteItem As SAPbobsCOM.BusinessPartners
        Dim objMainRecset As SAPbobsCOM.Recordset
        objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objMainRecset.DoQuery("Select CardCode from OCRD where U_Action<>'N'")
        For intItemLoop As Integer = 0 To objMainRecset.RecordCount - 1
            FileName = System.Windows.Forms.Application.StartupPath & "\BP.xml"
            strItem = objMainRecset.Fields.Item(0).Value
            objMainItem = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
            If objMainItem.GetByKey(strItem) Then
                objRemoteItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
                If objRemoteItem.GetByKey(strItem) Then
                    objMainCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objMainItem.SaveXML(FileName)
                    objRemoteCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objRemoteItem = objRemoteCompany.GetBusinessObjectFromXML(FileName, 0)
                    If objRemoteItem.Update() <> 0 Then
                        WriteErrorlog("Failed to Update BP : " & objRemoteItem.CardCode & ":" & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        objMainItem.UserFields.Fields.Item("U_Action").Value = "N"
                        objMainItem.Update()
                        WriteErrorlog("BP Code Updated : " & objRemoteItem.CardCode, sPath)
                    End If
                Else
                    objMainCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objMainItem.SaveXML(FileName)
                    objRemoteCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objRemoteItem = objRemoteCompany.GetBusinessObjectFromXML(FileName, 0)
                    If objRemoteItem.Add() <> 0 Then
                        WriteErrorlog("Failed to create BP : " & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        objMainItem.UserFields.Fields.Item("U_Action").Value = "N"
                        objMainItem.Update()
                        WriteErrorlog("New BP Created : " & objRemoteItem.CardCode, sPath)
                    End If
                End If
            End If
            objMainRecset.MoveNext()
        Next
    End Sub
    Private Sub UpdateBPMaster()
        Dim FileName, strItem As String
        Dim Ecount As Long
        Dim ii As Long
        Dim objMainItem, objRemoteItem As SAPbobsCOM.BusinessPartners
        Dim objMainRecset As SAPbobsCOM.Recordset
        objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objMainRecset.DoQuery("Select CardCode from OCRD where U_Action='U'")
        For intItemLoop As Integer = 0 To objMainRecset.RecordCount - 1
            FileName = System.Windows.Forms.Application.StartupPath & "\BP.xml"
            strItem = objMainRecset.Fields.Item(0).Value
            objMainItem = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
            If objMainItem.GetByKey(strItem) Then
                objRemoteItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
                If objRemoteItem.GetByKey(strItem) Then
                    objMainCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objMainItem.SaveXML(FileName)
                    objRemoteCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objRemoteItem = objRemoteCompany.GetBusinessObjectFromXML(FileName, 0)
                    If objRemoteItem.Update <> 0 Then
                        WriteErrorlog("Failed to update BP : " & objRemoteItem.CardCode & ":" & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        objMainItem.UserFields.Fields.Item("U_Action").Value = "N"
                        objMainItem.Update()
                        WriteErrorlog("BP Updated : " & objRemoteItem.CardCode, sPath)
                    End If
                End If
            End If
            objMainRecset.MoveNext()
        Next
    End Sub
#End Region

#Region "Get MaxCode"
    Public Function getMaxCode(ByVal sTable As String, ByVal sColumn As String, ByVal oRecSet As SAPbobsCOM.Recordset) As String
        Dim oRS As SAPbobsCOM.Recordset
        Dim MaxCode As Integer
        Dim sCode As String
        Dim strSQL As String
        Try
            strSQL = "SELECT MAX(CAST(" & sColumn & " AS Numeric)) FROM [" & sTable & "]"
            oRecSet.DoQuery(strSQL)

            If Convert.ToString(oRecSet.Fields.Item(0).Value).Length > 0 Then
                MaxCode = oRecSet.Fields.Item(0).Value + 1
            Else
                MaxCode = 1
            End If

            sCode = Format(MaxCode, "00000000")
            Return sCode
        Catch ex As Exception
            Throw ex
        Finally
            oRS = Nothing
        End Try
    End Function
#End Region

#Region "Export Stock transfer Request Details"
    Private Sub StocktransferRequest()
        Dim FileName, strItem, strSQLquery, strCode As String
        Dim Ecount As Long
        Dim ii, intDocEntry As Long
        strSQLquery = "SELECT T0.[DocEntry], T0.[U_DocDate], T0.[U_WhsCode], T1.[U_ItemCode], T1.[U_ItemName], T1.[U_Qty],T0.U_Status FROM [dbo].[@DABT_STRHEADER]  T0 "
        strSQLquery = strSQLquery & " inner join [dbo].[@DABT_STRLINES]  T1  on  (T0.[DocEntry] = T1.[DocEntry]  )  where t0.U_Status='O' and  isnull(T1.U_ItemCode,'')<>''"
        Dim objMainItem, objRemoteItem As SAPbobsCOM.UserTable
        Dim objMainRecset, objremoteRecSet As SAPbobsCOM.Recordset
        objremoteRecSet = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objremoteRecSet.DoQuery(strSQLquery)
        objMainRecset = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        For intItemLoop As Integer = 0 To objremoteRecSet.RecordCount - 1
            intDocEntry = objremoteRecSet.Fields.Item(0).Value
            objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            objMainItem = objMainCompany.UserTables.Item("DABT_StImport")
            strCode = getMaxCode("@DABT_StImport", "Code", objMainRecset)
            objMainItem.Code = strCode
            objMainItem.Name = strCode
            objMainItem.UserFields.Fields.Item("U_TransDate").Value = objremoteRecSet.Fields.Item(1).Value
            objMainItem.UserFields.Fields.Item("U_TransWhs").Value = objremoteRecSet.Fields.Item(2).Value
            objMainItem.UserFields.Fields.Item("U_ItemCode").Value = objremoteRecSet.Fields.Item(3).Value
            objMainItem.UserFields.Fields.Item("U_ItemName").Value = objremoteRecSet.Fields.Item(4).Value
            objMainItem.UserFields.Fields.Item("U_ReqQty").Value = objremoteRecSet.Fields.Item(5).Value
            If objMainItem.Add <> 0 Then
                WriteErrorlog("Failed to import data " & objRemoteCompany.GetLastErrorDescription, sPath)
            Else
                objMainRecset = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                objMainRecset.DoQuery("Update [@DABT_STRHEADER] set U_Status='I' where docentry=" & intDocEntry)
            End If
            objremoteRecSet.MoveNext()
        Next
    End Sub
#End Region

#Region "Impot Item Master"
    Private Sub ImportItemMaster()
        Dim FileName, strItem, strDflWhs As String
        Dim Ecount As Long
        Dim ii As Long
        Dim objMainItem, objRemoteItem As SAPbobsCOM.Items
        Dim objMainRecset As SAPbobsCOM.Recordset
        objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objMainRecset.DoQuery("Select ItemCode from OITM where U_Action<>'N'")
        For intItemLoop As Integer = 0 To objMainRecset.RecordCount - 1
            FileName = System.Windows.Forms.Application.StartupPath & "\Item.xml"
            strItem = objMainRecset.Fields.Item(0).Value
            objMainItem = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
            If objMainItem.GetByKey(strItem) Then
                objRemoteItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
                If objRemoteItem.GetByKey(strItem) Then
                    strDflWhs = objRemoteItem.DefaultWarehouse
                    objMainCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objMainItem.SaveXML(FileName)
                    objRemoteCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objRemoteItem = objRemoteCompany.GetBusinessObjectFromXML(FileName, 0)
                    If objRemoteItem.Update() <> 0 Then
                        WriteErrorlog("Failed to Update item : " & objRemoteItem.ItemCode & ":" & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        WriteErrorlog("Item Code updated : " & objRemoteItem.ItemCode, sPath)
                        If objRemoteItem.GetByKey(strItem) Then
                            objRemoteItem.DefaultWarehouse = strDflWhs
                            objRemoteItem.Update()
                        End If
                    End If
                Else
                    objMainCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objMainItem.SaveXML(FileName)
                    objRemoteCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objRemoteItem = objRemoteCompany.GetBusinessObjectFromXML(FileName, 0)
                    If objRemoteItem.Add() <> 0 Then
                        WriteErrorlog("Failed to create item : " & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        WriteErrorlog("New Item Created : " & objRemoteItem.ItemCode, sPath)
                    End If
                End If
            End If
            objMainRecset.MoveNext()
        Next
    End Sub

    Private Sub UpdateItemMaster()
        Dim FileName, strItem As String
        Dim Ecount As Long
        Dim ii As Long
        Dim objMainItem, objRemoteItem As SAPbobsCOM.Items
        Dim objMainRecset As SAPbobsCOM.Recordset
        objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objMainRecset.DoQuery("Select ItemCode from OITM where U_Action='U'")
        For intItemLoop As Integer = 0 To objMainRecset.RecordCount - 1
            FileName = System.Windows.Forms.Application.StartupPath & "\Item.xml"
            strItem = objMainRecset.Fields.Item(0).Value
            objMainItem = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
            If objMainItem.GetByKey(strItem) Then
                objRemoteItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
                If objRemoteItem.GetByKey(strItem) Then
                    objMainCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objMainItem.SaveXML(FileName)
                    objRemoteCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
                    objRemoteItem = objRemoteCompany.GetBusinessObjectFromXML(FileName, 0)
                    If objRemoteItem.Update <> 0 Then
                        WriteErrorlog("Failed to Update item : " & objRemoteItem.ItemCode & ":" & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        WriteErrorlog("Update Completed : " & objRemoteItem.Treecode, sPath)
                    End If
                End If
            End If
            objMainRecset.MoveNext()
        Next
    End Sub

    Private Sub UpdateBOM()
        Dim FileName, strItem As String
        Dim Ecount As Long
        Dim ii As Long
        Dim objMainItem, objRemoteItem As SAPbobsCOM.ProductTrees
        Dim objMainRecset As SAPbobsCOM.Recordset
        objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objMainRecset.DoQuery("Select * from OITT where TreeType='P' and  U_Action='U'")
        For intItemLoop As Integer = 0 To objMainRecset.RecordCount - 1
            FileName = System.Windows.Forms.Application.StartupPath & "\Item.xml"
            strItem = objMainRecset.Fields.Item("Code").Value
            objMainItem = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees)
            If objMainItem.GetByKey(strItem) Then
                objRemoteItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees)
                If objRemoteItem.GetByKey(strItem) Then
                    objRemoteItem.TreeCode = objMainItem.TreeCode
                    objRemoteItem.TreeType = SAPbobsCOM.BoItemTreeTypes.iProductionTree
                    objRemoteItem.Quantity = objMainItem.Quantity
                    objRemoteItem.UserFields.Fields.Item("U_SaleBOM").Value = objMainItem.UserFields.Fields.Item("U_SaleBOM").Value
                    For intRow As Integer = 0 To objMainItem.Items.Count - 1
                        If intRow > 0 Then
                            objRemoteItem.Items.Add()
                            objRemoteItem.Items.SetCurrentLine(intRow)
                        End If
                        objMainItem.Items.SetCurrentLine(intRow)
                        objRemoteItem.Items.ItemCode = objMainItem.Items.ItemCode
                        objRemoteItem.Items.IssueMethod = objMainItem.Items.IssueMethod
                        objRemoteItem.Items.ParentItem = objMainItem.Items.ParentItem
                        objRemoteItem.Items.Price = objMainItem.Items.Price
                        objRemoteItem.Items.PriceList = objMainItem.Items.PriceList
                        objRemoteItem.Items.Currency = objMainItem.Items.Currency
                        objRemoteItem.Items.Quantity = objMainItem.Items.Quantity
                        objRemoteItem.Items.Warehouse = objMainItem.Items.Warehouse
                    Next
                    If objRemoteItem.Update() <> 0 Then
                        WriteErrorlog("Failed to Update BOM : " & objMainItem.TreeCode & " :  " & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        objMainItem.UserFields.Fields.Item("U_Action").Value = "N"
                        objMainItem.Update()
                        WriteErrorlog("BOM Updated : " & objRemoteItem.TreeCode, sPath)
                    End If
                End If
            End If
            objMainRecset.MoveNext()
        Next
    End Sub

    Private Sub ImportBOM()
        Dim FileName, strItem As String
        Dim Ecount As Long
        Dim ii As Long
        Dim objMainItem, objRemoteItem As SAPbobsCOM.ProductTrees
        Dim objMainRecset As SAPbobsCOM.Recordset
        objMainRecset = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        objMainRecset.DoQuery("Select * from OITT where  TreeType='P' and  U_Action<>'N'")
        For intItemLoop As Integer = 0 To objMainRecset.RecordCount - 1
            FileName = System.Windows.Forms.Application.StartupPath & "\Item.xml"
            strItem = objMainRecset.Fields.Item("Code").Value
            objMainItem = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees)
            If objMainItem.GetByKey(strItem) Then
                objRemoteItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oProductTrees)
                If objRemoteItem.GetByKey(strItem) Then
                    objRemoteItem.TreeCode = objMainItem.TreeCode
                    objRemoteItem.TreeType = SAPbobsCOM.BoItemTreeTypes.iProductionTree
                    objRemoteItem.Quantity = objMainItem.Quantity
                    objRemoteItem.UserFields.Fields.Item("U_SaleBOM").Value = objMainItem.UserFields.Fields.Item("U_SaleBOM").Value
                    For intRow As Integer = 0 To objMainItem.Items.Count - 1
                        If intRow > 0 Then
                            objRemoteItem.Items.Add()
                            objRemoteItem.Items.SetCurrentLine(intRow)
                        End If
                        objMainItem.Items.SetCurrentLine(intRow)
                        objRemoteItem.Items.ItemCode = objMainItem.Items.ItemCode
                        objRemoteItem.Items.IssueMethod = objMainItem.Items.IssueMethod
                        objRemoteItem.Items.ParentItem = objMainItem.Items.ParentItem
                        objRemoteItem.Items.Price = objMainItem.Items.Price
                        objRemoteItem.Items.PriceList = objMainItem.Items.PriceList
                        objRemoteItem.Items.Currency = objMainItem.Items.Currency
                        objRemoteItem.Items.Quantity = objMainItem.Items.Quantity
                        objRemoteItem.Items.Warehouse = objMainItem.Items.Warehouse
                    Next
                    If objRemoteItem.Update() <> 0 Then
                        WriteErrorlog("Failed to Update BOM : " & objMainItem.TreeCode & " : " & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        'objMainItem.UserFields.Fields.Item("U_Action").Value = "N"
                        'objMainItem.Update()
                        WriteErrorlog("BOM Updated : " & objRemoteItem.TreeCode, sPath)
                    End If
                Else
                    objRemoteItem.TreeCode = objMainItem.TreeCode
                    objRemoteItem.TreeType = SAPbobsCOM.BoItemTreeTypes.iProductionTree
                    objRemoteItem.Quantity = objMainItem.Quantity
                    objRemoteItem.UserFields.Fields.Item("U_SaleBOM").Value = objMainItem.UserFields.Fields.Item("U_SaleBOM").Value
                    For intRow As Integer = 0 To objMainItem.Items.Count - 1
                        If intRow > 0 Then
                            objRemoteItem.Items.Add()
                            objRemoteItem.Items.SetCurrentLine(intRow)
                        End If
                        objMainItem.Items.SetCurrentLine(intRow)
                        objRemoteItem.Items.ItemCode = objMainItem.Items.ItemCode
                        objRemoteItem.Items.IssueMethod = objMainItem.Items.IssueMethod
                        objRemoteItem.Items.ParentItem = objMainItem.Items.ParentItem
                        objRemoteItem.Items.Price = objMainItem.Items.Price
                        objRemoteItem.Items.PriceList = objMainItem.Items.PriceList
                        objRemoteItem.Items.Currency = objMainItem.Items.Currency
                        objRemoteItem.Items.Quantity = objMainItem.Items.Quantity
                        objRemoteItem.Items.Warehouse = objMainItem.Items.Warehouse
                    Next
                    If objRemoteItem.Add() <> 0 Then
                        WriteErrorlog("Failed to create BOM : " & objMainItem.TreeCode & " : " & objRemoteCompany.GetLastErrorDescription, sPath)
                    Else
                        'objMainItem.UserFields.Fields.Item("U_Action").Value = "N"
                        'objMainItem.Update()
                        WriteErrorlog("New BOM Created : " & objRemoteItem.TreeCode, sPath)
                    End If
                End If
            End If
            objMainRecset.MoveNext()
        Next
    End Sub

#End Region

#Region "Export Mobilestic Files"

    Public Sub ExportItemMasterData(ByVal aItemCode As String, ByVal aFileName As String, ByVal strUDTCode As String)
        Dim oRecItem, oRecItemCode, oTepRS As SAPbobsCOM.Recordset
        Dim strSQL, strFilename, strSelectedFolderPath As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strExportFilePaty As String
        Dim blnErrorflag As Boolean
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = aFileName 'strPath & "\Import_ExportLog_" & strFilename & ".txt"
        '  WriteErrorlog("Exporting item Details", strPath)
        strSQL = "Select * from oitm where Itemcode='" & aItemCode & "'"
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        Dim FILedatetiem As String
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")
        ReadiniFile()
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            strExportFilePaty = strSelectedFolderPath
        Else
            strExportFilePaty = strSelectedFolderPath
        End If

        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If

        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("ItemCode").Value.ToString.ToUpper()
            Dim strTRGFileName As String
            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime & "_" & strUDTCode
            strTRGFileName = strExportFilePaty & "\PART_INB_IFD_" & FILedatetiem & ".trg"
            strFilename = strExportFilePaty & "\PART_INB_IFD_" & FILedatetiem & ".xml"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_PART_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("PART_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()
            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()
            writer.WriteStartElement("PART_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("PART")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            oTepRS.DoQuery("Select * from [@MOB_Export] where code='" & strUDTCode & "' and  U_MasterCode='" & aItemCode & "' and U_DocType='I'")
            '    writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            Dim strAction, transtype As String
            transtype = ""
            If transtype = "" Then
                strAction = oTepRS.Fields.Item("U_Action").Value
                writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            Else
                strAction = transtype
                writer.WriteString(transtype)
            End If

            writer.WriteEndElement()
            writer.WriteStartElement("PRTNUM")
            writer.WriteString(oRecItem.Fields.Item("ItemCode").Value.ToString.ToUpper())
            writer.WriteEndElement()


            '<ORGFLG> 
            Dim oORGRS As SAPbobsCOM.Recordset
            oORGRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            writer.WriteStartElement("ORGFLG")
            oORGRS.DoQuery("Select isnull(U_producttype,'') from OITM where itemcode='" & oRecItem.Fields.Item("ItemCode").Value & "'")
            If oORGRS.Fields.Item(0).Value.ToString.ToUpper = "ACCESSORY" Then
                writer.WriteString("1")
            Else
                writer.WriteString("0")
            End If
            writer.WriteEndElement()

            oORGRS.DoQuery("Select Itmsgrpcod from OITM where itemcode='" & oRecItem.Fields.Item("ItemCode").Value & "'")

            writer.WriteStartElement("ABCCOD")
            If oORGRS.Fields.Item(0).Value = "101" Then
                writer.WriteString("A")
            ElseIf oORGRS.Fields.Item(0).Value = "102" Then
                writer.WriteString("B")
            Else
                writer.WriteString("C")

            End If


            writer.WriteEndElement()

            writer.WriteStartElement("TYPCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PRTFAM")
            writer.WriteEndElement()

            writer.WriteStartElement("LODLVL")
            If oRecItem.Fields.Item("ManSerNum").Value = "Y" Then
                writer.WriteString("S")
            Else
                writer.WriteString("L")
            End If
            writer.WriteEndElement()

            writer.WriteStartElement("UNTCST")
            Dim dblavgPrice As Double
            Dim strAvgPrice As String
            dblavgPrice = oRecItem.Fields.Item("AvgPrice").Value
            strAvgPrice = dblavgPrice.ToString(".0000")


            'writer.WriteString(oRecItem.Fields.Item("AvgPrice").Value)
            writer.WriteString(strAvgPrice)
            writer.WriteEndElement()
            writer.WriteStartElement("STKUOM")
            writer.WriteString("EA")
            writer.WriteEndElement()
            writer.WriteStartElement("RCVSTS")
            writer.WriteString("SHIP")
            writer.WriteEndElement()
            writer.WriteStartElement("RCVFLG")
            ' writer.WriteString(oRecItem.Fields.Item("U_NeedApproval").Value)
            If strAction = "A" Then
                writer.WriteString("1")
            Else
                'writer.WriteString("1")
            End If
            writer.WriteEndElement()
            If oRecItem.Fields.Item("ManSerNum").Value = "Y" Then
                writer.WriteStartElement("SER_TYP")
                If oRecItem.Fields.Item("MngMethod").Value = "A" Then
                    writer.WriteString("INCAP_OUTVAL")
                ElseIf oRecItem.Fields.Item("MngMethod").Value = "R" Then
                    writer.WriteString("INCAP_OUTVAL")
                End If
                writer.WriteEndElement()
                writer.WriteStartElement("SER_LVL")
                If oRecItem.Fields.Item("ManSerNum").Value = "Y" Then
                    writer.WriteString("D")
                Else
                    writer.WriteString("")
                End If
                writer.WriteEndElement()
            Else
                writer.WriteStartElement("SER_TYP")
                writer.WriteEndElement()
                writer.WriteStartElement("SER_LVL")
                writer.WriteEndElement()
            End If

            'writer.WriteStartElement("PRTCOLOR")
            'writer.WriteString(oRecItem.Fields.Item("U_ColorID").Value)
            'writer.WriteEndElement()

            '  writer.WriteEndElement() 'End of Part Segemnt


            writer.WriteStartElement("COMCOD")
            Dim oCOmCode As SAPbobsCOM.Recordset
            oCOmCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oCOmCode.DoQuery("SELECT  isnull(dbo.[@SKU_CATEGORY].U_CommCode,'') FROM  dbo.OITM INNER JOIN  dbo.[@SKU_CATEGORY] ON dbo.OITM.U_CatID = dbo.[@SKU_CATEGORY].Code and dbo.OITM.ITEMCODE='" & oRecItem.Fields.Item("ItemCode").Value & "'")
            writer.WriteString(oCOmCode.Fields.Item(0).Value)
            writer.WriteEndElement()

            writer.WriteStartElement("PART_DESCRIPTION_SEG")
            writer.WriteStartElement("SENNAM")
            writer.WriteString("PART_DESC")
            writer.WriteEndElement()
            writer.WriteStartElement("LNGDSC")
            writer.WriteString(oRecItem.Fields.Item("ItemName").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("SHORT_DSC")
            writer.WriteEndElement()
            writer.WriteEndElement()

            'Repack elements

            writer.WriteStartElement("REPACK_CLASS_SEG")
            writer.WriteStartElement("SEGNAME")
            writer.WriteString("REPACK_CLASS")
            writer.WriteEndElement()
            writer.WriteStartElement("RPKCLS")
            writer.WriteString("P")
            writer.WriteEndElement()
            writer.WriteStartElement("SRTSEQ")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("REPACK_CLASS_SEG")
            writer.WriteStartElement("SEGNAME")
            writer.WriteString("REPACK_CLASS")
            writer.WriteEndElement()
            writer.WriteStartElement("RPKCLS")
            writer.WriteString("M")
            writer.WriteEndElement()
            writer.WriteStartElement("SRTSEQ")
            writer.WriteEndElement()
            writer.WriteEndElement()
            'end repack eleements
            If oRecItem.Fields.Item("ManSerNum").Value = "Y" And strAction = "A" Then
                If oRecItem.Fields.Item("U_producttype").Value <> "" Then
                    Dim oTempProd, otempProd1 As SAPbobsCOM.Recordset
                    Dim strProduct, strWMSSer, strSQL2, strSQL1 As String
                    oTempProd = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    otempProd1 = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    strSQL2 = "select isnull(U_WMSSerTyp1,''),isnull(U_WMSSerTyp2,'') from [@SKU_PRODUCTTYPE] where Name='" & oRecItem.Fields.Item("U_producttype").Value & "'"
                    oTempProd.DoQuery(strSQL2)
                    If oTempProd.Fields.Item(0).Value <> "" Then
                        strSQL1 = "select * from [@SKU_SERIALTYPE] where U_WMSSerTyp='" & oTempProd.Fields.Item(0).Value & "'"
                        otempProd1.DoQuery(strSQL1)
                        If otempProd1.RecordCount > 0 Then
                            writer.WriteStartElement("SER_NUM_TYP_SEG")
                            writer.WriteStartElement("SEGNAM")
                            writer.WriteString("SER_NUM_TYP")
                            writer.WriteEndElement()

                            writer.WriteStartElement("SER_NUM_TYP_ID")
                            writer.WriteString(otempProd1.Fields.Item("U_WMSSerTyp").Value)
                            writer.WriteEndElement()

                            writer.WriteStartElement("SER_MSK")
                            writer.WriteString(otempProd1.Fields.Item("U_MASK").Value)
                            writer.WriteEndElement()
                            writer.WriteStartElement("RPT_TO_HOST_FLG")
                            writer.WriteString(otempProd1.Fields.Item("U_HOST").Value)
                            writer.WriteEndElement()

                            writer.WriteStartElement("SRTSEQ")
                            writer.WriteString(otempProd1.Fields.Item("U_SORT").Value)
                            writer.WriteEndElement()
                            writer.WriteStartElement("LNGDSC")
                            writer.WriteString(otempProd1.Fields.Item("U_WMSSerDes").Value)
                            writer.WriteEndElement()
                            writer.WriteStartElement("SHORT_DSC")
                            writer.WriteEndElement()
                            writer.WriteEndElement()
                        End If
                    End If

                    If oTempProd.Fields.Item(1).Value <> "" Then
                        otempProd1.DoQuery("select * from [@SKU_SERIALTYPE] where U_WMSSerTyp='" & oTempProd.Fields.Item(1).Value & "'")
                        If otempProd1.RecordCount > 0 Then
                            writer.WriteStartElement("SER_NUM_TYP_SEG")
                            writer.WriteStartElement("SEGNAM")
                            writer.WriteString("SER_NUM_TYP")
                            writer.WriteEndElement()

                            writer.WriteStartElement("SER_NUM_TYP_ID")
                            writer.WriteString(otempProd1.Fields.Item("U_WMSSerTyp").Value)
                            writer.WriteEndElement()

                            writer.WriteStartElement("SER_MSK")
                            writer.WriteString(otempProd1.Fields.Item("U_MASK").Value)
                            writer.WriteEndElement()
                            writer.WriteStartElement("RPT_TO_HOST_FLG")
                            writer.WriteString(otempProd1.Fields.Item("U_HOST").Value)
                            writer.WriteEndElement()

                            writer.WriteStartElement("SRTSEQ")
                            writer.WriteString(otempProd1.Fields.Item("U_SORT").Value)
                            writer.WriteEndElement()
                            writer.WriteStartElement("LNGDSC")
                            writer.WriteString(otempProd1.Fields.Item("U_WMSSerDes").Value)
                            writer.WriteEndElement()
                            writer.WriteStartElement("SHORT_DSC")
                            writer.WriteEndElement()
                            writer.WriteEndElement()
                        End If
                    End If

                End If
            End If


            'End Serial Num Type Segment



            Dim oTempRs As SAPbobsCOM.Recordset
            oTempRs = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTempRs.DoQuery("Select * from OALI where OrigItem='" & oRecItem.Fields.Item("ItemCode").Value & "'")

            If strAction = "A" Then
                If oRecItem.Fields.Item("U_MPN").Value <> "" Then
                    writer.WriteStartElement("PART_ALT_PRTNUM_SEG")
                    writer.WriteStartElement("SEGNAM")
                    writer.WriteString("ALT_PRTNUM")
                    writer.WriteEndElement()
                    writer.WriteStartElement("ALT_PRT_TYP")
                    writer.WriteString("MPN")
                    writer.WriteEndElement()
                    writer.WriteStartElement("ALT_PRTNUM")
                    writer.WriteString(oRecItem.Fields.Item("U_MPN").Value)
                    writer.WriteEndElement()
                    writer.WriteStartElement("UOMCOD")
                    writer.WriteString("EA")
                    writer.WriteEndElement()

                    writer.WriteStartElement("RFID_FILTER_VAL_COD")
                    writer.WriteString("UNIT")
                    writer.WriteEndElement()
                    writer.WriteEndElement()
                End If

                If oRecItem.Fields.Item("U_Barcode1").Value <> "" Then
                    writer.WriteStartElement("PART_ALT_PRTNUM_SEG")
                    writer.WriteStartElement("SEGNAM")
                    writer.WriteString("ALT_PRTNUM")
                    writer.WriteEndElement()
                    writer.WriteStartElement("ALT_PRT_TYP")

                    writer.WriteString("UPCCOD")
                    writer.WriteEndElement()
                    writer.WriteStartElement("ALT_PRTNUM")
                    writer.WriteString(oRecItem.Fields.Item("U_Barcode1").Value)
                    writer.WriteEndElement()
                    writer.WriteStartElement("UOMCOD")
                    writer.WriteString("EA")
                    writer.WriteEndElement()
                    writer.WriteStartElement("RFID_FILTER_VAL_COD")
                    writer.WriteString("UNIT")
                    writer.WriteEndElement()
                    writer.WriteEndElement()
                End If

            End If

            If oTempRs.RecordCount <= 0 Then
                'writer.WriteStartElement("PART_ALT_PRTNUM_SEG")
                'writer.WriteStartElement("SEGNAM")
                'writer.WriteString("ALT_PRTNUM")
                'writer.WriteEndElement()
                'writer.WriteStartElement("ALT_PRTTYP")
                'writer.WriteEndElement()
                'writer.WriteStartElement("ALT_PRTNUM")
                'writer.WriteEndElement()
                'writer.WriteEndElement()
            Else
                'For intRow1 As Integer = 0 To oTempRs.RecordCount - 1
                '    writer.WriteStartElement("PART_ALT_PRTNUM_SEG")
                '    writer.WriteStartElement("SEGNAM")
                '    writer.WriteString("ALT_PRTNUM")
                '    writer.WriteEndElement()
                '    writer.WriteStartElement("ALT_PRTTYP")
                '    writer.WriteString(oTempRs.Fields.Item("AltItem").Value)
                '    writer.WriteEndElement()
                '    writer.WriteStartElement("ALT_PRTNUM")
                '    writer.WriteString(oTempRs.Fields.Item("AltItem").Value)
                '    writer.WriteEndElement()
                '    writer.WriteEndElement()
                '    oTempRs.MoveNext()
                'Next
            End If
            writer.WriteEndElement() 'End of Part Segemnt


            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.Close()
            strMessage = "Export Item Master Completed : " & strFilename
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            fs.Close()
            WriteErrorlog(strMessage, strPath)
            strMessage = "Export Item Master TRG Completed : " & strTRGFileName
            WriteErrorlog(strMessage, strPath)
            oRecItem.MoveNext()
        Next
    End Sub


#Region "Get Country Code"
    Private Function GetCountrycode(ByVal strCountryID As String) As String
        Dim oRecCountry As SAPbobsCOM.Recordset
        oRecCountry = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecCountry.DoQuery("Select isnull(Name,'') from [@MOB_Country] where code='" & strCountryID & "'")
        Return oRecCountry.Fields.Item(0).Value
    End Function
#End Region

#Region "Get CardName"

    Private Function GetCustomerCardName(ByVal aCardCode As String) As String
        Dim oTemRS As SAPbobsCOM.Recordset
        Dim strname As String
        oTemRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemRS.DoQuery("select isnull(CardName,'') from OCRD where cardcode='" & aCardCode & "'")
        strname = oTemRS.Fields.Item(0).Value
        If strname.Length > 35 Then
            strname = strname.Substring(0, 35)
        Else
            strname = strname
        End If
        'Return oTemRS.Fields.Item(0).Value
        Return strname

    End Function
    Private Function GetCardName(ByVal aCardCode As String) As String
        Dim oTemRS As SAPbobsCOM.Recordset
        Dim strname As String
        oTemRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemRS.DoQuery("select isnull(CardFName,'') from OCRD where cardcode='" & aCardCode & "'")
        strname = oTemRS.Fields.Item(0).Value
        If strname.Length > 10 Then
            strname = strname.Substring(0, 10)
        Else
            strname = strname
        End If

        'Return oTemRS.Fields.Item(0).Value
        Return strname

    End Function
#End Region

    Public Sub ExportCustomerData(ByVal aCardCode As String, ByVal afilename As String, ByVal strUDTCode As String)
        Dim oRecItem, oRecItemCode, oTepRS As SAPbobsCOM.Recordset
        Dim strSQL, strFilename As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strExportFilePaty, strSelectedFolderPath As String
        Dim blnErrorflag As Boolean
        Dim FILedatetiem As String
        Dim strTRGFileName As String
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Import_ExportLog_" & strFilename & ".txt"
        strPath = afilename
        'WriteErrorlog("Exporting Customer Details", strPath)
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        'BP customer Master
        strSQL = "Select * from CRD1 where  CARDCODE IN (select CardCode from OCRD where Cardtype='C' and cardcode='" & aCardCode & "')"
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")

        ReadiniFile()
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            strExportFilePaty = strSelectedFolderPath
        Else
            strExportFilePaty = strSelectedFolderPath
        End If


        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If

        Dim transtype As String = ""
        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("U_WMSID").Value & "_" & oRecItem.Fields.Item("CardCode").Value

            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime & "_" & strUDTCode

            strFilename = strExportFilePaty & "\CUST_INB_IFD_" & FILedatetiem & ".xml"
            strTRGFileName = strExportFilePaty & "\CUST_INB_IFD_" & FILedatetiem & ".trg"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_CUST_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("CUST_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()

            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("ADDR_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("ADDR_SEG")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            oTepRS.DoQuery("Select * from [@MOB_Export] where code='" & strUDTCode & "' and  U_MasterCode='" & oRecItem.Fields.Item("CardCode").Value & "' and U_DocType='B'")
            'writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            ' writer.WriteString(transtype)
            ' Dim transtype As String = ""
            transtype = ""
            If transtype = "" Then
                writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            Else
                writer.WriteString(transtype)
            End If

            writer.WriteEndElement()
            writer.WriteStartElement("HOST_EXT_ID")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
            writer.WriteStartElement("ADRNAM")

            Dim strAdrNam, strAdrnam1 As String
            If oRecItem.Fields.Item("U_AddressType").Value = 1 Then
                strAdrNam = oRecItem.Fields.Item("Address").Value
                If strAdrNam.Length > 39 Then
                    strAdrNam = strAdrNam.Substring(0, 39)
                End If
            Else
                strAdrNam = GetCustomerCardName(oRecItem.Fields.Item("CardCode").Value)
                strAdrnam1 = oRecItem.Fields.Item("Address").Value
                If strAdrNam.Length > 35 Then
                    strAdrnam1 = strAdrNam.Substring(0, 35).Trim
                Else
                    strAdrnam1 = strAdrNam
                End If
                Dim strCode As String()
                Dim strWMSIDCode As String
                strWMSIDCode = oRecItem.Fields.Item("U_WMSID").Value
                strCode = strWMSIDCode.Split("-")
                If strCode.Length > 1 Then
                    strAdrNam = strAdrnam1 & "-" & strCode(1)
                Else
                    strAdrNam = strAdrnam1 '& " " & oRecItem.Fields.Item("U_WMSID").Value
                End If
            End If
            'strAdrNam = strAdrnam1 & " " & oRecItem.Fields.Item("U_WMSID").Value
            writer.WriteString(strAdrNam)

            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRTYP")
            writer.WriteString("CST")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN1")
            '    writer.WriteString(oRecItem.Fields.Item("Address").Value)
            writer.WriteString(oRecItem.Fields.Item("Street").Value)
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN2")
            'writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRLN3")
            ' writer.WriteString(oRecItem.Fields.Item("Address3").Value)
            Dim strCounty As String
            strCounty = oRecItem.Fields.Item("County").Value
            If strCounty.Length > 39 Then
                strCounty = strCounty.Substring(0, 39)
            End If
            writer.WriteString(strCounty)

            writer.WriteEndElement()
            writer.WriteStartElement("ADRCTY")
            writer.WriteString(oRecItem.Fields.Item("city").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRSTC")
            writer.WriteString(oRecItem.Fields.Item("State").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRPSZ")
            writer.WriteString(oRecItem.Fields.Item("ZipCode").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CTRY_NAME")
            writer.WriteString(GetCountrycode(oRecItem.Fields.Item("Country").Value))
            writer.WriteEndElement()
            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PHNNUM")
            Dim oTest As SAPbobsCOM.Recordset
            Dim strPhone As String
            strPhone = oRecItem.Fields.Item("U_ShipAddressPhone").Value
            oTest = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            If strPhone = "" Then
                oTest.DoQuery("Select isnull(Phone1,'') from OCRD where cardcode='" & oRecItem.Fields.Item("CardCode").Value & "'")
                writer.WriteString(oTest.Fields.Item(0).Value)
            Else
                writer.WriteString(strPhone)
            End If
            writer.WriteEndElement()

            writer.WriteStartElement("FAXNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("RSAFLG")
            writer.WriteEndElement()

            writer.WriteStartElement("TEMP_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("LAST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("FIRST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("HOBORIFIC")
            writer.WriteEndElement()

            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("ADR_DISTRICT")
            writer.WriteEndElement()
            writer.WriteStartElement("WEB_ADR")
            writer.WriteEndElement()
            writer.WriteStartElement("EMAIL_ADR")
            writer.WriteEndElement()

            writer.WriteStartElement("PAGNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("LOCALE_ID")
            writer.WriteEndElement()
            writer.WriteStartElement("ATTN_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("ATTN_TEL")
            writer.WriteEndElement()
            writer.WriteStartElement("CONT_NAME")
            writer.WriteEndElement()

            writer.WriteStartElement("CONT_TEL")
            writer.WriteEndElement()
            writer.WriteStartElement("CONT_TITLE")
            writer.WriteEndElement()
            writer.WriteStartElement("PO_BOX_FLG")
            writer.WriteEndElement()
            writer.WriteEndElement()


            writer.WriteStartElement("CUST_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("CUSTOMER")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            oTepRS.DoQuery("Select * from [@MOB_Export] where U_MasterCode='" & oRecItem.Fields.Item("CardCode").Value & "' and U_DocType='B'")
            'writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            '    writer.WriteString(transtype)

            If transtype = "" Then
                writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            Else
                writer.WriteString(transtype)
            End If

            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("CSTNUM")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CSTTYP")
            writer.WriteEndElement()


            'Repack Session
            '•	<REPACK_CLASS_SEG>
            '•	<SEGNAM>REPACK_CLASS</SEGNAM>
            '•	<RPKCLS>MC</RPKCLS>
            '•	</REPACK_CLASS_SEG>

            writer.WriteStartElement("REPACK_CLASS_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("REPACK_CLASS")
            writer.WriteEndElement()
            writer.WriteStartElement("RPKCLS")
            writer.WriteString("MC")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("REPACK_CLASS_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("REPACK_CLASS")
            writer.WriteEndElement()
            writer.WriteStartElement("RPKCLS")

            'oTest.DoQuery("Select isnull(U_BlindShipCustomer,0) from OCRD where cardcode='" & oRecItem.Fields.Item("CardCode").Value & "'")
            'If oTest.Fields.Item(0).Value = 0 Then
            '    writer.WriteString("P")
            'Else
            '    writer.WriteString("M")
            'End If

            If oRecItem.Fields.Item("U_ADDRESSTYPE").Value.ToString = "1" Then
                writer.WriteString("P")
            Else
                writer.WriteString("M")
            End If

            writer.WriteEndElement()
            writer.WriteEndElement()

            'End Repack session
            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.Close()

            strMessage = "Export BP Master Completed :" & strFilename
            WriteErrorlog(strMessage, strPath)
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            strMessage = "Export BP Master TRG Completed :" & strTRGFileName
            WriteErrorlog(strMessage, strPath)
            fs.Close()
            oRecItem.MoveNext()
        Next

    End Sub

    Public Sub ExportsupplierData(ByVal aCardCode As String, ByVal aFileName As String, ByVal strUDTCode As String)
        Dim oRecItem, oRecItemCode As SAPbobsCOM.Recordset
        Dim strSQL, strFilename As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strSelectedFolderPath, strExportFilePaty As String
        Dim blnErrorflag As Boolean
        Dim FILedatetiem As String
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Import_ExportLog_" & strFilename & ".txt"
        strPath = aFileName
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'BP customer Master
        strSQL = "Select * from CRD1 where CARDCODE IN (select CardCode from OCRD where Cardtype='S' and cardcode='" & aCardCode & "')"
        'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")
        ReadiniFile()
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            ' strExportFilePaty = strSelectedFolderPath & "Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        Else
            'strExportFilePaty = strSelectedFolderPath & "\Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        End If

        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If
        Dim transtype As String
        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("U_WMSID").Value & "_" & oRecItem.Fields.Item("CardCode").Value
            Dim strTRGFileName As String
            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime & "_" & strUDTCode

            strTRGFileName = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".trg"
            strFilename = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".xml"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_SUPP_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("SUPP_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()

            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("SUPP_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("SUPPLIER")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            Dim oTepRS As SAPbobsCOM.Recordset
            oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTepRS.DoQuery("Select * from [@MOB_Export] where  code='" & strUDTCode & "' and U_MasterCode='" & oRecItem.Fields.Item("CardCode").Value & "' and U_DocType='B'")
            transtype = ""
            If transtype = "" Then
                writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            Else
                writer.WriteString(transtype)
            End If

            writer.WriteEndElement()
            writer.WriteStartElement("SUPNUM")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("HOST_EXT_ID")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()
            'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
            writer.WriteStartElement("ADRNAM")
            Dim strAdrNam, strAdrnam1 As String

            strAdrNam = GetCustomerCardName(oRecItem.Fields.Item("CardCode").Value)
            strAdrnam1 = oRecItem.Fields.Item("Address").Value

            If strAdrNam.Length > 35 Then
                strAdrnam1 = strAdrNam.Substring(0, 35).Trim
            Else
                strAdrnam1 = strAdrNam
            End If
            Dim strCode As String()
            Dim strWMSIDCode As String
            strWMSIDCode = oRecItem.Fields.Item("U_WMSID").Value
            strCode = strWMSIDCode.Split("-")
            If strCode.Length > 1 Then
                strAdrNam = strAdrnam1 & "-" & strCode(1)
            Else
                strAdrNam = strAdrnam1 '& " " & oRecItem.Fields.Item("U_WMSID").Value
            End If


            'strAdrNam = strAdrnam1 & " " & oRecItem.Fields.Item("U_WMSID").Value
            writer.WriteString(strAdrNam)



            ' writer.WriteString(GetCardName(oRecItem.Fields.Item("CardCode").Value))
            writer.WriteEndElement()

            writer.WriteStartElement("ADRTYP")
            writer.WriteString("SUP")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN1")
            '    writer.WriteString(oRecItem.Fields.Item("Address").Value)
            writer.WriteString(oRecItem.Fields.Item("Street").Value)
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN2")
            'writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRLN3")
            'writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRCTY")
            writer.WriteString(oRecItem.Fields.Item("city").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRSTC")
            writer.WriteString(oRecItem.Fields.Item("State").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRPSZ")
            writer.WriteString(oRecItem.Fields.Item("ZipCode").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CTRY_NAME")
            writer.WriteString(GetCountrycode(oRecItem.Fields.Item("country").Value.ToString))
            writer.WriteEndElement()
            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PHNNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("FAXNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("RSAFLG")
            writer.WriteEndElement()

            writer.WriteStartElement("TEMP_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("LAST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("FIRST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("HOBORIFIC")
            writer.WriteEndElement()

            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("ADR_DISTRICT")
            writer.WriteEndElement()
            writer.WriteStartElement("WEB_ADR")
            writer.WriteEndElement()
            writer.WriteStartElement("EMAIL_ADR")
            writer.WriteEndElement()

            writer.WriteStartElement("PAGNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("LOCALE_ID")
            writer.WriteEndElement()

            writer.WriteStartElement("PO_BOX_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("TRK_CNSG_COD")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.Close()
            strMessage = "Export Supplier Master Compleated : " & strFilename
            WriteErrorlog(strMessage, strPath)
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            strMessage = "Export Supplier TRG Master Compleated : " & strTRGFileName
            WriteErrorlog(strMessage, strPath)
            fs.Close()

            oRecItem.MoveNext()
        Next
        ' ShowSuccessMessage("Operation completed successfully")
    End Sub

    Public Sub ExportBilltoSupplierData(ByVal aCardCode As String, ByVal aFileName As String, ByVal strUDTCode As String)
        Dim oRecItem, oRecItemCode As SAPbobsCOM.Recordset
        Dim strSQL, strFilename As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strSelectedFolderPath, strExportFilePaty As String
        Dim blnErrorflag As Boolean
        Dim FILedatetiem As String
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Import_ExportLog_" & strFilename & ".txt"
        strPath = aFileName
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'BP customer Master
        '' strSQL = "Select * from CRD1 where CARDCODE IN (select CardCode from OCRD where Cardtype='S' and cardcode='" & aCardCode & "')"
        strSQL = "Select * from CRD1 where AdresType='B' and CARDCODE IN (select CardCode from OCRD where CardType='C' and cardcode='" & aCardCode & "')"

        'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")
        ReadiniFile()
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            ' strExportFilePaty = strSelectedFolderPath & "Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        Else
            'strExportFilePaty = strSelectedFolderPath & "\Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        End If

        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If
        Dim transtype As String
        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("U_WMSID").Value & "_" & oRecItem.Fields.Item("CardCode").Value
            Dim strTRGFileName As String
            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime & "_" & strUDTCode

            strTRGFileName = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".trg"
            strFilename = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".xml"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_SUPP_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("SUPP_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()

            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("SUPP_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("SUPPLIER")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            Dim oTepRS As SAPbobsCOM.Recordset
            oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTepRS.DoQuery("Select * from [@MOB_Export] where code='" & strUDTCode & "' and  U_MasterCode='" & oRecItem.Fields.Item("CardCode").Value & "' and U_DocType='B'")
            transtype = ""
            If transtype = "" Then
                writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            Else
                writer.WriteString(transtype)
            End If

            writer.WriteEndElement()
            writer.WriteStartElement("SUPNUM")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("HOST_EXT_ID")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()
            'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
            writer.WriteStartElement("ADRNAM")
            Dim strAdrNam, strAdrnam1 As String

            strAdrNam = GetCustomerCardName(oRecItem.Fields.Item("CardCode").Value)
            strAdrnam1 = oRecItem.Fields.Item("Address").Value

            If strAdrNam.Length > 35 Then
                strAdrnam1 = strAdrNam.Substring(0, 35).Trim
            Else
                strAdrnam1 = strAdrNam
            End If
            Dim strCode As String()
            Dim strWMSIDCode As String
            strWMSIDCode = oRecItem.Fields.Item("U_WMSID").Value
            strCode = strWMSIDCode.Split("-")
            If strCode.Length > 1 Then
                strAdrNam = strAdrnam1 & "-" & strCode(1)
            Else
                strAdrNam = strAdrnam1 '& " " & oRecItem.Fields.Item("U_WMSID").Value
            End If


            'strAdrNam = strAdrnam1 & " " & oRecItem.Fields.Item("U_WMSID").Value
            writer.WriteString(strAdrNam)



            ' writer.WriteString(GetCardName(oRecItem.Fields.Item("CardCode").Value))
            writer.WriteEndElement()

            writer.WriteStartElement("ADRTYP")
            writer.WriteString("CST")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN1")
            '    writer.WriteString(oRecItem.Fields.Item("Address").Value)
            writer.WriteString(oRecItem.Fields.Item("Street").Value)
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN2")
            'writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRLN3")
            'writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRCTY")
            writer.WriteString(oRecItem.Fields.Item("city").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRSTC")
            writer.WriteString(oRecItem.Fields.Item("State").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRPSZ")
            writer.WriteString(oRecItem.Fields.Item("ZipCode").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CTRY_NAME")
            writer.WriteString(GetCountrycode(oRecItem.Fields.Item("country").Value.ToString))
            writer.WriteEndElement()
            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PHNNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("FAXNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("RSAFLG")
            writer.WriteEndElement()

            writer.WriteStartElement("TEMP_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("LAST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("FIRST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("HOBORIFIC")
            writer.WriteEndElement()

            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("ADR_DISTRICT")
            writer.WriteEndElement()
            writer.WriteStartElement("WEB_ADR")
            writer.WriteEndElement()
            writer.WriteStartElement("EMAIL_ADR")
            writer.WriteEndElement()

            writer.WriteStartElement("PAGNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("LOCALE_ID")
            writer.WriteEndElement()

            writer.WriteStartElement("PO_BOX_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("TRK_CNSG_COD")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.Close()
            strMessage = "Export Supplier Master Compleated : " & strFilename
            WriteErrorlog(strMessage, strPath)
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            strMessage = "Export Supplier TRG Master Compleated : " & strTRGFileName
            WriteErrorlog(strMessage, strPath)
            fs.Close()

            oRecItem.MoveNext()
        Next
        ' ShowSuccessMessage("Operation completed successfully")
    End Sub


#Region "WMS ID Generation"



#Region "Get next WMS ID"
    Private Function GETNEXTWMSID(ByVal aCardCode As String, ByVal aAdresType As String) As String
        Dim oRs As SAPbobsCOM.Recordset
        Dim strWMSID, strQuery1, strWMSIDTemp As String
        Dim dblWMSID As Double
        oRs = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        If aAdresType = "B" Then
            strQuery1 = "select isnull(max((substring(isnull(U_WMSID,'000000000000'),10,3))),'000')+1  from CRD1  where cardcode='" & aCardCode & "' and Adrestype='B'"
        Else
            strQuery1 = "select isnull(max((substring(isnull(U_WMSID,'000000000000'),10,3))),'000')+1  from CRD1  where cardcode='" & aCardCode & "' and Adrestype='S'"
        End If
        oRs.DoQuery(strQuery1)
        dblWMSID = oRs.Fields.Item(0).Value
        strWMSIDTemp = Format(dblWMSID, "000")
        If aCardCode.Length > 6 Then
            strWMSID = aCardCode.Substring(aCardCode.Length - 6, 6)
        Else
            strWMSID = aCardCode
        End If
        strWMSID = aCardCode.Substring(0, 1) & strWMSID & "-" & aAdresType & strWMSIDTemp

        Return strWMSID
    End Function
#End Region

    Public Sub UpdateWMSID()
        Dim oUpdateRS As SAPbobsCOM.Recordset
        oUpdateRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oUpdateRS.DoQuery("SELECT T1.[CardCode], isnull(T1.[U_WMSID],''), T0.[CardType], T1.[LineNum], T1.[Address],t1.[Adrestype] FROM OCRD T0  INNER JOIN CRD1 T1 ON T0.CardCode = T1.CardCode where  isnull(T1.U_WMSID,'')=''")
        For intLoop As Integer = 0 To oUpdateRS.RecordCount - 1
            GenerateWMSID(oUpdateRS.Fields.Item(0).Value)
            oUpdateRS.MoveNext()
        Next
    End Sub
    Public Sub GenerateWMSID(ByVal aCardCode As String)
        Dim oTempID, oBPRec As SAPbobsCOM.Recordset
        Dim strWMSID As String
        Dim dblWMS As Double
        oTempID = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oBPRec = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oBPRec.DoQuery("SELECT T1.[CardCode], isnull(T1.[U_WMSID],''), T0.[CardType], T1.[LineNum], T1.[Address],t1.[Adrestype] FROM OCRD T0  INNER JOIN CRD1 T1 ON T0.CardCode = T1.CardCode where  T0.cardcode='" & aCardCode & "'")
        For intRow As Integer = 0 To oBPRec.RecordCount - 1
            strWMSID = oBPRec.Fields.Item(1).Value
            If strWMSID = "" Then
                strWMSID = GETNEXTWMSID(aCardCode, oBPRec.Fields.Item(5).Value)
                oTempID.DoQuery("Update CRD1 set U_WMSID='" & strWMSID & "' where Cardcode='" & aCardCode & "' and LineNum=" & oBPRec.Fields.Item(3).Value)
            End If
            oBPRec.MoveNext()
        Next
    End Sub
#End Region


#Region "Export"
    Private Sub export()
        Dim strvalue As String
        Dim stpath As String
        Try
            ReadiniFile()
            stpath = strExportDirectory
            Try
                ExportSKU(stpath, "SKU", objMainCompany)
            Catch ex As Exception
            End Try
            Try
                ExportSalesOrder(stpath, "SO", objMainCompany)
            Catch ex As Exception
            End Try
            Try
                ExportARCreditMemo(stpath, "ARCR", objMainCompany)
            Catch ex As Exception
            End Try
            Try
                ExportPurchaseOrder(stpath, "PO", objMainCompany)
            Catch ex As Exception
            End Try
        Catch ex As Exception
            ' oApplication.Utilities.Message(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
        End Try
    End Sub
#Region "Get StoreKey"
    'Public Function getStoreKey(ByVal aCompany As SAPbobsCOM.Company) As String
    '    Dim stStorekey As String
    '    Dim oTemp As SAPbobsCOM.Recordset
    '    oTemp = aCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '    oTemp.DoQuery("Select isnull(U_Z_Storekey,'') from OADM")
    '    Return oTemp.Fields.Item(0).Value
    'End Function
#End Region

#Region "Export Documents Details"
    Public Sub ExportSKU(ByVal aPath As String, ByVal aChoice As String, ByVal aCompany As SAPbobsCOM.Company)
        If aChoice <> "SKU" Then
            Exit Sub
        End If
        objMainCompany = aCompany
        Dim strPath, strFilename, strMessage, strExportFilePaty, strErrorLog, strTime As String
        ReadiniFile()
        strPath = strExportDirectory ' aPath ' System.Windows.Forms.Application.StartupPath
        strTime = Now.ToShortTimeString.Replace(":", "")
        strFilename = Now.Date.ToString("ddMMyyyy")
        strFilename = strFilename & strTime
        Dim stHours, stMin As String

        strErrorLog = ""
        If aChoice = "SKU" Then
            strErrorLog = strPath & "\Logs\SKU Import"
            strPath = strPath & "\Export\SKU Import"
        End If
        strExportFilePaty = strPath
        If Directory.Exists(strPath) = False Then
            Directory.CreateDirectory(strPath)
        End If
        If Directory.Exists(strErrorLog) = False Then
            Directory.CreateDirectory(strErrorLog)
        End If
        strFilename = "Export SKU_" & strFilename
        strErrorLog = strErrorLog & "\" & strFilename & ".txt"
        '  Message("Processing SKU's Exporting...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
        WriteErrorHeader(strErrorLog, "Export SKU's Starting..")
        If Directory.Exists(strExportFilePaty) = False Then
            Directory.CreateDirectory(strPath)
        End If
        Dim strStore As String
        strStore = getStoreKey(objMainCompany)
        Try
            Dim s As System.Text.StringBuilder = New System.Text.StringBuilder
            Dim strRecquery, strdocnum As String
            Dim oCheckrs As SAPbobsCOM.Recordset
            oCheckrs = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            '  strRecquery = "SELECT isnull(T0.[U_StoreKey],''),T0.[ItemCode], T0.[ItemName], T1.[ItmsGrpNam], T0.[ItemType], T0.[SWeight1], T0.[SVolume], isnull(U_Expirable,'N'), T0.[CodeBars],isnull(T0.U_BxBarCode,''),Isnull(T0.U_CrBarCode,'') , Isnull(T0.U_PlBarCode,''),T0.SalUnitMsr FROM OITM T0  INNER JOIN OITB T1 ON T0.ItmsGrpCod = T1.ItmsGrpCod  and T0.ItemCode in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SKU' and U_Z_Exported='N')"
            strRecquery = "SELECT isnull(T0.[U_StoreKey],''),T0.[ItemCode], T0.[ItemName], T1.[ItmsGrpNam], T0.[ItemType], T0.[SWeight1], T0.[SVolume], isnull(U_Expirable,'N'), T0.[CodeBars],T0.U_Pack1,T0.NumInBuy , T0.PurPackUn FROM OITM T0  INNER JOIN OITB T1 ON T0.ItmsGrpCod = T1.ItmsGrpCod  and T0.ItemCode in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SKU' and U_Z_Exported='N' and U_Storekey='" & strStore & "')"
            oCheckrs.DoQuery(strRecquery)
            '  oApplication.Utilities.Message("Exporting SKU's in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            If oCheckrs.RecordCount > 0 Then
                Dim otemprec As SAPbobsCOM.Recordset
                otemprec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                otemprec.DoQuery(strRecquery)
                If 1 = 1 Then
                    s.Remove(0, s.Length)
                    Dim cols As Integer = 2 ' Me.DataSet1.SalesOrder.Columns.Count
                    strdocnum = ""

                    s.Remove(0, s.Length)
                    s.Append("StoreKey" + vbTab)
                    s.Append("SKU" + vbTab)
                    s.Append("Description" + vbTab)
                    s.Append("SKUGroup2" + vbTab)
                    s.Append("SKUSubGroup" + vbTab)
                    s.Append("Weight" + vbTab)
                    s.Append("Volume" + vbTab)
                    s.Append("RotareBy" + vbTab)
                    '  s.Append("DefaultRotataion" + vbTab)
                    s.Append("AltSKU" + vbTab)
                    ' s.Append("Displaybox" + vbTab)
                    ' s.Append("Case" + vbTab)
                    ' s.Append("Pallet" + vbTab)
                    ' s.Append("DefaultUOM" + vbCrLf)
                    s.Append("DisplayBoxQtyinEA" + vbTab)
                    s.Append("ExportCartonQtyinEA" + vbTab)
                    s.Append("QtyofDisplayBoxinPallet" + vbCrLf)



                    Dim strItem As String
                    strItem = ""
                    For intRow As Integer = 0 To otemprec.RecordCount - 1
                        Dim strQt, strStoreKey, strName, groupname, itemtype, weight, volume, expirable, codebars, packkey, defaultuom As String
                        strQt = CStr(otemprec.Fields.Item(1).Value)
                        If strItem = "" Then
                            strItem = "'" & otemprec.Fields.Item("ItemCode").Value & "'"
                        Else
                            strItem = strItem & ",'" & otemprec.Fields.Item("ItemCode").Value & "'"
                        End If
                        strName = otemprec.Fields.Item("ItemName").Value
                        strStoreKey = ""
                        expirable = ""
                        ' strRecquery = "SELECT T0.[U_StoreKey),T0.[ItemCode], T0.[ItemName], T1.[ItmsGrpNam], T0.[ItemType],
                        ' T0.[SWeight1], T0.[SVolume], isnull(U_Expirable,'N'), T0.[CodeBars],isnull(T0.U_BxBarCode,''),Isnull(T0.U_CrBarCode,'') , Isnull(T0.U_PlBarCode,''),T0.SalUnitMsr FROM OITM T0  INNER JOIN OITB T1 ON T0.ItmsGrpCod = T1.ItmsGrpCod  and T0.ItemCode in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SKU' and U_Z_Exported='N')"

                        s.Append(otemprec.Fields.Item(0).Value + vbTab)
                        s.Append(otemprec.Fields.Item(1).Value + vbTab)
                        s.Append(otemprec.Fields.Item(2).Value + vbTab)
                        s.Append(otemprec.Fields.Item(3).Value + vbTab)
                        s.Append(otemprec.Fields.Item(4).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(5).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(6).Value.ToString + vbTab)
                        expirable = otemprec.Fields.Item(7).Value
                        'If expirable = "N" Then
                        '    s.Append(strStoreKey + vbTab)
                        '    s.Append(strStoreKey + vbTab)
                        'Else
                        '    s.Append("Lottable05" + vbTab)
                        '    s.Append("1" + vbTab)
                        'End If
                        s.Append(expirable + vbTab)
                        s.Append(otemprec.Fields.Item(8).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(9).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(10).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(11).Value.ToString + vbCrLf)
                        ' s.Append(otemprec.Fields.Item(12).Value.ToString + vbCrLf)
                        otemprec.MoveNext()
                    Next
                    Dim filename As String
                    filename = Now.Date.ToString("ddMMyyyyhhmm")
                    filename = strExportFilePaty & "\SKU_" & strFilename & ".csv"
                    Dim strFilename1, strcode, strinsert As String
                    strFilename1 = filename
                    Try
                        My.Computer.FileSystem.WriteAllText(strFilename1, s.ToString, False)
                        If File.Exists("C:\Test123.txt") Then
                            File.Delete("C:\test123.txt")
                        End If
                    Catch ex As Exception
                        strMessage = "Export File name : " & strFilename1 & " failed . Check the ConnectionInfo.Ini /  Connection"
                        WriteErrorlog(strMessage, strErrorLog)
                        End
                    End Try
                    strMessage = strItem & "--> SKU's  Exported compleated: File Name : " & strFilename1
                    Dim oUpdateRS As SAPbobsCOM.Recordset
                    Dim strUpdate As String
                    oUpdateRS = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    strUpdate = "Update [@Z_DABT_Export] set U_Z_Exported='Y' ,U_Z_ExportMethod='A',U_Z_ExportFile='" & strFilename1 & "',U_Z_ExportDate=getdate() where U_Z_MasterCode in (" & strItem & ") and U_Z_DocType='SKU'"
                    oUpdateRS.DoQuery(strUpdate)
                    WriteErrorlog(strMessage, strErrorLog)
                End If
            Else
                strMessage = ("No new SKUs!")
                WriteErrorlog(strMessage, strErrorLog)
            End If
        Catch ex As Exception
            strMessage = ("An Error Occured. A log entry has been created." & ex.Message)
            WriteErrorlog(strMessage, strErrorLog)
        Finally
            strMessage = "Export process compleated"
            WriteErrorlog(strMessage, strErrorLog)
        End Try
        '   System.Windows.Forms.Application.Exit()
    End Sub

    'Public Sub ExportSKU(ByVal aPath As String, ByVal aChoice As String, ByVal aCompany As SAPbobsCOM.Company)
    '    If aChoice <> "SKU" Then
    '        Exit Sub
    '    End If
    '    Dim strPath, strFilename, strMessage, strExportFilePaty, strErrorLog, strTime As String
    '    ReadiniFile()
    '    strPath = strExportDirectory ' aPath ' System.Windows.Forms.Application.StartupPath

    '    strTime = Now.ToShortTimeString.Replace(":", "")
    '    strFilename = Now.Date.ToString("ddMMyyyy")
    '    strFilename = strFilename & strTime
    '    Dim stHours, stMin As String

    '    strErrorLog = ""
    '    If aChoice = "SKU" Then
    '        strErrorLog = strPath & "\Logs\SKU Import"
    '        strPath = strPath & "\Export\SKU Import"
    '    End If
    '    strExportFilePaty = strPath
    '    If Directory.Exists(strPath) = False Then
    '        Directory.CreateDirectory(strPath)
    '    End If
    '    If Directory.Exists(strErrorLog) = False Then
    '        Directory.CreateDirectory(strErrorLog)
    '    End If
    '    strFilename = "Export SKU_" & strFilename
    '    strErrorLog = strErrorLog & "\" & strFilename & ".txt"
    '    '  Message("Processing SKU's Exporting...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
    '    WriteErrorHeader(strErrorLog, "Export SKU's Starting..")
    '    If Directory.Exists(strExportFilePaty) = False Then
    '        Directory.CreateDirectory(strPath)
    '    End If
    '    Try
    '        Dim s As System.Text.StringBuilder = New System.Text.StringBuilder
    '        Dim strRecquery, strdocnum As String
    '        Dim oCheckrs As SAPbobsCOM.Recordset
    '        oCheckrs = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '        '  strRecquery = "SELECT isnull(T0.[U_StoreKey],''),T0.[ItemCode], T0.[ItemName], T1.[ItmsGrpNam], T0.[ItemType], T0.[SWeight1], T0.[SVolume], isnull(U_Expirable,'N'), T0.[CodeBars],isnull(T0.U_BxBarCode,''),Isnull(T0.U_CrBarCode,'') , Isnull(T0.U_PlBarCode,''),T0.SalUnitMsr FROM OITM T0  INNER JOIN OITB T1 ON T0.ItmsGrpCod = T1.ItmsGrpCod  and T0.ItemCode in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SKU' and U_Z_Exported='N')"
    '        strRecquery = "SELECT isnull(T0.[U_StoreKey],''),T0.[ItemCode], T0.[ItemName], T1.[ItmsGrpNam], T0.[ItemType], T0.[SWeight1], T0.[SVolume], isnull(U_Expirable,'N'), T0.[CodeBars],T0.U_Pack1,T0.NumInBuy , T0.PurPackUn FROM OITM T0  INNER JOIN OITB T1 ON T0.ItmsGrpCod = T1.ItmsGrpCod  and T0.ItemCode in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SKU' and U_Z_Exported='N')"
    '        oCheckrs.DoQuery(strRecquery)
    '        '  oApplication.Utilities.Message("Exporting SKU's in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
    '        If oCheckrs.RecordCount > 0 Then
    '            Dim otemprec As SAPbobsCOM.Recordset
    '            otemprec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '            otemprec.DoQuery(strRecquery)
    '            If 1 = 1 Then
    '                s.Remove(0, s.Length)
    '                Dim cols As Integer = 2 ' Me.DataSet1.SalesOrder.Columns.Count
    '                strdocnum = ""

    '                s.Remove(0, s.Length)
    '                s.Append("StoreKey" + vbTab)
    '                s.Append("SKU" + vbTab)
    '                s.Append("Description" + vbTab)
    '                s.Append("SKUGroup2" + vbTab)
    '                s.Append("SKUSubGroup" + vbTab)
    '                s.Append("Weight" + vbTab)
    '                s.Append("Volume" + vbTab)
    '                s.Append("RotareBy" + vbTab)
    '                '  s.Append("DefaultRotataion" + vbTab)
    '                s.Append("AltSKU" + vbTab)
    '                ' s.Append("Displaybox" + vbTab)
    '                ' s.Append("Case" + vbTab)
    '                ' s.Append("Pallet" + vbTab)
    '                ' s.Append("DefaultUOM" + vbCrLf)
    '                s.Append("DisplayBoxQtyinEA" + vbTab)
    '                s.Append("ExportCartonQtyinEA" + vbTab)
    '                s.Append("QtyofDisplayBoxinPallet" + vbCrLf)



    '                Dim strItem As String
    '                strItem = ""
    '                For intRow As Integer = 0 To otemprec.RecordCount - 1
    '                    Dim strQt, strStoreKey, strName, groupname, itemtype, weight, volume, expirable, codebars, packkey, defaultuom As String
    '                    strQt = CStr(otemprec.Fields.Item(1).Value)
    '                    If strItem = "" Then
    '                        strItem = "'" & otemprec.Fields.Item("ItemCode").Value & "'"
    '                    Else
    '                        strItem = strItem & ",'" & otemprec.Fields.Item("ItemCode").Value & "'"
    '                    End If
    '                    strName = otemprec.Fields.Item("ItemName").Value
    '                    strStoreKey = ""
    '                    expirable = ""
    '                    ' strRecquery = "SELECT T0.[U_StoreKey),T0.[ItemCode], T0.[ItemName], T1.[ItmsGrpNam], T0.[ItemType],
    '                    ' T0.[SWeight1], T0.[SVolume], isnull(U_Expirable,'N'), T0.[CodeBars],isnull(T0.U_BxBarCode,''),Isnull(T0.U_CrBarCode,'') , Isnull(T0.U_PlBarCode,''),T0.SalUnitMsr FROM OITM T0  INNER JOIN OITB T1 ON T0.ItmsGrpCod = T1.ItmsGrpCod  and T0.ItemCode in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SKU' and U_Z_Exported='N')"

    '                    s.Append(otemprec.Fields.Item(0).Value + vbTab)
    '                    s.Append(otemprec.Fields.Item(1).Value + vbTab)
    '                    s.Append(otemprec.Fields.Item(2).Value + vbTab)
    '                    s.Append(otemprec.Fields.Item(3).Value + vbTab)
    '                    s.Append(otemprec.Fields.Item(4).Value.ToString + vbTab)
    '                    s.Append(otemprec.Fields.Item(5).Value.ToString + vbTab)
    '                    s.Append(otemprec.Fields.Item(6).Value.ToString + vbTab)
    '                    expirable = otemprec.Fields.Item(7).Value
    '                    'If expirable = "N" Then
    '                    '    s.Append(strStoreKey + vbTab)
    '                    '    s.Append(strStoreKey + vbTab)
    '                    'Else
    '                    '    s.Append("Lottable05" + vbTab)
    '                    '    s.Append("1" + vbTab)
    '                    'End If
    '                    s.Append(expirable + vbTab)
    '                    s.Append(otemprec.Fields.Item(8).Value.ToString + vbTab)
    '                    s.Append(otemprec.Fields.Item(9).Value.ToString + vbTab)
    '                    s.Append(otemprec.Fields.Item(10).Value.ToString + vbTab)
    '                    s.Append(otemprec.Fields.Item(11).Value.ToString + vbCrLf)
    '                    ' s.Append(otemprec.Fields.Item(12).Value.ToString + vbCrLf)
    '                    otemprec.MoveNext()
    '                Next
    '                Dim filename As String
    '                filename = Now.Date.ToString("ddMMyyyyhhmm")
    '                filename = strExportFilePaty & "\SKU_" & strFilename & ".csv"
    '                Dim strFilename1, strcode, strinsert As String
    '                strFilename1 = filename
    '                Try
    '                    My.Computer.FileSystem.WriteAllText(strFilename1, s.ToString, False)
    '                    If File.Exists("C:\Test123.txt") Then
    '                        File.Delete("C:\test123.txt")
    '                    End If
    '                Catch ex As Exception
    '                    strMessage = "Export File name : " & strFilename1 & " failed . Check the ConnectionInfo.Ini /  Connection"
    '                    WriteErrorlog(strMessage, strErrorLog)
    '                    End
    '                End Try
    '                strMessage = strItem & "--> SKU's  Exported compleated: File Name : " & strFilename1
    '                Dim oUpdateRS As SAPbobsCOM.Recordset
    '                Dim strUpdate As String
    '                oUpdateRS = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '                strUpdate = "Update [@Z_DABT_Export] set U_Z_Exported='Y' ,U_Z_ExportMethod='A',U_Z_ExportFile='" & strFilename1 & "',U_Z_ExportDate=getdate() where U_Z_MasterCode in (" & strItem & ") and U_Z_DocType='SKU'"
    '                oUpdateRS.DoQuery(strUpdate)
    '                WriteErrorlog(strMessage, strErrorLog)
    '            End If
    '        Else
    '            strMessage = ("No new SKUs!")
    '            WriteErrorlog(strMessage, strErrorLog)
    '        End If
    '    Catch ex As Exception
    '        strMessage = ("An Error Occured. A log entry has been created." & ex.Message)
    '        WriteErrorlog(strMessage, strErrorLog)
    '    Finally
    '        strMessage = "Export process compleated"
    '        WriteErrorlog(strMessage, strErrorLog)
    '    End Try
    '    '   System.Windows.Forms.Application.Exit()
    'End Sub

    Public Sub ExportSalesOrder(ByVal aPath As String, ByVal aChoice As String, ByVal aCompany As SAPbobsCOM.Company)
        Dim strPath, strFilename, strMessage, strExportFilePaty, strErrorLog, strTime As String
        If aChoice <> "SO" Then
            Exit Sub
        End If
        objMainCompany = aCompany
        ReadiniFile()
        strPath = strExportDirectory ' aPath ' System.Windows.Forms.Application.StartupPath
        strTime = Now.ToShortTimeString.Replace(":", "")
        strFilename = Now.Date.ToString("ddMMyyyy")
        strFilename = strFilename & strTime
        Dim stHours, stMin As String
        strErrorLog = ""
        If aChoice = "SO" Then
            strErrorLog = strPath & "\Logs\SO Import"
            strPath = strPath & "\Export\SO Import"
        End If
        strExportFilePaty = strPath
        If Directory.Exists(strPath) = False Then
            Directory.CreateDirectory(strPath)
        End If
        If Directory.Exists(strErrorLog) = False Then
            Directory.CreateDirectory(strErrorLog)
        End If
        strFilename = "Export SO_" & strFilename
        strErrorLog = strErrorLog & "\" & strFilename & ".txt"
        WriteErrorHeader(strErrorLog, "Export SO's Starting..")
        If Directory.Exists(strExportFilePaty) = False Then
            Directory.CreateDirectory(strPath)
        End If
        Dim strStore As String
        strStore = getStoreKey(objMainCompany)
        Try
            Dim s As System.Text.StringBuilder = New System.Text.StringBuilder
            Dim strRecquery, strdocnum, strString As String
            Dim oCheckrs As SAPbobsCOM.Recordset
            oCheckrs = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            strString = "SELECT T0.[DocEntry],T1.[WhsCode],isnull(T0.[U_StoreKey],''), T0.DocNum,'SO'e,T0.[DocNum], T1.[LineNum], T0.[CardCode], isnull(T1.[U_Shelflife],'0'),isnull(T0.[U_TrafLine],''),isnull(T0.[U_Cust_Class],''),T2.[SlpName],isnull(T0.[U_TrafLine],''), T0.[DocDueDate], T0.[DocDueDate],  '',T1.[ItemCode], T1.[Quantity], T0.[Comments], T0.[CardName],T0.[Address],T0.[DocNum] FROM [dbo].[ORDR]  T0 INNER JOIN [dbo].[RDR1]  T1 ON T0.DocEntry = T1.DocEntry and T1.LineStatus='O' INNER JOIN [dbo].[OSLP]  T2 ON T0.SlpCode = T2.SlpCode and T0.U_Storekey='" & strStore & "'"
            strRecquery = strString & " and T0.DocStatus='O'  and T0.DocEntry in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='SO' and U_Z_Exported='N')"
            oCheckrs.DoQuery(strRecquery)
            ' oApplication.Utilities.Message("Exporting Sales Orders in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            If oCheckrs.RecordCount > 0 Then
                Dim otemprec As SAPbobsCOM.Recordset
                otemprec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                otemprec.DoQuery(strRecquery)
                If 1 = 1 Then
                    s.Remove(0, s.Length)
                    Dim cols As Integer = 2 ' Me.DataSet1.SalesOrder.Columns.Count
                    strdocnum = ""

                    s.Remove(0, s.Length)
                    s.Append("WhsCode" + vbTab)
                    s.Append("StoreKey" + vbTab)
                    s.Append("ExternOrderKey" + vbTab)
                    s.Append("OrderType" + vbTab)
                    's.Append("OrderNumber" + vbTab)
                    s.Append("LineNum" + vbTab)
                    s.Append("ConsigneeKey" + vbTab)
                    s.Append("ShelfLfe" + vbTab)
                    s.Append("Route" + vbTab)
                    s.Append("SUser1" + vbTab)
                    s.Append("Sales Person" + vbTab)
                    s.Append("TraffiLine" + vbTab)
                    s.Append("RequestedDeliveryDate" + vbTab)
                    s.Append("ExpectedDelieryDate" + vbTab)
                    s.Append("CustomerTerritory" + vbTab)
                    s.Append("ItemCode" + vbTab)
                    s.Append("Quantity" + vbTab)
                    s.Append("OrderNote" + vbTab)
                    s.Append("CardName" + vbTab)
                    s.Append("CustomerAddress" + vbCrLf)
                    Dim strItem As String
                    strItem = ""
                    For intRow As Integer = 0 To otemprec.RecordCount - 1
                        ' oApplication.Utilities.Message("Exporting Sales Orders --> " & otemprec.Fields.Item("DocNum").Value & "  in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

                        Dim strQt, strStoreKey, strDuedate, strDocDate, groupname, itemtype, weight, volume, expiryflag, codebars, packkey, defaultuom As String
                        Dim dtduedate, dtdocdate As Date
                        strQt = CStr(otemprec.Fields.Item(1).Value)
                        If strItem = "" Then
                            strItem = "'" & otemprec.Fields.Item("DocNum").Value & "'"
                        Else
                            strItem = strItem & ",'" & otemprec.Fields.Item("DocNum").Value & "'"
                        End If
                        'strName = otemprec.Fields.Item("ItemName").Value
                        strStoreKey = " "
                        expiryflag = " "
                        dtdocdate = otemprec.Fields.Item("DocDueDate").Value
                        dtduedate = otemprec.Fields.Item("DocDueDate").Value
                        strDocDate = dtdocdate.ToString("dd-MM-yyyy")
                        strDuedate = dtduedate.ToString("dd-MM-yyyy")
                        s.Append(otemprec.Fields.Item(1).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(2).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(3).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(4).Value.ToString + vbTab)
                        '                        s.Append(otemprec.Fields.Item(5).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(6).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(7).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(8).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(9).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(10).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(11).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(12).Value.ToString + vbTab)
                        s.Append(strDuedate + vbTab)
                        s.Append(strDuedate + vbTab)
                        's.Append(otemprec.Fields.Item(14).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(15).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(16).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(17).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(18).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(19).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(20).Value.ToString + vbCrLf)
                        otemprec.MoveNext()
                    Next
                    Dim filename As String
                    filename = Now.Date.ToString("ddMMyyyyhhmm")
                    filename = strExportFilePaty & "\SO_" & strFilename & ".csv"
                    Dim strFilename1, strcode, strinsert As String
                    strFilename1 = filename
                    Try
                        My.Computer.FileSystem.WriteAllText(strFilename1, s.ToString, False)
                        If File.Exists("C:\Test123.txt") Then
                            File.Delete("C:\test123.txt")
                        End If
                    Catch ex As Exception
                        strMessage = "Export File name : " & strFilename1 & " failed . Check the ConnectionInfo.Ini /  Connection"
                        WriteErrorlog(strMessage, strErrorLog)
                        End
                    End Try
                    strMessage = strItem & "--> SO's  Exported compleated: File Name : " & strFilename1
                    Dim oUpdateRS As SAPbobsCOM.Recordset
                    Dim strUpdate As String
                    oUpdateRS = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    strUpdate = "Update [@Z_DABT_Export] set U_Z_Exported='Y' ,U_Z_ExportMethod='A',U_Z_ExportFile='" & strFilename1 & "',U_Z_ExportDate=getdate() where U_Z_DocNum in (" & strItem & ") and U_Z_DocType='SO'"
                    oUpdateRS.DoQuery(strUpdate)
                    WriteErrorlog(strMessage, strErrorLog)
                End If
            Else
                strMessage = ("No new SO's!")
                WriteErrorlog(strMessage, strErrorLog)
            End If
        Catch ex As Exception
            strMessage = ("An Error Occured. A log entry has been created." & ex.Message)
            WriteErrorlog(strMessage, strErrorLog)
        Finally
            strMessage = "Export process compleated"
            WriteErrorlog(strMessage, strErrorLog)
        End Try
        '   System.Windows.Forms.Application.Exit()
    End Sub

    Public Sub ExportARCreditMemo(ByVal aPath As String, ByVal aChoice As String, ByVal acompany As SAPbobsCOM.Company)
        Dim strPath, strFilename, strMessage, strExportFilePaty, strErrorLog, strTime As String
        If aChoice <> "ARCR" Then
            Exit Sub
        End If
        objMainCompany = acompany
        ReadiniFile()
        strPath = strExportDirectory ' aPath ' System.Windows.Forms.Application.StartupPath
        strTime = Now.ToShortTimeString.Replace(":", "")
        strFilename = Now.Date.ToString("ddMMyyyy")
        strFilename = strFilename & strTime
        Dim stHours, stMin As String

        strErrorLog = ""
        If aChoice = "ARCR" Then
            strErrorLog = strPath & "\Logs\ARCR Import"
            strPath = strPath & "\Export\ARCR Import"
        End If
        strExportFilePaty = strPath
        If Directory.Exists(strPath) = False Then
            Directory.CreateDirectory(strPath)
        End If
        If Directory.Exists(strErrorLog) = False Then
            Directory.CreateDirectory(strErrorLog)
        End If
        strFilename = "Export ARCR_" & strFilename
        strErrorLog = strErrorLog & "\" & strFilename & ".txt"
        ' Message("Processing Supplier Returns Exporting...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
        WriteErrorHeader(strErrorLog, "Export Supplier returns Starting..")
        If Directory.Exists(strExportFilePaty) = False Then
            Directory.CreateDirectory(strPath)
        End If
        Dim strStore As String
        strStore = getStoreKey(objMainCompany)
        Try
            Dim s As System.Text.StringBuilder = New System.Text.StringBuilder
            Dim strRecquery, strdocnum, strString As String
            Dim oCheckrs As SAPbobsCOM.Recordset
            oCheckrs = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            strString = "SELECT T0.[DocEntry],T1.[WhsCode],isnull(T0.[U_StoreKey],''), T0.DocNum,'OR',T0.[DocNum], T1.[LineNum], T0.[CardCode], isnull(T1.[U_Shelflife],'0'),isnull(T0.[U_TrafLine],''),isnull(T0.[U_Cust_Class],''),T2.[SlpName],isnull(T0.[U_TrafLine],''), T0.[DocDueDate], T0.[DocDueDate],  '',T1.[ItemCode], T1.[Quantity], T0.[Comments], T0.[CardName],T0.[Address],T0.[DocNum] FROM [dbo].[ODRF]  T0 INNER JOIN [dbo].[DRF1]  T1 ON T0.DocEntry = T1.DocEntry and T0.ObjType=16 INNER JOIN [dbo].[OSLP]  T2 ON T0.SlpCode = T2.SlpCode and T0.U_Storekey='" & strStore & "'"
            strRecquery = strString & " and T0.DocStatus='O' and T0.DocEntry in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='ARCR' and U_Z_Exported='N')"
            oCheckrs.DoQuery(strRecquery)
            ' oApplication.Utilities.Message("Exporting Supplier return in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            If oCheckrs.RecordCount > 0 Then
                Dim otemprec As SAPbobsCOM.Recordset
                otemprec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                otemprec.DoQuery(strRecquery)
                If 1 = 1 Then
                    s.Remove(0, s.Length)
                    Dim cols As Integer = 2 ' Me.DataSet1.SalesOrder.Columns.Count
                    strdocnum = ""

                    s.Remove(0, s.Length)
                    s.Append("WhsCode" + vbTab)
                    s.Append("StoreKey" + vbTab)
                    s.Append("ExternOrderKey" + vbTab)
                    s.Append("OrderType" + vbTab)
                    ' s.Append("OrderNumber" + vbTab)
                    s.Append("LineNum" + vbTab)
                    s.Append("ConsigneeKey" + vbTab)
                    s.Append("ShelfLfe" + vbTab)
                    s.Append("Route" + vbTab)
                    s.Append("SUser1" + vbTab)
                    s.Append("Sales Person" + vbTab)
                    s.Append("TraffiLine" + vbTab)
                    s.Append("RequestedDeliveryDate" + vbTab)
                    s.Append("ExpectedDelieryDate" + vbTab)
                    s.Append("CustomerTerritory" + vbTab)
                    s.Append("ItemCode" + vbTab)
                    s.Append("Quantity" + vbTab)
                    s.Append("OrderNote" + vbTab)
                    s.Append("CardName" + vbTab)
                    s.Append("CustomerAddress" + vbCrLf)
                    Dim strItem As String
                    strItem = ""
                    For intRow As Integer = 0 To otemprec.RecordCount - 1

                        'oApplication.Utilities.Message("Exporting AR Credit Memo --> " & otemprec.Fields.Item("DocNum").Value & "  in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

                        Dim strQt, strStoreKey, strDuedate, strDocDate, groupname, itemtype, weight, volume, expiryflag, codebars, packkey, defaultuom As String
                        Dim dtduedate, dtdocdate As Date
                        strQt = CStr(otemprec.Fields.Item(1).Value)
                        If strItem = "" Then
                            strItem = "'" & otemprec.Fields.Item("DocNum").Value & "'"
                        Else
                            strItem = strItem & ",'" & otemprec.Fields.Item("DocNum").Value & "'"
                        End If
                        'strName = otemprec.Fields.Item("ItemName").Value
                        strStoreKey = " "
                        expiryflag = " "
                        'strString = "SELECT T0.[DocEntry],T1.[WhsCode],isnull(T0.[U_StoreKey],''), T0.NumAtCard,T0.ObjectType,T0.[DocNum], T1.[LineNum],
                        'T0.[CardCode], isnull(T1.[U_Shelflife,'0'),isnull(T1.[U_TrafLine],''),
                        'isnull(T0.[U_Cust_Class],''),T2.[SlpName],,isnull(T1.[U_TrafLine],''), T0.[DocDueDate], T0.[DocDueDate],  '',T1.[ItemCode], T1.[Quantity], T0.[Comments], 
                        'T0.[CardName], T0.[Address]
                        ' FROM [dbo].[ORDR]  T0 INNER JOIN [dbo].[RDR1]  T1 ON T0.DocEntry = T1.DocEntry INNER JOIN [dbo].[OSLP]  T2 ON T0.SlpCode = T2.SlpCode"
                        dtdocdate = otemprec.Fields.Item("DocDueDate").Value
                        dtduedate = otemprec.Fields.Item("DocDueDate").Value
                        strDocDate = dtdocdate.ToString("dd-MM-yyyy")
                        strDuedate = dtduedate.ToString("dd-MM-yyyy")
                        s.Append(otemprec.Fields.Item(1).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(2).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(3).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(4).Value.ToString + vbTab)
                        '    s.Append(otemprec.Fields.Item(5).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(6).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(7).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(8).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(9).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(10).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(11).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(12).Value.ToString + vbTab)
                        s.Append(strDuedate + vbTab)
                        s.Append(strDuedate + vbTab)
                        ' s.Append(otemprec.Fields.Item(14).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(15).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(16).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(17).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(18).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(19).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(20).Value.ToString + vbCrLf)
                        otemprec.MoveNext()
                    Next

                    Dim filename As String
                    filename = Now.Date.ToString("ddMMyyyyhhmm")
                    filename = strExportFilePaty & "\ARCR_" & strFilename & ".csv"
                    Dim strFilename1, strcode, strinsert As String
                    strFilename1 = filename
                    Try
                        My.Computer.FileSystem.WriteAllText(strFilename1, s.ToString, False)
                        If File.Exists("C:\Test123.txt") Then
                            File.Delete("C:\test123.txt")
                        End If
                    Catch ex As Exception
                        strMessage = "Export File name : " & strFilename1 & " failed . Check the ConnectionInfo.Ini /  Connection"
                        WriteErrorlog(strMessage, strErrorLog)
                        End
                    End Try
                    strMessage = strItem & "--> Supplier returns Exported compleated: File Name : " & strFilename1
                    Dim oUpdateRS As SAPbobsCOM.Recordset
                    Dim strUpdate As String
                    oUpdateRS = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    strUpdate = "Update [@Z_DABT_Export] set U_Z_Exported='Y' ,U_Z_ExportMethod='A',U_Z_ExportFile='" & strFilename1 & "',U_Z_ExportDate=getdate() where U_Z_DocNum in (" & strItem & ") and U_Z_DocType='ARCR'"
                    oUpdateRS.DoQuery(strUpdate)
                    WriteErrorlog(strMessage, strErrorLog)
                End If
            Else
                strMessage = ("No new Supplier returns!")
                WriteErrorlog(strMessage, strErrorLog)
            End If
        Catch ex As Exception
            strMessage = ("An Error Occured. A log entry has been created." & ex.Message)
            WriteErrorlog(strMessage, strErrorLog)
        Finally
            strMessage = "Export process compleated"
            WriteErrorlog(strMessage, strErrorLog)
        End Try
        '   System.Windows.Forms.Application.Exit()
    End Sub

    Public Sub ExportPurchaseOrder(ByVal aPath As String, ByVal aChoice As String, ByVal aCompany As SAPbobsCOM.Company)
        Dim strPath, strFilename, strMessage, strExportFilePaty, strErrorLog, strTime As String
        If aChoice <> "PO" Then
            Exit Sub
        End If
        objMainCompany = aCompany
        ReadiniFile()
        strPath = strExportDirectory ' aPath ' System.Windows.Forms.Application.StartupPath
        strTime = Now.ToShortTimeString.Replace(":", "")
        strFilename = Now.Date.ToString("ddMMyyyy")
        strFilename = strFilename & strTime
        strErrorLog = ""
        If aChoice = "PO" Then
            strErrorLog = strPath & "\Logs\ASN Import"
            strPath = strPath & "\Export\ASN Import"
        End If
        strExportFilePaty = strPath
        If Directory.Exists(strPath) = False Then
            Directory.CreateDirectory(strPath)
        End If
        If Directory.Exists(strErrorLog) = False Then
            Directory.CreateDirectory(strErrorLog)
        End If
        strFilename = "Export ASN_" & strFilename
        strErrorLog = strErrorLog & "\" & strFilename & ".txt"
        ' Message("Processing Purchase Order Exporting...", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
        WriteErrorHeader(strErrorLog, "Export PO's Starting..")
        If Directory.Exists(strExportFilePaty) = False Then
            Directory.CreateDirectory(strPath)
        End If
        Dim strStore As String
        strStore = getStoreKey(objMainCompany)
        Try
            Dim s As System.Text.StringBuilder = New System.Text.StringBuilder
            Dim strRecquery, strdocnum, strString As String
            Dim oCheckrs As SAPbobsCOM.Recordset
            oCheckrs = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            'strString = "SELECT T0.[DocEntry],T1.[WhsCode],isnull(T0.[U_StoreKey],''), T0.[DocType], T0.NumAtCard,T0.NumAtCard,T0.[DocNum],  T0.[CardCode], T0.[DocDate], T0.[DocDueDate], T1.[ItemCode], T1.[Quantity] FROM [dbo].[OPOR]  T0 INNER JOIN [dbo].[POR1]  T1 ON T0.DocEntry = T1.DocEntry "
            strString = "SELECT T0.[DocEntry],T1.[WhsCode],isnull(T0.[U_StoreKey],''), T0.[DocType], T0.NumAtCard,T0.NumAtCard,T0.[DocNum],  T0.[CardCode], T0.[DocDate], T0.[DocDueDate], T1.[ItemCode], T1.[Quantity], T1.Quantity * T2.NumInBuy * isnull(T2.U_Pack1,1) ,T1.LineNum FROM [dbo].[OPOR]  T0 INNER JOIN [dbo].[POR1]  T1 ON T0.DocEntry = T1.DocEntry  and T1.LineStatus='O' inner Join OITM T2 on T1.ItemCode=T2.ItemCode and T0.U_Storekey='" & strStore & "'"
            strRecquery = strString & " and T0.DocStatus='O'   and T0.DocEntry in (Select U_Z_Mastercode from [@Z_DABT_EXPORT] where U_Z_DocType='PO' and U_Z_Exported='N')"
            oCheckrs.DoQuery(strRecquery)
            ' oApplication.Utilities.Message("Exporting Purchase Orders   in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            If oCheckrs.RecordCount > 0 Then
                Dim otemprec As SAPbobsCOM.Recordset
                otemprec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                otemprec.DoQuery(strRecquery)
                If 1 = 1 Then
                    s.Remove(0, s.Length)
                    Dim cols As Integer = 2 ' Me.DataSet1.SalesOrder.Columns.Count
                    strdocnum = ""
                    s.Remove(0, s.Length)
                    s.Append("WhsCode" + vbTab)
                    s.Append("StoreKey" + vbTab)
                    s.Append("DocType" + vbTab)
                    s.Append("Buyerref" + vbTab)
                    s.Append("SellerRef" + vbTab)
                    s.Append("DocumentNumber" + vbTab)
                    s.Append("Supplier Code" + vbTab)
                    s.Append("Document Date" + vbTab)
                    s.Append("ExpectedreceiptDate" + vbTab)
                    s.Append("ItemCode" + vbTab)
                    s.Append("Quantity" + vbTab)
                    s.Append("LineNum" + vbCrLf)

                    Dim strItem As String
                    strItem = ""
                    For intRow As Integer = 0 To otemprec.RecordCount - 1
                        'oApplication.Utilities.Message("Exporting Purchase Orders --> " & otemprec.Fields.Item("DocNum").Value & "  in process.....", SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                        Dim strQt, strStoreKey, strDuedate, strDocDate, groupname, itemtype, weight, volume, expiryflag, codebars, packkey, defaultuom As String
                        Dim dtduedate, dtdocdate As Date
                        strQt = CStr(otemprec.Fields.Item(1).Value)
                        If strItem = "" Then
                            strItem = "'" & otemprec.Fields.Item("DocNum").Value & "'"
                        Else
                            strItem = strItem & ",'" & otemprec.Fields.Item("DocNum").Value & "'"
                        End If
                        'strName = otemprec.Fields.Item("ItemName").Value
                        strStoreKey = " "
                        expiryflag = " "
                        dtdocdate = otemprec.Fields.Item("DocDate").Value
                        dtduedate = otemprec.Fields.Item("DocDueDate").Value
                        strDocDate = dtdocdate.ToString("dd-MM-yyyy")
                        strDuedate = dtduedate.ToString("dd-MM-yyyy")
                        'strString = "SELECT T0.[DocEntry],T1.[WhsCode],isnull(T0.[U_StoreKey],''), T0.[DocType], T0.NumAtCard,T0.NumAtCard,T0.[DocNum],  T0.[CardCode], T0.[DocDate], T0.[DocDueDate], T1.[ItemCode], T1.[Quantity] FROM [dbo].[OPOR]  T0 INNER JOIN [dbo].[POR1]  T1 ON T0.DocEntry = T1.DocEntry "
                        s.Append(otemprec.Fields.Item(1).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(2).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(3).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(4).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(5).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(6).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(7).Value.ToString + vbTab)
                        s.Append(strDocDate + vbTab)
                        s.Append(strDuedate + vbTab)
                        s.Append(otemprec.Fields.Item(10).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(12).Value.ToString + vbTab)
                        s.Append(otemprec.Fields.Item(13).Value.ToString + vbCrLf)
                        otemprec.MoveNext()
                    Next
                    Dim filename As String
                    filename = Now.Date.ToString("ddMMyyyyhhmm")
                    filename = strExportFilePaty & "\ASN_" & strFilename & ".csv"
                    Dim strFilename1, strcode, strinsert As String
                    strFilename1 = filename
                    Try
                        My.Computer.FileSystem.WriteAllText(strFilename1, s.ToString, False)
                        If File.Exists("C:\Test123.txt") Then
                            File.Delete("C:\test123.txt")
                        End If
                    Catch ex As Exception
                        strMessage = "Export File name : " & strFilename1 & " failed . Check the ConnectionInfo.Ini /  Connection"
                        WriteErrorlog(strMessage, strErrorLog)
                        End
                    End Try
                    strMessage = strItem & "--> PO's  Exported compleated: File Name : " & strFilename1
                    Dim oUpdateRS As SAPbobsCOM.Recordset
                    Dim strUpdate As String
                    oUpdateRS = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    strUpdate = "Update [@Z_DABT_Export] set U_Z_Exported='Y' ,U_Z_ExportMethod='A',U_Z_ExportFile='" & strFilename1 & "',U_Z_ExportDate=getdate() where U_Z_DocNum in (" & strItem & ") and U_Z_DocType='PO'"
                    oUpdateRS.DoQuery(strUpdate)
                    WriteErrorlog(strMessage, strErrorLog)
                End If
            Else
                strMessage = ("No new PO's!")
                WriteErrorlog(strMessage, strErrorLog)
            End If
        Catch ex As Exception
            strMessage = ("An Error Occured. A log entry has been created." & ex.Message)
            WriteErrorlog(strMessage, strErrorLog)
        Finally
            strMessage = "Export process compleated"
            WriteErrorlog(strMessage, strErrorLog)
        End Try
        '   System.Windows.Forms.Application.Exit()
    End Sub
#End Region

#End Region

#Region "Export"
    Public Sub ExportMasterData()
        Dim oTemp, oTemp1 As SAPbobsCOM.Recordset
        Dim strPath, strFilename, strErrorPath As String
        'strErrorLogPath = strErrorLogPath
        strPath = strErrorLogPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Mobilestic_" & strFilename & ".txt"
        sPath = strPath
        strErrorPath = sPath
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp1 = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N' and U_DocType='I'")
        WriteErrorlog("Exporting Item Master Details..", strErrorPath)
        Try
            For intLoop As Integer = 0 To oTemp.RecordCount - 1
                WriteErrorlog("Exporting Item Master :" & oTemp.Fields.Item("U_MasterCode").Value, sPath)
                Try
                    Dim strTime As String
                    ExportItemMasterData(oTemp.Fields.Item("U_MasterCode").Value, strErrorPath, oTemp.Fields.Item("Code").Value)
                    strTime = Now.ToShortTimeString.Replace(":", "")
                    oTemp1.DoQuery("update [@MOB_Export] set U_ExpType ='A',  U_Exported='Y', U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
                Catch ex As Exception
                    WriteErrorlog(ex.Message, sPath)
                End Try
                oTemp.MoveNext()
            Next
        Catch ex As Exception
            WriteErrorlog(ex.Message, sPath)
        End Try
        WriteErrorlog("Exporting Item Master Completed..", strErrorPath)
        WriteErrorlog("Exporting Customer Master Details..", strErrorPath)
        oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N' and U_DocType='B' and U_MasterCode in (Select cardcode from OCRD where CardType='C')")
        Try
            For intLoop As Integer = 0 To oTemp.RecordCount - 1
                WriteErrorlog("Exporting Customer Master :" & oTemp.Fields.Item("U_MasterCode").Value, strErrorPath)
                Try
                    ' GenerateWMSID(oTemp.Fields.Item("U_MasterCode").Value)
                    ExportCustomerData(oTemp.Fields.Item("U_MasterCode").Value, strErrorPath, oTemp.Fields.Item("Code").Value)
                    Dim strTime As String
                    strTime = Now.ToShortTimeString.Replace(":", "")
                    oTemp1.DoQuery("update [@MOB_Export] set U_ExpType ='A', U_Exported='Y', U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
                    ExportBilltoSupplierData(oTemp.Fields.Item("U_MasterCode").Value, strErrorPath, oTemp.Fields.Item("Code").Value)
                Catch ex As Exception
                    WriteErrorlog(ex.Message, sPath)
                End Try
                oTemp.MoveNext()
            Next
        Catch ex As Exception
            WriteErrorlog(ex.Message, sPath)
        End Try
        WriteErrorlog("Exporting Customer Master  Completed..", strErrorPath)
        WriteErrorlog("Exporting Supplier Master Details..", strErrorPath)
        oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N' and U_DocType='B' and U_MasterCode in (Select cardcode from OCRD where CardType='S')")
        Try
            For intLoop As Integer = 0 To oTemp.RecordCount - 1
                WriteErrorlog("Exporting Supplier Master :" & oTemp.Fields.Item("U_MasterCode").Value, strErrorPath)
                Try
                    ' GenerateWMSID(oTemp.Fields.Item("U_MasterCode").Value)
                    ExportsupplierData(oTemp.Fields.Item("U_MasterCode").Value, strErrorPath, oTemp.Fields.Item("Code").Value)
                    Dim strTime As String
                    strTime = Now.ToShortTimeString.Replace(":", "")
                    oTemp1.DoQuery("update [@MOB_Export] set  U_ExpType ='A', U_Exported='Y', U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
                Catch ex As Exception
                    WriteErrorlog(ex.Message, strErrorPath)
                End Try
                oTemp.MoveNext()
            Next
        Catch ex As Exception
            WriteErrorlog(ex.Message, strErrorPath)
        End Try
        WriteErrorlog("Exporting Supplier Master Completed..", strErrorPath)


        'Exporting Individual Address

        WriteErrorlog("Exporting Address Details..", strErrorPath)
        oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N' and U_DocType='BA' and U_MasterCode in (Select U_WMSID from CRD1)")
        Dim oTest As SAPbobsCOM.Recordset
        Dim stCardCode As String
        oTest = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        Try
            For intLoop As Integer = 0 To oTemp.RecordCount - 1
                WriteErrorlog("Exporting Address Master :" & oTemp.Fields.Item("U_MasterCode").Value, strErrorPath)
                Try
                    oTest.DoQuery("Select  * from CRD1 where U_WMSID='" & oTemp.Fields.Item("U_MasterCode").Value & "'")
                    If oTest.RecordCount > 0 Then
                        stCardCode = oTest.Fields.Item("CardCode").Value
                        ExportCustomerWMSID(stCardCode, oTemp.Fields.Item("U_MasterCode").Value)
                        ExportsupplierWMSID(stCardCode, oTemp.Fields.Item("U_MasterCode").Value)
                        ExportBilltoSUPWMSID(stCardCode, oTemp.Fields.Item("U_MasterCode").Value)

                        Dim strTime As String
                        strTime = Now.ToShortTimeString.Replace(":", "")
                        oTemp1.DoQuery("update [@MOB_Export] set U_ExpType ='A', Name=Code, U_Exported='Y', U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
                    End If
                Catch ex As Exception
                    WriteErrorlog(ex.Message, strErrorPath)
                End Try
                oTemp.MoveNext()
            Next
        Catch ex As Exception
            WriteErrorlog(ex.Message, strErrorPath)
        End Try
        WriteErrorlog("Exporting Address Completed..", strErrorPath)

        WriteErrorlog("Exporting Master data completed...", strErrorPath)
    End Sub

#End Region


#Region "Export BP Master for Single WMS ID"




    Public Sub ExportCustomerWMSID(ByVal aCardCode As String, ByVal aWMSID As String)
        Dim oRecItem, oRecItemCode, oTepRS As SAPbobsCOM.Recordset
        Dim strSQL, strFilename As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strExportFilePaty, strSelectedFolderPath As String
        Dim blnErrorflag As Boolean
        Dim FILedatetiem As String
        Dim strTRGFileName As String
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Import_ExportLog_" & strFilename & ".txt"
        WriteErrorHeader(strPath, "Exporting item Details")
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        'BP customer Master
        strSQL = "Select * from CRD1 where U_WMSID='" & aWMSID & "' and  CARDCODE IN (select CardCode from OCRD where Cardtype='C' and cardcode='" & aCardCode & "')"
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")
        strExportFilePaty = "E:\InterNational Business Projects\Abijit\Documents\Export Samples through Addon"
        'If strSelectedFolderPath.EndsWith("\") Then
        '    strExportFilePaty = strSelectedFolderPath & "Export\Customer"
        'Else
        '    strExportFilePaty = strSelectedFolderPath & "\Export\Customer"
        'End If
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            ' strExportFilePaty = strSelectedFolderPath & "Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        Else
            'strExportFilePaty = strSelectedFolderPath & "\Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        End If


        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If
        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("U_WMSID").Value & "_" & oRecItem.Fields.Item("CardCode").Value

            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime '& "_" & strUDTCode

            strFilename = strExportFilePaty & "\CUST_INB_IFD_" & FILedatetiem & ".xml"
            strTRGFileName = strExportFilePaty & "\CUST_INB_IFD_" & FILedatetiem & ".trg"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_CUST_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("CUST_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()

            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("ADDR_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("ADDR_SEG")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            oTepRS.DoQuery("Select * from [@MOB_Export] where U_MasterCode='" & aWMSID & "' and U_DocType='BA'")
            'writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            ' writer.WriteString(transtype)

            writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            
            writer.WriteEndElement()
            writer.WriteStartElement("HOST_EXT_ID")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
            writer.WriteStartElement("ADRNAM")
            Dim strAdrNam, strAdrnam1 As String
            If oRecItem.Fields.Item("U_AddressType").Value = 1 Then
                strAdrNam = oRecItem.Fields.Item("Address").Value
                If strAdrNam.Length > 39 Then
                    strAdrNam = strAdrNam.Substring(0, 39)
                End If
            Else
                strAdrNam = GetCustomerCardName(oRecItem.Fields.Item("CardCode").Value)
                strAdrnam1 = oRecItem.Fields.Item("Address").Value

                If strAdrNam.Length > 35 Then
                    strAdrnam1 = strAdrNam.Substring(0, 35).Trim
                Else
                    strAdrnam1 = strAdrNam
                End If
                Dim strCode As String()
                Dim strWMSIDCode As String
                strWMSIDCode = oRecItem.Fields.Item("U_WMSID").Value
                strCode = strWMSIDCode.Split("-")
                If strCode.Length > 1 Then
                    strAdrNam = strAdrnam1 & "-" & strCode(1)
                Else
                    strAdrNam = strAdrnam1 '& " " & oRecItem.Fields.Item("U_WMSID").Value
                End If
            End If


            'strAdrNam = strAdrnam1 & " " & oRecItem.Fields.Item("U_WMSID").Value
            writer.WriteString(strAdrNam)

            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRTYP")
            writer.WriteString("CST")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN1")
            '    writer.WriteString(oRecItem.Fields.Item("Address").Value)
            writer.WriteString(oRecItem.Fields.Item("Street").Value)
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN2")
            'writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRLN3")
            Dim strCounty As String
            strCounty = oRecItem.Fields.Item("County").Value
            If strCounty.Length > 39 Then
                strCounty = strCounty.Substring(0, 39)
            End If
            writer.WriteString(strCounty)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRCTY")
            writer.WriteString(oRecItem.Fields.Item("city").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRSTC")
            writer.WriteString(oRecItem.Fields.Item("State").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRPSZ")
            writer.WriteString(oRecItem.Fields.Item("ZipCode").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CTRY_NAME")
            writer.WriteString(GetCountrycode(oRecItem.Fields.Item("Country").Value))
            writer.WriteEndElement()
            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PHNNUM")
            Dim oTest As SAPbobsCOM.Recordset
            Dim strPhone As String
            strPhone = oRecItem.Fields.Item("U_ShipAddressPhone").Value
            oTest = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            If strPhone = "" Then
                oTest.DoQuery("Select isnull(Phone1,'') from OCRD where cardcode='" & oRecItem.Fields.Item("CardCode").Value & "'")
                writer.WriteString(oTest.Fields.Item(0).Value)
            Else
                writer.WriteString(strPhone)
            End If
            writer.WriteEndElement()

            writer.WriteStartElement("FAXNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("RSAFLG")
            writer.WriteEndElement()

            writer.WriteStartElement("TEMP_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("LAST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("FIRST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("HOBORIFIC")
            writer.WriteEndElement()

            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("ADR_DISTRICT")
            writer.WriteEndElement()
            writer.WriteStartElement("WEB_ADR")
            writer.WriteEndElement()
            writer.WriteStartElement("EMAIL_ADR")
            writer.WriteEndElement()

            writer.WriteStartElement("PAGNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("LOCALE_ID")
            writer.WriteEndElement()
            writer.WriteStartElement("ATTN_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("ATTN_TEL")
            writer.WriteEndElement()
            writer.WriteStartElement("CONT_NAME")
            writer.WriteEndElement()

            writer.WriteStartElement("CONT_TEL")
            writer.WriteEndElement()
            writer.WriteStartElement("CONT_TITLE")
            writer.WriteEndElement()
            writer.WriteStartElement("PO_BOX_FLG")
            writer.WriteEndElement()
            writer.WriteEndElement()


            writer.WriteStartElement("CUST_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("CUSTOMER")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            oTepRS.DoQuery("Select * from [@MOB_Export] where U_MasterCode='" & oRecItem.Fields.Item("U_WMSID").Value & "' and U_DocType='BA'")
            'writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            '    writer.WriteString(transtype)
            writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("CSTNUM")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CSTTYP")
            writer.WriteEndElement()


            'Repack Session
            '•	<REPACK_CLASS_SEG>
            '•	<SEGNAM>REPACK_CLASS</SEGNAM>
            '•	<RPKCLS>MC</RPKCLS>
            '•	</REPACK_CLASS_SEG>

            writer.WriteStartElement("REPACK_CLASS_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("REPACK_CLASS")
            writer.WriteEndElement()
            writer.WriteStartElement("RPKCLS")
            writer.WriteString("MC")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("REPACK_CLASS_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("REPACK_CLASS")
            writer.WriteEndElement()
            writer.WriteStartElement("RPKCLS")
            'oTest.DoQuery("Select isnull(U_BlindShipCustomer,0) from OCRD where cardcode='" & oRecItem.Fields.Item("CardCode").Value & "'")
            'If oTest.Fields.Item(0).Value = 0 Then
            '    writer.WriteString("P")
            'Else
            '    writer.WriteString("M")
            'End If

            If oRecItem.Fields.Item("U_ADDRESSTYPE").Value.ToString = "1" Then
                writer.WriteString("P")
            Else
                writer.WriteString("M")
            End If

            writer.WriteEndElement()
            writer.WriteEndElement()

            'End Repack session
            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.Close()
            ' strMessage = "Export BP Master Completed"
            '  WriteErrorlog(strMessage, strPath)
            strFilename = strExportFilePaty & "\CUST_INB_IFD_" & FILedatetiem & "."
            strFilename = strExportFilePaty & "\CUST_INB_IFD_" & FILedatetiem & ".xml"

            strMessage = "Export Address Compleated : " & strFilename
            WriteErrorlog(strMessage, strPath)
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            strMessage = "Export Address TRG  Compleated : " & strTRGFileName
            WriteErrorlog(strMessage, strPath)
            fs.Close()

            'fs.Close()
            oRecItem.MoveNext()
        Next

        ' ShowSuccessMessage("Operation completed successfully")

    End Sub

    Public Sub ExportsupplierWMSID(ByVal aCardCode As String, ByVal aWMSID As String)
        Dim oRecItem, oRecItemCode As SAPbobsCOM.Recordset
        Dim strSQL, strFilename As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strExportFilePaty, strSelectedFolderPath As String
        Dim blnErrorflag As Boolean
        Dim FILedatetiem As String
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Import_ExportLog_" & strFilename & ".txt"
        WriteErrorHeader(strPath, "Exporting item Details")
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'BP customer Master
        strSQL = "Select * from CRD1 where U_WMSID='" & aWMSID & "' and CARDCODE IN (select CardCode from OCRD where Cardtype='S' and cardcode='" & aCardCode & "')"
        'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            ' strExportFilePaty = strSelectedFolderPath & "Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        Else
            'strExportFilePaty = strSelectedFolderPath & "\Export\Supplier"
            strExportFilePaty = strSelectedFolderPath
        End If

        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If
        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("U_WMSID").Value & "_" & oRecItem.Fields.Item("CardCode").Value
            Dim strTRGFileName As String
            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime

            strTRGFileName = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".trg"
            strFilename = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".xml"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_SUPP_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("SUPP_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()

            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("SUPP_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("SUPPLIER")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            Dim oTepRS As SAPbobsCOM.Recordset
            oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTepRS.DoQuery("Select * from [@MOB_Export] where U_MasterCode='" & oRecItem.Fields.Item("U_WMSID").Value & "' and U_DocType='BA'")
            'writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            ' writer.WriteString(transtype)

            writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            
            writer.WriteEndElement()
            writer.WriteStartElement("SUPNUM")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("HOST_EXT_ID")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()
            'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
            writer.WriteStartElement("ADRNAM")
            Dim strAdrNam, strAdrnam1 As String
            'strAdrNam = GetCardName(oRecItem.Fields.Item("CardCode").Value)
            'strAdrnam1 = oRecItem.Fields.Item("Address").Value
            'If strAdrnam1.Length > 30 Then
            '    strAdrnam1 = strAdrnam1.Substring(0, 29)
            'Else
            '    strAdrnam1 = strAdrnam1
            'End If
            'strAdrNam = strAdrNam & " " & strAdrnam1
            'writer.WriteString(strAdrNam)

            strAdrNam = GetCustomerCardName(oRecItem.Fields.Item("CardCode").Value)
            strAdrnam1 = oRecItem.Fields.Item("Address").Value

            If strAdrNam.Length > 35 Then
                strAdrnam1 = strAdrNam.Substring(0, 35).Trim
            Else
                strAdrnam1 = strAdrNam
            End If
            Dim strCode As String()
            Dim strWMSIDCode As String
            strWMSIDCode = oRecItem.Fields.Item("U_WMSID").Value
            strCode = strWMSIDCode.Split("-")
            If strCode.Length > 1 Then
                strAdrNam = strAdrnam1 & "-" & strCode(1)
            Else
                strAdrNam = strAdrnam1 '& " " & oRecItem.Fields.Item("U_WMSID").Value
            End If


            'strAdrNam = strAdrnam1 & " " & oRecItem.Fields.Item("U_WMSID").Value
            writer.WriteString(strAdrNam)



            ' writer.WriteString(GetCardName(oRecItem.Fields.Item("CardCode").Value))
            writer.WriteEndElement()

            writer.WriteStartElement("ADRTYP")
            writer.WriteString("SUP")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN1")
            '    writer.WriteString(oRecItem.Fields.Item("Address").Value)
            writer.WriteString(oRecItem.Fields.Item("Street").Value)
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN2")
            'writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRLN3")
            'writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRCTY")
            writer.WriteString(oRecItem.Fields.Item("city").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRSTC")
            writer.WriteString(oRecItem.Fields.Item("State").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRPSZ")
            writer.WriteString(oRecItem.Fields.Item("ZipCode").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CTRY_NAME")
            writer.WriteString(GetCountrycode(oRecItem.Fields.Item("country").Value.ToString))
            writer.WriteEndElement()
            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PHNNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("FAXNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("RSAFLG")
            writer.WriteEndElement()

            writer.WriteStartElement("TEMP_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("LAST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("FIRST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("HOBORIFIC")
            writer.WriteEndElement()

            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("ADR_DISTRICT")
            writer.WriteEndElement()
            writer.WriteStartElement("WEB_ADR")
            writer.WriteEndElement()
            writer.WriteStartElement("EMAIL_ADR")
            writer.WriteEndElement()

            writer.WriteStartElement("PAGNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("LOCALE_ID")
            writer.WriteEndElement()

            writer.WriteStartElement("PO_BOX_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("TRK_CNSG_COD")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.Close()
            strMessage = "Export Address Compleated : " & strFilename
            WriteErrorlog(strMessage, strPath)
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            fs.Close()
            strMessage = "Export Address TRG  Compleated : " & strTRGFileName
            WriteErrorlog(strMessage, strPath)

            oRecItem.MoveNext()
        Next
        ' ShowSuccessMessage("Operation completed successfully")
    End Sub

    Public Sub ExportBilltoSUPWMSID(ByVal aCardCode As String, ByVal aWMSID As String)
        Dim oRecItem, oRecItemCode As SAPbobsCOM.Recordset
        Dim strSQL, strFilename As String
        Dim sValue As String
        Dim sPath, strLogDirectory, strPath, strMessage, strExportFilePaty, strSelectedFolderPath As String
        Dim blnErrorflag As Boolean
        Dim FILedatetiem As String
        strPath = strLogDirectory ' System.Windows.Forms.Application.StartupPath
        strFilename = Now.ToLongDateString
        strPath = strPath & "\Import_ExportLog_" & strFilename & ".txt"
        WriteErrorHeader(strPath, "Exporting item Details")
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'BP customer Master
        strSQL = "Select * from CRD1 where AdresType='B' and U_WMSID='" & aWMSID & "' and CARDCODE IN (select CardCode from OCRD where cardType='C' and  cardcode='" & aCardCode & "')"
        'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
        oRecItem = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItemCode = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecItem.DoQuery(strSQL)
        FILedatetiem = Now.ToString("yyyyMMdd_hh_mm_ss")
        strSelectedFolderPath = strExportDirectory
        If strSelectedFolderPath.EndsWith("\") Then
            strExportFilePaty = strSelectedFolderPath
        Else
            strExportFilePaty = strSelectedFolderPath
        End If

        If Directory.Exists(strExportFilePaty) Then
        Else
            Directory.CreateDirectory(strExportFilePaty)
        End If
        For intRow As Integer = 0 To oRecItem.RecordCount - 1
            FILedatetiem = oRecItem.Fields.Item("U_WMSID").Value & "_" & oRecItem.Fields.Item("CardCode").Value '.ToString.Replace("C", "V")
            Dim strTRGFileName As String
            Dim dtDateTime As String
            dtDateTime = Format(Now.Date, "yyyyMMdd") & Now.ToLongTimeString.Replace(":", "")
            FILedatetiem = FILedatetiem & "_" & dtDateTime '& "_" & strUDTCode

            strTRGFileName = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".trg"
            strFilename = strExportFilePaty & "\SUPP_INB_IFD_" & FILedatetiem & ".xml"
            Dim writer As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("UC_SUPP_INB_IFD")
            writer.WriteStartElement("CTRL_SEG")
            writer.WriteStartElement("TRNNAM")
            writer.WriteString("SUPP_TRAN")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNVER")
            writer.WriteString("2009.2")
            writer.WriteEndElement()

            writer.WriteStartElement("WHSE_ID")
            writer.WriteString("----")
            writer.WriteEndElement()

            writer.WriteStartElement("SUPP_SEG")
            writer.WriteStartElement("SEGNAM")
            writer.WriteString("SUPPLIER")
            writer.WriteEndElement()
            writer.WriteStartElement("TRNTYP")
            Dim oTepRS As SAPbobsCOM.Recordset
            oTepRS = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
            oTepRS.DoQuery("Select * from [@MOB_Export] where U_MasterCode='" & oRecItem.Fields.Item("U_WMSID").Value & "' and U_DocType='BA'")
            'writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            ' writer.WriteString(transtype)

            writer.WriteString(oTepRS.Fields.Item("U_Action").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("SUPNUM")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("HOST_EXT_ID")
            writer.WriteString(oRecItem.Fields.Item("U_WMSID").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CLIENT_ID")
            writer.WriteString("----")
            writer.WriteEndElement()
            'SELECT T0.[Address], T0.[CardCode], T0.[Street], T0.[Block], T0.[ZipCode], T0.[City], T0.[County], T0.[Country], T0.[State], T0.[AdresType], T0.[Address2], T0.[Address3], T0.[U_test], T0.[U_testy1] FROM CRD1 T0
            writer.WriteStartElement("ADRNAM")
            Dim strAdrNam, strAdrnam1 As String

            strAdrNam = GetCustomerCardName(oRecItem.Fields.Item("CardCode").Value)
            strAdrnam1 = oRecItem.Fields.Item("Address").Value

            If strAdrNam.Length > 35 Then
                strAdrnam1 = strAdrNam.Substring(0, 35).Trim
            Else
                strAdrnam1 = strAdrNam
            End If
            Dim strCode As String()
            Dim strWMSIDCode As String
            strWMSIDCode = oRecItem.Fields.Item("U_WMSID").Value
            strCode = strWMSIDCode.Split("-")
            If strCode.Length > 1 Then
                strAdrNam = strAdrnam1 & "-" & strCode(1)
            Else
                strAdrNam = strAdrnam1 '& " " & oRecItem.Fields.Item("U_WMSID").Value
            End If


            'strAdrNam = strAdrnam1 & " " & oRecItem.Fields.Item("U_WMSID").Value
            writer.WriteString(strAdrNam)



            ' writer.WriteString(GetCardName(oRecItem.Fields.Item("CardCode").Value))
            writer.WriteEndElement()

            writer.WriteStartElement("ADRTYP")
            writer.WriteString("CST")
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN1")
            '    writer.WriteString(oRecItem.Fields.Item("Address").Value)
            writer.WriteString(oRecItem.Fields.Item("Street").Value)
            writer.WriteEndElement()

            writer.WriteStartElement("ADRLN2")
            'writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRLN3")
            'writer.WriteString(oRecItem.Fields.Item("Block").Value)
            writer.WriteString(oRecItem.Fields.Item("Address2").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRCTY")
            writer.WriteString(oRecItem.Fields.Item("city").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRSTC")
            writer.WriteString(oRecItem.Fields.Item("State").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("ADRPSZ")
            writer.WriteString(oRecItem.Fields.Item("ZipCode").Value)
            writer.WriteEndElement()
            writer.WriteStartElement("CTRY_NAME")
            writer.WriteString(GetCountrycode(oRecItem.Fields.Item("country").Value.ToString))
            writer.WriteEndElement()
            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("PHNNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("FAXNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("RSAFLG")
            writer.WriteEndElement()

            writer.WriteStartElement("TEMP_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("LAST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("FIRST_NAME")
            writer.WriteEndElement()
            writer.WriteStartElement("HOBORIFIC")
            writer.WriteEndElement()

            writer.WriteStartElement("RGNCOD")
            writer.WriteEndElement()

            writer.WriteStartElement("ADR_DISTRICT")
            writer.WriteEndElement()
            writer.WriteStartElement("WEB_ADR")
            writer.WriteEndElement()
            writer.WriteStartElement("EMAIL_ADR")
            writer.WriteEndElement()

            writer.WriteStartElement("PAGNUM")
            writer.WriteEndElement()

            writer.WriteStartElement("LOCALE_ID")
            writer.WriteEndElement()

            writer.WriteStartElement("PO_BOX_FLG")
            writer.WriteEndElement()
            writer.WriteStartElement("TRK_CNSG_COD")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.Close()
            strMessage = "Export Address Compleated : " & strFilename
            WriteErrorlog(strMessage, strPath)
            If File.Exists(strTRGFileName) Then
                File.Delete(strTRGFileName)
            End If
            Dim fs As New FileStream(strTRGFileName, FileMode.Create)
            fs.Close()
            strMessage = "Export Address TRG  Compleated : " & strTRGFileName
            WriteErrorlog(strMessage, strPath)

            oRecItem.MoveNext()
        Next
        ' ShowSuccessMessage("Operation completed successfully")
    End Sub
#End Region

#Region "Export Documents Methods"
    'Public Sub ExportDocuments()
    '    Dim oTemp, oTemp1 As SAPbobsCOM.Recordset
    '    Dim oCheck, objCheckBox As SAPbouiCOM.CheckBox
    '    oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '    oTemp1 = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '    Dim strPath, strFilename, strErrorPath As String
    '    'strErrorLogPath = strErrorLogPath
    '    strPath = strErrorLogPath
    '    strFilename = Now.ToLongDateString
    '    strPath = strPath & "\Mobilestic_" & strFilename & ".txt"
    '    sPath = strPath
    '    strErrorPath = sPath
    '    oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '    oTemp1 = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '    WriteErrorlog("Exporting Sales Document..", strErrorPath)
    '    oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N'  and U_DocType='SO'")

    '    Try
    '        For intLoop As Integer = 0 To oTemp.RecordCount - 1
    '            ' WriteErrorlog("Exporting Sales Order : " & oTemp.Fields.Item("U_MasterCode").Value, strErrorPath)
    '            ' oStaticText.Caption = "Exporting Sales Order : " & oTemp.Fields.Item("U_MasterCode").Value
    '            ExportSalesOrder(oTemp.Fields.Item("U_MasterCode").Value, oTemp.Fields.Item("Code").Value)
    '            Dim strTime As String
    '            strTime = Now.ToShortTimeString.Replace(":", "")
    '            oTemp1.DoQuery("update [@MOB_Export] set U_ExpType ='A', U_Exported='Y' ,U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
    '            oTemp.MoveNext()
    '        Next
    '        ' oTemp1.DoQuery("Delete from  [@MOB_Export]  where Name like '%M' and U_DocType='SO'")
    '    Catch ex As Exception
    '        WriteErrorlog(ex.Message, strErrorPath)
    '    End Try
    '    WriteErrorlog("Exporting Purchasing Document..", strErrorPath)
    '    oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N' and U_DocType='PO'")
    '    Try
    '        For intLoop As Integer = 0 To oTemp.RecordCount - 1
    '            'WriteErrorlog("Exporting Purchase Order : " & oTemp.Fields.Item("U_MasterCode").Value, strErrorPath)
    '            ExportPurchaseOrder(oTemp.Fields.Item("U_MasterCode").Value, oTemp.Fields.Item("Code").Value)
    '            Dim strTime As String
    '            strTime = Now.ToShortTimeString.Replace(":", "")
    '            oTemp1.DoQuery("update [@MOB_Export] set U_ExpType ='A', U_Exported='Y',U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
    '            oTemp.MoveNext()
    '        Next
    '        'oTemp1.DoQuery("Delete from  [@MOB_Export]  where Name like '%M' and U_DocType='PO'")
    '    Catch ex As Exception
    '        WriteErrorlog(ex.Message, strErrorPath)
    '    End Try

    '    WriteErrorlog("Exporting Credit Memo to PO..", strErrorPath)

    '    oTemp.DoQuery("Select * from [@MOB_Export] where U_Exported='N' and U_DocType='CPO'")

    '    Try
    '        For intLoop As Integer = 0 To oTemp.RecordCount - 1
    '            'WriteErrorlog("Exporting Purchase Order : " & oTemp.Fields.Item("U_MasterCode").Value, strErrorPath)
    '            ' ExportCreditMemo(oTemp.Fields.Item("U_MasterCode").Value, oTemp.Fields.Item("Code").Value)
    '            Dim strTime As String
    '            strTime = Now.ToShortTimeString.Replace(":", "")
    '            oTemp1.DoQuery("update [@MOB_Export] set U_ExpType ='A', U_Exported='Y',U_ExpDate=getdate(),U_ExpTime='" & strTime & "' where code='" & oTemp.Fields.Item("Code").Value & "'")
    '            oTemp.MoveNext()
    '        Next
    '        'oTemp1.DoQuery("Delete from  [@MOB_Export]  where Name like '%M' and U_DocType='PO'")
    '    Catch ex As Exception
    '        WriteErrorlog(ex.Message, strErrorPath)
    '    End Try
    '    WriteErrorlog("Exporting Documetns completed...", strErrorPath)
    'End Sub


    


#End Region





#Region "Get Group Code"
    Private Function GetGroupName(ByVal aCode As Integer) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select * from OCRG where Groupcode=" & aCode)
        Return oTemp.Fields.Item("GroupName").Value
    End Function
#End Region
#Region "get WMD Code"
    Private Function GetWMSCode(ByVal aCardcode As String, ByVal aShipcode As String, ByVal aCardType As String) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim strstring As String
        strstring = "select isnull(U_WMSID,'') from CRD1 where CardCode='" & aCardcode & "' and address='" & aShipcode.Replace("'", "''") & "' and Adrestype='" & aCardType & "'"
        oTemp.DoQuery(strstring)
        Return oTemp.Fields.Item(0).Value
    End Function

    Public Function getCardCode(ByVal aCardcode As String, ByVal Fieldname As String) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim strstring As String
        strstring = "select isnull(" & Fieldname & ",'') from CRD1 where U_WMSID='" & aCardcode & "'"
        oTemp.DoQuery(strstring)
        Return oTemp.Fields.Item(0).Value
    End Function
#End Region

#Region "Get WMS_Warehouse COde"
    Private Function getWMSWhsCode(ByVal aWhscode As String) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select isnull(Name,'') from [@MOB_OWHS] where code='" & aWhscode & "'")
        Return oTemp.Fields.Item(0).Value
    End Function

    Public Function getSAPWhs(ByVal aWhscode As String) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select isnull(Code,'') from [@MOB_OWHS] where Name='" & aWhscode & "'")
        Return oTemp.Fields.Item(0).Value
    End Function
#End Region

#Region "Get CARCode"
    Private Function getCARCOD(ByVal strType As Integer, ByVal fieldname As String) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select isnull(" & fieldname & ",'') from OSHP where TrnsPcode=" & strType)
        Return oTemp.Fields.Item(0).Value
    End Function

    Public Function GetShippingType(ByVal aCadCode As String, ByVal aSrvLVL As String) As String
        Dim oTemp As SAPbobsCOM.Recordset
        oTemp = objRemoteCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTemp.DoQuery("Select transPCode from OSHP where U_CARCOD=" & aCadCode & "' and U_SRVLVL='" & aSrvLVL & "'")
        Return oTemp.Fields.Item(0).Value
    End Function
#End Region


#End Region


    Private Sub CopyFilestoCustomers(ByVal aFileName As String, ByVal aLogPath As String)
        Dim otemp As SAPbobsCOM.Recordset
        Dim strFilePath, strDesgfilename, strMessage As String
        otemp = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        otemp.DoQuery("Select * from OCRD where cardtype='C' and U_PharmInt = 'Y'")
        strFilePath = strExportFilePaty
        For intRow As Integer = 0 To otemp.RecordCount - 1
            strFilePath = strFilePath & "\" & otemp.Fields.Item("CardCode").Value
            If Directory.Exists(strFilePath) Then
            Else
                Directory.CreateDirectory(strFilePath)
            End If
            strDesgfilename = strFilePath & "\PROMFLQ.mfp"
            If File.Exists(strDesgfilename) Then
                File.Delete(strDesgfilename)
            End If
            File.Copy(aFileName, strDesgfilename)
            strFilePath = strExportFilePaty
            strMessage = "Exported :  File name : " & strDesgfilename
            WriteErrorlog(strMessage, aLogPath)
            otemp.MoveNext()
        Next


    End Sub

#Region "Connect MainCompany"
    Private Function connectLocalCompany() As Boolean
        sPath = strErrorLogPath
        Try
            If cmbCompanyDB.Text = "" Then
                MsgBox("Choose Company")
                Return False
            Else
                strSAPCompany = cmbCompanyDB.Text
            End If
            If txtServerName.Text = "" Then
                MsgBox("Enter UserName")
                Return False
            End If
            If txtServerPwd.Text = "" Then
                MsgBox("Enter Password")
                Return False
            End If
            oCompany = New SAPbobsCOM.Company
            oCompany.Server = txtServerName.Text
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
            If strLocalServertype = "2005" Then
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2005
            ElseIf strLocalServertype = "2008" Then
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
            ElseIf strLocalServertype = "2012" Then
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012
            Else
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
            End If

            oCompany.LicenseServer = LocalLicenseServer.Text ' "Compaq-PC:30000"
            oCompany.DbUserName = txtDBUserName.Text
            oCompany.DbPassword = txtServerPwd.Text
            oCompany.CompanyDB = cmbCompanyDB.Text
            oCompany.UserName = txtSBOUserName.Text
            oCompany.Password = txtCompanyPWD.Text

            sPath = strErrorFileName

            WriteErrorlog("Connection to local SAP B1 server started", sPath)
            If oCompany.Connected = True Then
                If (objPC.Initialise(oCompany)) Then
                Else
                    'MsgBox("Error in Connection")
                    WriteErrorlog("Error in Connection to Local Server", sPath)
                    Return False
                End If
                WriteiniFile()
                objRemoteCompany = oCompany
                objMainCompany = objRemoteCompany
                Return True
            Else
                If oCompany.Connect <> 0 Then
                    'MsgBox("Connection to SAP B1 failed. Error Description :" & oCompany.GetLastErrorDescription)
                    WriteErrorlog("Connection to Local SAP B1  Company :  " & cmbCompanyDB.Text & " failed : Error Description :" & oCompany.GetLastErrorDescription, sPath)
                    Return False
                Else
                    WriteiniFile()
                    '     MsgBox("Local SAP B1 Company Connected successfully")
                    sPath = strErrorFileName
                    WriteErrorlog("Local SAP B1 Company :  " & cmbCompanyDB.Text & " Company Connected successfully", sPath)
                    objRemoteCompany = oCompany
                    objMainCompany = objRemoteCompany
                    Return True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            WriteErrorlog(ex.Message, sPath)
            Return False
        End Try
        Return True
    End Function
#End Region

    Private Sub btnConnect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            If connectLocalCompany() = False Then
                MsgBox("Error in connection to local server")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBrowse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fldFolderBrowse.ShowDialog()
        txtDirectory.Text = fldFolderBrowse.SelectedPath
    End Sub

#End Region

    Private Sub cmbCompanyDB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompanyDB.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If connectMainCompany() = False Then
        '    MsgBox("Error in connection to main server")
        'End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If connectLocalCompany() Then
            If 1 = 1 Then
                ' strFilename = Now.ToLongDateString
                sPath = strErrorFileName
                WriteErrorlog("Process Started", sPath)
                Me.Hide()
                Me.Hide()
                ' WriteErrorlog("Export Invoice Document ", sPath)
                Try
                    'ExportSalesOrer(oCompany)
                    ExportMasterData()
                Catch ex As Exception
                    WriteErrorlog(ex.Message, sPath)
                End Try
                WriteErrorlog("Process Completed", sPath)
                Me.Hide()
                Me.Hide()
                End
            End If
        End If
        MsgBox("Export process Compleated")
        End
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        fldFolderBrowse.ShowDialog()
        txtDirectory.Text = fldFolderBrowse.SelectedPath
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbServertype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServertype.SelectedIndexChanged

    End Sub


    Public Function getDocumentQuantity(ByVal strQuantity As String) As Double
        Dim dblQuant As Double
        Dim strTemp As String
        'strTemp = CompanyDecimalSeprator
        'If CompanyDecimalSeprator <> "." Then
        '    If CompanyThousandSeprator <> strTemp Then
        '    End If
        '    strQuantity = strQuantity.Replace(".", ",")
        'End If
        Try
            dblQuant = Convert.ToDouble(strQuantity)
        Catch ex As Exception
            dblQuant = 0
        End Try

        Return dblQuant
    End Function
   
    Public Sub ReadALSane(ByVal aFolderpath As String, ByVal aPath As String)
        Dim strStorekey, strSokey, strSuccessFile, strErrorFile, strsuccessfolder, strErrorfolder, strLineno, strImpDocType, strType, strdate, strOrderKey, strShipdate, strSKU, strQty, strbatch, strmfgdate, strexpdate As String
        Dim dtShipdate, dtMfrDate, dtExpDate As Date
        Dim sr As IO.StreamReader
        Dim YEAR, MONTH, DAY, DATE1, strFilename, linje As String
        Dim oDelrec As SAPbobsCOM.Recordset
        Dim blnErrorflag As Boolean = False
        Dim blnError As Boolean = False
        strImportErrorLog = strErrorFileName
        Dim di As New IO.DirectoryInfo(aFolderpath)
        Dim aryFi As IO.FileInfo()
        For Each filename As String In IO.Directory.GetFiles(aFolderpath, "*", IO.SearchOption.AllDirectories)
            Dim fName As String = IO.Path.GetExtension(filename)
            If fName.ToUpper = ".TXT" Or fName.ToUpper = ".CSV" Then
                'If fName = ".txt" Then
                aryFi = di.GetFiles("*" & fName)
                Dim fi As IO.FileInfo
                WriteErrorlog("Reading  files...", strImportErrorLog)
                strsuccessfolder = aFolderpath
                strsuccessfolder = aFolderpath & "\Success"
                strErrorfolder = aFolderpath & "\Error"
                If Directory.Exists(strsuccessfolder) = False Then
                    Directory.CreateDirectory(strsuccessfolder)
                End If
                If Directory.Exists(strErrorfolder) = False Then
                    Directory.CreateDirectory(strErrorfolder)
                End If
                Dim strLIneStrin As String()
                For Each fi In aryFi
                    strFilename = fi.FullName
                    strSuccessFile = strsuccessfolder & "\" & fi.Name
                    strErrorFile = strErrorfolder & "\" & fi.Name
                    sr = New StreamReader(fi.FullName, System.Text.Encoding.Default) 'IO.File.OpenText(fil)
                    sPath = aPath
                    Try
                        WriteErrorlog("Reading  Processing...File Name : " & fi.Name, strImportErrorLog)
                        Dim oRec, oRecUpdate, oTemp As SAPbobsCOM.Recordset
                        oRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                        Try
                            If objMainCompany.InTransaction Then
                                objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                            End If
                            objMainCompany.StartTransaction()
                            oRec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                            oTemp = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                            linje = ""
                            blnError = False
                            Do While (sr.Peek <> -1)
                                linje = sr.ReadLine()
                                strLIneStrin = linje.Split(vbTab)
                                If getDocumentQuantity(strLIneStrin.GetValue(1)) > 0 Then
                                    Dim strType1, strCompCode, strOrigin, strgoodsno, strVat, strSupplier, strAccount, strBrand, strGoodsDate, strSupDocNo, strCurrency, strGoodsBranch, strvalue, strPaydate, strPeriodPay, strvatpercentage, strsuppliertype As String
                                    Dim strJDTNum, strJDTLine, strGLType, strAccount1, strCurrency1, strDebit, strCredit, strLineMemo, strDate1, strReference, strProject, strRef2 As String
                                    Dim strCost1, strCost2, strCost3, strCost4, strCost5, strUDF1, strUDF2, strUDF3 As String
                                    strJDTNum = strLIneStrin.GetValue(0)
                                    strJDTLine = strLIneStrin.GetValue(1)
                                    strGLType = strLIneStrin.GetValue(2)
                                    strAccount1 = strLIneStrin.GetValue(3)
                                    strCurrency1 = strLIneStrin.GetValue(4)
                                    strDebit = strLIneStrin.GetValue(5)
                                    strCredit = strLIneStrin.GetValue(6)
                                    strDate1 = strLIneStrin.GetValue(7)
                                    strLineMemo = strLIneStrin.GetValue(8)
                                    strReference = strLIneStrin.GetValue(10)
                                    strRef2 = strLIneStrin.GetValue(11)
                                    strProject = strLIneStrin.GetValue(12)

                                    Try
                                        strCost1 = strLIneStrin.GetValue(13)
                                    Catch ex As Exception
                                        strCost1 = ""
                                    End Try
                                    Try
                                        strCost2 = strLIneStrin.GetValue(14)
                                    Catch ex As Exception
                                        strCost2 = ""
                                    End Try
                                    Try
                                        strCost3 = strLIneStrin.GetValue(15)
                                    Catch ex As Exception
                                        strCost3 = ""
                                    End Try
                                    Try
                                        strCost4 = strLIneStrin.GetValue(16)
                                    Catch ex As Exception
                                        strCost4 = ""
                                    End Try
                                    Try
                                        strCost5 = strLIneStrin.GetValue(17)
                                    Catch ex As Exception
                                        strCost5 = ""
                                    End Try

                                    Try
                                        strUDF1 = strLIneStrin.GetValue(18)
                                    Catch ex As Exception
                                        strUDF1 = ""
                                    End Try

                                    Try
                                        strUDF2 = strLIneStrin.GetValue(19)
                                    Catch ex As Exception
                                        strUDF2 = ""
                                    End Try

                                    Try
                                        strUDF3 = strLIneStrin.GetValue(20)
                                    Catch ex As Exception
                                        strUDF3 = ""
                                    End Try




                                    If strGLType.ToUpper = "G" Then
                                        oRec.DoQuery("Select * from OACT where FormatCode='" & strAccount1 & "'")
                                    Else
                                        oRec.DoQuery("Select * from OCRD where CardCode='" & strAccount1 & "'")
                                    End If
                                    If oRec.RecordCount <= 0 Then
                                        WriteErrorlog("Invalid account code : " & strAccount1 & " JDTNUM=" & strJDTNum & " and JDTLINE: " & strJDTLine, strImportErrorLog)

                                        blnError = True
                                    End If

                                    strdate = strDate1
                                    If strdate <> "" Then
                                        DAY = strdate.Substring(6, 2)
                                        MONTH = strdate.Substring(4, 2)
                                        YEAR = strdate.Substring(0, 4)
                                        DATE1 = DAY & MONTH & YEAR
                                        dtMfrDate = GetDateTimeValue(DATE1)
                                    End If
                                    strdate = strDate1
                                    If strdate <> "" And strdate.Length = 8 Then
                                        DAY = strdate.Substring(6, 2)
                                        MONTH = strdate.Substring(4, 2)
                                        YEAR = strdate.Substring(0, 4)
                                        DATE1 = DAY & MONTH & YEAR
                                        dtExpDate = GetDateTimeValue(DATE1)
                                    Else
                                        strPaydate = ""
                                    End If
                                    Dim oUsertable As SAPbobsCOM.UserTable
                                    Dim strsql As String
                                    strsql = getMaxCode("@Z_OALJDT", "Code")
                                    Dim oTest As SAPbobsCOM.Recordset
                                    oTest = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

                                    If blnError = False Then
                                        oTest.DoQuery("Select * from [@Z_OALJDT] where U_Z_Imported='Y' and U_Z_JDTNUM='" & strJDTNum & "' and  U_Z_LINENO=" & strJDTLine)
                                        If oTest.RecordCount > 0 Then
                                            WriteErrorlog("This Entry already Imported :  Journel Number : " & strJDTNum & " LineNo :" & strJDTLine, strImportErrorLog)
                                        Else
                                            oTest.DoQuery("Delete from [@Z_OALJDT] where U_Z_Imported='N' and U_Z_JDTNUM='" & strJDTNum & "' and  U_Z_LINENO=" & strJDTLine)
                                            oUsertable = objMainCompany.UserTables.Item("Z_OALJDT")
                                            oUsertable.Code = strsql
                                            oUsertable.Name = strsql & "M"
                                            oUsertable.UserFields.Fields.Item("U_Z_JDTNUM").Value = strJDTNum
                                            oUsertable.UserFields.Fields.Item("U_Z_LINENO").Value = strJDTLine
                                            oUsertable.UserFields.Fields.Item("U_Z_GLTYPE").Value = strGLType
                                            oUsertable.UserFields.Fields.Item("U_Z_ACCTCODE").Value = strAccount1
                                            oUsertable.UserFields.Fields.Item("U_Z_CURRENCY").Value = strCurrency1
                                            oUsertable.UserFields.Fields.Item("U_Z_DEBIT").Value = strDebit
                                            oUsertable.UserFields.Fields.Item("U_Z_CREDIT").Value = strCredit
                                            If strdate <> "" Then
                                                oUsertable.UserFields.Fields.Item("U_Z_DATE").Value = dtMfrDate
                                            End If
                                            oUsertable.UserFields.Fields.Item("U_Z_LINEMEMO").Value = strReference
                                            oUsertable.UserFields.Fields.Item("U_Z_PROJECT").Value = strProject
                                            oUsertable.UserFields.Fields.Item("U_Z_REF2").Value = strRef2
                                            oUsertable.UserFields.Fields.Item("U_Z_Imported").Value = "N"

                                            oUsertable.UserFields.Fields.Item("U_Z_COST1").Value = strCost1
                                            oUsertable.UserFields.Fields.Item("U_Z_COST2").Value = strCost2
                                            oUsertable.UserFields.Fields.Item("U_Z_COST3").Value = strCost3
                                            oUsertable.UserFields.Fields.Item("U_Z_COST4").Value = strCost4
                                            oUsertable.UserFields.Fields.Item("U_Z_COST5").Value = strCost5

                                            oUsertable.UserFields.Fields.Item("U_Z_UDF1").Value = strUDF1
                                            oUsertable.UserFields.Fields.Item("U_Z_UDF2").Value = strUDF2
                                            oUsertable.UserFields.Fields.Item("U_Z_UDF3").Value = strUDF3

                                            If oUsertable.Add <> 0 Then
                                                WriteErrorlog(objMainCompany.GetLastErrorDescription, strImportErrorLog)
                                                oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                                ' oDelrec.DoQuery("Delete from [@Z_XADJ] where Name like '%M' and U_Z_Filename='" & fi.Name & "'")
                                            End If
                                        End If
                                    End If
                                End If
                            Loop

                            oDelrec = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                            WriteErrorlog("Reading  Process Completed..", strImportErrorLog)
                            If blnError = True Then
                                WriteErrorlog("Error occured during reading files. Please check the file contents and reimport", strImportErrorLog)
                                If objMainCompany.InTransaction Then
                                    objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                End If
                                sr.Close()
                                If File.Exists(strErrorFile) Then
                                    File.Delete(strErrorFile)
                                End If
                                File.Move(fi.FullName, strErrorFile)
                                WriteErrorlog("Reading file failed: Filename : " & fi.Name & " Moved to Error folder", strImportErrorLog)
                            Else
                                If objMainCompany.InTransaction Then
                                    objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                End If
                                sr.Close()
                                If File.Exists(strSuccessFile) Then
                                    File.Delete(strSuccessFile)
                                End If
                                File.Move(fi.FullName, strSuccessFile)
                                WriteErrorlog("Reading Process Completed: Filename-->" & fi.Name & " Moved to success folder", strImportErrorLog)
                            End If
                        Catch ex As Exception
                            WriteErrorlog(ex.Message, strImportErrorLog) ' Return False
                            WriteErrorlog("Error occured during reading files. Please check the file contents and reimport", strImportErrorLog)
                            If objMainCompany.InTransaction Then
                                objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                            End If
                            sr.Close()
                            If File.Exists(strErrorFile) Then
                                File.Delete(strErrorFile)
                            End If
                            File.Move(fi.FullName, strErrorFile)
                            WriteErrorlog("Reading file failed: Filename : " & fi.Name & " Moved to Error folder", strImportErrorLog)
                        End Try
                    Catch ex As Exception
                        WriteErrorlog(ex.Message, strImportErrorLog)
                       
                    End Try

                Next
            Else
                WriteErrorlog("Wrong File Format : " & filename & " Imported only .txt or .csv files...", strImportErrorLog)
                '    Exit Sub
            End If
        Next
        If createJournalEntry() = True Then
            WriteErrorlog("Journel Entry Process Completed..", strImportErrorLog)
        Else
            WriteErrorlog("Journel Entry Process failed..", strImportErrorLog)
        End If

    End Sub

    Public Function createJournalEntry() As Boolean
        Dim oTest, oTest1, otest2 As SAPbobsCOM.Recordset
        Dim strQry As String
        Dim oJE As SAPbobsCOM.JournalEntries
        oTest = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oTest1 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        otest2 = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        strImportErrorLog = strErrorFileName ' System.Windows.Forms.Application.StartupPath & "\Import_Log.txt"
        Dim blnError As Boolean = False
        Try
            If objMainCompany.InTransaction Then
                objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
            End If
            objMainCompany.StartTransaction()
            strQry = "Select Count(*),U_Z_Date,U_Z_JDTNUM from [@Z_OALJDT] where isnull(U_Z_Imported,'N')='N' Group by U_Z_Date, U_Z_JDTNUM"
            oTest.DoQuery(strQry)
            Dim dtdate As Date
            WriteErrorlog("Creating Journal Entries..", strImportErrorLog)
            For intRow As Integer = 0 To oTest.RecordCount - 1
                dtdate = oTest.Fields.Item("U_Z_Date").Value
                WriteErrorlog("Journal Ref Number : " & oTest.Fields.Item("U_Z_JDTNUM").Value, strImportErrorLog)
                strQry = "Select * from [@Z_OALJDT] where isnull(U_Z_Imported,'N')='N' and  U_Z_JDTNUM='" & oTest.Fields.Item("U_Z_JDTNUM").Value & "' and U_Z_DATE='" & dtdate.ToString("yyyy-MM-dd") & "'"
                oTest1.DoQuery(strQry)
                oJE = objMainCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries)
                Dim blnLineExists As Boolean = False
                For intLoop As Integer = 0 To oTest1.RecordCount - 1
                    oJE.ReferenceDate = oTest.Fields.Item(1).Value
                    If intLoop > 0 Then
                        oJE.Lines.Add()
                    End If
                    oJE.Lines.SetCurrentLine(intLoop)
                    If oTest1.Fields.Item("U_Z_ACCTCODE").Value = "G" Then
                        oJE.Lines.AccountCode = oTest1.Fields.Item("U_Z_ACCTCODE").Value
                    Else
                        oJE.Lines.ShortName = oTest1.Fields.Item("U_Z_ACCTCODE").Value
                    End If
                    If oTest1.Fields.Item("U_Z_PROJECT").Value <> "" Then
                        oJE.Lines.ProjectCode = oTest1.Fields.Item("U_Z_PROJECT").Value
                    End If
                    oJE.Lines.UserFields.Fields.Item("U_Z_JDTNUM").Value = oTest1.Fields.Item("U_Z_JDTNUM").Value
                    oJE.Lines.UserFields.Fields.Item("U_Z_LineNo").Value = oTest1.Fields.Item("U_Z_LINENO").Value
                    Dim dblCredit, dblDebit As Double
                    Dim strCurrency As String = oTest1.Fields.Item("U_Z_CURRENCY").Value
                    dblCredit = oTest1.Fields.Item("U_Z_CREDIT").Value
                    dblDebit = oTest1.Fields.Item("U_Z_DEBIT").Value
                    If strCurrency <> localcurrency And strCurrency <> systemcurrency Then
                        oJE.Lines.FCCurrency = strCurrency
                        oJE.Lines.FCDebit = dblDebit
                        oJE.Lines.FCCredit = dblCredit
                    Else
                        oJE.Lines.Debit = dblDebit
                        oJE.Lines.Credit = dblCredit
                    End If
                    Dim strref2 = oTest1.Fields.Item("U_Z_LINEMEMO").Value
                    oJE.Lines.Reference1 = oTest1.Fields.Item("U_Z_REF2").Value
                    oJE.Lines.LineMemo = oTest1.Fields.Item("U_Z_LINEMEMO").Value

                    If oTest1.Fields.Item("U_Z_COST1").Value <> "" Then
                        oJE.Lines.CostingCode = oTest1.Fields.Item("U_Z_COST1").Value
                    End If
                    If oTest1.Fields.Item("U_Z_COST2").Value <> "" Then
                        oJE.Lines.CostingCode2 = oTest1.Fields.Item("U_Z_COST2").Value
                    End If
                    If oTest1.Fields.Item("U_Z_COST3").Value <> "" Then
                        oJE.Lines.CostingCode3 = oTest1.Fields.Item("U_Z_COST3").Value
                    End If
                    If oTest1.Fields.Item("U_Z_COST4").Value <> "" Then
                        oJE.Lines.CostingCode4 = oTest1.Fields.Item("U_Z_COST4").Value
                    End If
                    If oTest1.Fields.Item("U_Z_COST5").Value <> "" Then
                        oJE.Lines.CostingCode5 = oTest1.Fields.Item("U_Z_COST5").Value
                    End If
                    Try
                        If oTest1.Fields.Item("U_Z_UDF1").Value <> "" Then
                            oJE.Lines.UserFields.Fields.Item("U_UDF1").Value = oTest1.Fields.Item("U_Z_UDF1").Value
                        End If
                    Catch ex As Exception

                    End Try

                    Try
                        If oTest1.Fields.Item("U_Z_UDF2").Value <> "" Then
                            oJE.Lines.UserFields.Fields.Item("U_UDF2").Value = oTest1.Fields.Item("U_Z_UDF3").Value
                        End If
                    Catch ex As Exception

                    End Try

                    Try
                        If oTest1.Fields.Item("U_Z_UDF3").Value <> "" Then
                            oJE.Lines.UserFields.Fields.Item("U_UDF3").Value = oTest1.Fields.Item("U_Z_UDF3").Value
                        End If
                    Catch ex As Exception

                    End Try
                 
                    oJE.Memo = oTest1.Fields.Item("U_Z_LINEMEMO").Value


                    oJE.Reference = strref2
                    blnLineExists = True
                    oTest1.MoveNext()
                Next
                If blnLineExists = True Then
                    If oJE.Add <> 0 Then
                        WriteErrorlog("Journal Ref Number : " & oTest.Fields.Item("U_Z_JDTNUM").Value & " Error : " & objMainCompany.GetLastErrorDescription, strImportErrorLog)
                        'oApplication.Utilities.Message(oApplication.Company.GetLastErrorDescription, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                        ' Return False
                        blnError = True
                        If objMainCompany.InTransaction Then
                            objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                        End If
                    Else
                        Dim strDoc As String
                        objMainCompany.GetNewObjectCode(strDoc)
                        oTest1.DoQuery("Update  [@Z_OALJDT] set U_Z_JDTREF='" & strDoc & "',U_Z_Imported='Y' where isnull(U_Z_Imported,'N')='N' and  U_Z_JDTNUM='" & oTest.Fields.Item("U_Z_JDTNUM").Value & "'")
                        WriteErrorlog("Journal Ref Number : " & oTest.Fields.Item("U_Z_JDTNUM").Value & " Imported Successfully : JE Ref No : " & strDoc, strImportErrorLog)
                        If objMainCompany.InTransaction Then
                            objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                        End If

                    End If
                End If
                oTest.MoveNext()
            Next


        Catch ex As Exception
            If objMainCompany.InTransaction Then
                objMainCompany.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
            End If
        End Try
        If blnError = False Then
            Return True
        Else
            Return False
        End If
        Return True
    End Function
End Class
