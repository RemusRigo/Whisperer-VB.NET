<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
	  components = New ComponentModel.Container()
	  Dim TreeNode1 As TreeNode = New TreeNode("AI")
	  Dim TreeNode2 As TreeNode = New TreeNode("Regional Settings")
	  Dim TreeNode3 As TreeNode = New TreeNode("Start Menu")
	  Dim TreeNode4 As TreeNode = New TreeNode("TaskBar")
	  Dim TreeNode5 As TreeNode = New TreeNode("Theme")
	  Dim TreeNode6 As TreeNode = New TreeNode("Hyper-V")
	  Dim TreeNode7 As TreeNode = New TreeNode("Virtualization", New TreeNode() {TreeNode6})
	  Dim TreeNode8 As TreeNode = New TreeNode("Windows Explorer")
	  Dim TreeNode9 As TreeNode = New TreeNode("Windows Search")
	  Dim TreeNode10 As TreeNode = New TreeNode("Microsoft Windows", New TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode7, TreeNode8, TreeNode9})
	  Dim TreeNode11 As TreeNode = New TreeNode("Google Chrome")
	  Dim TreeNode12 As TreeNode = New TreeNode("Mozilla Firefox")
	  Dim TreeNode13 As TreeNode = New TreeNode("Microsoft Edge")
	  Dim TreeNode14 As TreeNode = New TreeNode("Opera")
	  Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
	  scMain = New SplitContainer()
	  tvItems = New TreeView()
	  imgList = New ImageList(components)
	  StatusStrip = New StatusStrip()
	  ToolStripStatusLabel1 = New ToolStripStatusLabel()
	  CType(scMain, ComponentModel.ISupportInitialize).BeginInit()
	  scMain.Panel1.SuspendLayout()
	  scMain.SuspendLayout()
	  StatusStrip.SuspendLayout()
	  SuspendLayout()
	  ' 
	  ' scMain
	  ' 
	  scMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
	  scMain.FixedPanel = FixedPanel.Panel1
	  scMain.Location = New Point(0, 0)
	  scMain.Margin = New Padding(4, 3, 4, 3)
	  scMain.Name = "scMain"
	  ' 
	  ' scMain.Panel1
	  ' 
	  scMain.Panel1.AccessibleName = ""
	  scMain.Panel1.Controls.Add(tvItems)
	  scMain.Size = New Size(933, 494)
	  scMain.SplitterDistance = 273
	  scMain.SplitterWidth = 5
	  scMain.TabIndex = 0
	  ' 
	  ' tvItems
	  ' 
	  tvItems.Dock = DockStyle.Fill
	  tvItems.ImageIndex = 0
	  tvItems.ImageList = imgList
	  tvItems.Location = New Point(0, 0)
	  tvItems.Margin = New Padding(4, 3, 4, 3)
	  tvItems.Name = "tvItems"
	  TreeNode1.Name = "Node9"
	  TreeNode1.Text = "AI"
	  TreeNode2.Name = "Node11"
	  TreeNode2.Text = "Regional Settings"
	  TreeNode3.Name = "Node1"
	  TreeNode3.Text = "Start Menu"
	  TreeNode4.Name = "Node2"
	  TreeNode4.Text = "TaskBar"
	  TreeNode5.Name = "Node10"
	  TreeNode5.Text = "Theme"
	  TreeNode6.ImageKey = "HyperV"
	  TreeNode6.Name = "Node8"
	  TreeNode6.Text = "Hyper-V"
	  TreeNode7.Name = "Node7"
	  TreeNode7.Text = "Virtualization"
	  TreeNode8.Name = "Node0"
	  TreeNode8.Text = "Windows Explorer"
	  TreeNode9.Name = "Node3"
	  TreeNode9.Text = "Windows Search"
	  TreeNode10.Name = "Node0"
	  TreeNode10.Text = "Microsoft Windows"
	  TreeNode11.Name = "Node4"
	  TreeNode11.Text = "Google Chrome"
	  TreeNode12.Name = "Node6"
	  TreeNode12.Text = "Mozilla Firefox"
	  TreeNode13.Name = "Node12"
	  TreeNode13.Text = "Microsoft Edge"
	  TreeNode14.Name = "Node5"
	  TreeNode14.Text = "Opera"
	  tvItems.Nodes.AddRange(New TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
	  tvItems.SelectedImageIndex = 0
	  tvItems.Size = New Size(273, 494)
	  tvItems.TabIndex = 0
	  ' 
	  ' imgList
	  ' 
	  imgList.ColorDepth = ColorDepth.Depth32Bit
	  imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), ImageListStreamer)
	  imgList.TransparentColor = Color.Transparent
	  imgList.Images.SetKeyName(0, "empty.ico")
	  imgList.Images.SetKeyName(1, "HyperV")
	  ' 
	  ' StatusStrip
	  ' 
	  StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
	  StatusStrip.Location = New Point(0, 497)
	  StatusStrip.Name = "StatusStrip"
	  StatusStrip.Size = New Size(933, 22)
	  StatusStrip.TabIndex = 1
	  StatusStrip.Text = "StatusStrip1"
	  ' 
	  ' ToolStripStatusLabel1
	  ' 
	  ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
	  ToolStripStatusLabel1.Size = New Size(120, 17)
	  ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
	  ' 
	  ' frmMain
	  ' 
	  AutoScaleDimensions = New SizeF(7F, 15F)
	  AutoScaleMode = AutoScaleMode.Font
	  ClientSize = New Size(933, 519)
	  Controls.Add(StatusStrip)
	  Controls.Add(scMain)
	  Margin = New Padding(4, 3, 4, 3)
	  Name = "frmMain"
	  Text = "Whisperer"
	  scMain.Panel1.ResumeLayout(False)
	  CType(scMain, ComponentModel.ISupportInitialize).EndInit()
	  scMain.ResumeLayout(False)
	  StatusStrip.ResumeLayout(False)
	  StatusStrip.PerformLayout()
	  ResumeLayout(False)
	  PerformLayout()

   End Sub

   Friend WithEvents scMain As SplitContainer
	Friend WithEvents tvItems As TreeView
    Friend WithEvents imgList As ImageList
   Friend WithEvents StatusStrip As StatusStrip
   Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
