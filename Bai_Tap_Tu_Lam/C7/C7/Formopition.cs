using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C7
{
    public enum ShapeType
    {
        Rectangle,
        Ellipse,
        Triangle
    }

    public partial class Formopition : Form
    {
        public ShapeType SelectedShapeType { get; private set; }
        public Color SelectedColor { get; private set; }
        Color currentColor = Color.Red;
        public Formopition(ShapeType currentShapeType, Color currentColor)
        {
            InitializeComponent();
            SelectedShapeType = currentShapeType;
            SelectedColor = currentColor;
            button1.BackColor = SelectedColor;
        }

        private void Formopition_Load(object sender, EventArgs e)
        {
            // Thiết lập radio button phù hợp
            switch (SelectedShapeType)
            {
                case ShapeType.Rectangle:
                    rdHCN.Checked = true;
                    break;
                case ShapeType.Ellipse:
                    rdEll.Checked = true;
                    break;
                case ShapeType.Triangle:
                    rdTamGiac.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = SelectedColor; // Màu ban đầu
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SelectedColor = dlg.Color;
                    button1.BackColor = SelectedColor; // Cập nhật màu cho button
                    // Cập nhật hiển thị, ví dụ đổi màu background 1 ô panelPreview
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdHCN.Checked)
                SelectedShapeType = ShapeType.Rectangle;
            else if (rdEll.Checked)
                SelectedShapeType = ShapeType.Ellipse;
            else if (rdTamGiac.Checked)
                SelectedShapeType = ShapeType.Triangle;

            // Trả kết quả OK về form chính
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
