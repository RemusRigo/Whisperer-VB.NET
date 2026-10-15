Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32

Public Class frmTaskBar

   Private isInitialized As Boolean = False

   Private Sub frmTaskBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ' Search Box
      cbSearchBox.Items.AddRange(New String() {"Hidden", "Show search icon only", "Show search box", "Show search button"})
      cbSearchBox.SelectedIndex = RegReadDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode")

	  ' Widgets
	  ' HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced > TaskbarDa is blocked by group policy in some environments

	  If RegValueExists(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarDa") Then
         Select Case RegReadDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarDa")
            Case 0
               chkBoxWidgets.Checked = False
            Case 1
               chkBoxWidgets.Checked = True
         End Select
      Else
         chkBoxWidgets.CheckState = CheckState.Indeterminate
      End If

      If RegValueExists(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Dsh", "AllowNewsAndInterests") Then
         Select Case RegReadDWord(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Dsh", "AllowNewsAndInterests")
            Case 0
               chkBoxWidgetsLM.Checked = False
            Case 1
               chkBoxWidgetsLM.Checked = True
         End Select

      Else
         chkBoxWidgetsLM.CheckState = CheckState.Indeterminate
      End If

      isInitialized = True
   End Sub

   Private Sub cbSearchBox_SelectedIndexChanged(sender As Object, e As EventArgs)
      If isInitialized Then
         RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", cbSearchBox.SelectedIndex)
      End If
   End Sub

   Private Sub chkBoxWidgets_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxWidgets.CheckedChanged
      If isInitialized Then
         If chkBoxWidgets.Checked Then
            RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarDa", 1)
         End If
		 If Not chkBoxWidgets.Checked Then
			RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarDa", 0)
		 End If
	  End If
   End Sub

   Private Sub chkBoxWidgetsLM_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxWidgetsLM.CheckedChanged
      If isInitialized Then
         If chkBoxWidgetsLM.Checked Then
            RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Dsh", "AllowNewsAndInterests", 0)
            MessageBox.Show("0")
         End If
         If Not chkBoxWidgetsLM.Checked Then
            RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Dsh", "AllowNewsAndInterests", 1)
            MessageBox.Show("1")
         End If
      End If
   End Sub
End Class