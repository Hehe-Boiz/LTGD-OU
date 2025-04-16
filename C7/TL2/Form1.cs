using System.IO.Compression;
using System.Text.Json;

namespace TL2
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private ShapeType currentShapeType = ShapeType.Rectangle;
        private Color currentColor = Color.Red;
        Point pOld;
        bool isDrawing = false;
        private Rectangle currentRect;

        private Bitmap canvas;
        private Graphics gBitmap;


        public Form1()
        {
            InitializeComponent();
        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formopition formopition = new Formopition(currentShapeType, currentColor);


            if (formopition.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật lại shape type và color dựa trên lựa chọn
                currentShapeType = formopition.SelectedShapeType;
                currentColor = formopition.SelectedColor;
            }
        }

        private void frmDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                int x = Math.Min(pOld.X, e.X);
                int y = Math.Min(pOld.Y, e.Y);
                int width = Math.Abs(e.X - pOld.X);
                int height = Math.Abs(e.Y - pOld.Y);

                currentRect = new Rectangle(x, y, width, height);
                Invalidate(); // Yêu cầu vẽ lại
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
            isDrawing = true;
        }

        private void frmDraw_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ từng shape trong danh sách
            //foreach (var shape in shapes)
            //{
            //    shape.Draw(e.Graphics);
            //}

            e.Graphics.DrawImageUnscaled(canvas, Point.Empty);

            if (isDrawing && currentRect != Rectangle.Empty)
            {
                Shape tempShape = new Shape(currentShapeType, currentRect, currentColor);
                tempShape.Draw(e.Graphics);
            }
        }

        private void clearALlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            gBitmap.Clear(Color.White);
            Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Shape newShape = new Shape(currentShapeType, currentRect, currentColor);
                // Thêm shape mới
                shapes.Add(newShape);
                newShape.Draw(gBitmap);
                currentRect = Rectangle.Empty;

                Invalidate(); // Vẽ lại
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Empl file (*.empl)|*.empl";
            saveFileDialog.DefaultExt = "empl";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            { 

                canvas.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                gBitmap.Clear(Color.White);
                shapes.Clear();
                Invalidate(); Invalidate();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Empl file (*.empl)|*.empl";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap loadedCanvas = new Bitmap(openDialog.FileName);

                // Dispose of existing resources
                if (canvas != null)
                    canvas.Dispose();

                if (gBitmap != null)
                    gBitmap.Dispose();

                // Set the loaded bitmap as the current canvas
                canvas = loadedCanvas;
                gBitmap = Graphics.FromImage(canvas);

                // Clear the shapes list as we're now working with the bitmap directly
                shapes.Clear();

                // Redraw the form with the new canvas
                Invalidate();

                MessageBox.Show("File opened successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            gBitmap = Graphics.FromImage(canvas);
            gBitmap.Clear(Color.White);
        }

       
    }
}
