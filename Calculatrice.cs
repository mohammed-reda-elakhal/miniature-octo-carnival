namespace SimpleCalculatrice
{
    public partial class Calculatrice : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {

        }


       #region Operation numeric

             #region Zero button
                private void button4_Click(object sender, EventArgs e)
                    {
                    if( textBox.Text == "0")
                    {
                        textBox.Text = "0";
                    }
                    else
                    {
                        textBox.Text += "0";
                    }
                    
                    }
            #endregion

             #region One Button
            private void One_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
            }
            #endregion

             #region Two Button
            private void Two_Click(object sender, EventArgs e)
            {
                if (textBox.Text == "0")
                {
                    textBox.Text = "2";
                }
                else
                {
                    textBox.Text += "2";
                }
             }

            #endregion

             #region Three Button
            private void Three_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }
            #endregion

             #region Four Button
            private void four_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }
            #endregion    }

             #region Five Button
            private void button6_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }
            #endregion

             #region Sixe Button
            private void Sixe_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }
            #endregion

             #region Siven Button
            private void Siven_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }
            #endregion

             #region Eight Button
            private void Eight_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }
            #endregion

             #region Nine Button
            private void Nine_Click(object sender, EventArgs e)
            {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }
        #endregion

        #endregion

        #region Mines Button
        private void button14_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "-";
        }
        #endregion

        #region Equal Button
        private void button12_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst - valueSecond;
                    textBox.Text = Result.ToString();   
                    break;

                case "+":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst + valueSecond;
                    textBox.Text = Result.ToString();
                    break;

                case "*":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst * valueSecond;
                    textBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(textBox.Text);
                    if (valueSecond == 0)
                    {
                        Result = 0;
                    }
                    else
                    {
                        Result = valueFirst / valueSecond;
                    }
                    textBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = decimal.Parse(textBox.Text);
                    Result = valueFirst % valueSecond;
                    textBox.Text = Result.ToString();
                    break;
            }
        }
        #endregion

        #region Clear Button
        private void Clear_Click(object sender, EventArgs e)
        {
            valueSecond = 0.0m;
            valueFirst = 0.0m;
            textBox.Text = "0";
        }
        #endregion

       

        #region Dote Button
        private void Dote_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }
        #endregion

        #region Plus Button
        private void Plus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "+";
        }
        #endregion

        #region Divise Button
        private void Divise_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "/";
        }
        #endregion

        #region Multiple Button
        private void Multiple_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "*";
        }
        #endregion

        #region MinesPlus Button
        private void PlusMines_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("-"))
            {
                textBox.Text = textBox.Text.Trim('-');
            }
            else
            {
                textBox.Text = "-"+textBox.Text;
            }
        }
        #endregion

        #region Module Button
        private void Module_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "%";
        }
        #endregion

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }
    }
}