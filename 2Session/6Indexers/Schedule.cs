using System.Collections;
using System;

namespace _6Indexers
{
    public class Schedule
    {
        Hashtable hashtable = new Hashtable();
        DateTime dt1 = new DateTime(2018, 9, 1, 11, 50, 0);
        DateTime dt2 = new DateTime(2018, 9, 1, 14, 20, 0);
        DateTime dt3 = new DateTime(2018, 9, 3, 08, 00, 0);

        
        public Schedule(){
        hashtable.Add(dt1,"DNP");
         hashtable.Add(dt2,"SDJ");
          hashtable.Add(dt3,"NES");

        }

        public string returnValue(DateTime dt){
            return hashtable[dt].ToString();
            
        }

        public string returnValue(string dt){


            DateTime enteredDate = DateTime.ParseExact(dt,"yyyy-MM-dd HH:mm:s",null);
            
            return hashtable[enteredDate].ToString();

        }

    }
}