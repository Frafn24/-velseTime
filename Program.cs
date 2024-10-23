using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ØvelseTime2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory loopsCTFA = new Inventory();
            loopsCTFA.main();
            Console.ReadLine();

           
        }


        public static void PrintFoodItems()
        {
            FoodItem[] foodItems = new FoodItem[10];
            foodItems[0] = new FoodItem(1, "Æble", 4, DateTime.Now.AddDays(7));
            foodItems[1] = new FoodItem(2, "Brød", 20, DateTime.Now.AddDays(3));
            foodItems[2] = new FoodItem(3, "Mælk", 10, DateTime.Now.AddDays(5));
            foodItems[3] = new FoodItem(4, "Kartofler", 15, DateTime.Now.AddDays(14));
            foodItems[4] = new FoodItem(5, "Gulerødder", 8, DateTime.Now.AddDays(10));
            foodItems[5] = new FoodItem(6, "Kylling", 50, DateTime.Now.AddDays(2));
            foodItems[6] = new FoodItem(7, "Ost", 25, DateTime.Now.AddDays(20));
            foodItems[7] = new FoodItem(8, "Ris", 15, DateTime.Now.AddDays(6));
            foodItems[8] = new FoodItem(9, "Banan", 3, DateTime.Now.AddDays(4));
            foodItems[9] = new FoodItem(10, "Tomat", 20, DateTime.Now.AddDays(6));
            for (int i = 0; i < foodItems.Length; i++)
            {
                Console.WriteLine(foodItems[i].ToString());
            }
        }
        public static void PrintNonFoodItem()
        {
            string[] array = new string[]
            {
                "11",
                "22",
                "33",
                "44",
                "55",
                "66",
            };

            NonFoodItem[] nonFoodItems = new NonFoodItem[10];
            nonFoodItems[0] = new NonFoodItem(1, "Æble", 4, array);
            nonFoodItems[1] = new NonFoodItem(2, "Brød", 20, array);
            nonFoodItems[2] = new NonFoodItem(3, "Mælk", 10, array);
            nonFoodItems[3] = new NonFoodItem(4, "Kartofler", 15, array);
            nonFoodItems[4] = new NonFoodItem(5, "Gulerødder", 8, array);
            nonFoodItems[5] = new NonFoodItem(6, "Kylling", 50, array);
            nonFoodItems[6] = new NonFoodItem(7, "Ost", 25, array);
            nonFoodItems[7] = new NonFoodItem(8, "Ris", 15, array);
            nonFoodItems[8] = new NonFoodItem(9, "Banan", 3, array);
            nonFoodItems[9] = new NonFoodItem(10, "Tomat", 20, array);
            for (int i = 0; i < nonFoodItems.Length; i++)
            {
                Console.WriteLine(nonFoodItems[i].ToString());
            }
        }
    }

    public class Inventory : Item
    {
        Item[] items;
        string[] array = new string[]
        {
                "11",
                "22",
                "33",
                "44",
                "55",
                "66",
        };
        public void main()
        {
            items = new Item[2];
            items[0] = new NonFoodItem(1, "lol", 11.5, array);
            items[1] = new FoodItem(1,"Æble",4,DateTime.Now.AddDays(1));

            Console.WriteLine(GetInvetoryValue());
            PrintInventory();
        }


        public void Additem(Item item)
        {
            var NewItems = new Item[items.Length+1];
            for (int i = 0; i < items.Length; i++)
            {
                NewItems[i] = items[i];
            }
            NewItems[items.Length+1] = item;
            items = NewItems;
        }
        public void RemeveItem(Item item)
        {
            if (items.Length>0)
            {
                var NewItems = new Item[items.Length -1];
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i]!=item)
                    {
                        NewItems[i] = items[i];
                    }
                }
                items = NewItems;
            }
        }
        public double GetInvetoryValue()
        {
            if (items.Length>0)
            {
                double invVal = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    invVal = invVal + items[i].Getprice();
                }
                return invVal;
            }
            return 0;

        }
        public void PrintInventory()
        {
            if (items.Length < 0)
            {
                Console.WriteLine("der er ingen items i din inventory");
            }
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }
    }
    public class Item
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public string Getname()
        {
              return name;
        }
        public double Getprice() 
        { 
            return price;
        }

    }
    public class NewFoodItem : Item
    {
        public DateTime expires { get; set; }
        public DateTime GetExpires()
        {
            return expires;
        }
        public override string ToString()
        {
            var newString = $"Name:{name}, Price:{price}, expiration date:{expires}";
            return newString;
        }
    }
    public class NewNonFoodItem : Item
    {
        public string[] materials { get; set; }
        public override string ToString()
        {
            string listOfMaterials = "";
            for (int i = 0; i < materials.Length; i++)
            {
                var newlistOfMaterials = listOfMaterials;
                string material = materials[i];
                listOfMaterials = listOfMaterials + ", " + material;
            }
            var newString = $"Name:{name}, Price:{price}, Materials{listOfMaterials}";
            return newString;
        }
    }


        public class FoodItem:Item
    {
        public DateTime expires { get; set; }

        public FoodItem(int x_id,string x_name,double x_price,DateTime x_expires)
        {
            id = x_id;
            name = x_name;
            price = x_price;    
            expires = x_expires;
        }


        public DateTime GetExpires()
        {
            return expires;
        }
        public override string ToString()
        {
            var newString = $"Name:{name}, Price:{price}, expiration date:{expires}";
            return newString;
        }
    }
    public class NonFoodItem : Item
    {
        public string[] materials { get; set; }

        public NonFoodItem(int x_id, string x_name, double x_price, string[] x_materials)
        {
            id = x_id;
            name= x_name;
            price = x_price;
            materials = x_materials;    
        }
        public string[] GetMaterials()
        {
            return materials;
        }
        public override string ToString()
        {
            string listOfMaterials="";
            for (int i = 0; i < materials.Length; i++)
            {
                var newlistOfMaterials = listOfMaterials;
                string material = materials[i];
                listOfMaterials = listOfMaterials+", " + material;
            }
            var newString = $"Name:{name}, Price:{price}, Materials{listOfMaterials}";
            return newString;
        }
    }
}
