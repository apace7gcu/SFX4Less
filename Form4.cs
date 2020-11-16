using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFX4Less
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

           
        }
        /// <summary>
        /// Item stores inventory info when button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAddItem_Click(object sender, EventArgs e)
        {

            //Sets calendar selection to one date only.
            calDateAdded.MaxSelectionCount = 1;


            //If statements based on radio buttons, inputs info in the respective inventory class
            //Displays info in message box as confirmation.

            //Equipment radio button
            if (rbEquip.Checked)
            {
                Equipment newEquipment = new Equipment(lbColor.SelectedIndex.ToString(),
                    calDateAdded.SelectionStart.ToString(), txtBrand.Text,
                    int.Parse(txtQty.Text), txtDesc.Text, txtCom.Text,
                    int.Parse(txtInventCount.Text), int.Parse(txtExtra1.Text), int.Parse(txtExtra2.Text));

                MessageBox.Show(string.Format("Date Added: {0} \n Color: {1} \n Brand: {2} \n " +
                    "Item Quantity: {3} \n Item Description: \n {4} \n Weight: {5} \n Size: {6} " +
                    "\n Additional Comments: \n {7} \n Total Inventory Count: {8}", 
                    
                        newEquipment.date, newEquipment.color, newEquipment.brand, newEquipment.itemQty,
                        newEquipment.itemDesc, newEquipment.equipWeight, newEquipment.equipSize,
                        newEquipment.itemCom, newEquipment.CallInventory())); 
           }

            //Makeup radio button
            else if (rbMakeup.Checked)
            {
                Makeup newMakeup = new Makeup(lbColor.SelectedIndex.ToString(),
                    calDateAdded.SelectionStart.ToString(), txtBrand.Text,
                    int.Parse(txtQty.Text), txtDesc.Text, txtCom.Text,
                    int.Parse(txtInventCount.Text), double.Parse(txtExtra1.Text), txtExtra2.Text);

                MessageBox.Show(string.Format("Date Added: {0} \n Color: {1} \n Brand: {2} \n " +
                    "Item Quantity: {3} \n Item Description: \n {4} \n Net Weight: {5} \n  Makeup Type: {6} " +
                    "\n Additional Comments: \n {7}, \n Total Inventory Count: {8}",

                        newMakeup.date, newMakeup.color, newMakeup.brand, newMakeup.itemQty,
                        newMakeup.itemDesc, newMakeup.netWT, newMakeup.makeupType,
                        newMakeup.itemCom, newMakeup.CallInventory()));

            }

            //Prop radio button
            else if (rbProp.Checked)
            {

                Prop newProp = new Prop(lbColor.SelectedIndex.ToString(),
                    calDateAdded.SelectionStart.ToString(), txtBrand.Text,
                    int.Parse(txtQty.Text), txtDesc.Text, txtCom.Text,
                    int.Parse(txtInventCount.Text), int.Parse(txtExtra1.Text), int.Parse(txtExtra2.Text));

                MessageBox.Show(string.Format("Date Added: {0} \n Color: {1} \n Brand: {2} \n " +
                    "Item Quantity: {3} \n Item Description: \n {4}  \n  Weight: {5} \n Size: {6} \n Additional Comments:" +
                    " \n {7} \n Total Inventory Count: {8}",

                        newProp.date, newProp.color, newProp.brand, newProp.itemQty,
                        newProp.itemDesc, newProp.propWeight, newProp.propSize,
                        newProp.itemCom, newProp.CallInventory()));
            }

            //Software radio button
            else
            {
                Software newSoftware = new Software(lbColor.SelectedIndex.ToString(),
                    calDateAdded.SelectionStart.ToString(), txtBrand.Text,
                    int.Parse(txtQty.Text), txtDesc.Text, txtCom.Text,
                    int.Parse(txtInventCount.Text), txtExtra1.Text, txtExtra2.Text);

                MessageBox.Show(string.Format("Date Added: {0} \n Color: {1} \n Brand: {2} \n " +
                    "Item Quantity: {3} \n Item Description: \n {4} \n Required Specs: {5} \n " +
                    "Operating System(s): {6} \n Additional Comments: \n {7} \n Total Inventory Count: {8}",

                        newSoftware.date, newSoftware.color, newSoftware.brand, newSoftware.itemQty,
                        newSoftware.itemDesc, newSoftware.specReq, newSoftware.os,
                        newSoftware.itemCom, newSoftware.CallInventory()));
            }
        }
    }
}
