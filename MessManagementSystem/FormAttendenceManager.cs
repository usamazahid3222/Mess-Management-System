using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessManagementSystem
{
    public partial class FormAttendenceManager : Form
    {

        private string mealType;
        private string id;
        private string month;
        private double totl=0;
        private string total="0";
        private string unit = "0";
        MessManagmentSystemEntities mms = new MessManagmentSystemEntities();


        public FormAttendenceManager()
        {
            InitializeComponent();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            //MessSystem manager = new MessSystem();
            //manager.saveToDb(register);
            FormMain.main.Show();
            this.Close();
        }

        /* on Meal Enter button food name, unit , type and date is 
         * added to the database and no changes can be made after enter. */


        private void btnMealEnter_Click(object sender, EventArgs e)
        {

            Meal meal = new Meal();
            DBAccess daa = new DBAccess();
            List<Meal> myList = daa.SelectAllMeal();

            var orderByDescendingResult = (from last in myList
                                           orderby last.SerialNumber descending
                                           select last.SerialNumber).FirstOrDefault();
            int n = orderByDescendingResult;
            n++;


            if (rdBtnBreakFast.Checked == true) { mealType = "BreakFast"; }
            else if (rdBtnLaunch.Checked == true) { mealType = "Launch"; }
            else if (rdBtnDinner.Checked == true) { mealType = "Dinner"; }

            try
            {
                meal.SerialNumber = n;
                meal.Date = dateTimePicker1.Text;
                meal.Type = mealType;
                meal.FoodName = txtFoodName.Text;
                meal.Unit = txtUnit.Text;


                if (new DBAccess().InsertMeal(meal) > 0)
                    MessageBox.Show("Inserted/Locked");
                else
                    MessageBox.Show("Not Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            grpboxMeal.Enabled = false;
        }



        private void btnStudentEnter_Click(object sender, EventArgs e)
        {
            if (rdBtnA.Checked == true) { id = txtRoom.Text + "-A"; }
            else if (rdBtnB.Checked == true) { id = txtRoom.Text + "-B"; }
            else if (rdBtnC.Checked == true) { id = txtRoom.Text + "-C"; }
            else if (rdBtnD.Checked == true) { id = txtRoom.Text + "-D"; }
            Student instance = new Student();
            DBAccess daa = new DBAccess();
            List<Student> myList = daa.selectRegisteredStudent();
            var check = myList.Where(last => last.Room.Equals(id) && last.LeaveDate == "0").FirstOrDefault();
            if (check != null)
            {
                txtStudentName.Text = check.Name;
                enterStudentAttendence();
            }
            else 
            {
                MessageBox.Show("This Student is not Registerd");
            }
        }


        private void enterStudentAttendence()
        {
            totl = (double.Parse(txtQuantity.Text) * double.Parse(txtUnit.Text)) + double.Parse(txtAdCharges.Text) ;
            total = totl.ToString();
            unit = ((double.Parse(txtQuantity.Text) * double.Parse(txtUnit.Text)) + double.Parse(txtAdCharges.Text)).ToString();

            if (mealType == "BreakFast")
            {
                Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Breakfast> myList = daa.SelectAllBreakfast();

                var orderByDescendingResult = (from last in myList
                                               orderby last.SerialNumber descending
                                               select last.SerialNumber).FirstOrDefault();
                int n = orderByDescendingResult;
                n++;

                var check = myList.Where(last => last.Room.Equals(id) && last.Date.Equals(dateTimePicker1.Text)).FirstOrDefault();

                

                if (check != null)
                {
                    total = (double.Parse(total) + double.Parse(check.Unit)).ToString();
                    
                    try
                    {
                        if (new DBAccess().UpdateBreakFast(id, total, dateTimePicker1.Text) > 0)
                            MessageBox.Show("update");
                        else
                            MessageBox.Show("Not updated ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                   
                    try
                    {
                        instance.SerialNumber = n;
                        instance.Date = dateTimePicker1.Text;
                        instance.Room = id;
                        instance.Name = txtStudentName.Text;
                        instance.Unit = total;


                        if (new DBAccess().InsertBreakFast(instance) > 0)
                            MessageBox.Show("Inserted/Locked");
                        else
                            MessageBox.Show("Not Inserted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                updateMonthlyBill(unit);
            }

            else if (mealType == "Launch")
            {
                Launch instance = new Launch();
                DBAccess daa = new DBAccess();
                List<Launch> myList = daa.SelectAllLaunch();

                var orderByDescendingResult = (from last in myList
                                               orderby last.SerialNumber descending
                                               select last.SerialNumber).FirstOrDefault();
                int n = orderByDescendingResult;
                n++;
                var check = myList.Where(last => last.Room.Equals(id) && last.Date.Equals(dateTimePicker1.Text)).FirstOrDefault();


                if (check != null)
                {
                    total = (double.Parse(total) + double.Parse(check.Unit)).ToString();
                    try
                    {
                       // check.Unit = unit;
                        if (new DBAccess().UpdateLaunch(id, total, dateTimePicker1.Text) > 0)
                            MessageBox.Show("update");
                        else
                            MessageBox.Show("Not updated ");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        instance.SerialNumber = n;
                        instance.Date = dateTimePicker1.Text;
                        instance.Room = id;
                        instance.Name = txtStudentName.Text;
                        instance.Unit = total;


                        if (new DBAccess().InsertLaunch(instance) > 0)
                            MessageBox.Show("Inserted/Locked");
                        else
                            MessageBox.Show("Not Inserted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                updateMonthlyBill(unit);
            }
            else if (mealType == "Dinner")
            {
                Dinner instance = new Dinner();
                DBAccess daa = new DBAccess();
                List<Dinner> myList = daa.SelectAllDinner();

                var orderByDescendingResult = (from last in myList
                                               orderby last.SerialNumber descending
                                               select last.SerialNumber).FirstOrDefault();
                int n = orderByDescendingResult;
                n++;
                var check = myList.Where(last => last.Room.Equals(id) && last.Date.Equals(dateTimePicker1.Text)).FirstOrDefault();
                if (check != null)
                {
                    total = (double.Parse(total) + double.Parse(check.Unit)).ToString();
                    try
                    {
                       // check.Unit = unit;
                        if (new DBAccess().UpdateDinner(id, total, dateTimePicker1.Text) > 0)
                            MessageBox.Show("update");
                        else
                            MessageBox.Show("Not updated");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        instance.SerialNumber = n;
                        instance.Date = dateTimePicker1.Text;
                        instance.Room = id;
                        instance.Name = txtStudentName.Text;
                        instance.Unit = total;


                        if (new DBAccess().InsertDinner(instance) > 0)
                            MessageBox.Show("Inserted/Locked");
                        else
                            MessageBox.Show("Not Inserted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                updateMonthlyBill(unit);
            }
            txtStudentName.Text = null;
            txtRoom.Text = null;
            txtAdCharges.Text = "0";
            txtQuantity.Text = "0";
            LoadData();
        }

        private void updateMonthlyBill(string puni)
        {

            month = dateTimePicker1.Text.Substring(0, 7);

            MonthlyBill instance = new MonthlyBill();
            DBAccess daa = new DBAccess();
            List<MonthlyBill> myList = daa.selectMonthlyBill();

            var orderByDescendingResult = (from last in myList
                                           orderby last.SerialNumber descending
                                           select last.SerialNumber).FirstOrDefault();
            int n = orderByDescendingResult;
            n++;

            var check = myList.Where(last => last.Room.Equals(id) && last.Month.Equals(month)).LastOrDefault();

            if (check != null)
            {

                puni = (double.Parse(check.Bill) + double.Parse(puni)).ToString();
                try
                {
                    if (new DBAccess().UpdateMonthlyBill(id, puni, month) > 0)
                        MessageBox.Show(" bill update");
                    else
                        MessageBox.Show("Not updated ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    instance.SerialNumber = n;
                    instance.Month = month;
                    instance.Room = id;
                    instance.Name = txtStudentName.Text;
                    instance.Bill = puni;
                    instance.Recieved = "0";
                    instance.UnitRate = "-1";


                    if (new DBAccess().InsertMonthlyBill(instance) > 0)
                        MessageBox.Show("bill Inserted/Locked");
                    else
                        MessageBox.Show(" bill Not Inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            totl = 0;
            total = "0";
            unit = "0";
        }

        private void LoadData()
        {
            try
            {
                Breakfast breakfast = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Breakfast> breakFastList = daa.SelectAllBreakfast();

                Launch launch = new Launch();
                List<Launch> launchList = daa.SelectAllLaunch();

                Dinner dinner = new Dinner();
                List<Dinner> DinnerList = daa.SelectAllDinner();


                var table1 = from b in breakFastList
                             orderby b.Room
                             where b.Date.Equals(dateTimePicker1.Text)
                             select new
                            {
                                Room = b.Room,
                                UserName = b.Name,
                                Unit = b.Unit

                            };
                dataGridViewBreakFast.DataSource = table1.ToList();


                var table2 = from b in launchList // outer sequence
                             orderby b.Room
                             where b.Date.Equals(dateTimePicker1.Text)
                             select new
                             {
                                 Room = b.Room,
                                 UserName = b.Name,
                                 Unit = b.Unit
                             };
                dataGridViewLaunch.DataSource = table2.ToList();

                var table3 = from b in DinnerList // outer sequence
                             orderby b.Room
                             where b.Date.Equals(dateTimePicker1.Text)
                             select new
                             {
                                 Room = b.Room,
                                 UserName = b.Name,
                                 Unit = b.Unit

                             };
                dataGridViewDinner.DataSource = table3.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void FormAttendenceManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }


    }

}

