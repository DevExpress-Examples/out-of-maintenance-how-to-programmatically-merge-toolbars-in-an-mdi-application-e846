using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MergeMdiToolbars
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControl1;
		private DevExpress.XtraBars.BarDockControl barDockControl2;
		private DevExpress.XtraBars.BarDockControl barDockControl3;
		private DevExpress.XtraBars.BarDockControl barDockControl4;
		private DevExpress.XtraBars.BarSubItem BarSubItem1;
		private DevExpress.XtraBars.BarSubItem BarSubItem2;
		private DevExpress.XtraBars.BarSubItem BarSubItem3;
		private DevExpress.XtraBars.BarButtonItem BarButtonItem1;
		private DevExpress.XtraBars.BarButtonItem BarButtonItem2;
		private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private IContainer components;

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.BarSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.BarSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BarSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BarButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarSubItem2,
            this.BarSubItem1,
            this.BarSubItem3,
            this.BarButtonItem1,
            this.BarButtonItem2});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(49, 167);
            this.bar1.FloatSize = new System.Drawing.Size(29, 25);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarSubItem3)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 1";
            // 
            // BarSubItem2
            // 
            this.BarSubItem2.Caption = "File";
            this.BarSubItem2.Id = 1;
            this.BarSubItem2.Name = "BarSubItem2";
            // 
            // BarSubItem1
            // 
            this.BarSubItem1.Caption = "Menu";
            this.BarSubItem1.Id = 0;
            this.BarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButtonItem1, true)});
            this.BarSubItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.BarSubItem1.Name = "BarSubItem1";
            // 
            // BarButtonItem1
            // 
            this.BarButtonItem1.Caption = "Close";
            this.BarButtonItem1.Id = 3;
            this.BarButtonItem1.Name = "BarButtonItem1";
            // 
            // BarSubItem3
            // 
            this.BarSubItem3.Caption = "Help";
            this.BarSubItem3.Id = 2;
            this.BarSubItem3.Name = "BarSubItem3";
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(123, 212);
            this.bar2.FloatSize = new System.Drawing.Size(29, 25);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButtonItem2)});
            this.bar2.Text = "Custom 2";
            // 
            // BarButtonItem2
            // 
            this.BarButtonItem2.Caption = "Toolbar";
            this.BarButtonItem2.Id = 4;
            this.BarButtonItem2.Name = "BarButtonItem2";
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(276, 239);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Form2_Load(object sender, System.EventArgs e) {
		
		}
	}
}
