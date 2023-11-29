using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace BillingApp.connection_class
{
    public class Connectionstringcs
    {
        //private static string path;
        public static string Connect()
        {
            return ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
           /* path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\db_connect";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
                //return ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            }*/
             
        }
    }
}

// connection string for localdatabase
/*"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SoftwareDevelopment\BillingApp\BillingApp\InventoryDB.mdf;Integrated Security=True"*/
//"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True"
//"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True;MultipleAcivityResultSets=true;Connect Timeout =30"
//Server=(localdb)\MSSQLLocalDB;
//Data Source=(LocalDB)\MSSQLLocalDB
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SoftwareDevelopment\BillingApp\BillingApp\bin\Debug\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30


//CS for SQL server

//Data Source=DESKTOP-GJBN1NF\SQLEXPRESS;Initial Catalog=BillingApp;Integrated Security=True

/* <add name = "BillingApp.Properties.Settings.InventoryDBConnectionString"
  connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True"
  providerName="System.Data.SqlClient" />*/
//"Server=DESKTOP-T4B4D9L\SQLEXPRESS;Initial Catalog=BillingApp;MultipleActiveResultSets=true;Integrated Security=True"

// <add name = "dbcs" connectionString="Server=DESKTOP-GJBN1NF\SQLEXPRESS;Initial Catalog=BillingSystem;MultipleActiveResultSets=true;Integrated Security=True"
// providerName="System.Data.SqlClient" />


//Data Source = 171.79.102.60;Initial Catalog = BillingSystem; User ID = easyapp; Password=***********


//------------DATE-----------14-05-2021--------------


/*<add name="dbcs" connectionString="Server=DESKTOP-GJBN1NF\SQLEXPRESS;Initial Catalog = BillingSystem;MultipleActiveResultSets=true;Enlist=true; User ID = easyapp; Password=alok.1991"
  providerName="System.Data.SqlClient" />
<add name="BillingSystem.Properties.Settings.dbcs" connectionString="Server=192.168.1.11;Initial Catalog = BillingSystem;MultipleActiveResultSets=true; User ID = easyapp; Password=alok.1991"
  providerName="System.Data.SqlClient" />
*/

/*<connectionStrings>
<add name="dbcs" connectionString="Server=DESKTOP-GJBN1NF\SQLEXPRESS;Initial Catalog = ComputerShop;MultipleActiveResultSets=true;Enlist=true; User ID = easyapp; Password=alok.1991"
  providerName="System.Data.SqlClient" />
<add name="BillingSystem.Properties.Settings.dbcs" connectionString="&quot;Data Source=192.168.1.11;Initial Catalog=ComputerShop;User ID =easyapp;Password=alok.1991; MultipleActiveResultSets=true;&quot; "
  providerName="System.Data.SqlClient" />
<add name="BillingSystem.Properties.Settings.BillingSystemConnectionString"
  connectionString="Data Source=DESKTOP-GJBN1NF\SQLEXPRESS;Initial Catalog=BillingSystem;Persist Security Info=True;User ID=easyapp;Password=alok.1991"
  providerName="System.Data.SqlClient" />
</connectionStrings>
*/

// ADD this Befor Making setup
/*<connectionStrings>
<add name="dbcs" connectionString=""/>
</connectionStrings>
*/