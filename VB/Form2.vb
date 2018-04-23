Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace MergeMdiToolbars
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class Form2
		Inherits System.Windows.Forms.Form
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private BarSubItem1 As DevExpress.XtraBars.BarSubItem
		Private BarSubItem2 As DevExpress.XtraBars.BarSubItem
		Private BarSubItem3 As DevExpress.XtraBars.BarSubItem
		Private BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
			Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2})
			Me.barManager1.DockControls.Add(Me.barDockControl1)
			Me.barManager1.DockControls.Add(Me.barDockControl2)
			Me.barManager1.DockControls.Add(Me.barDockControl3)
			Me.barManager1.DockControls.Add(Me.barDockControl4)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.BarSubItem2, Me.BarSubItem1, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2})
			Me.barManager1.MainMenu = Me.bar1
			Me.barManager1.MaxItemId = 5
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 1"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.FloatLocation = New System.Drawing.Point(49, 167)
			Me.bar1.FloatSize = New System.Drawing.Size(29, 25)
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3)})
			Me.bar1.OptionsBar.MultiLine = True
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "Custom 1"
			' 
			' BarSubItem2
			' 
			Me.BarSubItem2.Caption = "File"
			Me.BarSubItem2.Id = 1
			Me.BarSubItem2.Name = "BarSubItem2"
			' 
			' BarSubItem1
			' 
			Me.BarSubItem1.Caption = "Menu"
			Me.BarSubItem1.Id = 0
			Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True)})
			Me.BarSubItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
			Me.BarSubItem1.Name = "BarSubItem1"
			' 
			' BarButtonItem1
			' 
			Me.BarButtonItem1.Caption = "Close"
			Me.BarButtonItem1.Id = 3
			Me.BarButtonItem1.Name = "BarButtonItem1"
			' 
			' BarSubItem3
			' 
			Me.BarSubItem3.Caption = "Help"
			Me.BarSubItem3.Id = 2
			Me.BarSubItem3.Name = "BarSubItem3"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Custom 2"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.FloatLocation = New System.Drawing.Point(123, 212)
			Me.bar2.FloatSize = New System.Drawing.Size(29, 25)
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
			Me.bar2.Text = "Custom 2"
			' 
			' BarButtonItem2
			' 
			Me.BarButtonItem2.Caption = "Toolbar"
			Me.BarButtonItem2.Id = 4
			Me.BarButtonItem2.Name = "BarButtonItem2"
			' 
			' Form2
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(276, 239)
			Me.Controls.Add(Me.barDockControl3)
			Me.Controls.Add(Me.barDockControl4)
			Me.Controls.Add(Me.barDockControl2)
			Me.Controls.Add(Me.barDockControl1)
			Me.Name = "Form2"
			Me.Text = "Form2"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
