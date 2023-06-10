using DoAnPBL3.BLL;
using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace DoAnPBL3
{
    public partial class ThongKeKhachHang : Form
    {
        public ThongKeKhachHang()
        {
            InitializeComponent();
            SetCBB();
            cbbTKBy.SelectedIndex = 0;
        }

        public void SetCBB()
        {
            cbbTKBy.Items.AddRange(new object[]
            {
                "Theo ngày", "Theo tháng", "Theo năm"
            });
        }


        public void LoadChartKH(DateTime dayStart,DateTime dayEnd,string data)
        {
            ChartKH.DataSource = QLThongKeBLL.Instance.KhachHang(dayStart, dayEnd, data);
            ChartKH.ChartAreas[0].AxisY.Title = "Số người";
            ChartKH.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            ChartKH.ChartAreas[0].AxisX.Title = "Ngày đến nhà hàng";
            ChartKH.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            ChartKH.Series[0].XValueMember = "ngayDen";
            ChartKH.Series[0].YValueMembers = "tongSoNguoi";
            ChartKH.ChartAreas[0].AxisY.LabelStyle.Format = "#,###";

            if (data == "Theo ngày")
            {
                ChartKH.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                ChartKH.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            }
            else if (data == "Theo tháng")
            {
                ChartKH.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                ChartKH.ChartAreas[0].AxisX.LabelStyle.Format = "MM/yyyy";
            }
            else
            {
                ChartKH.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                ChartKH.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";
            }
            ChartKH.DataBind();
        }    

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;
            string txt = cbbTKBy.SelectedItem.ToString();
            startDate = dtpkStart.Value.Date;
            endDate = dtpkEnd.Value.Date;
            if (QLThongKeBLL.Instance.Check(startDate, endDate) == true)
            {
                dtgvData.DataSource = QLThongKeBLL.Instance.KhachHang(startDate, endDate, txt);
                LoadChartKH(startDate,endDate,txt);
            }
            else
            {
                MessageBox.Show("Chọn ngày bắt đầu và ngày kết thúc không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
