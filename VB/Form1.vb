Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraBars

Namespace MergeMdiToolbars
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private BarSubItem1 As DevExpress.XtraBars.BarSubItem
		Private WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
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
			Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
			Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControl1)
			Me.barManager1.DockControls.Add(Me.barDockControl2)
			Me.barManager1.DockControls.Add(Me.barDockControl3)
			Me.barManager1.DockControls.Add(Me.barDockControl4)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.BarSubItem1, Me.BarStaticItem1, Me.BarButtonItem1, Me.barButtonItem2})
			Me.barManager1.MainMenu = Me.bar1
			Me.barManager1.MaxItemId = 4
			Me.barManager1.StatusBar = Me.bar2
'			Me.barManager1.UnMerge += New DevExpress.XtraBars.BarManagerMergeEventHandler(Me.barManager1_UnMerge);
'			Me.barManager1.Merge += New DevExpress.XtraBars.BarManagerMergeEventHandler(Me.barManager1_Merge);
			' 
			' bar1
			' 
			Me.bar1.BarName = "Main menu"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.FloatLocation = New System.Drawing.Point(52, 165)
			Me.bar1.FloatSize = New System.Drawing.Size(29, 25)
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
			Me.bar1.OptionsBar.MultiLine = True
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "Main menu"
			' 
			' BarSubItem1
			' 
			Me.BarSubItem1.Caption = "Menu"
			Me.BarSubItem1.Id = 1
			Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
			Me.BarSubItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
			Me.BarSubItem1.Name = "BarSubItem1"
			' 
			' BarButtonItem1
			' 
			Me.BarButtonItem1.Caption = "Open"
			Me.BarButtonItem1.Id = 2
			Me.BarButtonItem1.Name = "BarButtonItem1"
'			Me.BarButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.BarButtonItem1_ItemClick);
			' 
			' bar2
			' 
			Me.bar2.BarName = "Status bar"
			Me.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar2.FloatLocation = New System.Drawing.Point(65, 425)
			Me.bar2.FloatSize = New System.Drawing.Size(29, 25)
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1)})
			Me.bar2.OptionsBar.AllowQuickCustomization = False
			Me.bar2.OptionsBar.DrawDragBorder = False
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Status bar"
			' 
			' BarStaticItem1
			' 
			Me.BarStaticItem1.Caption = "Status"
			Me.BarStaticItem1.Id = 0
			Me.BarStaticItem1.Name = "BarStaticItem1"
			Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' bar3
			' 
			Me.bar3.BarName = "Custom 3"
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 1
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar3.FloatLocation = New System.Drawing.Point(335, 269)
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
			Me.bar3.Text = "Custom 3"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Main Toolbar"
			Me.barButtonItem2.Id = 3
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(471, 356)
			Me.Controls.Add(Me.barDockControl3)
			Me.Controls.Add(Me.barDockControl4)
			Me.Controls.Add(Me.barDockControl2)
			Me.Controls.Add(Me.barDockControl1)
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
			Dim form As Form = New Form2()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub barManager1_Merge(ByVal sender As Object, ByVal e As DevExpress.XtraBars.BarManagerMergeEventArgs) Handles barManager1.Merge
			If TypeOf e.ChildManager.Form Is Form2 Then
				Dim newBar As New Bar(barManager1)
				newBar.BarName = "DynamicBar"
				newBar.OptionsBar.Hidden = True
				Dim sourceBar As Bar = e.ChildManager.Bars("Custom 2")

				newBar.DockStyle = BarDockStyle.Top
				barManager1.Bars.Add(newBar)
				newBar.Merge(sourceBar)
				sourceBar.Visible = False
			End If
		End Sub

		Private Sub barManager1_UnMerge(ByVal sender As Object, ByVal e As DevExpress.XtraBars.BarManagerMergeEventArgs) Handles barManager1.UnMerge
			Dim newBar As Bar = barManager1.Bars("DynamicBar")
			If newBar IsNot Nothing Then
				newBar.Dispose()
			End If
		End Sub
	End Class
End Namespace
