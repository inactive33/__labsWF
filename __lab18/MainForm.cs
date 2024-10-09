using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __lab18
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeRecorder();
        }

        private Recorder recorder; // Поле для хранения экземпляра Recorder

        private void InitializeRecorder()
        {
            recorder = new Recorder(3, 3, 5);

            // Добавляем данные в массив поставщиков
            recorder.AddSupplier("Ivanov", 5);
            recorder.AddSupplier("Petrov", 6);
            recorder.AddSupplier("Sidorov", 51);
            recorder.AddSupplier("Kovalev", 61);

            // Добавляем данные в массив товаров
            recorder.AddGoods("Apple", 50);
            recorder.AddGoods("Grushi", 60);
            recorder.AddGoods("Ananasi", 70);
            recorder.AddGoods("Banana", 80);

            // Регистрируем поставщиков (поставщик/товар)
            recorder.Recording(5, 50);
            recorder.Recording(6, 60);
            recorder.Recording(51, 60);

            // Пример: добавление количества к каждому товару
            recorder.Gsr_GSRecords.GoodsSupplier_Links[0].Amount = 100;
            recorder.Gsr_GSRecords.GoodsSupplier_Links[1].Amount = 200;
            recorder.Gsr_GSRecords.GoodsSupplier_Links[2].Amount = 300;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            recorder.Sp_Display(rTxtBox_DisplayOutput);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            recorder.Gc_Display(rTxtBox_DisplayOutput);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            recorder.FindSuppliersByGoodsID(60, rTxtBox_DisplayOutput);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            recorder.FindTotalAmountByGoodsID(60, rTxtBox_DisplayOutput);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            recorder.FindSuppliersByGoodsName("Apple", rTxtBox_DisplayOutput);
        }
    }
}
