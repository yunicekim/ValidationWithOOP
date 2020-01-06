using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YKAssignment5.YKUtilityClasses;
/*
 * This is for practicing OOP 
 * 
 * The program is to validate whether typed string right format or not
 * 
 * Revision History
 *  April 14, 2019 Created by Yunice Kim
 *  
 */
namespace YKAssignment5
{
    public partial class YKAssignment5 : Form
    {
        public YKAssignment5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// validate all inputs correct and reformat if it is not right format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (YKNumericUtilities.IsNumeric(txtNumeric.Text))
            {
                lblNumericResult.Text = "Inputed String is Numeric";
            }
            else
            {
                lblNumericResult.Text = "Inputed String is not Numeric";
            }

            if (YKNumericUtilities.IsInteger(txtInteger.Text))
            {
                lblIntegerResult.Text = "Inputed String is Integer";
            }
            else
            {
                lblIntegerResult.Text = "Inputed String is not Integer";
            }

            string result = "";
            result = YKNumericUtilities.MakeNumber(txtMakeNumbers.Text);
            if ( result == null)
            {
                lblMakeNumbersResult.Text = "Making Numbers is failed";
            }
            else
            {
                lblMakeNumbersResult.Text = result.ToString();
            }

            lblNameResult.Text = YKStringUtilities.Capitalize(txtName.Text);

            lblAddressResult.Text = YKStringUtilities.Capitalize(txtAddress.Text);

            lblCityResult.Text = YKStringUtilities.Capitalize(txtCity.Text);

            if (YKValidations.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                lblPhoneNumberValid.Text = "Phone number is valid";

                lblPhoneNumberResult.Text = YKStringUtilities.FormatPhoneNumber(txtPhoneNumber.Text);
            }
            else
            {
                lblPhoneNumberValid.Text = "Phone number is not valid";
            }


            if (YKValidations.ValidateCanadianPostalCode(txtPostalCode.Text))
            {
                lblPostalCodeValid.Text = "Postcal Code is valid";

                lblPostalCodeResult.Text = YKStringUtilities.FormatCanadianPostalCode(txtPostalCode.Text);
            }
            else
            {
                lblPostalCodeValid.Text = "Postcal Code is not valid";
            }

            if (YKValidations.ValidateUPZipCode(txtUSPostalCode.Text))
            {
                lblUSPostalCodeValid.Text = "US Postcal Code is valid";

                lblUSPostalCodeResult.Text = YKStringUtilities.FormatUSZipCode(txtUSPostalCode.Text);
            }
            else
            {
                lblUSPostalCodeValid.Text = "US Postcal Code is not valid";
            }

            lblFullNameResult.Text = YKStringUtilities.MakeFullName(txtFirstName.Text, txtLastName.Text);
        }

        /// <summary>
        /// handle the textbox for typing only digit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            YKNumericUtilities.KeyPressEvent(e);
        }

        /// <summary>
        /// reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInteger.Text = "";
            lblIntegerResult.Text = "";

            txtNumeric.Text = "";
            lblNumericResult.Text = "";

            txtMakeNumbers.Text = "";
            lblMakeNumbersResult.Text = "";

            txtName.Text = "";
            lblNameResult.Text = "";

            txtAddress.Text = "";
            lblAddressResult.Text = "";

            txtCity.Text = "";
            lblCityResult.Text = "";

            txtPhoneNumber.Text = "";
            lblPhoneNumberResult.Text = "";
            lblPhoneNumberValid.Text = "";

            txtPostalCode.Text = "";
            lblPostalCodeResult.Text = "";
            lblPostalCodeValid.Text = "";

            txtUSPostalCode.Text = "";
            lblUSPostalCodeResult.Text = "";
            lblUSPostalCodeValid.Text = "";

            txtFirstName.Text = "";
            txtLastName.Text = "";
            lblFullNameResult.Text = "";
        }

        /// <summary>
        /// autofill the right value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoFillValid_Click(object sender, EventArgs e)
        {
            txtNumeric.Text = "12345";
            txtInteger.Text = "89.13";
            txtMakeNumbers.Text = "$827,93-8 6";
            txtName.Text = "yuniCe kiM ";
            txtAddress.Text = "  2883 homeR  watson";
            txtCity.Text = "kitcheNer";
            txtPhoneNumber.Text = "1233211234";
            txtPostalCode.Text = "n2c2h7";
            txtUSPostalCode.Text = "543219876";
            txtFirstName.Text = "yunice";
            txtLastName.Text = "kim";
        }

        /// <summary>
        /// autofill the invalid values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoFillInvalid_Click(object sender, EventArgs e)
        {
            txtNumeric.Text = "1ske2345";
            txtInteger.Text = "of89.13";
            txtMakeNumbers.Text = "$8fe27,93-8 6";
            txtName.Text = "yunIce kim";
            txtAddress.Text = "2883 homer wAtson";
            txtCity.Text = "kiTchener";
            txtPhoneNumber.Text = "12321124";
            txtPostalCode.Text = "utu2y3";
            txtUSPostalCode.Text = "54321976";
            txtFirstName.Text = "yuNice";
            txtLastName.Text = "kIm";
        }
    }
}
