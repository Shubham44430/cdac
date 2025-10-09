namespace Shop{

 class Item{

    private int id;
    private double costperunit;
    private int quantity;

    public int Id{
        get{return id;}
        set{id = value;}
    }

    public double Costperunit{
        get{return costperunit;}
        set{costperunit = value;}
    }

    public int Quantity{
        get{return quantity;}
        set{quantity = value;}
    }

    public Item( int i, double c, int q){

        id = i;
        costperunit = c;
        quantity = q;
    }

    public double SellingPrice(){
        price = quantity * costperunit;
        return price;
    }


} 
}