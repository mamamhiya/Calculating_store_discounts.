namespace Calculating_store_discounts_
{
    public partial class โปรแกรมคำนวนส่วนลดของร้านค้า : Form
    {
        public โปรแกรมคำนวนส่วนลดของร้านค้า()
        {
            InitializeComponent();
        }

        public class StoreDiscountCalculator
        {
            public double TotalAmount { get; set; }
            public bool Member { get; set; }
            public string DisRank { get; set; }

            public StoreDiscountCalculator(double totalAmount, bool member)
                {
                    TotalAmount = totalAmount;
                    Member = member;
                }
            public int DisPercent()
            {
                int discountPercent = 0;

                // ตรวจสอบเงื่อนไขตามยอดซื้อ
                if (TotalAmount >= 5000)
                {
                    discountPercent = 20;
                    DisRank = "Platinum";
                }
                else if (TotalAmount >= 3000)
                {
                    discountPercent = 15;
                    DisRank = "Gold";
                }
                else if (TotalAmount >= 1000)
                {
                    discountPercent = 10;
                    DisRank = "Silver";
                }
                else if (TotalAmount >= 500)
                {
                    discountPercent = 5;
                    DisRank = "Bronze";
                }

                if (Member && TotalAmount >= 500)
                {
                    discountPercent += 5;
                }

                return discountPercent;
            }

            public double CalculateDiscountAmount()
            {
                int discountPercent = DisPercent();
                return (TotalAmount * discountPercent) / 100;
            }
            public double CalculateFinalAmount()
            {
                double discountAmount = CalculateDiscountAmount();
                return TotalAmount - discountAmount;
            }

            public void advice()
            {
                if (TotalAmount < 500)MessageBox.Show($"ซื้อเพิ่มอีก {500-TotalAmount} เพื่อรับส่วนลด 5%", "ห้ามพลาด");
                if(DisRank == "Bronze")MessageBox.Show($"ซื้อเพิ่มอีก {1000-TotalAmount} เพื่อรับส่วนลด 10%","ห้ามพลาด");
                else if(DisRank == "Silver")MessageBox.Show($"ซื้อเพิ่มอีก {3000-TotalAmount} เพื่อรับส่วนลด 15%", "ห้ามพลาด");
                else if(DisRank == "Gold")MessageBox.Show($"ซื้อเพิ่มอีก {5000-TotalAmount} เพื่อรับส่วนลด 20%", "ห้ามพลาด");
            }

            public void getReceipt(TextBox tb_receipt)
            {
                int discountPercent = DisPercent();
                double discountAmount = CalculateDiscountAmount();
                double finalAmount = CalculateFinalAmount();
                tb_receipt.Clear();
                tb_receipt.AppendText($"ยอดซื้อ: {TotalAmount:F2} บาท" + Environment.NewLine);
                if (TotalAmount >= 500)
                {
                    tb_receipt.AppendText($"ได้รับส่วนลดระดับ: {DisRank} {discountPercent}%" + Environment.NewLine);
                    if (Member)tb_receipt.AppendText("ได้รับส่วนลดพิเศษสมาชิก +5%"+ Environment.NewLine);
                    tb_receipt.AppendText($"จำนวนส่วนลด: {discountAmount:F2} บาท"+Environment.NewLine);
                }
                tb_receipt.AppendText($"ราคาที่ต้องจ่าย: {finalAmount:F2} บาท");
                advice();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double total = double.Parse(tb_total.Text);
            bool member = memY.Checked;
            StoreDiscountCalculator cal = new StoreDiscountCalculator(total, member);
            cal.getReceipt(tb_receipt);
        }
    }
}
