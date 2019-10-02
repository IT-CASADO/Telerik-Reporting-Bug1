namespace WebApplication1
{
	partial class Report1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for telerik Reporting designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
			this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
			this.detail = new Telerik.Reporting.DetailSection();
			this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
			this.textBox1 = new Telerik.Reporting.TextBox();
			this.textBox2 = new Telerik.Reporting.TextBox();
			this.textBox3 = new Telerik.Reporting.TextBox();
			this.objectDataSource1 = new Telerik.Reporting.ObjectDataSource();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// pageHeaderSection1
			// 
			this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2D);
			this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox3});
			this.pageHeaderSection1.Name = "pageHeaderSection1";
			// 
			// detail
			// 
			this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.7D);
			this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
			this.detail.Name = "detail";
			// 
			// pageFooterSection1
			// 
			this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5D);
			this.pageFooterSection1.Name = "pageFooterSection1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.5D), Telerik.Reporting.Drawing.Unit.Cm(0.4D));
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
			this.textBox1.Value = "= Fields.Type";
			// 
			// textBox2
			// 
			this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9D), Telerik.Reporting.Drawing.Unit.Cm(0.4D));
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.6D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
			this.textBox2.Value = "= Fields.Value";
			// 
			// textBox3
			// 
			this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.5D), Telerik.Reporting.Drawing.Unit.Cm(0.7D));
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
			this.textBox3.Value = "Claims of user";
			// 
			// objectDataSource1
			// 
			this.objectDataSource1.DataMember = "GetDataSource";
			this.objectDataSource1.DataSource = typeof(WebApplication1.Reports.Report1DataSource);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// Report1
			// 
			this.DataSource = this.objectDataSource1;
			this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
			this.Name = "Report1";
			this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
			styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
			styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
			this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
			this.Width = Telerik.Reporting.Drawing.Unit.Cm(17D);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
		private Telerik.Reporting.DetailSection detail;
		private Telerik.Reporting.PageFooterSection pageFooterSection1;
		private Telerik.Reporting.TextBox textBox1;
		private Telerik.Reporting.ObjectDataSource objectDataSource1;
		private Telerik.Reporting.TextBox textBox3;
		private Telerik.Reporting.TextBox textBox2;
	}
}