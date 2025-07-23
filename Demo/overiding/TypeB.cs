using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.overiding
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        //override or hide
        //apply override : 
        //1.Apply overrid using 'new ' Keyword
        //1.Apply overrid using 'override  ' keyword 

        // static Binding 
        // Compiler will Bind Function Call Based on Refrence type not the object type 
        // At compilation time 
        public new void Fun01() // using  keyword new 
        {

            Console.WriteLine("Fun01 from Type B ");
        }
        // must be not privat and virtual 

        // Dynamic Binding 
        //ClR will Binding the function call based on object  type Not the reference type    
        // Run time 
        public override void Fun02() //    using keyword override 
        { 

            Console.WriteLine($"A: {A} B: {B}");
        }
    }

}
