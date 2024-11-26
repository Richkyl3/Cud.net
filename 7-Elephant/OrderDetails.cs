namespace _7_Elephant
{
    public class OrderDetails
    {
        public int product_id { get; set; }   // Product ID ที่เชื่อมโยงกับ Phone
        public int amount { get; set; }        // จำนวนสินค้าที่สั่ง
        public decimal sub_total { get; set; } // ราคารวมของสินค้าในรายการ
        public virtual Phone Phone { get; set; } // การเชื่อมโยงกับคลาส Phone
    }
}
