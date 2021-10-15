using DotRas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPPOE_Dialer
{
    public partial class ConnectDialer : Form
    {
        public ConnectDialer()
        {
            InitializeComponent();
            CreateConnect("PPPoEDialer");
        }

        public void CreateConnect(string ConnectName)
        {
            RasDialer dialer = new RasDialer();
            RasPhoneBook book = new RasPhoneBook();
            try
            {
                book.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User));
                if (book.Entries.Contains(ConnectName))
                {
                    book.Entries[ConnectName].PhoneNumber = " ";
                    book.Entries[ConnectName].Update();
                }
                else
                {
                    System.Collections.ObjectModel.ReadOnlyCollection<RasDevice> readOnlyCollection = RasDevice.GetDevices();
                    RasDevice device = RasDevice.GetDevices().Where(o => o.DeviceType == RasDeviceType.PPPoE).First();
                    RasEntry entry = RasEntry.CreateBroadbandEntry(ConnectName, device);
                    entry.PhoneNumber = " ";
                    book.Entries.Add(entry);
                }
            }
            catch (Exception)
            {
                lb_status.Text = "PPPoE Connected Book";
            }

            if (Properties.Settings.Default.userName != string.Empty)
            {
                uName.Text = Properties.Settings.Default.userName;
                passwd.Text = Properties.Settings.Default.passUser;
            }
        }


    [Obsolete]
        private void cnnect_Click(object sender, EventArgs e)
        {
            try
            {
                string username = uName.Text.Replace("\\r", "\r").Replace("\\n", "\n");
                string password = passwd.Text.ToString();
                RasDialer dialer = new RasDialer();
                dialer.EntryName = "PPPoEDialer";
                dialer.PhoneNumber = " ";
                dialer.AllowUseStoredCredentials = true;
                dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);
                dialer.Credentials = new System.Net.NetworkCredential(username, password);
                dialer.Timeout = 500;
                RasHandle myras = dialer.Dial();
                while (myras.IsInvalid)
                {
                    lb_status.Text = "Not Connected, invalid username or password";
                }
                if (!myras.IsInvalid)
                {
                    lb_status.Text = "Connected Successfully";
                    RasConnection conn = RasConnection.GetActiveConnectionByHandle(myras);
                    RasIPInfo ipaddr = (RasIPInfo)conn.GetProjectionInfo(RasProjectionType.IP);
                    lb_message.Text = "MyIP： " + ipaddr.IPAddress.ToString();
                    //dial.IsEnabled = false;
                    //hangup.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (checkBox1.Checked)
            {
                Properties.Settings.Default.userName = uName.Text;
                Properties.Settings.Default.passUser = passwd.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
