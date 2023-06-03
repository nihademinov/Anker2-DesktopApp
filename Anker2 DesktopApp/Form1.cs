using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Anker2_DesktopApp
{
    public partial class Form1 : Form
    {

        bool checkChangeButton = false;
        string patternNameAndSurname = @"^[A-Za-z]+$";
        string patternNumber = @"^\+\d{3}\d{3}\d{6}$";
        string patternEmail = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
        List<User> allUsers = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Surname can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (textBoxName.Text == "")
            {
                MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }


            if (textBoxTel.Text == "")
            {
                MessageBox.Show("Phone number can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (!Regex.IsMatch(textBoxSurname.Text, patternNameAndSurname))
            {
                MessageBox.Show("Wrong surname type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (!Regex.IsMatch(textBoxName.Text, patternNameAndSurname))
            {
                MessageBox.Show("Wrong name type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (!Regex.IsMatch(textBoxTel.Text, patternNumber))
            {
                MessageBox.Show("Wrong phone number type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (!Regex.IsMatch(textBoxEmail.Text, patternEmail))
            {
                MessageBox.Show("Wrong email type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }


            if(checkChangeButton && check)
            {
                listBox1.Text = "";
                if (check)
                {
                    string userFileName = textBoxName.Text + ".json";

                    try
                    {
                        using FileStream fs = new FileStream(userFileName, FileMode.Open);
                        MessageBox.Show("File with this name now exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSurname.Text = "";
                        textBoxName.Text = "";
                        textBoxTel.Text = "";
                        dateTimePicker1.Text = "";
                        textBoxEmail.Text = "";
                        fs.Close();

                    }
                    catch (Exception)
                    {
                        using FileStream fs = new FileStream(userFileName, FileMode.Create);
                        fs.Close();
                        User newUser = new User(textBoxSurname.Text, textBoxName.Text, textBoxTel.Text, dateTimePicker1.Text, textBoxEmail.Text);
                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;

                        File.WriteAllText(userFileName, JsonSerializer.Serialize(newUser, options));
                        fs.Close();
                        textBoxSurname.Text = "";
                        textBoxName.Text = "";
                        textBoxTel.Text = "";
                        dateTimePicker1.Text = "";
                        textBoxEmail.Text = "";
                        checkChangeButton = false;

                    }

                }
            }

            if (check && !checkChangeButton)
            {
                string userFileName = textBoxName.Text + ".json";

                try
                {
                    using FileStream fs = new FileStream(userFileName, FileMode.Open);
                    MessageBox.Show("File with this name now exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSurname.Text = "";
                    textBoxName.Text = "";
                    textBoxTel.Text = "";
                    dateTimePicker1.Text = "";
                    textBoxEmail.Text = "";
                    fs.Close();

                }
                catch (Exception)
                {

                    User newUser = new User(textBoxSurname.Text, textBoxName.Text, textBoxTel.Text, dateTimePicker1.Text, textBoxEmail.Text);
                    allUsers.Add(newUser);
                    listBox1.Items.Add(newUser);
                    textBoxSurname.Text = "";
                    textBoxName.Text = "";
                    textBoxTel.Text = "";
                    dateTimePicker1.Text = "";
                    textBoxEmail.Text = "";

                }

            }


        }

        private void buttonSaveListBox_Click(object sender, EventArgs e)
        {
            if (allUsers != null)
            {
                foreach (var item in allUsers)
                {
                    string userName = item.ToString();
                    foreach (var item2 in listBox1.SelectedItems)
                    {
                        if (userName == item2.ToString())
                        {
                            string userFileName = item.Property_Name + ".json";

                            using FileStream fs = new FileStream(userFileName, FileMode.Create);
                            fs.Close();

                            JsonSerializerOptions options = new JsonSerializerOptions();
                            options.WriteIndented = true;

                            File.WriteAllText(userFileName, JsonSerializer.Serialize(item, options));
                            fs.Close();

                        }
                    }
                }

                while (listBox1.SelectedItems.Count > 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
                MessageBox.Show("Your data successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Text File|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string userNameFile = openFileDialog1.FileName;

                string user = File.ReadAllText(userNameFile);
                User? newUser = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(user);

                textBoxSurname.Text = newUser.Property_Surname;
                textBoxEmail.Text = newUser.Property_Email;
                textBoxName.Text = newUser.Property_Name;
                textBoxTel.Text = newUser.Property_Phone;
                dateTimePicker1.Text = newUser.Property_Date;
                textBoxSurname.ReadOnly = true;
                textBoxName.ReadOnly = true;
                textBoxEmail.ReadOnly = true;
                textBoxTel.ReadOnly = true;
                this.dateTimePicker1.Enabled = false;
            }


        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string userFile = textBoxName.Text + ".json";
            File.Delete(userFile);
            checkChangeButton = true;

            textBoxSurname.ReadOnly = false;
            textBoxName.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxTel.ReadOnly = false;
            this.dateTimePicker1.Enabled = true;
        }
    }
}
