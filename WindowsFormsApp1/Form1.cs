using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string _DBPathFile; // path to SQLite database
        private string _DBPathSave;
        private string[] _buffer; // буфер для хранениязберігання строк таблиці при її зміні
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hello world", "Information window", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                // звернення до функцій form1 в класі якого ми знаходимось
                this.Close();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        /////////////////// TOOL STRIP MENU
        /// Open file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "SQLite files (*.sqlite)|*.sqlite|All files(*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _DBPathFile = openFileDialog1.FileName;
                DBPathFileName.ForeColor = Color.Green;
                DBPathFileName.Text = _DBPathFile;
            }

            string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mydatabase.sqlite");
            // C: \Users\Oleksii\source\repos\WindowsFormsApp1_my\WindowsFormsApp1
            //if (!File.Exists(pathToFile)) // якщо файл не існує
            if (!File.Exists(_DBPathFile)) // якщо файл не існує
            {
                //SQLiteConnection.CreateFile(pathToFile);
                SQLiteConnection.CreateFile(_DBPathFile);
            }
            string connectionString = $"DataSource = {_DBPathFile}; Version=3;";
            //string connectionString = $"DataSource = {pathToFile}; Version=3;";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();

            // Створення файлу в директорії проекту
            string createStudentsTableQuery = " CREATE TABLE IF NOT EXISTS students (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name varchar(24), age int)";
            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStudentsTableQuery, sQLiteConnection);
            sQLiteCommand.ExecuteNonQuery();

            // заповнення БД
            /*SQLiteCommand sQLiteCommandAddStudent;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                string insertStudentTableQuery = $"INSERT INTO students (name, age) VALUES ('Alex_{i + 1}', {random.Next(15, 36)})";
                sQLiteCommandAddStudent = new SQLiteCommand(insertStudentTableQuery, sQLiteConnection);
                sQLiteCommandAddStudent.ExecuteNonQuery();
            }*/

            // ***********Вивід інформації з БД в dataGridViewStudent******
            string selectStudentTableQuery = "SELECT * FROM students";

            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStudent.ColumnCount = 3;
            // 1-й стовпчик
            dataGridViewStudent.Columns[0].Name = "#";
            dataGridViewStudent.Columns[0].ReadOnly = true;
            // 2 та 3 стовпчик
            dataGridViewStudent.Columns[1].Name = "Name";
            dataGridViewStudent.Columns[2].Name = "Age";

            SQLiteCommand sQLiteCommandSelectStudents = new SQLiteCommand(selectStudentTableQuery, sQLiteConnection);
            SQLiteDataReader studentsReader = sQLiteCommandSelectStudents.ExecuteReader();

            int counter = 0;
            foreach (DbDataRecord student in studentsReader)
            {
                string[] oneRow = new string[dataGridViewStudent.ColumnCount];
                for (int i = 0; i < student.FieldCount; i++)
                {
                    if (i == 0)
                    {
                        oneRow[i] = (++counter).ToString();
                    }
                    else
                    {
                        oneRow[i] = student.GetValue(i).ToString();
                    }
                }
                dataGridViewStudent.Rows.Add(oneRow);
            }
            sQLiteConnection.Close();


        }
        /// Save file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog1.Filter = "SQLite files (*.sqlite)|*.sqlite|All files(*.*)|*.*";
            saveFileDialog1.FileName = "sqliteDB";
            _DBPathSave = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, saveFileDialog1.FileName = "sqliteDB");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                if (!File.Exists(_DBPathSave)) // якщо файл не існує
                {
                    SQLiteConnection.CreateFile(_DBPathSave);
                }
                else
                {
                    MessageBox.Show("File with this name exists. Rename File", "Information window", 0, MessageBoxIcon.Warning);
                }
                string connectionString = $"DataSource = {_DBPathSave}; Version=3;";
                
                //if (MessageBox.Show("File saved!", "Information window", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                //{
               //     this.Close();
               // }
                //_DBPathFile = saveFileDialog1.FileName;
                //DBPathFileName.ForeColor = Color.Green;
                //DBPathFileName.Text = _DBPathFile;
            }
            else { return; }
        }



        /////////////////// BUTTONS///////////////////////
        /// Add student button
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            //string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mydatabase.sqlite");
            string connectionString = $"DataSource = {_DBPathFile}; Version=3;";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();

            SQLiteCommand sQLiteCommandAddStudent;
            // Додавання в БД нового студента
            string insertStudentTableQuery = $"INSERT INTO students (name, age) VALUES (\'{textBox_name.Text}\', {textBox_age.Text})";
            sQLiteCommandAddStudent = new SQLiteCommand(insertStudentTableQuery, sQLiteConnection);
            sQLiteCommandAddStudent.ExecuteNonQuery();
            string[] oneRow = new string[dataGridViewStudent.ColumnCount];
            oneRow[0] = (dataGridViewStudent.Rows.Count).ToString();
            oneRow[1] = textBox_name.Text;
            oneRow[2] = textBox_age.Text;
            // очистка textBox
            textBox_name.Clear();
            textBox_age.Clear();
            dataGridViewStudent.Rows.Add(oneRow);
            sQLiteConnection.Close();

        }
        /// Delete student button
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (textBox_delete.Text.Length > 0)
            {
                bool check = false;
                for (int i = 0; i < dataGridViewStudent.Rows.Count - 1; i++)
                {
                    if (textBox_delete.Text == dataGridViewStudent[0, i].Value.ToString())
                    {
                        check = true;
                        string connectionString = $"DataSource={_DBPathFile}; Version=3";
                        SQLiteConnection sQLiteConnection2 = new SQLiteConnection(connectionString);
                        sQLiteConnection2.Open();
                        //string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mydatabase.sqlite");
                        //string connectionString = $"DataSource = {pathToFile}; Version=3;";
                        //SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
                        //sQLiteConnection.Open();


                        SQLiteCommand sQLiteCommandDeleteStudent;
                        string deleteStudentTableQuery = $"DELETE FROM students WHERE name = \'{dataGridViewStudent[1, i].Value.ToString()}\' AND age = \'{dataGridViewStudent[2, i].Value.ToString()}\'";
                        sQLiteCommandDeleteStudent = new SQLiteCommand(deleteStudentTableQuery, sQLiteConnection2);
                        sQLiteCommandDeleteStudent.ExecuteNonQuery();
                        dataGridViewStudent.Rows.RemoveAt(i);
                        textBox_delete.Clear();
                        //dataGridViewStudent.Show();
                        sQLiteConnection2.Close();

                    }
                }
                // Перевірка введеного id
                if (!check) MessageBox.Show("Error! Incorect input id number :( ");
            }
            else
            {
                MessageBox.Show("Please, input id number to delete!");
            }
        }

        
    }
}
