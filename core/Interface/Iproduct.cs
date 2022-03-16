public interface Iproduct
{
    bool AddProduct(Mproduct pr);

    bool UpdateProduct(Mproduct pr);

    bool DleteProduct(int id);

    List<Mproduct> showlist();

    Mproduct showdeails(int id);

    int countproduct(int id);


}
