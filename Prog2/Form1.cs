//N5284
//Program 2
//March 5, 2019
//CIS 199-75
//This program takes a users inputed taxable income amount and calculates their marginal tax rate and amount of tax due

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        //When the "Calculate Tax" button is clicked do the following:
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //Variable Dictionary
            //Tax Rates
            const double TAX_RATE_ONE = 0.10;                   //1st marginal tax rate
            const double TAX_RATE_TWO = 0.12;                   //2nd marginal tax rate
            const double TAX_RATE_THREE = 0.22;                 //3rd marginal tax rate
            const double TAX_RATE_FOUR = 0.24;                  //4th marginal tax rate
            const double TAX_RATE_FIVE = 0.32;                  //5th marginal tax rate
            const double TAX_RATE_SIX = 0.35;                   //6th marginal tax rate
            const double TAX_RATE_SEVEN = 0.37;                 //7th marginal tax rate

            //Single
            const double SINGLE_THRESH_ONE = 9700;              //1st threshold for those filing as single
            const double SINGLE_THRESH_TWO = 39475;             //2nd threshold for those filing as single
            const double SINGLE_THRESH_THREE = 84200;           //3rd threshold for those filing as single
            const double SINGLE_THRESH_FOUR = 160725;           //4th threshold for those filing as single
            const double SINGLE_THRESH_FIVE = 204100;           //5th threshold for those filing as single
            const double SINGLE_THRESH_SIX = 510300;            //6th threshold for those filing as single

            //Married Filing Jointly
            const double MARRIED_JOINT_THRESH_ONE = 19400;      //1st threshold for married people filing jointly
            const double MARRIED_JOINT_THRESH_TWO = 78950;      //2nd threshold for married people filing jointly
            const double MARRIED_JOINT_THRESH_THREE = 168400;   //3rd threshold for married people filing jointly
            const double MARRIED_JOINT_THRESH_FOUR = 321450;    //4th threshold for married people filing jointly
            const double MARRIED_JOINT_THRESH_FIVE = 408200;    //5th threshold for married people filing jointly
            const double MARRIED_JOINT_THRESH_SIX = 612350;     //6th threshold for married people filing jointly

            //Head of Household
            const double HEAD_HOUSE_THRESH_ONE = 13850;         //1st threshold for those filing as the head of household
            const double HEAD_HOUSE_THRESH_TWO = 52850;         //2nd threshold for those filing as the head of household
            const double HEAD_HOUSE_THRESH_THREE = 84200;       //3rd threshold for those filing as the head of household
            const double HEAD_HOUSE_THRESH_FOUR = 160700;       //4th threshold for those filing as the head of household
            const double HEAD_HOUSE_THRESH_FIVE = 204100;       //5th threshold for those filing as the head of household
            const double HEAD_HOUSE_THRESH_SIX = 510300;        //6th threshold for those filing as the head of household

            //Married Filing Separately
            const double MARRIED_SEP_THRESH_ONE = 9700;         //1st threshold for married people filing separately
            const double MARRIED_SEP_THRESH_TWO = 39475;        //2nd threshold for married people filing separately
            const double MARRIED_SEP_THRESH_THREE = 84200;      //3rd threshold for married people filing separately
            const double MARRIED_SEP_THRESH_FOUR = 160725;      //4th threshold for married people filing separately
            const double MARRIED_SEP_THRESH_FIVE = 204100;      //5th threshold for married people filing separately
            const double MARRIED_SEP_THRESH_SIX = 306175;       //6th threshold for married people filing separately

            const int MAKE_PERCENT = 100;                        //Make the 

            //Inputs
            double incomeAmount;                                //User inputed income amount

            //Outputs
            double marginalRate;                                //The users marginal tax rate
            double taxDue;                                      //The amount of tax the user owes

            //Check to see if input is valid
            if (Double.TryParse(taxIncomeTxt.Text, out incomeAmount) && incomeAmount >= 0)
            {
                //Single
                if (singleRadioBtn.Checked)
                {
                    if (incomeAmount <= SINGLE_THRESH_ONE)
                    {
                        marginalRate = TAX_RATE_ONE;
                        taxDue = incomeAmount * TAX_RATE_ONE;
                    }

                    else if (incomeAmount <= SINGLE_THRESH_TWO)
                    {
                        marginalRate = TAX_RATE_TWO;
                        taxDue = SINGLE_THRESH_ONE * TAX_RATE_ONE + (incomeAmount - SINGLE_THRESH_ONE) * TAX_RATE_TWO;
                    }

                    else if (incomeAmount <= SINGLE_THRESH_THREE)
                    {
                        marginalRate = TAX_RATE_THREE;
                        taxDue = SINGLE_THRESH_ONE * TAX_RATE_ONE + (SINGLE_THRESH_TWO - SINGLE_THRESH_ONE) * TAX_RATE_TWO + (incomeAmount - SINGLE_THRESH_TWO) * TAX_RATE_THREE;
                    }

                    else if (incomeAmount <= SINGLE_THRESH_FOUR)
                    {
                        marginalRate = TAX_RATE_FOUR;
                        taxDue = SINGLE_THRESH_ONE * TAX_RATE_ONE + (SINGLE_THRESH_TWO - SINGLE_THRESH_ONE) * TAX_RATE_TWO + (SINGLE_THRESH_THREE - SINGLE_THRESH_TWO) * TAX_RATE_THREE + (incomeAmount - SINGLE_THRESH_THREE) * TAX_RATE_FOUR;
                    }

                    else if (incomeAmount <= SINGLE_THRESH_FIVE)
                    {
                        marginalRate = TAX_RATE_FIVE;
                        taxDue = SINGLE_THRESH_ONE * TAX_RATE_ONE + (SINGLE_THRESH_TWO - SINGLE_THRESH_ONE) * TAX_RATE_TWO + (SINGLE_THRESH_THREE - SINGLE_THRESH_TWO) * TAX_RATE_THREE + (SINGLE_THRESH_FOUR - SINGLE_THRESH_THREE) * TAX_RATE_FOUR + (incomeAmount - SINGLE_THRESH_FOUR) * TAX_RATE_FIVE;
                    }

                    else if (incomeAmount <= SINGLE_THRESH_SIX)
                    {
                        marginalRate = TAX_RATE_SIX;
                        taxDue = SINGLE_THRESH_ONE * TAX_RATE_ONE + (SINGLE_THRESH_TWO - SINGLE_THRESH_ONE) * TAX_RATE_TWO + (SINGLE_THRESH_THREE - SINGLE_THRESH_TWO) * TAX_RATE_THREE + (SINGLE_THRESH_FOUR - SINGLE_THRESH_THREE) * TAX_RATE_FOUR + (SINGLE_THRESH_FIVE - SINGLE_THRESH_FOUR) * TAX_RATE_FIVE + (incomeAmount - SINGLE_THRESH_FIVE) * TAX_RATE_SIX;
                    }

                    else
                    {
                        marginalRate = TAX_RATE_SEVEN;
                        taxDue = SINGLE_THRESH_ONE * TAX_RATE_ONE + (SINGLE_THRESH_TWO - SINGLE_THRESH_ONE) * TAX_RATE_TWO + (SINGLE_THRESH_THREE - SINGLE_THRESH_TWO) * TAX_RATE_THREE + (SINGLE_THRESH_FOUR - SINGLE_THRESH_THREE) * TAX_RATE_FOUR + (SINGLE_THRESH_FIVE - SINGLE_THRESH_FOUR) * TAX_RATE_FIVE + (SINGLE_THRESH_SIX - SINGLE_THRESH_FIVE) * TAX_RATE_SIX + (incomeAmount - SINGLE_THRESH_SIX) * TAX_RATE_SEVEN;
                    }

                    //Output to Labels
                    outMarginalTaxLbl.Text = $"{marginalRate * MAKE_PERCENT}%";
                    outIncomeTaxLbl.Text = $"{taxDue:C}";
                }

                //Married Filing Jointly
                else if (marriedJointRadioBtn.Checked)
                {
                    if (incomeAmount <= MARRIED_JOINT_THRESH_ONE)
                    {
                        marginalRate = TAX_RATE_ONE;
                        taxDue = incomeAmount * TAX_RATE_ONE;
                    }

                    else if (incomeAmount <= MARRIED_JOINT_THRESH_TWO)
                    {
                        marginalRate = TAX_RATE_TWO;
                        taxDue = MARRIED_JOINT_THRESH_ONE * TAX_RATE_ONE + (incomeAmount - MARRIED_JOINT_THRESH_ONE) * TAX_RATE_TWO;
                    }

                    else if (incomeAmount <= MARRIED_JOINT_THRESH_THREE)
                    {
                        marginalRate = TAX_RATE_THREE;
                        taxDue = MARRIED_JOINT_THRESH_ONE * TAX_RATE_ONE + (MARRIED_JOINT_THRESH_TWO - MARRIED_JOINT_THRESH_ONE) * TAX_RATE_TWO + (incomeAmount - MARRIED_JOINT_THRESH_TWO) * TAX_RATE_THREE;
                    }

                    else if (incomeAmount <= MARRIED_JOINT_THRESH_FOUR)
                    {
                        marginalRate = TAX_RATE_FOUR;
                        taxDue = MARRIED_JOINT_THRESH_ONE * TAX_RATE_ONE + (MARRIED_JOINT_THRESH_TWO - MARRIED_JOINT_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_JOINT_THRESH_THREE - MARRIED_JOINT_THRESH_TWO) * TAX_RATE_THREE + (incomeAmount - MARRIED_JOINT_THRESH_THREE) * TAX_RATE_FOUR;
                    }

                    else if (incomeAmount <= MARRIED_JOINT_THRESH_FIVE)
                    {
                        marginalRate = TAX_RATE_FIVE;
                        taxDue = MARRIED_JOINT_THRESH_ONE * TAX_RATE_ONE + (MARRIED_JOINT_THRESH_TWO - MARRIED_JOINT_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_JOINT_THRESH_THREE - MARRIED_JOINT_THRESH_TWO) * TAX_RATE_THREE + (MARRIED_JOINT_THRESH_FOUR - MARRIED_JOINT_THRESH_THREE) * TAX_RATE_FOUR + (incomeAmount - MARRIED_JOINT_THRESH_FOUR) * TAX_RATE_FIVE;
                    }

                    else if (incomeAmount <= MARRIED_JOINT_THRESH_SIX)
                    {
                        marginalRate = TAX_RATE_SIX;
                        taxDue = MARRIED_JOINT_THRESH_ONE * TAX_RATE_ONE + (MARRIED_JOINT_THRESH_TWO - MARRIED_JOINT_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_JOINT_THRESH_THREE - MARRIED_JOINT_THRESH_TWO) * TAX_RATE_THREE + (MARRIED_JOINT_THRESH_FOUR - MARRIED_JOINT_THRESH_THREE) * TAX_RATE_FOUR + (MARRIED_JOINT_THRESH_FIVE - MARRIED_JOINT_THRESH_FOUR) * TAX_RATE_FIVE + (incomeAmount - MARRIED_JOINT_THRESH_FIVE) * TAX_RATE_SIX;
                    }

                    else
                    {
                        marginalRate = TAX_RATE_SEVEN;
                        taxDue = MARRIED_JOINT_THRESH_ONE * TAX_RATE_ONE + (MARRIED_JOINT_THRESH_TWO - MARRIED_JOINT_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_JOINT_THRESH_THREE - MARRIED_JOINT_THRESH_TWO) * TAX_RATE_THREE + (MARRIED_JOINT_THRESH_FOUR - MARRIED_JOINT_THRESH_THREE) * TAX_RATE_FOUR + (MARRIED_JOINT_THRESH_FIVE - MARRIED_JOINT_THRESH_FOUR) * TAX_RATE_FIVE + (MARRIED_JOINT_THRESH_SIX - MARRIED_JOINT_THRESH_FIVE) * TAX_RATE_SIX + (incomeAmount - MARRIED_JOINT_THRESH_SIX) * TAX_RATE_SEVEN;
                    }

                    //Output to Labels
                    outMarginalTaxLbl.Text = $"{marginalRate * MAKE_PERCENT}%";
                    outIncomeTaxLbl.Text = $"{taxDue:C}";
                }

                //Head of Household
                else if (headHouseRadioBtn.Checked)
                {
                    if (incomeAmount <= HEAD_HOUSE_THRESH_ONE)
                    {
                        marginalRate = TAX_RATE_ONE;
                        taxDue = incomeAmount * TAX_RATE_ONE;
                    }

                    else if (incomeAmount <= HEAD_HOUSE_THRESH_TWO)
                    {
                        marginalRate = TAX_RATE_TWO;
                        taxDue = HEAD_HOUSE_THRESH_ONE * TAX_RATE_ONE + (incomeAmount - HEAD_HOUSE_THRESH_ONE) * TAX_RATE_TWO;
                    }

                    else if (incomeAmount <= HEAD_HOUSE_THRESH_THREE)
                    {
                        marginalRate = TAX_RATE_THREE;
                        taxDue = HEAD_HOUSE_THRESH_ONE * TAX_RATE_ONE + (HEAD_HOUSE_THRESH_TWO - HEAD_HOUSE_THRESH_ONE) * TAX_RATE_TWO + (incomeAmount - HEAD_HOUSE_THRESH_TWO) * TAX_RATE_THREE;
                    }

                    else if (incomeAmount <= HEAD_HOUSE_THRESH_FOUR)
                    {
                        marginalRate = TAX_RATE_FOUR;
                        taxDue = HEAD_HOUSE_THRESH_ONE * TAX_RATE_ONE + (HEAD_HOUSE_THRESH_TWO - HEAD_HOUSE_THRESH_ONE) * TAX_RATE_TWO + (HEAD_HOUSE_THRESH_THREE - HEAD_HOUSE_THRESH_TWO) * TAX_RATE_THREE + (incomeAmount - HEAD_HOUSE_THRESH_THREE) * TAX_RATE_FOUR;
                    }

                    else if (incomeAmount <= HEAD_HOUSE_THRESH_FIVE)
                    {
                        marginalRate = TAX_RATE_FIVE;
                        taxDue = HEAD_HOUSE_THRESH_ONE * TAX_RATE_ONE + (HEAD_HOUSE_THRESH_TWO - HEAD_HOUSE_THRESH_ONE) * TAX_RATE_TWO + (HEAD_HOUSE_THRESH_THREE - HEAD_HOUSE_THRESH_TWO) * TAX_RATE_THREE + (HEAD_HOUSE_THRESH_FOUR - HEAD_HOUSE_THRESH_THREE) * TAX_RATE_FOUR + (incomeAmount - HEAD_HOUSE_THRESH_FOUR) * TAX_RATE_FIVE;
                    }

                    else if (incomeAmount <= HEAD_HOUSE_THRESH_SIX)
                    {
                        marginalRate = TAX_RATE_SIX;
                        taxDue = HEAD_HOUSE_THRESH_ONE * TAX_RATE_ONE + (HEAD_HOUSE_THRESH_TWO - HEAD_HOUSE_THRESH_ONE) * TAX_RATE_TWO + (HEAD_HOUSE_THRESH_THREE - HEAD_HOUSE_THRESH_TWO) * TAX_RATE_THREE + (HEAD_HOUSE_THRESH_FOUR - HEAD_HOUSE_THRESH_THREE) * TAX_RATE_FOUR + (HEAD_HOUSE_THRESH_FIVE - HEAD_HOUSE_THRESH_FOUR) * TAX_RATE_FIVE + (incomeAmount - HEAD_HOUSE_THRESH_FIVE) * TAX_RATE_SIX;
                    }

                    else
                    {
                        marginalRate = TAX_RATE_SEVEN;
                        taxDue = HEAD_HOUSE_THRESH_ONE * TAX_RATE_ONE + (HEAD_HOUSE_THRESH_TWO - HEAD_HOUSE_THRESH_ONE) * TAX_RATE_TWO + (HEAD_HOUSE_THRESH_THREE - HEAD_HOUSE_THRESH_TWO) * TAX_RATE_THREE + (HEAD_HOUSE_THRESH_FOUR - HEAD_HOUSE_THRESH_THREE) * TAX_RATE_FOUR + (HEAD_HOUSE_THRESH_FIVE - HEAD_HOUSE_THRESH_FOUR) * TAX_RATE_FIVE + (HEAD_HOUSE_THRESH_SIX - HEAD_HOUSE_THRESH_FIVE) * TAX_RATE_SIX + (incomeAmount - HEAD_HOUSE_THRESH_SIX) * TAX_RATE_SEVEN;
                    }

                    //Output to Labels
                    outMarginalTaxLbl.Text = $"{marginalRate * MAKE_PERCENT}%";
                    outIncomeTaxLbl.Text = $"{taxDue:C}";
                }

                //Married Filing Separately
                else
                {
                    if (incomeAmount <= MARRIED_SEP_THRESH_ONE)
                    {
                        marginalRate = TAX_RATE_ONE;
                        taxDue = incomeAmount * TAX_RATE_ONE;
                    }

                    else if (incomeAmount <= MARRIED_SEP_THRESH_TWO)
                    {
                        marginalRate = TAX_RATE_TWO;
                        taxDue = MARRIED_SEP_THRESH_ONE * TAX_RATE_ONE + (incomeAmount - MARRIED_SEP_THRESH_ONE) * TAX_RATE_TWO;
                    }

                    else if (incomeAmount <= MARRIED_SEP_THRESH_THREE)
                    {
                        marginalRate = TAX_RATE_THREE;
                        taxDue = MARRIED_SEP_THRESH_ONE * TAX_RATE_ONE + (MARRIED_SEP_THRESH_TWO - MARRIED_SEP_THRESH_ONE) * TAX_RATE_TWO + (incomeAmount - MARRIED_SEP_THRESH_TWO) * TAX_RATE_THREE;
                    }

                    else if (incomeAmount <= MARRIED_SEP_THRESH_FOUR)
                    {
                        marginalRate = TAX_RATE_FOUR;
                        taxDue = MARRIED_SEP_THRESH_ONE * TAX_RATE_ONE + (MARRIED_SEP_THRESH_TWO - MARRIED_SEP_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_SEP_THRESH_THREE - MARRIED_SEP_THRESH_TWO) * TAX_RATE_THREE + (incomeAmount - MARRIED_SEP_THRESH_THREE) * TAX_RATE_FOUR;
                    }

                    else if (incomeAmount <= MARRIED_SEP_THRESH_FIVE)
                    {
                        marginalRate = TAX_RATE_FIVE;
                        taxDue = MARRIED_SEP_THRESH_ONE * TAX_RATE_ONE + (MARRIED_SEP_THRESH_TWO - MARRIED_SEP_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_SEP_THRESH_THREE - MARRIED_SEP_THRESH_TWO) * TAX_RATE_THREE + (MARRIED_SEP_THRESH_FOUR - MARRIED_SEP_THRESH_THREE) * TAX_RATE_FOUR + (incomeAmount - MARRIED_SEP_THRESH_FOUR) * TAX_RATE_FIVE;
                    }

                    else if (incomeAmount <= MARRIED_SEP_THRESH_SIX)
                    {
                        marginalRate = TAX_RATE_SIX;
                        taxDue = MARRIED_SEP_THRESH_ONE * TAX_RATE_ONE + (MARRIED_SEP_THRESH_TWO - MARRIED_SEP_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_SEP_THRESH_THREE - MARRIED_SEP_THRESH_TWO) * TAX_RATE_THREE + (MARRIED_SEP_THRESH_FOUR - MARRIED_SEP_THRESH_THREE) * TAX_RATE_FOUR + (MARRIED_SEP_THRESH_FIVE - MARRIED_SEP_THRESH_FOUR) * TAX_RATE_FIVE + (incomeAmount - MARRIED_SEP_THRESH_FIVE) * TAX_RATE_SIX;
                    }

                    else
                    {
                        marginalRate = TAX_RATE_SEVEN;
                        taxDue = MARRIED_SEP_THRESH_ONE * TAX_RATE_ONE + (MARRIED_SEP_THRESH_TWO - MARRIED_SEP_THRESH_ONE) * TAX_RATE_TWO + (MARRIED_SEP_THRESH_THREE - MARRIED_SEP_THRESH_TWO) * TAX_RATE_THREE + (MARRIED_SEP_THRESH_FOUR - MARRIED_SEP_THRESH_THREE) * TAX_RATE_FOUR + (MARRIED_SEP_THRESH_FIVE - MARRIED_SEP_THRESH_FOUR) * TAX_RATE_FIVE + (MARRIED_SEP_THRESH_SIX - MARRIED_SEP_THRESH_FIVE) * TAX_RATE_SIX + (incomeAmount - MARRIED_SEP_THRESH_SIX) * TAX_RATE_SEVEN;
                    }

                    //Output to Labels
                    outMarginalTaxLbl.Text = $"{marginalRate * MAKE_PERCENT}%";
                    outIncomeTaxLbl.Text = $"{taxDue:C}";
                }
            }

            //If the input is not valid
            else
            {
                MessageBox.Show("Please input a valid taxable income amount");
            }
        }
    }
}
