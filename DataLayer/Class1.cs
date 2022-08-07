using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Class1
    {
    }
    public class ClsDataLayer
    {
        //Declate DataTable and TableAdapter
        DS_User.USERMSK_SELECTDataTable UDT = new DS_User.USERMSK_SELECTDataTable();


        DS_UserTableAdapters.USERMSK_SELECTTableAdapter UAdaspter = new DataLayer.DS_UserTableAdapters.USERMST_SELECTTableAdapter();



        //for insert record to database_email)
        public void InsertData(string _Username, string _Usertype, string _Address, string _ProducedEnergy, string _ConsumedEnergy)
        //public void InsertData(string _USERNAME, string _USERTYPE, string _ADDRESS, int _PRODUCEDENERGY, int _CONSUMEDENERGY)



        {
            
            int i = UAdaspter.Insert(_Username, _Usertype, _Address, _ProducedEnergy, _ConsumedEnergy);
        }

        //for select record from database
        public object SelectData()
        {
            return UDT = UAdaspter.SelectUser();
        }

    }
}

