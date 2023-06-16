using DevExpress.DataAccess.Sql;
using System;

namespace XtraReportApp {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            reportDesigner1.AddService(typeof(IDBCommandInterceptor), new NolockInterceptor());
        }
        private void Form1_Load(object sender, EventArgs e) {
            reportDesigner1.OpenReport(new XtraReport1());
        }
    }
}
