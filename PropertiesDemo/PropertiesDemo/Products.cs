using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Products
    {
        static int productid;
        static Products()
        {
            productid = 0;
        }

        public Products()
        {
            productid = productid + 1;
            ProductId =productid;
        
        }
        public Products(int prodprice,string prodname)
        {
            ProductPrice=prodprice;
            ProductName=prodname;   
            productid=productid+1;  
            ProductId=productid;

        }

        public Products(int prodprice,string prodname,string uom):this(prodprice,prodname) 
        {
            UOM = uom;
        }

        public string UOM { get; set; }
        public int ProductPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
    }
}
