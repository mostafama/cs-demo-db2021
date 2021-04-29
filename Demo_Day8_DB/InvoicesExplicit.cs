using Demo_Day8_DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Demo_Day8_DB
{
    public partial class InvoicesExplicit : Form
    {
        MMABooksContext context;
        Invoice currentInvoice; 
        public InvoicesExplicit()
        {
            InitializeComponent();
        }

        private void InvoicesExplicit_Load(object sender, EventArgs e)
        {
            context = new MMABooksContext();
            invoicesDGrid.AutoGenerateColumns = false;

            // Load all invoices and also all InvoiceLineItems
            //invoicesDGrid.DataSource = 
            //    context.Invoices.Include("InvoiceLineItems").ToList();

            // Load only the invoices
            invoicesDGrid.DataSource = context.Invoices.ToList();
        }

        private void invoicesDGrid_SelectionChanged(object sender, EventArgs e)
        {   
            if (invoicesDGrid.SelectedCells.Count > 0)
            {
                // To get the ID of the selected Invoice
                int index = invoicesDGrid.SelectedCells[0].RowIndex;
                int invoiceId = (int)invoicesDGrid.Rows[index].Cells[0].Value;

                currentInvoice = context.Invoices.Find(invoiceId);

                // This will load the InvoiceLineItems only for the currently selected invoice 
                //if (!context.Entry(currentInvoice)
                //     .Collection("InvoiceLineItems").IsLoaded)
                //{
                //    context.Entry(currentInvoice)
                //        .Collection("InvoiceLineItems").Load();
                //}

                // Display the invoice line items for the selected invoice 
                invoiceDetailsDGrid.DataSource =
                    currentInvoice.InvoiceLineItems.ToList();

            }
        }
    }
}
