using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_21
{
    public sealed class Singleton
    {
        //eager initialization of singleton

        /* private static Singleton instance = new Singleton();
           private Singleton() { }

            public static Singleton GetInstance
        {
            get
            {
                return instance;
            } 
        }
         */

        //lazy initialization of singleton

        /*  private static Singleton instance = null;
          private Singleton() { }

          public static Singleton GetInstance
          {
              get
              {
                  if (instance == null)
                      instance = new Singleton();

                  return instance;
              }
          }*/

        //Thread-safe (Double-checked Locking) initialization of singleton

        private static Singleton instance = null;
        private string Name { get; set; }
        private string IP { get; set; }
        private Singleton()
        {
            
            Console.WriteLine("Singleton Object");

            Name = "MyServer";
            IP = "192.168.1.23";
        }
       
        private static object syncLock = new object();

        public static Singleton Instance
        {
            get
            {
                
                lock (syncLock)
                {
                    if (Singleton.instance == null)
                        Singleton.instance = new Singleton();

                    return Singleton.instance;
                }
            }
        }

        public void Show() 
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

    }
}
