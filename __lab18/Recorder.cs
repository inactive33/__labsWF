using System;
using System.Linq;
using System.Windows.Forms;

namespace __lab18
{
    internal class Recorder
    {
        readonly Goods[] list_Goods; // Массив товаров
        readonly  Supplier[] list_Suppliers; // Массив поставщиков
        readonly  GoodsSupplierRecords gsr_GSRecords; // Объект класса GSRecords
        int cur_suppliers; // текущ. количество поставщиков
        int cur_goods; // текущ. количество товаров
        readonly int max_suppliers; // макс количество поставщиков
        readonly int max_goods; // макс количество товаров

        public Goods[] List_Goods 
        { 
            get { return list_Goods; } 
        }
        public Supplier[] List_Suppliers
        {
            get { return List_Suppliers; }
        }
        public GoodsSupplierRecords Gsr_GSRecords { 
            get { return gsr_GSRecords; }
        }

        public Recorder(int max_gd, int max_sp, int max_records) { 
            list_Goods = new Goods[max_gd];
            list_Suppliers = new Supplier[max_sp];
            cur_suppliers = 0;
            this.max_suppliers = max_sp;
            cur_goods = 0;
            this.max_goods = max_gd;
            gsr_GSRecords = new GoodsSupplierRecords(max_records);
        }
        public bool AddSupplier(string name, int num_sp) 
        { 
            Supplier temp = new Supplier(name, num_sp);
            int i = 0;
            while (i < cur_suppliers && !temp.Equals(list_Suppliers[i]))
            {
                i++;
            }
            if (i != cur_suppliers || cur_suppliers == max_suppliers)
            {
                return false;
            }
            else { 
                list_Suppliers[cur_suppliers++]= temp;
                return true;
            }
        }
        public void Sp_Display(RichTextBox txtBox) 
        {
            for (int i = 0; i < cur_suppliers; i++) 
            {
                txtBox.Clear();
                txtBox.AppendText($"{list_Suppliers[i].Suppler_name}, {list_Suppliers[i].Suppler_id}");
            }
        }
        public bool AddGoods(string name, int num_gd) 
        { 
            Goods temp = new Goods(name, num_gd);
            int i = 0;
            while (i < cur_goods && !temp.Equals(list_Goods[i])) 
            {
                i++;
            }
            if (i != cur_goods || cur_goods == max_goods) return false;
            else { 
                list_Goods[cur_goods++]= temp;
                return true;
            }
        }
        public void Gc_Display(RichTextBox txtBox)
        {
            for (int i = 0; i < cur_suppliers; i++)
            {
                txtBox.Clear();
                txtBox.AppendText($"{list_Goods[i].Goods_name}, {list_Goods[i].Goods_id}");
            }
        }
        // Регистрация поставщика для товара
        public bool Recording(int SupplierID, int GoodsID)
        { 
            int i = 0, j = 0;
            while (i < cur_suppliers && SupplierID != list_Suppliers[i].Suppler_id) 
            {
                i++;
            }
            if (i == cur_suppliers) return false;
            else 
            {
                while (j < cur_goods && GoodsID != list_Goods[j].Goods_id) 
                { 
                    j++;
                }
                if (j == cur_goods) return false;
                else return gsr_GSRecords.AddRecord(SupplierID, GoodsID);
            }
        }
        // 1. Определить, кто из поставщиков поставляет товар с заданным номером и в каком количестве
        public void FindSuppliersByGoodsID(int goodsID, RichTextBox txtBox) 
        {
            txtBox.Clear();
            bool found = false;
            for (int i = 0; i < gsr_GSRecords.GoodsSupplier_Links.Length; i++) 
            {
                if (gsr_GSRecords.GoodsSupplier_Links[i] != null && gsr_GSRecords.GoodsSupplier_Links[i].Goods_id == goodsID) 
                { 
                    Supplier supplier = Array.Find(list_Suppliers, s => s.Suppler_id == gsr_GSRecords.GoodsSupplier_Links[i].Supplier_id);
                    if (supplier != null) 
                    {
                        txtBox.AppendText($"{supplier.Suppler_name} поставляет {gsr_GSRecords.GoodsSupplier_Links[i].Amount} единиц(ы).\n");
                        found = true;
                    }
                }
            }
            if (!found) {
                txtBox.AppendText("Поставщиков не найдено");
            }
        }
        // 2. Каков объем поставок заданного товара у различных поставщиков 
        public void FindTotalAmountByGoodsID(int goodsID, RichTextBox txtBox) 
        {
            txtBox.Clear();
            int totalAmount = 0;
            for (int i = 0; i < gsr_GSRecords.GoodsSupplier_Links.Length; i++) 
            {
                if (gsr_GSRecords.GoodsSupplier_Links[i] != null && gsr_GSRecords.GoodsSupplier_Links[i].Goods_id == goodsID) {
                    totalAmount += gsr_GSRecords.GoodsSupplier_Links[i].Amount;
                }
            }
            txtBox.AppendText($"Общий объем поставок: {totalAmount} единиц(ы)");
        }
        // 3. Перечислить имена поставщиков, которые могут поставить товар с указанным названием
        public void FindSuppliersByGoodsName(string goodsName, RichTextBox txtBox) {
            txtBox.Clear();
            Goods foundGoods = Array.Find(list_Goods, g => g.Goods_name == goodsName);
            if (foundGoods != null)
            {
                FindSuppliersByGoodsID(foundGoods.Goods_id, txtBox);
            }
            else 
            {
                txtBox.AppendText($"Товар с таким названием не найден");
            }
        }
    }
}