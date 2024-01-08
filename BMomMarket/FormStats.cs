using BMomMarket.Model;
using Microsoft.EntityFrameworkCore;
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

namespace BMomMarket
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
            LoadChart();
        }
        private void LoadChart()
        {
            Controls.Clear();
            chart.Series.Clear();
            var db = new BmomMarketContext();
            //Chart chart = new Chart();
            //chart.Dock = DockStyle.Fill;
            var result = db.Orders
                .GroupBy(o => EF.Property<DateTime>(o, "OrderDate").Date)
                .Select(g => new
                {
                    OrderDay = g.Key,
                    DailyRevenue = g.Sum(o => o.TotalPrice)
                })
                .ToList();

            // Tạo loại biểu đồ
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in result)
            {
                // Thêm dữ liệu vào loại biểu đồ
                series.Points.AddXY(item.OrderDay, item.DailyRevenue);
            }

            // Thêm loại biểu đồ vào biểu đồ
            chart.Series.Add(series);
            chart.Invalidate();

            // Thêm biểu đồ vào form
            Controls.Add(chart);
        }
    }
}
