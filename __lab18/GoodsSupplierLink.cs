namespace __lab18
{
    internal class GoodsSupplierLink
    {
        readonly int supplier_id;
        readonly int goods_id;
        int amount = 0;

        public int Supplier_id 
        { 
            get { return supplier_id; }
        }
        public int Goods_id
        {
            get { return goods_id; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public GoodsSupplierLink(int supplier_id, int goods_id) 
        { 
            this.supplier_id = supplier_id;
            this.goods_id = goods_id;
        }
        public override bool Equals(object obj)
        {
            GoodsSupplierLink p = obj as GoodsSupplierLink;
            return ((supplier_id == p.supplier_id) && goods_id == p.goods_id);
        }
    }
}
