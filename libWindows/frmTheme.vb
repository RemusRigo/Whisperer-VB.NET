Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32


Public Class frmTheme

   Private isInitialized As Boolean = False

   Private Sub frmTheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ' Check Apps Light Theme
      If RegReadDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme") = 0 Then
         rBtnAppsDark.Checked = True
      Else
         rBtnAppsLight.Checked = True
      End If

      ' Check System Light Theme
      If RegReadDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme") = 0 Then
         rBtnSysDark.Checked = True
      Else
         rBtnSysLight.Checked = True
      End If
      isInitialized = True
   End Sub

   Private Sub rBtnAppsLight_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnAppsLight.CheckedChanged
      If (rBtnAppsLight.Checked And isInitialized) Then
         RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", 1)
      End If
   End Sub

   Private Sub rBtnAppsDark_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnAppsDark.CheckedChanged
      If (rBtnAppsDark.Checked And isInitialized) Then
         RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", 0)
      End If
   End Sub

   Private Sub rBtnSysLight_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnSysLight.CheckedChanged
      If (rBtnSysLight.Checked And isInitialized) Then
         RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", 1)
      End If
   End Sub

   Private Sub rBtnSysDark_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnSysDark.CheckedChanged
      If (rBtnSysDark.Checked And isInitialized) Then
         RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", 0)
      End If
   End Sub
End Class