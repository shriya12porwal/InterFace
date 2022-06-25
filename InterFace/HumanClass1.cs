namespace InterFace
{
    public partial class HumanClass1 : HumanInterface1
    {
        public int var = 50;

        internal int var1 = 100;
        private int var2 = 200;
        protected string var3 = "Global Logic";
        public readonly string var4 = string.Empty;
        public static readonly string var5 = string.Empty;
        public HumanClass1()
        {
            
        var4 = "Hitachi";
        }
        static HumanClass1()
        {
            var5 = "Multinational";
        }
        public string Address(string address)
        {
            return (address);

        }
        protected int function(int a)
        {
            return a * 20;
        }
        public string Name(string name)
        {
            return name;
        } 
    }
    public partial class HumanClass1 : HumanInterface1
    {
       
        public void Sleep(bool a)
        {
            if (a == true)
            {
                Console.WriteLine("Sleeping:");
            }
            else
            {
                Console.WriteLine("Not Sleeping");
            }

        }
        public void Code(bool a)
        {
            if (a == true)
            {
                Console.WriteLine("Doing Coding:");
            }
            else
            {
                Console.WriteLine("Not doing Coding");
            }
        }
         public void Eat(bool a)
            {
                if (a == true)
                {
                    Console.WriteLine("Sleeping:");
                }
                else
                {
                    Console.WriteLine("Not Sleeping");
                }
            }

         public void Walk(bool a)
        {
            if (a)
            {
                Console.WriteLine("Walking:");
            }
            else
            {
                Console.WriteLine("Not Walking");
            }
        }
    }


    public sealed class ChildClass:HumanClass1
    {
        HumanClass1 obj = new HumanClass1();
        public ChildClass()
        {
            Console.WriteLine("I am Child Class:");
        }
        public void fun()
        {
            Console.WriteLine("I am Child Function:");
           

        }
       /* public void Description()
        {
            Console.WriteLine("public variable:", obj.var);

            Console.WriteLine("Internal variable:", obj.var1); 
            Console.WriteLine("Protected variable:",this.var3);

            Console.WriteLine("Readonly variable:",var4);
           
            int res = this.function(100);
            Console.WriteLine("Protected member", var3);
        }*/
    }
}