using DoAnPBL3.BLL;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace DoAnPBL3

{
    public partial class ThongKeDoanhThu : Form
    {
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            SetCBB();
            cbbNgaythongke.SelectedIndex = 0;
            dtmStartDate.Value = DateTime.Now;
            dtmEndDay.Value = DateTime.Now;
            
        }
        public void SetCBB()
        {
            cbbNgaythongke.Items.AddRange(new object[]
            {
                "Theo ngày", "Theo tháng", "Theo năm"
            });
        }

        public void Load(DateTime startDate,DateTime endDate,string txt)
        {
           
            lblKhachhang.Text = Convert.ToString(QLThongKeBLL.Instance.TongKhachhang(startDate,endDate,txt).ToString("#,###"));
            lblDoanhthu.Text = Convert.ToString(QLThongKeBLL.Instance.TongDoanhThu(startDate, endDate, txt).ToString("#,### VNĐ"));
            lblMonandadat.Text = Convert.ToString(QLThongKeBLL.Instance.Tongmonan(startDate, endDate, txt).ToString("#,###"));
            chartDoanhthu.DataSource = QLThongKeBLL.Instance.DoanhThu(startDate, endDate, txt);
            chartDoanhthu.Series[0].XValueMember = "ngaythanhtoan";
            chartDoanhthu.Series[0].YValueMembers = "tongtien";
            chartDoanhthu.ChartAreas[0].AxisY.LabelStyle.Format = "#,###";
            chartDoanhthu.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartDoanhthu.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 10, FontStyle.Bold);
            chartDoanhthu.ChartAreas[0].AxisX.Title = "Ngày thanh toán";
            chartDoanhthu.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 10, FontStyle.Bold);

            if (cbbNgaythongke.SelectedItem.ToString() == "Theo ngày")
            {
                chartDoanhthu.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                chartDoanhthu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
               
            }else if(cbbNgaythongke.SelectedItem.ToString() == "Theo tháng")
            {
                chartDoanhthu.ChartAreas[0].AxisX.LabelStyle.Format = "MM/yyyy";
                chartDoanhthu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            }
            else
            {
                chartDoanhthu.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";
                chartDoanhthu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
            }

            chartDoanhthu.DataBind();


            chartThucdon.DataSource = QLThongKeBLL.Instance.ThucDon(startDate, endDate, txt);
            chartThucdon.Series[0].XValueMember = "tenmonan";
            chartThucdon.Series[0].YValueMembers = "soluongmon";
            chartThucdon.DataBind();
        }

      

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtmStartDate.Value.Date;
            DateTime endDate = dtmEndDay.Value.Date;
            string txt = cbbNgaythongke.SelectedItem.ToString();
            if (QLThongKeBLL.Instance.Check(startDate, endDate) == true)
            {
                Load(startDate,endDate,txt);
            }
            else
            {
                MessageBox.Show("Chọn ngày bắt đầu và kết thúc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
