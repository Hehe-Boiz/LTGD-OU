using System;

namespace C3
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        Phanso ps1, ps2, ps3;
        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                int tuSo1 = int.Parse(txtTuso1.Text);
                int tuSo2 = int.Parse(txtTuso2.Text);
                int mauSo1 = int.Parse(txtMauso1.Text);
                int mauSo2 = int.Parse(txtMauso2.Text);

                ps1 = new Phanso(tuSo1, mauSo1);
                ps2 = new Phanso(tuSo2, mauSo2);
                ps3 = new Phanso();

                Button btn = (Button)sender;
                lbToanTu.Text = btn.Text;

                switch (btn.Text)
                {
                    case "+":
                        ps3 = Phanso.Cong(ps1, ps2);
                        break;
                    case "-":
                        ps3 = Phanso.Tru(ps1, ps2);
                        break;
                    case "*":
                        ps3 = Phanso.Nhan(ps1, ps2);
                        break;
                    case "/":
                        ps3 = Phanso.Chia(ps1, ps2);
                        break;
                }

                txtTuso3.Text = ps3.Tuso.ToString();
                txtMauso3.Text = ps3.Mauso.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai định dạng");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Lỗi chia cho 0");
            }

        }

        private Phanso gamePs1;
        private Phanso gamePs2;
        private Phanso gameCorrectAnswer;
        private string gameOperator;
        private Random random = new Random();

        private void GenerateNewQuestion()
        {
            try
            {
                int tu1 = random.Next(-10, 11);
                int mau1 = random.Next(1, 11) * (random.Next(0, 2) == 0 ? 1 : -1); 
                int tu2 = random.Next(-10, 11);
                int mau2 = random.Next(1, 11) * (random.Next(0, 2) == 0 ? 1 : -1);

                txtTuso1.Text = tu1.ToString();
                txtMauso1.Text = mau1.ToString();

                txtTuso2.Text = tu1.ToString();
                txtMauso2.Text = mau1.ToString();

                gamePs1 = new Phanso(tu1, mau1);
                gamePs2 = new Phanso(tu2, mau2);

                int opIndex = random.Next(0, 4); 
                string[] operators = { "+", "-", "*", "/" };
                gameOperator = operators[opIndex];

                // Tính đáp án đúng
                switch (gameOperator)
                {
                    case "+":
                        gameCorrectAnswer = Phanso.Cong(gamePs1, gamePs2);
                        break;
                    case "-":
                        gameCorrectAnswer = Phanso.Tru(gamePs1, gamePs2);
                        break;
                    case "*":
                        gameCorrectAnswer = Phanso.Nhan(gamePs1, gamePs2);
                        break;
                    case "/":
                        // Xử lý trường hợp chia cho 0
                        if (gamePs2.Tuso == 0)
                        {
                            GenerateNewQuestion();
                            return;
                        }
                        gameCorrectAnswer = Phanso.Chia(gamePs1, gamePs2);
                        break;
                }

                
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi khi tạo câu hỏi: {ex.Message}", "Lỗi Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CheckAnswer()
        {
            // Kiểm tra xem đã có câu hỏi chưa
            if (gameCorrectAnswer == null)
            {
                 lblGameStatus.Text = "Hãy tạo câu hỏi mới trước!";
                return;
            }

            try
            {
                if (!int.TryParse(txtTuso3.Text, out int userTu) ||
                    !int.TryParse(txtMauso3.Text, out int userMau))
                {
                    MessageBox.Show("Đáp án không hợp lệ. Vui lòng nhập số nguyên.", "Lỗi Đáp Án", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Phanso userAnswer = new Phanso(userTu, userMau); 

                if (userAnswer == gameCorrectAnswer)
                {
                     lblGameStatus.Text = "Chính xác! Tuyệt vời!";
                }
                else
                {
                     lblGameStatus.Text = $"Sai rồi! Đáp án đúng là: {gameCorrectAnswer.ToString()}";
                }
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi Đáp Án", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 lblGameStatus.Text = "Lỗi: Mẫu số đáp án không hợp lệ.";
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi khi kiểm tra đáp án: {ex.Message}", "Lỗi Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 lblGameStatus.Text = "Lỗi kiểm tra đáp án!";
            }
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
    }
}
