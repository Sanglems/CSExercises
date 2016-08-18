﻿using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of TV you need to be order");
            int tv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of DVD you need to be order");
            int dvd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of MP3 you need to be order");
            int mp3 = Convert.ToInt32(Console.ReadLine());
            double discountedPrice = CalculateTotalPrice(tv, dvd, mp3);
            Console.WriteLine("The discounted price is {0}", discountedPrice);

        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            double discountedPrice;
            int tvdvdprice = 900 * tvQty + 500 * dvdQty;
            int mp3price = 700 * mp3Qty;
            if (tvdvdprice <= 5000)
            { discountedPrice = tvdvdprice + mp3price;
            }
            else if ((tvdvdprice > 5000) && (tvdvdprice <= 10000))
            {
                discountedPrice = 0.9 * tvdvdprice + mp3price; 
            }
            else
            { discountedPrice = 0.85 * tvdvdprice + mp3price;
            }
            return discountedPrice;

        }
    }
}