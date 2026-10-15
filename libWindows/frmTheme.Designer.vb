<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        grpBoxApps = New GroupBox()
        rBtnAppsDark = New RadioButton()
        rBtnAppsLight = New RadioButton()
        grpBoxSystem = New GroupBox()
        rBtnSysDark = New RadioButton()
        rBtnSysLight = New RadioButton()
        grpBoxApps.SuspendLayout()
        grpBoxSystem.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpBoxApps
        ' 
        grpBoxApps.Controls.Add(rBtnAppsDark)
        grpBoxApps.Controls.Add(rBtnAppsLight)
        grpBoxApps.Location = New Point(10, 12)
        grpBoxApps.Name = "grpBoxApps"
        grpBoxApps.Size = New Size(135, 43)
        grpBoxApps.TabIndex = 0
        grpBoxApps.TabStop = False
        grpBoxApps.Text = "Apps:"
        ' 
        ' rBtnAppsDark
        ' 
        rBtnAppsDark.AutoSize = True
        rBtnAppsDark.Font = New Font("Segoe UI", 8F)
        rBtnAppsDark.Location = New Point(63, 22)
        rBtnAppsDark.Name = "rBtnAppsDark"
        rBtnAppsDark.Size = New Size(49, 17)
        rBtnAppsDark.TabIndex = 1
        rBtnAppsDark.TabStop = True
        rBtnAppsDark.Text = "Dark"
        rBtnAppsDark.UseVisualStyleBackColor = True
        ' 
        ' rBtnAppsLight
        ' 
        rBtnAppsLight.AutoSize = True
        rBtnAppsLight.Font = New Font("Segoe UI", 8F)
        rBtnAppsLight.Location = New Point(6, 22)
        rBtnAppsLight.Name = "rBtnAppsLight"
        rBtnAppsLight.Size = New Size(51, 17)
        rBtnAppsLight.TabIndex = 0
        rBtnAppsLight.TabStop = True
        rBtnAppsLight.Text = "Light"
        rBtnAppsLight.UseVisualStyleBackColor = True
        ' 
        ' grpBoxSystem
        ' 
        grpBoxSystem.Controls.Add(rBtnSysDark)
        grpBoxSystem.Controls.Add(rBtnSysLight)
        grpBoxSystem.Location = New Point(10, 63)
        grpBoxSystem.Name = "grpBoxSystem"
        grpBoxSystem.Size = New Size(135, 43)
        grpBoxSystem.TabIndex = 1
        grpBoxSystem.TabStop = False
        grpBoxSystem.Text = "System:"
        ' 
        ' rBtnSysDark
        ' 
        rBtnSysDark.AutoSize = True
        rBtnSysDark.Font = New Font("Segoe UI", 8F)
        rBtnSysDark.Location = New Point(63, 20)
        rBtnSysDark.Name = "rBtnSysDark"
        rBtnSysDark.Size = New Size(49, 17)
        rBtnSysDark.TabIndex = 1
        rBtnSysDark.TabStop = True
        rBtnSysDark.Text = "Dark"
        rBtnSysDark.UseVisualStyleBackColor = True
        ' 
        ' rBtnSysLight
        ' 
        rBtnSysLight.AutoSize = True
        rBtnSysLight.Font = New Font("Segoe UI", 8F)
        rBtnSysLight.Location = New Point(6, 20)
        rBtnSysLight.Name = "rBtnSysLight"
        rBtnSysLight.Size = New Size(51, 17)
        rBtnSysLight.TabIndex = 0
        rBtnSysLight.TabStop = True
        rBtnSysLight.Text = "Light"
        rBtnSysLight.UseVisualStyleBackColor = True
        ' 
        ' frmTheme
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpBoxSystem)
        Controls.Add(grpBoxApps)
        Name = "frmTheme"
        Text = "frmTheme"
        grpBoxApps.ResumeLayout(False)
        grpBoxApps.PerformLayout()
        grpBoxSystem.ResumeLayout(False)
        grpBoxSystem.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpBoxApps As GroupBox
    Friend WithEvents rBtnAppsDark As RadioButton
    Friend WithEvents rBtnAppsLight As RadioButton
    Friend WithEvents grpBoxSystem As GroupBox
    Friend WithEvents rBtnSysDark As RadioButton
    Friend WithEvents rBtnSysLight As RadioButton
End Class
