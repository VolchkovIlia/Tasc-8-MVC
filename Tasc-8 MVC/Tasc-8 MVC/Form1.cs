using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tasc_8_MVC
{
    public partial class Form1 : Form
    {
        //Связывем представление с контроллером,
        //чтобы получить и установить значения m и b и рассчитать значение y.
        private LinearEquationController _controller;
        private double _x;
        public Form1()
        {
            InitializeComponent();
            _controller = new LinearEquationController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Получаем значения m и b из текстовых полей,
        //устанавливаем их в контроллере и рассчитываем значение y
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double.TryParse(xTextBox.Text, out _x);
            double.TryParse(mTextBox.Text, out double m);
            double.TryParse(bTextBox.Text, out double b);

            _controller.SetSlope(m);
            _controller.SetYIntercept(b);

            double y = _controller.CalculateY(_x);
            yTextBox.Text = y.ToString();
        }
        //Обновляем значение y при изменении значения x
        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(xTextBox.Text, out _x);
            double y = _controller.CalculateY(_x);
            yTextBox.Text = y.ToString();
        }
    }
}
