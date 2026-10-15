<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAI
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	  Try
		 If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		 End If
	  Finally
		 MyBase.Dispose(disposing)
	  End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
	  btnRun = New Button()
	  chkBoxDisableBingSearch = New CheckBox()
	  chkBoxDisableSearchLocation = New CheckBox()
	  chkBoxDisableSearchStore = New CheckBox()
	  chkBoxDisableCortana = New CheckBox()
	  chkBoxDisableRecall = New CheckBox()
	  chkBoxDisableSearchSuggestions = New CheckBox()
	  grpBoxApps = New GroupBox()
	  chkBoxPaint = New CheckBox()
	  chkBoxNotepad = New CheckBox()
	  chkBoxDisableCopilot = New CheckBox()
	  grpBoxApps.SuspendLayout()
	  SuspendLayout()
	  ' 
	  ' btnRun
	  ' 
	  btnRun.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
	  btnRun.Location = New Point(780, 435)
	  btnRun.Name = "btnRun"
	  btnRun.Size = New Size(50, 23)
	  btnRun.TabIndex = 1
	  btnRun.Text = "Run"
	  btnRun.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableBingSearch
	  ' 
	  chkBoxDisableBingSearch.AutoSize = True
	  chkBoxDisableBingSearch.Checked = True
	  chkBoxDisableBingSearch.CheckState = CheckState.Checked
	  chkBoxDisableBingSearch.Location = New Point(5, 5)
	  chkBoxDisableBingSearch.Name = "chkBoxDisableBingSearch"
	  chkBoxDisableBingSearch.Size = New Size(158, 19)
	  chkBoxDisableBingSearch.TabIndex = 2
	  chkBoxDisableBingSearch.Text = "Disable Bing/Web Search"
	  chkBoxDisableBingSearch.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableSearchLocation
	  ' 
	  chkBoxDisableSearchLocation.AutoSize = True
	  chkBoxDisableSearchLocation.Checked = True
	  chkBoxDisableSearchLocation.CheckState = CheckState.Checked
	  chkBoxDisableSearchLocation.Location = New Point(5, 45)
	  chkBoxDisableSearchLocation.Name = "chkBoxDisableSearchLocation"
	  chkBoxDisableSearchLocation.Size = New Size(188, 19)
	  chkBoxDisableSearchLocation.TabIndex = 3
	  chkBoxDisableSearchLocation.Text = "Disable Search access Location"
	  chkBoxDisableSearchLocation.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableSearchStore
	  ' 
	  chkBoxDisableSearchStore.AutoSize = True
	  chkBoxDisableSearchStore.Checked = True
	  chkBoxDisableSearchStore.CheckState = CheckState.Checked
	  chkBoxDisableSearchStore.Location = New Point(5, 65)
	  chkBoxDisableSearchStore.Name = "chkBoxDisableSearchStore"
	  chkBoxDisableSearchStore.Size = New Size(169, 19)
	  chkBoxDisableSearchStore.TabIndex = 4
	  chkBoxDisableSearchStore.Text = "Disable Search access Store"
	  chkBoxDisableSearchStore.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableCortana
	  ' 
	  chkBoxDisableCortana.AutoSize = True
	  chkBoxDisableCortana.Checked = True
	  chkBoxDisableCortana.CheckState = CheckState.Checked
	  chkBoxDisableCortana.Location = New Point(5, 85)
	  chkBoxDisableCortana.Name = "chkBoxDisableCortana"
	  chkBoxDisableCortana.Size = New Size(109, 19)
	  chkBoxDisableCortana.TabIndex = 6
	  chkBoxDisableCortana.Text = "Disable Cortana"
	  chkBoxDisableCortana.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableRecall
	  ' 
	  chkBoxDisableRecall.AutoSize = True
	  chkBoxDisableRecall.Checked = True
	  chkBoxDisableRecall.CheckState = CheckState.Checked
	  chkBoxDisableRecall.Location = New Point(5, 125)
	  chkBoxDisableRecall.Name = "chkBoxDisableRecall"
	  chkBoxDisableRecall.Size = New Size(98, 19)
	  chkBoxDisableRecall.TabIndex = 7
	  chkBoxDisableRecall.Text = "Disable Recall"
	  chkBoxDisableRecall.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableSearchSuggestions
	  ' 
	  chkBoxDisableSearchSuggestions.AutoSize = True
	  chkBoxDisableSearchSuggestions.Checked = True
	  chkBoxDisableSearchSuggestions.CheckState = CheckState.Checked
	  chkBoxDisableSearchSuggestions.Location = New Point(5, 25)
	  chkBoxDisableSearchSuggestions.Name = "chkBoxDisableSearchSuggestions"
	  chkBoxDisableSearchSuggestions.Size = New Size(169, 19)
	  chkBoxDisableSearchSuggestions.TabIndex = 8
	  chkBoxDisableSearchSuggestions.Text = "Disable Search Suggestions"
	  chkBoxDisableSearchSuggestions.UseVisualStyleBackColor = True
	  ' 
	  ' grpBoxApps
	  ' 
	  grpBoxApps.Controls.Add(chkBoxPaint)
	  grpBoxApps.Controls.Add(chkBoxNotepad)
	  grpBoxApps.Location = New Point(225, 5)
	  grpBoxApps.Name = "grpBoxApps"
	  grpBoxApps.Size = New Size(222, 99)
	  grpBoxApps.TabIndex = 9
	  grpBoxApps.TabStop = False
	  grpBoxApps.Text = "Remove AI features from:"
	  ' 
	  ' chkBoxPaint
	  ' 
	  chkBoxPaint.AutoSize = True
	  chkBoxPaint.Checked = True
	  chkBoxPaint.CheckState = CheckState.Checked
	  chkBoxPaint.Location = New Point(5, 40)
	  chkBoxPaint.Name = "chkBoxPaint"
	  chkBoxPaint.Size = New Size(53, 19)
	  chkBoxPaint.TabIndex = 12
	  chkBoxPaint.Text = "Paint"
	  chkBoxPaint.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxNotepad
	  ' 
	  chkBoxNotepad.AutoSize = True
	  chkBoxNotepad.Checked = True
	  chkBoxNotepad.CheckState = CheckState.Checked
	  chkBoxNotepad.Location = New Point(5, 20)
	  chkBoxNotepad.Name = "chkBoxNotepad"
	  chkBoxNotepad.Size = New Size(72, 19)
	  chkBoxNotepad.TabIndex = 11
	  chkBoxNotepad.Text = "Notepad"
	  chkBoxNotepad.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxDisableCopilot
	  ' 
	  chkBoxDisableCopilot.AutoSize = True
	  chkBoxDisableCopilot.Checked = True
	  chkBoxDisableCopilot.CheckState = CheckState.Checked
	  chkBoxDisableCopilot.Location = New Point(5, 105)
	  chkBoxDisableCopilot.Name = "chkBoxDisableCopilot"
	  chkBoxDisableCopilot.Size = New Size(106, 19)
	  chkBoxDisableCopilot.TabIndex = 6
	  chkBoxDisableCopilot.Text = "Disable Copilot"
	  chkBoxDisableCopilot.UseVisualStyleBackColor = True
	  ' 
	  ' frmAI
	  ' 
	  AutoScaleDimensions = New SizeF(7F, 15F)
	  AutoScaleMode = AutoScaleMode.Font
	  ClientSize = New Size(834, 461)
	  Controls.Add(chkBoxDisableCopilot)
	  Controls.Add(grpBoxApps)
	  Controls.Add(chkBoxDisableSearchSuggestions)
	  Controls.Add(chkBoxDisableRecall)
	  Controls.Add(chkBoxDisableCortana)
	  Controls.Add(chkBoxDisableSearchStore)
	  Controls.Add(chkBoxDisableSearchLocation)
	  Controls.Add(chkBoxDisableBingSearch)
	  Controls.Add(btnRun)
	  Name = "frmAI"
	  Text = "A.I."
	  grpBoxApps.ResumeLayout(False)
	  grpBoxApps.PerformLayout()
	  ResumeLayout(False)
	  PerformLayout()
   End Sub

   Friend WithEvents btnRun As Button
   Friend WithEvents chkBoxDisableBingSearch As CheckBox
   Friend WithEvents chkBoxDisableSearchLocation As CheckBox
   Friend WithEvents chkBoxDisableSearchStore As CheckBox
   Friend WithEvents chkBoxDisableCortana As CheckBox
   Friend WithEvents chkBoxDisableRecall As CheckBox
   Friend WithEvents chkBoxDisableSearchSuggestions As CheckBox
   Friend WithEvents grpBoxApps As GroupBox
   Friend WithEvents chkBoxDisableCopilot As CheckBox
   Friend WithEvents chkBoxNotepad As CheckBox
   Friend WithEvents chkBoxPaint As CheckBox
End Class
