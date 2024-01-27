using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{


    public class DrivedPerson:Person
    {

        public DrivedPerson()
        {
            ProtectedMethod();
           
               
        }

    }
    public class Person
    {
        // public
        // private
        // protected
        // protected internal
        // internal
        // erişim belirteçler 5 adettir. 
        // methodlar, sınıflar, prop'lar, field'lar erişim belirteci alabilir.

        // Ayrıca daha sonraki konularda farklı c# özelliklerinde erişim belirteç alabildiğini göreceksiniz.
        private string PrivateProp { get; set; }


        public string PublicProp { get; set; }

        // Public metot her yerden erişilebilir metot demektir. Public ifadesi kullanıldığında her katmandan bu metoda erişmek mümkündür.
        public void PublicMethod()
        {

            Console.WriteLine("ben public'im");



            // private olan metoda sınıfın içerisinden erişebilinir.
            PrivateMethod();
        }


        // Private üyelere sadece sınıfın içerisindn erişebilirsiniz.
        // Sınıfın dışında, nesne örneği alırken, yada farklı bir sınıftan private üyeye erişmek çünkün değildir. 

        //

        private void PrivateMethod()
        {
            Console.WriteLine("ben private'im");

         
        }



        // Erişim belirteç verilmezse, method private olur.
        void PrivateMethod1()
        {
            Console.WriteLine("ben private'im");
        }
        // Protected metot kalıtım dünyasının private'idir.

        // protected methodlara sadece kalıtım hiyerarşisi içerisindeki sınıflar erişebilir.
        protected void ProtectedMethod()
        {

            Console.WriteLine("ben protected'im");
        }

        // Internal erişim belirleyicisine sahip olan metotlara dış projeşerden erişilemez.

        // Internal erişim belirleyicisine sahip metotlara aynı projede her yerden erişilebilir.
        internal void InternalMethod()
        {
            Console.WriteLine("ben internal'im");
        }



        // salı günü bakılacak!!!!!!!!!!
        protected internal void ProtectedInternalMethod() {

            Console.WriteLine("ben hem internal hemde protected'im");

        }
    }
}
