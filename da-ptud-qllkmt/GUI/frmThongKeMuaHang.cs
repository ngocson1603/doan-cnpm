using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmThongKeMuaHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.QL_CUAHANGLINHKIENMAYTINH);
        public frmThongKeMuaHang()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            chart1.Series["DoanhThu1"].XValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)ChartValueType.DateTime;
            chart1.Series["DoanhThu1"].YValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)ChartValueType.Int32;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select TenSanPham as Ten,sum(soluong*ChiTietHoaDon.giaban) as SL from SanPham,ChiTietHoaDon,HoaDon,KhachHang where ChiTietHoaDon.MaSanPham = SanPham.MaSanPham and HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon and KhachHang.MaKH = HoaDon.MaKH and Month(NgayLapHoaDon) = '" + DateTime.Now.Month.ToString() + "'and Gmail = '" + frmDN.taikhoan + "' group by TenSanPham", conn);

            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["DoanhThu1"].XValueMember = "Ten";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["DoanhThu1"].YValueMembers = "SL";
            chart1.Series["DoanhThu1"].IsValueShownAsLabel = true;
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            chart2.Series["VNĐ"].XValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)ChartValueType.DateTime;
            chart2.Series["VNĐ"].YValueType = (System.Windows.Forms.DataVisualization.Charting.ChartValueType)ChartValueType.Int32;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select TenSanPham as Ten,sum(soluong*ChiTietHoaDon.giaban) as SL from SanPham,ChiTietHoaDon,HoaDon,KhachHang where ChiTietHoaDon.MaSanPham = SanPham.MaSanPham and HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon and KhachHang.MaKH = HoaDon.MaKH and Gmail = '" + frmDN.taikhoan + "' group by TenSanPham", conn);

            adapt.Fill(ds);
            chart2.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart2.Series["VNĐ"].XValueMember = "Ten";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart2.Series["VNĐ"].YValueMembers = "SL";
            chart2.Series["VNĐ"].IsValueShownAsLabel = true;
            conn.Close();
        }
    }
}
