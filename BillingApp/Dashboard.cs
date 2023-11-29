
using BillingApp.main_class;
using BillingSystem;
using BillingSystem.main_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BillingApp
{
    public partial class homefrm : Form
    {
        public homefrm()
        {
            InitializeComponent();
        }
        Viewalldata vd = new Viewalldata();
        retrievedata rt = new retrievedata();
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.newproduct == true)
            {
                ProductRegistration pr = new ProductRegistration();
                pr.ShowDialog();
            }
            else { msg(); }
        }
        private void addproductbtn_Click(object sender, EventArgs e)
        {
            if (Currenttime.newproduct == true)
            {
                ProductRegistration pr = new ProductRegistration();
                pr.ShowDialog();
            }
            else { msg(); }
        }
        private void gstbtn_Click(object sender, EventArgs e)
        {
            GST taxgst = new GST();
            taxgst.ShowDialog();
        }
        private void stockbtn_Click(object sender, EventArgs e)
        {
            if (Currenttime.stock == true)
            {
                Stock stck = new Stock();                
                stck.ShowDialog();
            }
            else { msg(); }
        }
        
        private void salebtn_Click(object sender, EventArgs e)
        {
            //Currenttime.spage == true ? sp.Show() :
            if(Currenttime.spage == true)
            {
                SalePage sp = new SalePage();                
                sp.Show();
            }
            else
            { msg(); }


        }
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.newcustomer == true)
            {
                CustomerDetails cd = new CustomerDetails();
                cd.ShowDialog();
            }
            else { msg(); }
        }
        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.CustomerD == true)
            {
                CustomerDetail cd = new CustomerDetail();
                cd.ShowDialog();
            }
            else { msg(); }
        }
        private void homefrm_Load(object sender, EventArgs e)
        {         
            timetimer.Start();
            Datelbl.Text = DateTime.Now.ToLongDateString();            
            userlogglbl.Text = loggedInUser.UserName;
            roleidlogglbl.Text = Currenttime.rolltitle;
            if (Currenttime.Isadmin == true)
            {              
                settingmenustrip.Enabled = true;
            }
            
            vslbl.Text = "Version " + Application.ProductVersion;
        }            
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.back == true)
            {
                Backup b = new Backup();
                b.ShowDialog();
            }
            else { msg(); }
        }
        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void newUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Waiting w = new Waiting();
            w.Show();
        }

        private void purchagebtn_Click(object sender, EventArgs e)
        {
            if (Currenttime.purchase == true)
            {
                PurchaseStock ps = new PurchaseStock();
                ps.Show();
            }
            else { msg(); }
        }

      

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.productD == true)
            {
                ProductDetailView pdv = new ProductDetailView();
                pdv.ShowDialog();
            }
            else { msg(); }
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void timetimer_Tick(object sender, EventArgs e)
        {
            this.timrlbl.Text = DateTime.Now.ToLongTimeString();
           // timrlbl.Text = Currenttime.timenow.ToString();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.newsuplr == true)
            {
                Supplier s = new Supplier();
                s.ShowDialog();
            }
            else { msg(); }
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.suplrD == true)
            {
                SupplierDetails sd = new SupplierDetails();
                sd.ShowDialog();
            }
            else { msg(); }
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.purchaseH == true)
            {
                PurchaseHistory ph = new PurchaseHistory();
                ph.ShowDialog();
            }
            else { msg(); }
        }

        private void salePurchaseLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.saleLB == true)
            {
                SalePurchaseLB splb = new SalePurchaseLB();
                splb.ShowDialog();
            }
            else { msg(); }
        }

        private void createExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.creatEXP == true)
            {
                CreateExpenses ce = new CreateExpenses();
                ce.ShowDialog();
            }
            else { msg(); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void msg()
        {
            MessageBox.Show("Your access has been denied, Please Contact admin","Access Denied",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loggin l = new Loggin();
            l.ShowDialog();
        }

        private void addExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.addEXP == true)
            {
                Expenses ex = new Expenses();
                ex.ShowDialog();
            }
            else { msg(); }
        }

        private void newSaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Currenttime.spage == true)
            {
                SalePage sp = new SalePage();
                sp.Show();
            }
            else
            { msg(); }
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.purchase == true)
            {
                PurchaseStock ps = new PurchaseStock();
                ps.Show();
            }
            else { msg(); }
        }

        private void newCotagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCatagory catform = new NewCatagory();
            catform.ShowDialog();
        }

        private void catagoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catagaryviews catview = new catagaryviews();
            catview.ShowDialog();
        }

        private void homefrm_Activated(object sender, EventArgs e)
        {
           vd.getaccess();
           
           // setuseraccess();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreDatabase rd = new RestoreDatabase();
            rd.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.ShowDialog();
        }

        private void serverConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Systemcontact sc = new Systemcontact();
            sc.ShowDialog();
        }

        private void invoicePageSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoicePageSize ips = new InvoicePageSize();
            ips.ShowDialog();
        }

        private void gSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GST taxgst = new GST();
            taxgst.ShowDialog();
        }

        private void invoiceHeaderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InvoicePageheader iph = new InvoicePageheader();
            iph.ShowDialog();
        }

        private void invoiceTCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InvoicePageFooter ipf = new InvoicePageFooter();
            ipf.ShowDialog();

        }

        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccess ua = new UserAccess();
            ua.ShowDialog();
        }

        private void newUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInfo unfo = new UserInfo();
            unfo.ShowDialog();
        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsers vu = new ViewUsers();
            vu.ShowDialog();
        }

        private void newRollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersRoles ur = new UsersRoles();
            ur.ShowDialog();
        }

        private void viewAllRollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rolesview r = new Rolesview();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            vd.getinvoicecountBYDATE(Convert.ToDateTime(DateTime.Now.ToShortDateString()), tdinvoicelbl, todaysale);
            vd.getpurchasecountBYDATE(Convert.ToDateTime(DateTime.Now.ToLongDateString()), tplbl, tpalbl);
            vd.getexpenssBYDATE(Convert.ToDateTime(DateTime.Now.ToLongDateString()), tealbl);
            vd.gettotalitem();
            tslbl.Text = Currenttime.totalSTCKitem.ToString();
            vd.getshop(firmheadertxt, firtaddtxt);

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void homefrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F12)
            {
                vd.getinvoicecountBYDATE(Convert.ToDateTime(DateTime.Now.ToShortDateString()), tdinvoicelbl, todaysale);
                vd.getpurchasecountBYDATE(Convert.ToDateTime(DateTime.Now.ToLongDateString()), tplbl, tpalbl);
                vd.getexpenssBYDATE(Convert.ToDateTime(DateTime.Now.ToLongDateString()), tealbl);
                vd.gettotalitem();
                tslbl.Text = Currenttime.totalSTCKitem.ToString();
                vd.getshop(firmheadertxt, firtaddtxt);
            }
            if(e.Control==true && e.KeyCode == Keys.L)
            {
                this.Hide();
                Loggin l = new Loggin();
                l.ShowDialog();
            }
        }

        private void saleHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Currenttime.shistory == true)
            {
                Salehistory sh = new Salehistory();
                sh.ShowDialog();
            }
            else { msg(); }
        }

        private void packageValidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageValidity PV = new PackageValidity();
            PV.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.loadvalue = 0;
            r.Show();
            
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.loadvalue = 1;
            r.Show();
        }

        private void saleWithSerialNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalePageSetting sl = new SalePageSetting();
            sl.Show();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import im = new Import();
            im.ShowDialog();
        }

        private void profitLosssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profit_Loss pl = new Profit_Loss();
            pl.ShowDialog();
        }

        private void customerLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAccount ca = new CustomerAccount();
            ca.ShowDialog();
        }

        private void supplierLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplieraccount sa = new Supplieraccount();
            sa.ShowDialog();
        }
    }
}
