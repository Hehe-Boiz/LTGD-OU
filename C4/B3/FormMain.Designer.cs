namespace B3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label1 = new Label();
            txtHoten = new TextBox();
            label2 = new Label();
            dtNgaysinh = new DateTimePicker();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            btThem = new Button();
            btXoa = new Button();
            lbusername = new Label();
            listNhanvien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SmallImageList = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // txtHoten
            // 
            txtHoten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoten.Location = new Point(154, 32);
            txtHoten.Multiline = true;
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(252, 34);
            txtHoten.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh:";
            // 
            // dtNgaysinh
            // 
            dtNgaysinh.Format = DateTimePickerFormat.Custom;
            dtNgaysinh.Location = new Point(151, 87);
            dtNgaysinh.Name = "dtNgaysinh";
            dtNgaysinh.Size = new Size(255, 27);
            dtNgaysinh.TabIndex = 3;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(153, 151);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 24);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(237, 151);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(50, 24);
            rdNu.TabIndex = 5;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            btThem.Location = new Point(149, 199);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 6;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(307, 199);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 7;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // lbusername
            // 
            lbusername.BorderStyle = BorderStyle.Fixed3D;
            lbusername.Location = new Point(31, 318);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(375, 48);
            lbusername.TabIndex = 8;
            lbusername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listNhanvien
            // 
            listNhanvien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Họ tên";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Ngày sinh";
            listNhanvien.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listNhanvien.Location = new Point(424, 32);
            listNhanvien.Name = "listNhanvien";
            listNhanvien.Size = new Size(364, 406);
            listNhanvien.SmallImageList = SmallImageList;
            listNhanvien.TabIndex = 9;
            listNhanvien.UseCompatibleStateImageBehavior = false;
            listNhanvien.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ tên";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ngày sinh";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giới tính";
            columnHeader3.Width = 100;
            // 
            // SmallImageList
            // 
            SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
            SmallImageList.ImageStream = (ImageListStreamer)resources.GetObject("SmallImageList.ImageStream");
            SmallImageList.TransparentColor = Color.Transparent;
            SmallImageList.Images.SetKeyName(0, "OIP.jpg");
            SmallImageList.Images.SetKeyName(1, "lovepik-woman-avatar-free-vector-illustration-material-png-image_401265628_wh860.png");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listNhanvien);
            Controls.Add(lbusername);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(dtNgaysinh);
            Controls.Add(label2);
            Controls.Add(txtHoten);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoten;
        private Label label2;
        private DateTimePicker dtNgaysinh;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private Button btThem;
        private Button btXoa;
        private Label lbusername;
        private ListView listNhanvien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ImageList SmallImageList;
    }
}
