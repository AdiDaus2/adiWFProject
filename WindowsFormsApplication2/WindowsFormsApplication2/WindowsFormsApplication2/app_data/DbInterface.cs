using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace WindowsFormsApplication2
{
     interface DbInterface 
    {



       void Insert();


        void Delete(int IdKey);

         void Update();
        

      

    }
}
