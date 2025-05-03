using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            lstLeft.Items.Add(txtNhap.Text);
            txtNhap.Clear();
        }

        private void btMoveRight_Click(object sender, EventArgs e)
        {
            var selectItems = lstLeft.SelectedItems.Cast<object>().ToList();
            foreach (var item in selectItems)
            {
                lstRight.Items.Add(item);
                lstLeft.Items.Remove(item);
            }
        }

        private void btMoveLeft_Click(object sender, EventArgs e)
        {
            var selectItems = lstRight.SelectedItems.Cast<object>().ToList();
            foreach (var item in selectItems)
            {
                lstLeft.Items.Add(item);
                lstRight.Items.Remove(item);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var selectItemsLeft = lstLeft.SelectedItems.Cast<object>().ToList();
            foreach (var item in selectItemsLeft)
            {
                lstLeft.Items.Remove(item);
            }
            var selectItemsRight = lstRight.SelectedItems.Cast<object>().ToList();
            foreach (var item in selectItemsRight)
            {
                lstRight.Items.Remove(item);
            }
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            lstLeft.Items.Clear();
            lstRight.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = cbColor.SelectedItem.ToString();
            lstRight.BackColor = Color.FromName(selectedColor);
        }

    }
}
