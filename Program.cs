using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqlearning
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "Hard Disk", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 1000 });
            productList.Add(new ProductStore { productName = "SSD Disk", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "Processor", productPrice = 7680 });
            productList.Add(new ProductStore { productName = "Bluetooth", productPrice = 540 });
            productList.Add(new ProductStore { productName = "Keyboard & Mouse", productPrice = 1130 });
            #region SELECTING BY CONDITION 

            //var result = productList.Where(P => P.productName ); SELECT ALL var result = productList.Select(P =>P);
            //result.ToList().ForEach(P => Console.WriteLine("PRODUCT NAME {0},PRODUCXT PRICE {1}", P.productName, P.productPrice));
            //Console.ReadKey();
            //Console.ReadKey();
            #endregion
            #region ORDER
            // var RESULT = productList.OrderBy(P => P.productName );
            //// var RESULT = productList.OrderByDescending(P => P.productName );
            // RESULT.ToList().ForEach(P => Console.WriteLine("PRODUCT NAME ={0},PRODUCT PRRICE {1}", P.productName, P.productPrice));
            // Console.ReadKey();
            #endregion
            #region THEN BY  ADVABCE FITHER FOR ANOTHER ROW 
            var result = productList.OrderBy(p => p.productName).ThenBy(p => p.productPrice);
         //   var result = productList.OrderBy(p => p.productName).ThenByDescending(p => p.productPrice);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
            #endregion
        }
        #region REVERSE
        //  var result = productList.OrderBy(p => p.productPrice).Reverse();
        #endregion
    }
}
