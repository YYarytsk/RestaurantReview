using System;
using System.Collections.Generic;

namespace Lib
{
    public class User
    {
        string firstName;
        public string firstName{
            get{
                if (!String.IsNullOrEmpty(firstName))
                    return firstName;
                else 
                    throw new NullReferenceException();
            }
            set{
                firstName=value;
            }
        }

        string lastName;
        public string lastName{
            get{
                if (!String.IsNullOrEmpty(lastName))
                    return lastName;
                else 
                    throw new NullReferenceException();
            }
            set{
                lastName=value;
            }
        }

        DateTime dob;
        public DateTime Dob { 
            get{
                return dob;
        }
            set{
                dob=value;
            } 
       }

       string phoneNumber;
       public string phoneNumber{
            get{
                if (!String.IsNullOrEmpty(phoneNumber))
                    return lphoneNumber;
                else 
                    throw new NullReferenceException();
            }
            set{
                phoneNumber=value;
            }
        }

        string email;
        public string email{
            get{
                if (!String.IsNullOrEmpty(email))
                    return email;
                else 
                    throw new NullReferenceException();
            }
            set{
                email=value;
            }
        }
    }
}
