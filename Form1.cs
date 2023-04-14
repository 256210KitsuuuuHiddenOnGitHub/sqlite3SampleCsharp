using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace sqlite3Test
{
    public partial class Form1 : Form
    {
        //FileName, find on Root Directory (H:\C#sauceCode\sqlite3Test\sqlite3Test\bin\Debug\net6.0-windows) <- Example of My root Directory
        public const String nameFile = "nameOfDatabase.sqlite";
        public const String connection = "Data Source=nameOfDatabase.sqlite;Version=3;";
        //Ready Connection
        SQLiteConnection db;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                //Create File Connection
                SQLiteConnection.CreateFile(nameFile);
                db = new SQLiteConnection(connection);
                //Open Connection
                db.Open();

                //Command of Table Making
                String query = "CREATE TABLE Start(studID int PRIMARY KEY, name VARCHAR(20))";

                //Execute Command
                //Logic is, Ready up Query Commands then insert command, then second, the target connection
                SQLiteCommand queryCommand = new SQLiteCommand(query, db);
                queryCommand.ExecuteNonQuery();

                //Close Connection, Save Memory
                db.Close();
                label4.Text = "Status: Database Created !";
            }
            catch (Exception ex)
            {
                label4.Text = "Status : DataBase Already Created !";
            }
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete Database File
                if (File.Exists(nameFile))
                {
                    File.Delete(nameFile);
                    label4.Text = "Status: Database Deleted !";
                }
            }
            catch (Exception ex)
            {
                label4.Text = "Status : Database Doesnt Exist!";
            }
        }

        private void btnSubmitSQL_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Content
                String getName = txtBoxName.Text.ToString();
                String getStudentID = txtBoxSID.Text.ToString();

                //open Connection
                db = new SQLiteConnection(connection);
                db.Open();

                //Query Command
                String query = "INSERT INTO Start VALUES(@SID,@SNAME);";
                SQLiteCommand queryCommand = new SQLiteCommand(query, db);
                //AddWithValue() is Easiest Way than Add()
                queryCommand.Parameters.AddWithValue("@SNAME", getName);
                queryCommand.Parameters.AddWithValue("@SID", int.Parse(getStudentID));
                //Execute and Close Connection
                queryCommand.ExecuteNonQuery();
                db.Close();
                label4.Text = "Status: Data Submitted";
            }
            catch (Exception ex)
            {
                label4.Text = "Status : Duplicate Primary Keys, Cant add Further!\nor Empty String!";
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            //Open Connection
            db = new SQLiteConnection(connection);
            db.Open();

            //Query Command, Get Data by DataSet (dataView Cant Enter SQLITE 3)
            String query = "SELECT * FROM Start";
            SQLiteDataAdapter sdp = new SQLiteDataAdapter(query, db);
            DataSet dp = new DataSet();

            //Then Insert in DataGridView and Close
            sdp.Fill(dp, "Start");
            dViewDB.DataSource = dp.Tables["Start"];
            db.Close();
        }
    }
}
