// Copyright © 2022 Omar ElSaadany | All rights reserved
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BucketSortAlgo
{
    public partial class BucketAlg : Form
    {
        public BucketAlg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void InsertionSort(List<double>array,int size)
        {
            for(int i = 1; i < size; i++)
            {
                double k = array[i];
                int j = i - 1;

                while (j >= 0 && k < array[j] ) 
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = k;
            }
        }

        void BucketSort(double[] arr,int n)
        {
            if(n>0)
            {
                List<double>[] Buckets = new List<double>[n];

                for(int i=0;i<n;i++)
                {
                    Buckets[i] = new List<double>();
                }

                for(int i = 0; i < n; i++)
                {
                    double indx = arr[i] * n;
                    Buckets[(int)indx].Add(arr[i]);
                }

                for(int i = 0; i < n; i++)
                {
                    InsertionSort(Buckets[i], Buckets[i].Count);
                }

                int index = 0;
                int dt = 0;

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < Buckets[i].Count;j++)
                    {
                        arr[index++] = Buckets[i][j];
                        OutPut.Items.Add(arr[dt]);
                        dt++;
                    }
                }
            }
        }

        void ClearOutPut()
        {
            OutPut.Items.Clear();
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            EnteredData.Select();
            double value;
            if(double.TryParse(EnteredData.Text,out value))
            { 
                ListData.Items.Add(value); ClearOutPut();
            }
            else
            { 
                MessageBox.Show("Enter No. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            EnteredData.Clear();
        }

        private void SortData_Click(object sender, EventArgs e)
        {
            ClearOutPut();
            int n = ListData.Items.Count;
            double[] values = new double[n];

            for(int i=0;i<n;i++)
            {
                values[i] = Convert.ToDouble(ListData.Items[i]);
            }
            BucketSort(values, n);
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            ListData.Items.Clear();
            ClearOutPut();
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            if (ListData.SelectedItem != null)
            { 
                ListData.Items.Remove(ListData.SelectedItem);
                ClearOutPut(); 
            }
            else
            {
                MessageBox.Show("Select Element First", "UNSELECTED ELEMENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnteredData_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
// Copyright © 2022 Omar ElSaadany | All rights reserved
