﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {

   private static String ConvertToWords(String numb)  
{  
    String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";  
    String endStr = "";  
    try  
    {  
        int decimalPlace = numb.IndexOf(".");  
        if (decimalPlace > 0)  
        {  
            wholeNo = numb.Substring(0, decimalPlace);  
            points = numb.Substring(decimalPlace + 1);  
            if (Convert.ToInt32(points) > 0)  
            {  
                andStr = "and";
                endStr = " " + endStr;
               
            }  
        }  
        val = String.Format("{0} {1}{2} {3}", ConvertWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);  
    }  
    catch { }  
    return val;  
}




        private static String ConvertWholeNumber(String Number)  
{  
    string word = "";  
    try  
    {  
        bool beginsZero = false;   
        bool isDone = false;  
        double dblAmt = (Convert.ToDouble(Number));  
          
        if (dblAmt > 0)  
        {
            beginsZero = Number.StartsWith("0");  
  
            int numDigits = Number.Length;  
            int pos = 0;
            String place = "";
            switch (numDigits)  
            {  
                case 1:

                    word = oneNumbers(Number);  
                    isDone = true;  
                    break;  
                case 2:  
                    word = tenNumbers(Number);  
                    isDone = true;  
                    break;  
                case 3: 
                    pos = (numDigits % 3) + 1;  
                    place = " Hundred and ";  
                    break;  
                case 4:  
                case 5:  
                case 6:  
                    pos = (numDigits % 4) + 1;  
                    place = " Thousand ";  
                    break;  
                case 7:  
                case 8:  
                case 9:  
                    pos = (numDigits % 7) + 1;  
                    place = " Million ";  
                    break;  
                case 10:  
                case 11:  
                case 12:  
  
                    pos = (numDigits % 10) + 1;  
                    place = " Billion ";  
                    break;    
                default:  
                    isDone = true;  
                    break;  
            }  
            if (!isDone)  
            {  
                if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")  
                {  
                    try  
                    {  
                        word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));  
                    }  
                    catch { }  
                }  
                else  
                {  
                    word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));  
                }  
    
            }  
            
            if (word.Trim().Equals(place.Trim())) word = "";  
        }  
    }  
    catch { }  
    return word.Trim();  
}

        private static String tenNumbers(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = tenNumbers(Number.Substring(0, 1) + "0") + " " + oneNumbers(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }

        private static String oneNumbers(String Number)  
{  
    int _Number = Convert.ToInt32(Number);  
    String name = "";  
    switch (_Number)  
    {  
  
        case 1:  
            name = "One";  
            break;  
        case 2:  
            name = "Two";  
            break;  
        case 3:  
            name = "Three";  
            break;  
        case 4:  
            name = "Four";  
            break;  
        case 5:  
            name = "Five";  
            break;  
        case 6:  
            name = "Six";  
            break;  
        case 7:  
            name = "Seven";  
            break;  
        case 8:  
            name = "Eight";  
            break;  
        case 9:  
            name = "Nine";  
            break;  
    }  
    return name;  
}
      
        static void Main(string[] args)
        {
            string isMinus = "";  
    try  
    {  
         string number = Console.ReadLine();  
        number = Convert.ToDouble(number).ToString();  
  
        if (number.Contains("-"))  
        {
            isMinus = "Minus ";  
            number = number.Substring(1, number.Length - 1);  
        }  
        if (number == "0")  
        {  
            Console.WriteLine("\nZero Only");  
        }  
        else  
        {
            Console.WriteLine("\n{0}", isMinus + ConvertToWords(number));  
        }  
        Console.ReadKey();  
    }  
    catch (Exception ex)  
    {  
        Console.WriteLine(ex.Message);  
    }  
        }
        
    }
}
