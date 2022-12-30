using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookServiceUsingLINQ
{
    public class AddressBookManagement
    {
        public static void AddDataToTable()
        {
            DataTable table = new DataTable();          //UC1 Create Table
            table.Columns.Add("firstName", typeof(string));         //Add said 8 Columns
            table.Columns.Add("lastName", typeof(string));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("city", typeof(string));
            table.Columns.Add("state", typeof(string));
            table.Columns.Add("zip", typeof(int));
            table.Columns.Add("phoneNumber", typeof(int));
            table.Columns.Add("email", typeof(string));

            //  --UC3-Add/Insertion of Contacts/Records/Rows in the Table.
            table.Rows.Add("Aneesh","Katta","Hyderabad", "Mncl", "Telagana",456456,643533,"ak@gmail.com");
            table.Rows.Add("Vinay","Navik","Chembur", "Mumbai", "Maharashtra",400074,828006,"vn@gmail.com");
            table.Rows.Add("akshata","r","bnglr", "Mncl", "Banglore",456456,643533,"ar@gmail.com");
            table.Rows.Add("anil","bamne","mahape", "Mncl", "Pune",546545,773592,"ab@gmail.com");
            table.Rows.Add("shubhadh","g","krnt", "Mncl", "Karnataka",878787,643533,"sg@gmail.com");
            
            DisplayProductTable(table);
        }
        public static void DisplayProductTable(DataTable table)
        {
            IEnumerable<DataRow> list = from datas in table.AsEnumerable() select datas;
            foreach (DataRow contact in list)
            {
                Console.WriteLine("firstName:" + contact.Field<string>("firstName")   
                    +"  lastName:"+ contact.Field<string>("lastName")   
                    + " address:"+ contact.Field<string>("address")   
                    + " city:"+ contact.Field<string>("city")   
                    + " state:"+ contact.Field<string>("state")   
                    + " zip:"+ contact.Field<int>("zip")   
                    + " phoneNumber:"+ contact.Field<int>("phoneNumber")   
                    + " email:"+ contact.Field<string>("email"));
            }
        }
    }
}

