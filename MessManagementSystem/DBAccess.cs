using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem
{
    class DBAccess
    {

        // *********************************** INSERTIONS ********************************************

        // insert / add New student to the mess
        public int insertNewStudent(Student std)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.Students.Add(std);
            return mms.SaveChanges();
        }
        public int insertNewAttendenceManager(AttendenceManager std)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.AttendenceManagers.Add(std);
            return mms.SaveChanges();
        }

        public int InsertMeal(Meal meal)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.Meals.Add(meal);
            return mms.SaveChanges();
        }
        //Breakfast Record
        public int InsertBreakFast(Breakfast instance)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.Breakfasts.Add(instance);
            return mms.SaveChanges();
        }
        // Launch Record
        public int InsertLaunch(Launch instance)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.Launches.Add(instance);
            return mms.SaveChanges();
        }

        public int InsertDinner(Dinner instance)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.Dinners.Add(instance);
            return mms.SaveChanges();
        }

        public int InsertMonthlyBill(MonthlyBill instance)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.MonthlyBills.Add(instance);
            return mms.SaveChanges();
        }

        //************************ Mess Expense

        public int insertMessExpense(MessRecord instance)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();
            mms.MessRecords.Add(instance);
            return mms.SaveChanges();
        }

        //********************* END INSERTIONS **************************************************

        public int deleteAttManager(string uname)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            var adm = mms.AttendenceManagers.Where(x => x.UserName == uname).FirstOrDefault();
            if (adm != null)
                mms.AttendenceManagers.Remove(adm);
            return mms.SaveChanges();
        }


        //****************** Update queries ********************************************
        public int UpdateBreakFast(string id ,string unit,string date)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            var adm = mms.Breakfasts.Where(x => x.Room.Equals(id) && x.Date.Equals(date)).FirstOrDefault();
            if (adm != null)
            {
                adm.Unit = unit;
            }
            return mms.SaveChanges();
        }

        public int UpdateLaunch(string id, string unit, string date)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            var adm = mms.Launches.Where(x => x.Room == id && x.Date == date).FirstOrDefault();
            if (adm != null)
            {
                adm.Unit = unit;
            }
            return mms.SaveChanges();
        }

        public int UpdateDinner(string id, string unit, string date)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            var adm = mms.Dinners.Where(x => x.Room == id && x.Date == date).FirstOrDefault();
            if (adm != null)
            {
                adm.Unit = unit;
            }
            return mms.SaveChanges();
        }

        public int UpdateMonthlyBill(string id, string unit, string date)
        {
            MessManagmentSystemEntities mms = new MessManagmentSystemEntities();

            var adm = mms.MonthlyBills.Where(x => x.Room == id && x.Month == date).FirstOrDefault();
            if (adm != null)
            {
                adm.Bill = unit;
            }
            return mms.SaveChanges();
        }


        //*** *************************** Select All *****************
        public List<Meal> SelectAllMeal()
        {
            return new MessManagmentSystemEntities().Meals.ToList();
        }

        public List<Breakfast> SelectAllBreakfast()
        {
            return new MessManagmentSystemEntities().Breakfasts.ToList();
        }

        public List<Launch> SelectAllLaunch()
        {
            return new MessManagmentSystemEntities().Launches.ToList();
        }

        public List<Dinner> SelectAllDinner()
        {
            return new MessManagmentSystemEntities().Dinners.ToList();
        }
        public List<Student> selectRegisteredStudent()
        {
            return new MessManagmentSystemEntities().Students.ToList();
        }

        public List<AttendenceManager> selectRegisteredAttManager()
        {
            return new MessManagmentSystemEntities().AttendenceManagers.ToList();
        }

        public List<MonthlyBill> selectMonthlyBill()
        {
            return new MessManagmentSystemEntities().MonthlyBills.ToList();
        }

        public List<MessRecord> selectMessRecord()
        {
            return new MessManagmentSystemEntities().MessRecords.ToList();
        }
    }
}
