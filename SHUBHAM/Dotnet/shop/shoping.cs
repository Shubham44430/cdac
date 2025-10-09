namespace shop
{


    class ShoppingCart : Item
    {

        public ShoppingCart(int i, double c, int q) : base(i, c, q)
        {
        }

        public override double SellingPrice()
        {
            double price = base.SellingPrice();
            if (price > 1000)
                return price * 0.90;
            else if (price > 500)
                return price * 0.95;
            else
                return price;
        }

    }
}