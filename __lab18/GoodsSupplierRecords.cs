using System.Windows.Forms;

namespace __lab18
{
    internal class GoodsSupplierRecords
    {
        readonly GoodsSupplierLink[] goodsSupplier_Links; // ссылка на массив объектов класса GSLink
        readonly int max_counts; // макс. кол-во регистраций
        int current_counts; // Текущее количество регистрации

        public GoodsSupplierLink[] GoodsSupplier_Links 
        {
            get { return goodsSupplier_Links; }
        }

        public GoodsSupplierRecords(int max_counts) 
        { 
            this.max_counts = max_counts;
            current_counts = 0;
            goodsSupplier_Links = new GoodsSupplierLink[max_counts];
        }

        // проверка, существует ли регистрация поставщика
        public bool GoodsSupplier_Find(int num_sp, int num_goods) 
        {
            GoodsSupplierLink temp = new GoodsSupplierLink (num_sp, num_goods);
            int i = 0;
            while ((i < current_counts) && !temp.Equals(goodsSupplier_Links[i]))
                i++;
            if (i == current_counts) return false;
            else return true;
        }

        public bool AddRecord(int num_sp, int num_gsr) 
        {
            if (GoodsSupplier_Find(num_sp, num_gsr) || current_counts == max_counts) return false;
            else
            {
                goodsSupplier_Links[current_counts++] = new GoodsSupplierLink(num_sp, num_gsr);
                return true;
            }
        }
        public void Display(RichTextBox txtBox) 
        {
            txtBox.Clear();
            for (int i = 0; i < current_counts; i++) 
            {
                txtBox.AppendText($"{goodsSupplier_Links[i].Supplier_id}, {goodsSupplier_Links[i].Goods_id}, {goodsSupplier_Links[i].Amount}");
            }
        }
    }
}
