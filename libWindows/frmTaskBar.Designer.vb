<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskBar
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
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        chkBoxWidgets = New CheckBox()
        lblSearchBox = New Label()
        cbSearchBox = New ComboBox()
        TabPage2 = New TabPage()
        chkBoxWidgetsLM = New CheckBox()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Dock = DockStyle.Fill
        TabControl.Location = New Point(0, 0)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(800, 450)
        TabControl.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(chkBoxWidgets)
        TabPage1.Controls.Add(lblSearchBox)
        TabPage1.Controls.Add(cbSearchBox)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 422)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Current User"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' chkBoxWidgets
        ' 
        chkBoxWidgets.AutoSize = True
        chkBoxWidgets.Location = New Point(8, 32)
        chkBoxWidgets.Name = "chkBoxWidgets"
        chkBoxWidgets.Size = New Size(101, 19)
        chkBoxWidgets.TabIndex = 5
        chkBoxWidgets.Text = "Show Widgets"
        chkBoxWidgets.ThreeState = True
        chkBoxWidgets.UseVisualStyleBackColor = True
        ' 
        ' lblSearchBox
        ' 
        lblSearchBox.AutoSize = True
        lblSearchBox.Location = New Point(6, 6)
        lblSearchBox.Name = "lblSearchBox"
        lblSearchBox.Size = New Size(61, 15)
        lblSearchBox.TabIndex = 4
        lblSearchBox.Text = "SearchBox"
        ' 
        ' cbSearchBox
        ' 
        cbSearchBox.DropDownStyle = ComboBoxStyle.DropDownList
        cbSearchBox.FormattingEnabled = True
        cbSearchBox.Location = New Point(73, 3)
        cbSearchBox.Name = "cbSearchBox"
        cbSearchBox.Size = New Size(121, 23)
        cbSearchBox.TabIndex = 3
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(chkBoxWidgetsLM)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(792, 422)
        TabPage2.TabIndex = 1
        TabPage2.Text = "All Users"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' chkBoxWidgetsLM
        ' 
        chkBoxWidgetsLM.AutoSize = True
        chkBoxWidgetsLM.Location = New Point(8, 6)
        chkBoxWidgetsLM.Name = "chkBoxWidgetsLM"
        chkBoxWidgetsLM.Size = New Size(110, 19)
        chkBoxWidgetsLM.TabIndex = 6
        chkBoxWidgetsLM.Text = "Disable Widgets"
        chkBoxWidgetsLM.ThreeState = True
        chkBoxWidgetsLM.UseVisualStyleBackColor = True
        ' 
        ' frmTaskBar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl)
        Name = "frmTaskBar"
        Text = "TaskBar"
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chkBoxWidgets As CheckBox
    Friend WithEvents lblSearchBox As Label
    Friend WithEvents cbSearchBox As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chkBoxWidgetsLM As CheckBox
End Class
