using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_WHAT_IS_NEW
{
    public class ExpressionBodied
    {

        //Readonly properties
        public string Name { get; }

        public string LastName { get; }

        //Property expression bodied
        public string FullName => $" {Name} {LastName}";

        //Constructor expression bodied and tuple deconstruction
        public ExpressionBodied(string userName, string userLastName) => (Name, LastName) = (userName, userLastName );

        public void OtherFunction()
        {
            //The read only property Name can be modified on the constructor method
            //Compilier will show a error
            //Name = "ABC";
        }
    }
}
