using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_Data;
using Demo_Day8_DB.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Demo_Day8_DB
{
    public partial class CustomerFrm : Form
    {
        MMABooksContext context;    // The DB context
        Customer currentCustomer;   // To hold the current customer information
        public CustomerFrm()
        {
            InitializeComponent();
        }


        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            try
            {
                context = new MMABooksContext();    // Instantiate the context
                currentCustomer = context.Customers.First();   // Load the first Customer
                //stateComboBox.Items.AddRange(
                //    context.States.Select(s=> s.StateName).ToArray());
                // Loading all states data into the combo-box
                stateComboBox.DataSource = context.States.ToList();
                stateComboBox.DisplayMember = "StateName";
                stateComboBox.ValueMember = "StateCode";
                // Load all customer IDs 
                Object[] cIds = context.Customers.Select(c => (Object)c.CustomerId).ToArray();
                customerIdCBox.Items.AddRange(cIds);

                DisplayCustomer(); // Display the customer data

                // To learn Extension methods
                Word w = new Word() { Name = "All Good"};
                w.GetSeries();
            }
            catch (SqlException sqlException)
            {
                string errorMessage = "";
                foreach (SqlError error in sqlException.Errors)
                {
                    errorMessage += "ERROR CODE:  " + error.Number +
                                    " " + error.Message + "\n";
                }
                MessageBox.Show(errorMessage);
            }
            catch (Exception ex)
            {  
                string errorMessage = "DB error: " + ex.Message + "\n";
                MessageBox.Show(errorMessage);
            }

        }

        /// <summary>
        /// Display the current customer information in the Form fields
        /// </summary>
        private void DisplayCustomer()
        {
            if (currentCustomer is null) return;
            customerIdTxt.Text = currentCustomer.CustomerId.ToString();
            customerIdCBox.SelectedItem = currentCustomer.CustomerId;
            nameTxt.Text = currentCustomer.Name;
            addressTxt.Text = currentCustomer.Address;
            cityTxt.Text = currentCustomer.City;
            //stateTxt.Text = currentCustomer.State;
            //string state = context.States.First(
            //    s => s.StateCode == currentCustomer.State).StateName;
            stateComboBox.SelectedValue = currentCustomer.State;
            postalTxt.Text = currentCustomer.ZipCode;

            saveBtn.Enabled = false;
            discardBtn.Enabled = false;

            // Enable/disable the Back button based on the index of the current selected Customer ID    
            if (customerIdCBox.SelectedIndex > 0) backBtn.Enabled = true;
            else backBtn.Enabled = false;
            // Enable/disable the Next button based on the index of the current selected Customer ID    
            if (customerIdCBox.SelectedIndex == customerIdCBox.Items.Count - 1) nextBtn.Enabled = false;
            else nextBtn.Enabled = true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int index = customerIdCBox.SelectedIndex + 1;   // Get the next index of the current customer ID
            int id = Int32.Parse(customerIdCBox.Items[index].ToString());
            currentCustomer = context.Customers.Find(id);   // Load Customer ID=1
            DisplayCustomer();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            int index = customerIdCBox.SelectedIndex - 1;   // Get the prev index of the current customer ID
            int id = Int32.Parse(customerIdCBox.Items[index].ToString());
            currentCustomer = context.Customers.Find(id);   // Load Customer ID=1
            DisplayCustomer();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                currentCustomer.Name = nameTxt.Text;
                currentCustomer.Address = addressTxt.Text;
                currentCustomer.City = cityTxt.Text;
                //currentCustomer.State = stateTxt.Text;
                currentCustomer.State = stateComboBox.SelectedValue.ToString();
                currentCustomer.ZipCode = postalTxt.Text;

                context.SaveChanges();
                DisplayCustomer();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                if (context.Entry(currentCustomer).State ==
                    EntityState.Detached)
                {
                    MessageBox.Show(
                        "Another user has deleted that customer.",
                        "Concurrency Error");                    
                }
                else
                {
                    string message =
                        "Another user has updated that customer.\n" +
                        "The current database values will be displayed.";
                    MessageBox.Show(message, "Concurrency Error");
                    this.DisplayCustomer();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "DB error: " + ex.Message + "\n";
                MessageBox.Show(errorMessage);
            }
    }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
            discardBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Create a new object to hold the new customer information
            Customer newCustomer = new Customer()
            {
                Name = nameTxt.Text,
                Address = addressTxt.Text,
                City = cityTxt.Text,
                //State = stateTxt.Text,
                State = stateComboBox.SelectedValue.ToString(),
                ZipCode = postalTxt.Text
            };

            context.Customers.Add(newCustomer); // Add the new customer
            context.SaveChanges();  // Save the changes to the DB
            currentCustomer = newCustomer;
            DisplayCustomer();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            context.Customers.Remove(currentCustomer);
            context.SaveChanges();
            currentCustomer = context.Customers.First();   // Load the first Customer
            DisplayCustomer();
        }

        private void customerIdCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customerIdCBox.SelectedItem);
            currentCustomer = context.Customers.Find(id);   // Load Customer ID=1
            DisplayCustomer();
        }

        private void invoicesBtn_Click(object sender, EventArgs e)
        {
            InvoicesExplicit invoicesFrm = new InvoicesExplicit();
            invoicesFrm.ShowDialog();
        }
    }
}
