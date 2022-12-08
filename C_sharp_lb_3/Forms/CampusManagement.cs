
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
                if (str == "" || str is null) return false;
            }
            return true;
        }

        private bool CheckArrayIDMatchingValues(string ID)
        {
            if (Campus.CampusStudents.Count > 0)
            {
                foreach (Student student in Campus.CampusStudents)
                {
                    if (student.IDrecordBook == ID) return false;
                }
            }
            return true;
        }

        private void bt_addStudents_Click(object sender, EventArgs e)
        {
            string[] arrString = new string[7] // Заносимо значення з полів вводу в масив
            {
                tb_st_name.Text,
                tb_st_surname.Text,
                tb_st_patronymic.Text,
                tb_st_faculty.Text,
                tb_st_group.Text,
                tb_st_course.Text,
                tb_st_sex.Text
            };
            bool ch_ok = true;
            bool id_ok = false;
            char ch = ' ';

            if (tb_st_ID.Text.Length != 0)
                if (tb_st_ID.Text.Length != 8 || !int.TryParse(tb_st_ID.Text, out int num)) MessageBox.Show($"Перевірте правильність вводу ідентифікатора!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!CheckArrayIDMatchingValues(tb_st_ID.Text)) MessageBox.Show($"Такий ідентифікатор вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else id_ok = true;
            else id_ok = true;

            if (tb_st_sex.Text.Length == 1) ch = tb_st_sex.Text[0];
            else ch_ok = false;

            if (CheckingStringInputValues(arrString) && id_ok && ch_ok && Enum.IsDefined(typeof(Sex), (Sex)ch) &&
                Enum.IsDefined(typeof(CourseNumber), Convert.ToInt32(tb_st_course.Text))) // Перевіряємо масив на пусті значення та звіряємо значення 
            {

                Enum.TryParse(tb_st_sex.Text, out Sex s);
                Enum.TryParse(tb_st_course.Text, out CourseNumber c);
                Campus.CampusStudents.Add(new Student(new string[] { tb_st_name.Text, tb_st_surname.Text, tb_st_patronymic.Text }, tb_st_faculty.Text, s, tb_st_group.Text, tb_st_ID.Text, c));

                StringBuilder sb = new StringBuilder();
                sb.Append(Campus.CampusStudents[^1].FullName[1] + " ");
                sb.Append(Campus.CampusStudents[^1].FullName[0] + " ");
                sb.Append(Campus.CampusStudents[^1].FullName[2]);
                MessageBox.Show($"Студент з ім'ям {sb.ToString()}, \nщо вчиться на факультеті {Campus.CampusStudents[^1].Faculty} в групі {Campus.CampusStudents[^1].Group} на {Campus.CampusStudents[^1].Course} курсі був успішно створений. " +
                    $"\nНомер залікової книжки: {Campus.CampusStudents[^1].IDrecordBook}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Перевірте правильність вводу даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_st_add_Click(object sender, EventArgs e)
        {

        }

        private void bt_st_del_Click(object sender, EventArgs e)
        {

        }

        private void bt_st_relocate_Click(object sender, EventArgs e)
        {

        }
    }
}
