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
    public partial class FormClerk : Form
    {

        private String monthFrom;
        private String monthTo;
        public FormClerk()
        {
            InitializeComponent();
        }


        // On "Add new Student " A new Form pop ups to register new student
        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {

            try
            {
                Student student = new Student();
                student.Name = txtName.Text;
                student.Room = txtRoom.Text;
                student.RegistrationNumber = txtregNo.Text;
                student.JoinDate = datePickerJoinDate.Text;
                student.LeaveDate = "0";
                if (new DBAccess().insertNewStudent(student) > 0)
                {
                    MessageBox.Show("Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                txtName.Text = null;
                txtRoom.Text = null;
                txtregNo.Text = null;
                LoadStudentData();
            }

        }

        // Close Current Window and Goes to the Main Form
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FormMain.main.Show();
            this.Close();
        }

        public void LoadStudentData()
        {
            try
            {
                Student student = new Student();
                DBAccess daa = new DBAccess();
                List<Student> studentList = daa.selectRegisteredStudent();

                var table = from std in studentList
                            select new
                            {
                                Registration = std.RegistrationNumber,
                                Name = std.Name,
                                Room = std.Room,
                                Joining = std.JoinDate,
                                LeaveDate = std.LeaveDate
                            };
                dataGridViewStudent.DataSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //********** LOAD CLERK FORM **************
        private void FormClerk_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadCompleteMealRecord();
            loadAttendenceManagerList();
            loadMonthlyBill();
            LoadMessExpense();
        }



        //******************** Show List of All Attendence Manager ****************************

        public void loadAttendenceManagerList()
        {

            // Show All Attendence Manager
            try
            {
                // Meal instance = new Meal();
                DBAccess daa = new DBAccess();
                List<AttendenceManager> list = daa.selectRegisteredAttManager();

                var table = from std in list
                            select new
                            {
                                Name = std.Name,
                                Username = std.UserName,
                                Password = std.Password,


                            };
                dataGridViewAttendenceManager.DataSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //************ Load COmplete Record in the complete tab ********************
        public void LoadCompleteMealRecord()
        {
            // Show All Meal Up to date in th grid
            try
            {
                // Meal instance = new Meal();
                DBAccess daa = new DBAccess();
                List<Meal> list = daa.SelectAllMeal();

                var table1 = from std in list
                             select new
                             {
                                 Date = std.Date,
                                 Type = std.Type,
                                 FoodName = std.FoodName,
                                 Unit = std.Unit,

                             };
                dataGridMeal.DataSource = table1.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All breakfast in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Breakfast> list = daa.SelectAllBreakfast();

                var table2 = from std in list
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewBreakfast.DataSource = table2.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All Launch in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Launch> list = daa.SelectAllLaunch();

                var table3 = from std in list
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewLaunch.DataSource = table3.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All Dinner in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Dinner> list = daa.SelectAllDinner();

                var table4 = from std in list
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewDinner.DataSource = table4.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddAttManager_Click(object sender, EventArgs e)
        {
            try
            {
                AttendenceManager instance = new AttendenceManager();
                instance.Name = txtAttName.Text;
                instance.UserName = txtAtUsername.Text;
                instance.Password = txtAttPassword.Text;
                if (new DBAccess().insertNewAttendenceManager(instance) > 0)
                {
                    MessageBox.Show("Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                loadAttendenceManagerList();
            }
        }

        private void btnShowAllRecord_Click(object sender, EventArgs e)
        {
            LoadCompleteMealRecord();
        }

        private void btnSearchAllRecord_Click(object sender, EventArgs e)
        {
            // Show All Meal Up to date in th grid
            try
            {
                // Meal instance = new Meal();
                DBAccess daa = new DBAccess();
                List<Meal> list = daa.SelectAllMeal();

                var table1 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))))
                             select new
                             {
                                 Date = std.Date,
                                 Type = std.Type,
                                 FoodName = std.FoodName,
                                 Unit = std.Unit,

                             };
                dataGridMeal.DataSource = table1.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All breakfast in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Breakfast> list = daa.SelectAllBreakfast();

                var table2 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))))
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewBreakfast.DataSource = table2.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All Launch in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Launch> list = daa.SelectAllLaunch();

                var table3 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))))
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewLaunch.DataSource = table3.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All Dinner in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Dinner> list = daa.SelectAllDinner();

                var table4 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))))
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewDinner.DataSource = table4.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearchStdAllRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Meal instance = new Meal();
                DBAccess daa = new DBAccess();
                List<Meal> list = daa.SelectAllMeal();

                var table1 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))))
                             select new
                             {
                                 Date = std.Date,
                                 Type = std.Type,
                                 FoodName = std.FoodName,
                                 Unit = std.Unit,

                             };
                dataGridMeal.DataSource = table1.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Breakfast> list = daa.SelectAllBreakfast();

                var table2 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))
                             && (std.Room == txtAllRecordStd.Text)))
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewBreakfast.DataSource = table2.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All Launch in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Launch> list = daa.SelectAllLaunch();

                var table3 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))
                             && (std.Room == txtAllRecordStd.Text)))
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewLaunch.DataSource = table3.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Show All Dinner in th grid view


            try
            {
                // Breakfast instance = new Breakfast();
                DBAccess daa = new DBAccess();
                List<Dinner> list = daa.SelectAllDinner();

                var table4 = from std in list
                             where (((std.Date.CompareTo(dateAllRecordFrom.Text) >= 0) && ((std.Date.CompareTo(dateAllRecordTo.Text) <= 0))
                             && (std.Room == txtAllRecordStd.Text)))
                             select new
                             {
                                 Date = std.Date,
                                 Room = std.Room,
                                 Name = std.Name,
                                 Unit = std.Unit,

                             };
                dataGridViewDinner.DataSource = table4.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadMonthlyBill()
        {
            try
            {
                MonthlyBill instance = new MonthlyBill();
                DBAccess daa = new DBAccess();
                List<MonthlyBill> myList = daa.selectMonthlyBill();

                var table = from std in myList
                            select new
                            {
                                BillNO = std.SerialNumber,
                                Month = std.Month,
                                Name = std.Name,
                                Room = std.Room,
                                Bill = std.Bill,
                                UnitRate = std.UnitRate,
                                TotalBill = std.Total,
                                Recieved = std.Recieved,
                            };
                dataGridViewMonthlyBill.DataSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMonthlyBillSearch_Click(object sender, EventArgs e)
        {
            monthConversion();
            try
            {
                MonthlyBill instance = new MonthlyBill();
                DBAccess daa = new DBAccess();
                List<MonthlyBill> myList = daa.selectMonthlyBill();

                var table = from std in myList
                            where (((std.Month.CompareTo(monthFrom) >= 0) && ((std.Month.CompareTo(monthTo) <= 0))
                            && std.Room.Equals(txtMBSearchById.Text)))
                            select new
                            {
                                BillNO = std.SerialNumber,
                                Month = std.Month,
                                Name = std.Name,
                                Room = std.Room,
                                Bill = std.Bill,
                                UnitRate = std.UnitRate,
                                TotalBill = std.Total,
                                Recieved = std.Recieved,
                            };
                dataGridViewMonthlyBill.DataSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void monthConversion()
        {

            monthFrom = dateTimePicker1.Text.Substring(0, 7);
            monthTo = dateTimePicker2.Text.Substring(0, 7);

        }

        private void btnStudentShowAll_Click(object sender, EventArgs e)
        {
            LoadStudentData();
            txtName.Text = null;
            txtRoom.Text = null; ;
            datePickerJoinDate.Text = null;
            datePickerLeaveDate.Text = null;
            txtregNo.Text = null;
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            try
            {

                var adm = mms.Students.Where(x => x.RegistrationNumber == txtregNo.Text).FirstOrDefault();
                if (adm != null)
                {
                    adm.Name = txtName.Text;
                    adm.Room = txtRoom.Text;
                    adm.JoinDate = datePickerJoinDate.Text;
                    adm.LeaveDate = datePickerLeaveDate.Text;
                    MessageBox.Show(" Record Updated");
                }
                else
                    MessageBox.Show("RegNo Cannot Be Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mms.SaveChanges();
                txtName.Text = null;
                txtRoom.Text = null; ;
                datePickerJoinDate.Text = null;
                datePickerLeaveDate.Text = null;
                txtregNo.Text = null;

            }
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DBAccess daa = new DBAccess();
                List<Student> list = daa.selectRegisteredStudent();

                var table1 = from std in list
                             where std.RegistrationNumber.Equals(txtStudentSearchReg.Text)
                             select new
                             {
                                 Registration = std.RegistrationNumber,
                                 Name = std.Name,
                                 Room = std.Room,
                                 Joining = std.JoinDate,
                                 LeaveDate = std.LeaveDate

                             };
                dataGridViewStudent.DataSource = table1.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAttenderSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DBAccess daa = new DBAccess();
                List<AttendenceManager> list = daa.selectRegisteredAttManager();

                var table1 = from std in list
                             where std.UserName.Equals(txtAttenderSearch.Text)
                             select new
                             {
                                 Name = std.Name,
                                 Username = std.UserName,
                                 Password = std.Password,

                             };
                dataGridViewAttendenceManager.DataSource = table1.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewAttendenceManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStudent.Rows[e.RowIndex];
                txtAttName.Text = row.Cells["Name"].Value.ToString();
                txtAtUsername.Text = row.Cells["Username"].Value.ToString();
                txtAttPassword.Text = row.Cells["Password"].Value.ToString();

            }
        }

        private void btnAttShowAll_Click(object sender, EventArgs e)
        {
            txtAttName.Text = null;
            txtAtUsername.Text = null;
            txtAttPassword.Text = null;
            loadAttendenceManagerList();
        }

        private void dataGridViewAttendenceManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAttendenceManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewAttendenceManager.CurrentRow.Selected = true;
                txtAttName.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtAtUsername.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                txtAttPassword.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();

            }

        }

        //private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        dataGridViewStudent.CurrentRow.Selected = true;
        //        txtregNo.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Registration"].FormattedValue.ToString();
        //        txtName.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
        //        txtRoom.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Room"].FormattedValue.ToString();
        //        datePickerJoinDate.Text = dataGridViewAttendenceManager.Rows[e.RowIndex].Cells["Joining"].FormattedValue.ToString();

        //    }

        //}

        private void dataGridViewStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStudent.Rows[e.RowIndex];
                txtregNo.Text = row.Cells["Registration"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtRoom.Text = row.Cells["Room"].Value.ToString();
                datePickerJoinDate.Text = row.Cells["Joining"].Value.ToString();
            }
        }

        private void btnAttDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (new DBAccess().deleteAttManager(txtAtUsername.Text) > 0)
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Not Exist ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                txtAttName.Text = null;
                txtAtUsername.Text = null;
                txtAttPassword.Text = null;
                loadAttendenceManagerList();
            }
        }

        private void btnAttUpdate_Click(object sender, EventArgs e)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            try
            {
                var adm = mms.AttendenceManagers.Where(x => x.UserName == txtAtUsername.Text).FirstOrDefault();
                if (adm != null)
                {
                    adm.Password = txtAttPassword.Text;
                    adm.Name = txtAttName.Text;

                    MessageBox.Show(" Record Updated");
                }
                else
                    MessageBox.Show("Cannot Be Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mms.SaveChanges();
                txtAttName.Text = null;
                txtAtUsername.Text = null;
                txtAttPassword.Text = null;
                loadAttendenceManagerList();

            }
        }

        private void btnMonBillShowAll_Click(object sender, EventArgs e)
        {
            loadMonthlyBill();
        }

        private void btnMBShow_Click(object sender, EventArgs e)
        {
            monthConversion();
            try
            {
                MonthlyBill instance = new MonthlyBill();
                DBAccess daa = new DBAccess();
                List<MonthlyBill> myList = daa.selectMonthlyBill();

                var table = from std in myList
                            where (((std.Month.CompareTo(monthFrom) >= 0) && ((std.Month.CompareTo(monthTo) <= 0))))
                            select new
                            {
                                BillNO = std.SerialNumber,
                                Month = std.Month,
                                Name = std.Name,
                                Room = std.Room,
                                Bill = std.Bill,
                                UnitRate = std.UnitRate,
                                TotalBill = std.Total,
                                Recieved = std.Recieved,
                            };
                dataGridViewMonthlyBill.DataSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void dataGridViewMonthlyBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewMonthlyBill.Rows[e.RowIndex];
                txtMBBillNo.Text = row.Cells["BillNO"].Value.ToString();
            }
        }

        private void btnMBPrint_Click(object sender, EventArgs e)
        {
            int bill = Convert.ToInt32(txtMBBillNo.Text);
            try
            {

                MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

                var table = mms.MonthlyBills.Where(x => x.SerialNumber == bill).FirstOrDefault();
                if (table != null)
                {
                    MessageBox.Show("Bill No : " + table.SerialNumber + "\nName: " + table.Name + "\nMonth: " + table.Month + "\nBill: " + table.Bill);
                }
                else
                    MessageBox.Show("Bill Not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnMBPaid_Click(object sender, EventArgs e)
        {
            int bill = int.Parse(txtMBBillNo.Text);
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            try
            {

                //var adm = mms.MonthlyBills.Where(std => std.SerialNumber.Equals(int.Parse(txtMBBillNo.Text))).FirstOrDefault();
                var adm = mms.MonthlyBills.Where(x => x.SerialNumber == bill).FirstOrDefault();
                if (adm != null)
                {
                    adm.Recieved = adm.Total;
                    mms.SaveChanges();
                    MessageBox.Show("Bill Paid");
                }
                else
                {
                    MessageBox.Show("Bill# not Found");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                loadMonthlyBill();
            }
        }

        private void btnMBApply_Click(object sender, EventArgs e)
        {
            monthConversion();
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            try
            {
                MonthlyBill instance = new MonthlyBill();
                DBAccess daa = new DBAccess();
                List<MonthlyBill> myList = daa.selectMonthlyBill();

                var adm = mms.MonthlyBills.Where(std => std.UnitRate == "-1" && ((std.Month.CompareTo(monthFrom) >= 0) && ((std.Month.CompareTo(monthTo) <= 0)))).ToList();
                foreach (var ad in adm)
                {
                    ad.UnitRate = txtMBBoxUnitRate.Text;
                    ad.Total = (double.Parse(txtMBBoxUnitRate.Text) * double.Parse(ad.Bill)).ToString();
                }
                mms.SaveChanges();
                MessageBox.Show("Bills Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                loadMonthlyBill();
            }
        }

        private void btnMEAdd_Click(object sender, EventArgs e)
        {
          
            try
            {
                MessRecord instance = new MessRecord();
                instance.Month = dateME.Text;
                instance.Expense = txtMEexpense.Text;
                if (new DBAccess().insertMessExpense(instance) > 0)
                {
                    MessageBox.Show("Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                LoadMessExpense();
                dateME.Text = null;
                txtMEexpense.Text = null;
            }
        }

        private void LoadMessExpense()
        {
            try
            {
                //MonthlyBill instance = new MonthlyBill();
                DBAccess daa = new DBAccess();
                List<MessRecord> myList = daa.selectMessRecord();

                var table = from std in myList
                            select new
                            {
                                Month = std.Month,
                                Expense = std.Expense,
                            };
                dataGridViewME.DataSource = table.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnMEcalculate_Click(object sender, EventArgs e)
        {
            double expense=0;
            double collection=0;
            double balance=0;

            string month = dateME.Text.Substring(0, 7);
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            try
            {
                var adm = mms.MessRecords.Where(std => std.Month.Contains(month)).ToList();
                foreach (var ad in adm)
                {
                    expense += double.Parse(ad.Expense);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                var adm = mms.MonthlyBills.Where(std => std.Month.Equals(month)).ToList();
                foreach (var ad in adm)
                {
                    collection += double.Parse(ad.Recieved);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            txtMEex.Text = expense.ToString();
            txtMEcollect.Text = collection.ToString();
            balance = expense - collection;
            txtMEbalance.Text = balance.ToString();

        }


    }
}
