public class Rproduct : Iproduct
{

         private readonly Context context;
         public Rproduct(Context _context)
         {
             context=_context;
         }


  
    public bool AddProduct(Mproduct pr)
    {
        Product p=new Product()
        {
            Name=pr.Name,
            price=pr.price
        };

        context.products.Add(p);
        context.SaveChanges();
        return true;
    }

    public int countproduct(int id)
    {
        throw new NotImplementedException();
    }

    public bool DleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Mproduct showdeails(int id)
    {
        throw new NotImplementedException();
    }

    public List<Mproduct> showlist()
    {
        throw new NotImplementedException();
    }

    public bool UpdateProduct(Mproduct pr)
    {
        throw new NotImplementedException();
    }
}