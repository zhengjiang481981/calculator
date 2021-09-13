using System;
using System.Windows.Forms;

namespace CalculatorApp
{
	public partial class Form1 : Form
	{
		//private const variables
		private const string NumberZero = "0";
		private const string NumberOne = "1";
		private const string NumberTwo = "2";
		private const string NumberThree = "3";
		private const string NumberFour = "4";
		private const string NumberFive = "5";
		private const string NumberSix = "6";
		private const string NumberSeven = "7";
		private const string NumberEight = "8";
		private const string NumberNine = "9";
		private const string DecimalText = ".";
		private const string CalculateActionPlus = "+";
		private const string CalculateActionDivide = "/";
		private const string CalculateActionMultiply = "*";
		private const string CalculateActionMinus = "-";
		private const string Error = "Error";
		

		//private variables
		private string _firstNumber = "";
		private string _secondNumber = "";
		private string _inputValue = "";
		private decimal _result;
		private string _calculateAction = "";


		public Form1()
		{
			InitializeComponent();
		}

		private void button_one_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberOne;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_two_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberTwo;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_three_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberThree;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_four_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberFour;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_five_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberFive;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_six_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberSix;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_seven_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberSeven;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_eight_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberEight;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_nine_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberNine;
			SetFirstAndSecondNumber();
			displayScreen.Text += _inputValue;
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			_inputValue = "";
			_firstNumber = "";
			_secondNumber = "";
			_calculateAction = "";
			displayScreen.Text = NumberZero;
		}

		private void button_divide_Click(object sender, EventArgs e)
		{
			CalculateResult();
			_calculateAction = CalculateActionDivide;
			_inputValue = "";
		}

		private void button_multiply_Click(object sender, EventArgs e)
		{
			CalculateResult();
			_calculateAction = CalculateActionMultiply;
			_inputValue = "";
		}

		private void button_minus_Click(object sender, EventArgs e)
		{
			CalculateResult();
			_calculateAction = CalculateActionMinus;
			_inputValue = "";
		}

		private void button_plus_Click(object sender, EventArgs e)
		{
			CalculateResult();
			_calculateAction = CalculateActionPlus;
			_inputValue = "";
		}

		private void button_equal_Click(object sender, EventArgs e)
		{
			CalculateResult();
		}

		private void button_zero_Click(object sender, EventArgs e)
		{
			displayScreen.Text = "";
			_inputValue += NumberZero;
			if (_calculateAction == "")
			{
				_firstNumber = _inputValue;
			}
			else
			{
				_secondNumber = _inputValue;
			}
			displayScreen.Text = _inputValue;
		}

		private void CalculateResult()
		{
			if (_firstNumber != "" && _secondNumber != "")
			{
				var firstNumberInt = Convert.ToDecimal(_firstNumber);
				var secondNumberInt = Convert.ToDecimal(_secondNumber);
				if (_calculateAction == CalculateActionPlus)
				{
					_result = firstNumberInt + secondNumberInt;
				}
				else if (_calculateAction == CalculateActionMinus)
				{
					_result = firstNumberInt - secondNumberInt;
				}
				else if (_calculateAction == CalculateActionMultiply)
				{
					_result = firstNumberInt * secondNumberInt;
				}
				else
				{
					if (secondNumberInt != 0)
					{
						_result = Convert.ToDecimal(firstNumberInt / secondNumberInt);
					}
					else
					{
						displayScreen.Text = Error;
						_firstNumber = "";
					}
				}

				if (displayScreen.Text != Error)
				{
					displayScreen.Text = _result.ToString("0.##");
					_firstNumber = _result.ToString("0.##");
				}

				_secondNumber = "";
				_inputValue = "";
				_calculateAction = "";
			}
		}

		private void SetFirstAndSecondNumber()
		{
			if (_calculateAction == "")
			{
				_firstNumber = _inputValue;
			}
			else
			{
				_secondNumber = _inputValue;
			}
		}
	}
}
