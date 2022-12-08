
using C_sharp_lb_3;
using Hostels;
using System.Text;

namespace C_sharp_lb_2.Forms
{

    public partial class CampusManagement : Form
    {
        void Activator(bool val)
        {

        }

        Hostel? hostel = null;
        public CampusManagement()
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




        private void bt_showInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hostel.ToString(), $"Інформація про гуртожиток № {hostel.ID}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_calcProfit_Click(object sender, EventArgs e)
        {
            if (rb_month.Checked) MessageBox.Show($"Місячний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit} грн.", "Місячний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_6month.Checked) MessageBox.Show($"Піврічний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit * 6} грн.", "Піврічний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rb_year.Checked) MessageBox.Show($"Річний прибуток гуртожитку № {hostel.ID} становить: {hostel.hostelProfit * 12} грн.", "Річний дохід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show($"Оберіть період для розрахунку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckingStringInputValues(string[] arr)
        {
            foreach (string str in arr)
            {
                if ((str == "" || str is null) && str != tb_st_ID.Text) return false;
            }
            return true;
        }

        private void bt_addStudents_Click(object sender, EventArgs e)
        {
            string[] arrString = new string[8] // Заносимо значення з полів вводу в масив
            {
                tb_st_name.Text,
                tb_st_surname.Text,
                tb_st_patronymic.Text,
                tb_st_faculty.Text,
                tb_st_group.Text,
                tb_st_course.Text,
                tb_st_ID.Text,
                tb_st_sex.Text
            };

            if (CheckingStringInputValues(arrString) && tb_st_sex.Text.Length == 1 && Enum.IsDefined(typeof(Sex), tb_st_sex.Text.ToCharArray()) &&
                Enum.IsDefined(typeof(CourseNumber), Convert.ToInt32(tb_st_course.Text))) // Перевіряємо масив на пусті значення та звіряємо значення 
            {
                Enum.TryParse(tb_st_sex.Text, out Sex s);
                Enum.TryParse(tb_st_course.Text, out CourseNumber c);
                Campus.CampusStudents.Add(new Student(new string[] { tb_st_name.Text, tb_st_surname.Text, tb_st_patronymic.Text }, tb_st_faculty.Text, s, tb_st_group.Text, tb_st_ID.Text, c));

                StringBuilder sb = new StringBuilder();
                sb.Append(Campus.CampusStudents[^1].FullName[2] + " ");
                sb.Append(Campus.CampusStudents[^1].FullName[1] + " ");
                sb.Append(Campus.CampusStudents[^1].FullName[3]);
                MessageBox.Show($"Студент з ім'ям {sb.ToString()}, \nщо вчиться на факультеті {Campus.CampusStudents[^1].Faculty} в групі {Campus.CampusStudents[^1].Group} на {Campus.CampusStudents[^1].Course} курсі був успішно створений. " +
                    $"\nНомер залікової книжки: {Campus.CampusStudents[^1].IDrecordBook}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Перевірте правильність вводу даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
