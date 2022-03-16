using Microsoft.AspNetCore.Mvc;

public class Home:Controller
 {
     private readonly Iproduct p;
     public Home(Iproduct p)
     {
         this.p=p;
     }
     
    public IActionResult index()
    {
        
        return View();
    }

    public IActionResult add(Mproduct pr)
    {
        p.AddProduct(pr);
        return RedirectToAction("index");
    }
    
    
 }