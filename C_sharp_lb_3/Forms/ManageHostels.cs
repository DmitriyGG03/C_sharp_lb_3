﻿

using Hostels;

namespace C_sharp_lb_2.Forms
{

    public partial class ManageHostels : Form
    {
        void Activator(bool val)
        {
            if (val == false)
            {
                tb_studNumber.Text = "";
                tb_stuffNumber.Text = "";
                bt_addStudents.Enabled = false;
                bt_delStudents.Enabled = false;
                bt_addStuff.Enabled = false;
                bt_delStuff.Enabled = false;
            }
            bt_showInfo.Enabled = val;
            bt_addCanteen.Enabled = val;
            gb_calcProfits.Enabled = val;

            tb_studNumber.Enabled = val;
            tb_stuffNumber.Enabled = val;


        }

        Hostel? hostel = null;
        public ManageHostels()
        {
            InitializeComponent();
        }

        private void tb_hostelID_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num) && Campus.FindingHostel(num, out hostel))
            {
                pb_1.ImageLocation = Campus.picOK;
                Activator(true);
            }
            else
            {
                pb_1.ImageLocation = Campus.picDislike;
                Activator(false);
            }
        }

        private void tb_studNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                if (hostel.StudentAmount >= num)
                {
                    bt_delStudents.Enabled = true;
                }
                else bt_delStudents.Enabled = false;
                if (hostel.RoomsNumber * 3 >= num)
                {
                    bt_addStudents.Enabled = true;
                }
                else bt_addStudents.Enabled = false;
                pb_2.ImageLocation = Campus.picOK;
            }
            else
            {
                pb_2.ImageLocation = Campus.picDislike;

                bt_addStudents.Enabled = false;
                bt_delStudents.Enabled = false;
            }
        }

        private void tb_stuffNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                if (hostel.StuffNumber >= num && (hostel.StuffNumber - num) >= 1)
                {
                    bt_delStuff.Enabled = true;
                }
                else
                    bt_delStuff.Enabled = false;
                bt_addStuff.Enabled = true;

                pb_4.ImageLocation = Campus.picOK;
            }
            else
            {
                pb_4.ImageLocation = Campus.picDislike;

                bt_addStuff.Enabled = false;
                bt_delStuff.Enabled = false;
            }
        }

        private void ManageHostels_Load(object sender, EventArgs e)
        {
            Activator(false);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }



        private void bt_addStudents_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_studNumber.Text);
            
            MessageBox.Show($"{amount} студенти/ів були успішно додані до гуртожитку № {hostel.ID}!", "Операція успішна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_studNumber.Text = "";
        }

        private void bt_delStudents_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_studNumber.Text);
            
            MessageBox.Show($"{amount} студенти/ів були успішно видалені з гуртожитку № {hostel.ID}!", "Операція успішна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_studNumber.Text = "";
        }

        private void bt_addStuff_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_stuffNumber.Text);
            
            MessageBox.Show($"{amount} працівників були успішно додані до гуртожитку № {hostel.ID}!", "Операція успішна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_stuffNumber.Text = "";
        }

        private void bt_delStuff_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tb_stuffNumber.Text);
            
            MessageBox.Show($"{amount} працівників були успішно видалені з гуртожитку № {hostel.ID}!", "Операція успішна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostel.CalcProfit();
            tb_stuffNumber.Text = "";
        }

        private void bt_showInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hostel.ToString(), $"Інформація про гуртожиток № {hostel.ID}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_calcProfit_Click(object sender, EventArgs e)
        {
            if(rb_month.Checked) MessageBox.Show($"Місячний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit} грн.", "Місячний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_6month.Checked) MessageBox.Show($"Піврічний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit * 6} грн.", "Піврічний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_year.Checked) MessageBox.Show($"Річний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit * 12} грн.", "Річний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show($"Оберіть період для розрахунку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
