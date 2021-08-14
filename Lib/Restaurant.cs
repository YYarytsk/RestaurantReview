using System;
using System.Collections.Generic;


namespace Lib
{
    public enum TypeOfFood{
        FastFood,
        Italian,
        Buffet,
        Pizza,
        Vegan
    }
    public class Restaurant
    {
        string restaurantName;
        public string restaurantName { 
            get{
                if(!String.IsNullOrEmpty(restaurantName))
                    return restaurantName;
                else
                    throw new NullReferenceException();
            }
            set{
                restaurantName=value;
            } 
         }

         public string restaurantAddress { 
            get{
                if(!String.IsNullOrEmpty(restaurantAddress))
                    return restaurantAddress;
                else
                    throw new NullReferenceException();
            }
            set{
                restaurantAddress=value;
            } 
         }

         public string restaurantZippCode { 
            get{
                if(!String.IsNullOrEmpty(restaurantZippCode))
                    return restaurantZippCode;
                else
                    throw new NullReferenceException();
            }
            set{
                restaurantZippCode=value;
            } 
         }

        TypeOfFood typeOfFood;
        public TypeOfFood TypeOfFood { 
            get{
                return typeOfFood;
            } 
            set{
                typeOfFood=value;
            }
        }
    }
}