using System.Windows.Forms;

namespace __lab18
{
    internal class Supplier
    {
        readonly string s_name;
        readonly int s_id;

        public string Suppler_name
        {
            get { return s_name; }
        }
        public int Suppler_id
        {
            get { return s_id; }
        }
        public Supplier(string s_name, int s_id) { 
            this.s_name = s_name;
            this.s_id = s_id;
        }
        public void Display(RichTextBox txtBox) {
            txtBox.AppendText($"Поставщик: s_name = {s_name}, s_id = {s_id}");
        }
        // Сравнение двух объектов класса Supplier на равенство
        public override bool Equals(object obj)
        {
            Supplier p = obj as Supplier;
            return ((s_name == p.s_name )&&(s_id == p.s_id));
        }
    }
}
