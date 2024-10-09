using System.Windows.Forms;

namespace __lab18
{
    internal class Goods
    {
        readonly string goods_name;
        readonly int goods_id;
        public string Goods_name
        {
            get { return goods_name; }
        }
        public int Goods_id 
        { 
            get { return goods_id; }
        }
        public Goods(string goods_name, int goods_id) 
        { 
            this.goods_name = goods_name;
            this.goods_id = goods_id;
        }
        public void Display(RichTextBox txtBox) 
        {
            txtBox.Clear();
            txtBox.AppendText($"Товар goods_name = {goods_name}, goods_id = {goods_id}");
        }
        public override bool Equals(object obj)
        {
            Goods p = obj as Goods;
            return ((goods_name == p.goods_name) && (goods_id == p.goods_id));
        }
    }
}
