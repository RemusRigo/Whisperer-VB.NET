Imports Microsoft.Win32

Public Class frmAI
   Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

	  ' Bing/Web Search
	  If chkBoxDisableBingSearch.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", 0)
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "ConnectedSearchUseWeb", 0)
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "DisableWebSearch", 1)
	  End If

	  ' Copilot
	  If chkBoxDisableCopilot.Checked Then
		 ' Disable Copilot service for current user
		 RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 1)
		 ' Disable Copilot button on taskbar
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowCopilotButton", 0)
		 If IsRunningAsAdmin() Then
			' Disable Copilot service for all users
			RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 1)
		 End If
	  End If

		 ' Cortana
		 If chkBoxDisableCortana.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", 0)
		 If IsRunningAsAdmin() Then
			RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\Windows Search", "AllowCortana", 0)
			RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\Windows Search", "CortanaConsent", 0)
		 End If
	  End If

	  ' Recall
	  If chkBoxDisableRecall.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 1)
		 If IsRunningAsAdmin() Then
			RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "AllowRecallEnablement", 0)
			RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 1)
			RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\WindowsAI", "TurnOffSavingSnapshots", 1)
		 End If
	  End If

	  ' Search
	  If chkBoxDisableSearchSuggestions.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\Explorer", "DisableSearchBoxSuggestions", 1)
	  End If

	  If chkBoxDisableSearchLocation.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", 0)
	  End If

	  If (chkBoxDisableSearchLocation.Checked And IsRunningAsAdmin()) Then
		 RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Windows\Explorer", "AllowSearchToUseLocation", 1)
	  End If

	  ' Noatepad
	  If (chkBoxNotepad.Checked And IsRunningAsAdmin()) Then
		 RegWriteDWord(Registry.LocalMachine, "Software\Policies\WindowsNotepad", "DisableAIFeatures", 1)
	  End If

	  ' Paint
	  If (chkBoxPaint.Checked And IsRunningAsAdmin()) Then
		 RegWriteDWord(Registry.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Paint", "DisableCocreator", 1)
		 RegWriteDWord(Registry.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Paint", "DisableGenerativeFill", 1)
		 RegWriteDWord(Registry.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Paint", "DisableImageCreator", 1)
		 RegWriteDWord(Registry.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Paint", "DisableGenerativeErase", 1)
		 RegWriteDWord(Registry.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Paint", "DisableRemoveBackground", 1)
	  End If


   End Sub

End Class