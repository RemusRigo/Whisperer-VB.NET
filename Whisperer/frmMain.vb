Imports System.Windows
Imports System.Windows.Forms.Design.AxImporter ' For Message
'Imports System.Runtime
Imports System.Runtime.InteropServices ' For DllImport
Imports libVM
Imports libSW
Imports libWindows
Imports libUtilities

Public Class frmMain

   '-----------------------------------------------------------------------------------------------
   ' Add About menu item to system menu
   <DllImport("user32.dll")>
   Private Shared Function GetSystemMenu(hWnd As IntPtr, bRevert As Boolean) As IntPtr
   End Function

   <DllImport("user32.dll")>
   Private Shared Function AppendMenu(hMenu As IntPtr, uFlags As UInteger, uIDNewItem As UInteger, lpNewItem As String) As Boolean
   End Function

   ' Menu flags
   Private Const MF_SEPARATOR As UInteger = &H800
   Private Const MF_STRING As UInteger = &H0
   ' Custom menu item IDs (must be between 1 and &HF000 to avoid conflicts)
   Private Const WM_SYSCOMMAND As Integer = &H112
   Private Const SYSMENU_ABOUT_ID As UInteger = 1000

   Protected Overrides Sub OnHandleCreated(e As EventArgs)
      MyBase.OnHandleCreated(e)
      Dim hSysMenu As IntPtr = GetSystemMenu(Me.Handle, False)
      ' Add a separator and then your custom item
      AppendMenu(hSysMenu, MF_SEPARATOR, 0, String.Empty)
      AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "About...")
   End Sub

   Protected Overrides Sub WndProc(ByRef m As Message)
	  MyBase.WndProc(m)
	  If m.Msg = WM_SYSCOMMAND Then
		 If CUInt(m.WParam) = SYSMENU_ABOUT_ID Then
			frmAbout.ShowDialog()
		 End If
	  End If
   End Sub

   '-----------------------------------------------------------------------------------------------
   ' Process the selected node and display the corresponding form in the right panel
   Public Sub ProcessOptions(frm As String)
	  Dim frmChild As Form = Nothing
	  scMain.Panel2.Controls.Clear()
	  Me.Text = "Wisperer"
	  Select Case frm
		 Case "Microsoft Windows\AI"
			frmChild = New frmAI()
		 Case "Microsoft Windows\Regional Settings"
			frmChild = New frmRegion()
		 Case "Microsoft Windows\Start Menu"
			frmChild = New frmStartMenu()
		 Case "Microsoft Windows\TaskBar"
			frmChild = New frmTaskBar()
		 Case "Microsoft Windows\Theme"
			frmChild = New frmTheme()
		 Case "Microsoft Windows\Virtualization\Hyper-V"
			frmChild = New frmHyperV()
		 Case "Microsoft Edge"
			frmChild = New frmMicrosoftEdge()
		 Case Else
	  End Select
	  If frmChild IsNot Nothing Then
		 ' Embed the form inside the right panel
		 frmChild.TopLevel = False
		 frmChild.FormBorderStyle = FormBorderStyle.None
		 frmChild.Dock = DockStyle.Fill
		 scMain.Panel2.Controls.Add(frmChild)
		 frmChild.Show()
	  End If
   End Sub

   '-----------------------------------------------------------------------------------------------
   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	  tvItems.ExpandAll()

	  ' resize
	  Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.75 ' 75%
	  Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.75

	  ' recenter
	  Me.StartPosition = FormStartPosition.Manual
	  Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
	  Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

	  ' check admin privileges
	  If IsRunningAsAdmin() Then
		 StatusStrip.Items(0).Text = "Whisperer is running with Admin privileges // Right-click on title bar to show the About dialog box"
	  Else
		 StatusStrip.Items(0).Text = "Whisperer is NOT running with Admin privileges // Right-click on title bar to show the About dialog box"
	  End If
   End Sub

   '-----------------------------------------------------------------------------------------------
   ' Get the full path of the selected node
   Private Sub tvItems_DoubleClick(sender As Object, e As EventArgs) Handles tvItems.DoubleClick
	  If tvItems.SelectedNode Is Nothing Then
		 MsgBox("Please select a node first.", MsgBoxStyle.Exclamation, "No Node Selected")
		 Return
	  Else
		 ProcessOptions(tvItems.SelectedNode.FullPath)
	  End If
   End Sub

   '-----------------------------------------------------------------------------------------------
   ' nodes are always expanded
   Private Sub tvItems_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvItems.NodeMouseDoubleClick
      e.Node.Toggle()
   End Sub

End Class
