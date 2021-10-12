using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    public partial class CalendarForm : Form
    {
        private const int k_NumOfDigitsInMonth = 2;
        private const int k_NumOfDigitsInDay = 2;
        private const int k_IndexOfMonthInString = 3;
        private const int k_IndexOfDayInString = 0;
        private AppManager m_AppManager;
        private DateTime m_LastDateTasksDisplayed;

        public CalendarForm(AppManager i_AppManager)
        {
            InitializeComponent();
            m_AppManager = i_AppManager;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            deleteCheckedTasks();
            clearPreviouslyData();
            fetchBirthdaysOfChosenDate(monthCalendar.SelectionStart.ToShortDateString());
            fetchEventsOfChosenDate(monthCalendar.SelectionStart);
            fetchTasksOfChosenDate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppManager.Calendar.SaveTasksAndDates();
            m_AppManager.AppSettings.TasksInCalendar = m_AppManager.Calendar.m_TasksToRemember;
            m_AppManager.AppSettings.DatesInCalendar = m_AppManager.Calendar.m_DatesToRemember;
            deleteCheckedTasks();
        }

        private void fetchBirthdaysOfChosenDate(string i_Date)
        {
            List<string> friendsList = m_AppManager.Calendar.GetBirthdayFriendsOfTheDay(string.Format("{0}/{1}", i_Date.Substring(k_IndexOfMonthInString, k_NumOfDigitsInMonth), i_Date.Substring(k_IndexOfDayInString, k_NumOfDigitsInDay)));
            foreach (string friendName in friendsList)
            {
                listBoxBirthday.Items.Add(friendName);
            }
        }

        private void fetchEventsOfChosenDate(DateTime i_Date)
        {
            List<string> EventList = m_AppManager.Calendar.GetEventsOfTheDay(i_Date);
            foreach (string eventName in EventList)
            {
                listBoxBirthday.Items.Add(eventName);
            }
        }

        private void fetchTasksOfChosenDate()
        {
            foreach(string task in m_AppManager.Calendar.GetTasksOfTheDay(monthCalendar.SelectionStart))
            {
                checkedListBoxTask.Items.Add(task);
            }

            m_LastDateTasksDisplayed = monthCalendar.SelectionStart;
        }

        private void deleteCheckedTasks()
        {
            foreach(string checkedTask in checkedListBoxTask.CheckedItems)
            {
                m_AppManager.Calendar.RemoveTask(m_LastDateTasksDisplayed.ToShortDateString(), checkedTask);
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if(textBoxAddTask.Text != string.Empty)
            {
                m_AppManager.Calendar.AddTask(monthCalendar.SelectionStart.ToShortDateString(), textBoxAddTask.Text);
                checkedListBoxTask.Items.Add(textBoxAddTask.Text);
                textBoxAddTask.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter a task");
            }
        }

        private void clearPreviouslyData()
        {
            listBoxBirthday.Items.Clear();
            listBoxEvent.Items.Clear();
            checkedListBoxTask.Items.Clear();
        }
    }
}