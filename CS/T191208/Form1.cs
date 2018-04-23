using System;

namespace T191208
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.barManager1.CreateCustomizationForm += barManager1_CreateCustomizationForm;
		}

		private void barManager1_CreateCustomizationForm(object sender, DevExpress.XtraBars.CreateCustomizationFormEventArgs e)
		{
			e.CustomizationForm = new MyForm(new CustomCustomizationControl(), this.LookAndFeel);
		}

	}
}
