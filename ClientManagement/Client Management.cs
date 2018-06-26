using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClientManagement
{
    public partial class ClientManagmentForm : Form
    {
        private List<Client> clientList = new List<Client>();

        public ClientManagmentForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();

            DialogResult result = loadFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    pathLabel.Text = loadFileDialog.FileName;
                    StreamReader reader = new StreamReader(loadFileDialog.FileName);

                    eliminateDuplicatesButton.Enabled = true;
                    eliminateDuplicatesButton.Visible = true;

                    while (!reader.EndOfStream)
                    {
                        string[] clientRaw = new string[6];
                        clientRaw = reader.ReadLine().Split(',');

                        if (clientRaw[0] != "INSURED" && clientRaw[0].Length != 1)
                        {
                            clientList.Add(new Client(clientRaw[0], clientRaw[1], clientRaw[2], clientRaw[3] + "," + clientRaw[4], clientRaw[5]));
                            displayBox.Items.Add(clientRaw[0] + ":" + clientRaw[1]);
                        }

                        //Console.WriteLine(clientRaw[0]);
                    }

                    reader.Close();
                }
                catch (IOException)
                {
                }
            }
            //Console.WriteLine(loadFileDialog.FileName);
        }

        private void eliminateDuplicatesButton_Click(object sender, EventArgs e)
        {
            string prevClient = clientList[0].clientName;

            for (int i = 1; i < clientList.Count; i++)
            {
                string curClient = clientList[i].clientName;

                if (curClient.ToLower() == prevClient.ToLower())
                {
                    clientList.RemoveAt(i);
                    displayBox.Items.RemoveAt(i);
                    i--;
                } else
                {
                    prevClient = curClient;
                }
            }
        }

        private void displayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedClientName.Text = displayBox.SelectedItem.ToString().Split(':')[1];
            string tempPolicyID;

            if (displayBox.SelectedItem != null)
            {
                tempPolicyID = displayBox.SelectedItem.ToString().Split(':')[1];
            }
            else tempPolicyID = null;

            foreach (Client loopClient in clientList)
            {
                if (loopClient.clientPolicyID == tempPolicyID)
                {
                    selectedClientName.Text = loopClient.clientName;
                    selectedClientPolicy.Text = loopClient.clientPolicyID;
                    selectedClientStreet.Text = loopClient.clientStreetAddress;
                    selectedClientCSZ.Text = loopClient.clientCityStateZip;
                    selectedClientDOB.Text = loopClient.clientDOB;

                    break;
                }
            }
        }

        private void policySearchButton_Click(object sender, EventArgs e)
        {
            foreach (string loopString in displayBox.Items)
            {
                if (loopString.Split(':')[1] == policySearchBox.Text)
                {
                    displayBox.SelectedItem = loopString;

                    break;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            foreach (Client loopClient in clientList)
            {
                if (loopClient.clientPolicyID == selectedClientPolicy.Text)
                {
                    loopClient.clientName = selectedClientName.Text;
                    loopClient.clientStreetAddress = selectedClientStreet.Text;
                    loopClient.clientCityStateZip = selectedClientCSZ.Text;
                    loopClient.clientDOB = selectedClientDOB.Text;

                    break;
                }
            }

            displayBox.Items[displayBox.SelectedIndex] = selectedClientName.Text + ":" + selectedClientPolicy.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (Client loopClient in clientList)
            {
                if (loopClient.clientPolicyID == selectedClientPolicy.Text)
                {
                    clientList.Remove(loopClient);

                    break;
                }
            }

            displayBox.Items.RemoveAt(displayBox.SelectedIndex);

            selectedClientName.Text = "";
            selectedClientPolicy.Text = "";
            selectedClientStreet.Text = "";
            selectedClientCSZ.Text = "";
            selectedClientDOB.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Save Changes";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                fs.Close();


                Console.WriteLine(saveFileDialog.FileName);

                string[] clientRawOut = new string[clientList.Count];

                for (int i = 0; i < clientRawOut.Length; i++)
                {
                    clientRawOut[i] = clientList[i].clientName + "," 
                                    + clientList[i].clientPolicyID + ","
                                    + clientList[i].clientStreetAddress + ","
                                    + clientList[i].clientCityStateZip + ","
                                    + clientList[i].clientDOB;
                }

                File.WriteAllLines(saveFileDialog.FileName, clientRawOut);

                clientList.Clear();
                displayBox.Items.Clear();

                selectedClientName.Text = "";
                selectedClientPolicy.Text = "";
                selectedClientStreet.Text = "";
                selectedClientCSZ.Text = "";
                selectedClientDOB.Text = "";

                pathLabel.Text = "(No File Loaded)";

                eliminateDuplicatesButton.Visible = false;
                eliminateDuplicatesButton.Enabled = false;
            }
        }
    }
}
