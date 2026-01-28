/*
 * Au'rias Holcombe
 * CPT - 185 - A01H
 * Lab 8
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHolcombe_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void buttSortAscending_Click(object sender, EventArgs e)
        {
            //This sorts by Population (Ascending)
            this.cityTableAdapter.SortA(this.populationDBDataSet.City);
        }

        private void buttSortDescending_Click(object sender, EventArgs e)
        {
            //This sorts by Population (Descending)
            this.cityTableAdapter.SortD(this.populationDBDataSet.City);
        }

        private void buttAveragePop_Click(object sender, EventArgs e)
        {
            try
            {
                //This finds the Average Population
                double averagePop;

                averagePop = (double)this.cityTableAdapter.Avg();

                MessageBox.Show($"The Population average is: {averagePop}");
            }
            catch
            {
                MessageBox.Show("Bad Data...");
            }
        }

        private void buttTotalPop_Click(object sender, EventArgs e)
        {
            try
            {
                //This finds the Total Population
                double sumPop;

                sumPop = (double)this.cityTableAdapter.Sum();

                MessageBox.Show($"The Population total is: {sumPop}");
            }
            catch
            {
                MessageBox.Show("Bad Data...");
            }
        }

        private void buttCities_Click(object sender, EventArgs e)
        {
            //This sorts by cities
            this.cityTableAdapter.CityOrder(this.populationDBDataSet.City);
        }

        private void buttHighestPop_Click(object sender, EventArgs e)
        {
            try
            {
                //This sorts by Highest Population
                double max;
                max = (double)this.cityTableAdapter.Max();
                MessageBox.Show($"The Biggest Population size is: {max}");
            }
            catch
            {
                MessageBox.Show("Bad Data...");
            }
        }

        private void buttLowestPop_Click(object sender, EventArgs e)
        {
            try
            {
                //This sorts by Lowest Population
                double min;
                min = (double)this.cityTableAdapter.Min();
                MessageBox.Show($"The Smallest Population size is: {min}");
            }
            catch
            {
                MessageBox.Show("Bad Data...");
            }
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            //This Exits Form
            this.Close();
        }
    }
}
