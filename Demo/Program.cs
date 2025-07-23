using Demo.Binding;
using Demo.Inheritance;
using Demo.overiding;
using System.Security.Cryptography.X509Certificates;


namespace Demo
{
    internal class Program
    {

        //static void EmployeeProcess(FullTimeEmployee employee) {

        //    if (employee is not null) {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}
        //static void EmployeeProcess(PartTimeEmployee employee) {

        //    if (employee is not null) {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        //static void EmployeeProcess(Employee employee)
        //{

        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}


        #region Polymorphism
        //static int Sum(int X,int Y) {

        // return X + Y;  


        //}
        //static double Sum(double X, double Y) {
        //    return X + Y;        
        //}
        //static double Sum(int X, double Y) {
        //    return X + Y;        
        //}
        //static double Sum(double X, int Y) {
        //    return X + Y;        
        //}
        //static double Sum(double X, int Y, int Z) {
        //    return X + Y + Z;        
        //} 
        #endregion
        static void Main()
        {


            //Class VS Struct 
            #region Inheritance 
            //Inheritance 
            //X--> Y
            //DRY 
            //Parent parent = new Parent(1, 2);
            ////Console.WriteLine(parent);
            //parent.Fun02(); 
            //parent.Fun01();
            //Child child = new Child(1, 2, 3);
            //Console.WriteLine(child); 
            #endregion

            #region Polymorphism
            //Polymorphism
            //1. Polymorphism Method (Function )Overloading  
            //2. Polymorphism Method (Function )Overriding 

            // Console.WriteLine();

            //1. Polymorphism Method (Function )Overloading 
            //There are more than Function(in the same scope[class -struct ])
            //these function have the same name but different signature    
            // (count - type - order) parameters
            //Sum(1, 2);
            //Sum(2.45,5.545);

            #endregion


            #region Overriding
            //2. Polymorphism Method (Function )Overriding 
            // There are more than one functions [in different scope [class ]] have same name
            // and same signature but with behaviour 
            //TypeB typeB = new TypeB() { A=1,B=5};
            ////typeB.A = 121;
            ////typeB.B = 454;
            //typeB.Fun01();
            //typeB.Fun02(); 
            #endregion

            #region Binding
            //Binding
            //What is Bindong ?
            //Referance from parent refer to object from child  
            //TypeA Ref;
            ////Ref = new TypeA();  
            //// Child is Parent 
            ////Type B is Type A

            //Ref = new TypeB();
            //Ref.A = 12;
            //Ref.Fun01(); // static Binding methods 
            //Ref.Fun02(); //  




            #endregion

            #region not Bindig
            // child is parent 
            // Animal --> Dog : Dog is Animal 
            // Dog -->  (Dog)Animal : Animal is Dog 
            //TypeA Ref =new TypeA();
            //Ref =new TypeB();

            //TypeB typeB = (TypeB) Ref;// not Bindig (Casting)

            #endregion

            #region When we Need Binding 
            //When we Need Binding 

            //FullTime Employee : Id , Name , Address , Email , Salary 
            // FullTimeEmployee fulltime = new FullTimeEmployee()
            // {
            //     Id = 1,
            //     Name = "Ahmed",
            //     Email = "ahmed@g.c ",
            //     Address = "cairo",
            //     Salary = 56555

            // };

            // // PartTime Empolyee : Id , Name , Address , Email, Number of Hours ,HourRate

            //// EmployeeProcess(fulltime);
            // PartTimeEmployee parttime = new PartTimeEmployee() { 

            // Id = 2,
            // Name = "ali",
            // Email="ali@gmail.com",
            // Address="mansoura",
            // NumberOFHours = 30,
            // HourRate = 10,


            // };

            //  EmployeeProcess(parttime);

            #endregion

            //TypeA typeA;
            //typeA = new TypeA();    
            //typeA = new TypeB();
            //typeA = new TypeC();
            //typeA.A = 12;
            //typeA.Fun01();
            //typeA.Fun02();  


            // internal -->in claas or any class in same namespace(project)
            // protected -->  class and class which inherited from class 
            // protected internal --> in class or any class or any class in namespace
        }

        public class Person {
    
            internal protected int id; 
            protected string name; // class or any class inherited from class  
            private protected int p;// in class itself 

            public void Fun1() {
                Console.WriteLine("name");
            
            }
        
        }
        public class student : Person { 
        

          
        }
    }
}
