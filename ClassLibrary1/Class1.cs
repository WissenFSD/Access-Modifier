using Access_Modifier;

namespace ClassLibrary1
{
    public class Class1:Person
    {

        public Class1()
        {
            Person p = new Person();

            // Arada kalıtım hiyerarşisi var bu sebeple erişim mümkün ?

            ProtectedInternalMethod();
        }
    }
}