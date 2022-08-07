using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Class1
    {
        public ClsDataLayer objDAL = new ClsDataLayer();

        public void InsertNewUser(string _Username, string _Usertype, string _Address, string _ProducedEnergy, string _ConsumedEnergy)
       
        {
            objDAL.InsertData(_Username, _Usertype, _Address, _ProducedEnergy, _ConsumedEnergy);
        }

        public object SelectUser()
        {
            return objDAL.SelectData();
        }
    }
}
    