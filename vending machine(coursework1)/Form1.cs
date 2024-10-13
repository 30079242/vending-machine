namespace vending_machine_coursework1_
{

    public partial class MainForm : Form
    {
        double TotalPurchase = 0.0;
        string itemName;
        public MainForm()
        {
            InitializeComponent();
        }


        private void GenericBtn_Click(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            textBoxBasket.Text += Environment.NewLine;
            int quantity = 1;
            //BasketList.Items.Add(ClickedButton.Name);

            if (ClickedButton != null)
            {
                switch (ClickedButton.Name)
                {
                    case "MonsterBtn":
                       
                        textBoxBasket.Text += quantity + "x Energy Drink:    2.30£";
                        TotalPurchase += 2.30;
                        itemName = "Energy drink";
                        

                        break;
                    case "NoodlesBtn":
                        textBoxBasket.Text += quantity + "x Noodles:            1.20£";
                        TotalPurchase += 1.20;
                        itemName = "Noodles";
                       
                        break;
                    case "CrispsBtn":
                        textBoxBasket.Text += quantity + "x Crisps:               0.89£";
                        TotalPurchase += 0.89;
                        itemName = "Crisps";
                      
                        break;
                    case "TwixBtn":
                        textBoxBasket.Text += quantity + "x Twix Bar:          1.50£";
                        TotalPurchase += 1.50;
                        itemName = "Twisx";
                        break;

                }

                if (textBoxBasket.Text.Contains(itemName))
                {
                    //is this shown there?
                    quantity++;
                }

                textBoxTotal.Text = "Total: " + "   " + TotalPurchase.ToString("F");


            }
        }
    }
}
