using SerializerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using ControlsLib;

namespace Практическая8
{
    /// <summary>
    /// Логика взаимодействия для CalendarPage.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
        List<DaySelect> daySelects;

        public CalendarPage(DateTime? startDate = null)
        {
            InitializeComponent();

            daySelects = Serializer.Load<List<DaySelect>>("days.json");
            if (daySelects == null)
            {
                daySelects = new List<DaySelect>();
            }

            if (startDate == null)
            {
                MonthSelect.Text = DateTime.Now.ToString();
            }
            else
            {
                MonthSelect.Text = startDate.ToString();
            }
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(MonthSelect.Text);
            date = date.AddMonths(-1);
            MonthSelect.Text = date.ToString();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(MonthSelect.Text);
            date = date.AddMonths(1);
            MonthSelect.Text = date.ToString();
        }

        private void MonthSelect_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(MonthSelect.Text);
            MonthLabel.Content = date.ToString("MMMM, yyyy");

            UpdateDays();
        }

        private void UpdateDays()
        {
            DateTime month = Convert.ToDateTime(MonthSelect.Text);
            List<CardWithIcon> days = new List<CardWithIcon>();
            int daysInMonth = DateTime.DaysInMonth(month.Year, month.Month);
            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime date = GetDay(i);
                DaySelect? daySelect = daySelects.Find((item) => item.date == date.ToString("dd.MM.yyyy"));

                BitmapImage? image = null;
                if (daySelect != null && daySelect.puncts.Count > 0)
                {
                    Punct punct = daySelect.puncts[0];
                    image = new BitmapImage(new Uri(punct.image, UriKind.Absolute));
                }

                CardWithIcon dayControl = new CardWithIcon(date.Day.ToString(), image);
                days.Add(dayControl);
            }

            DaysList.ItemsSource = days;
        }

        private DateTime GetDay(int day)
        {
            DateTime month = Convert.ToDateTime(MonthSelect.Text);
            return new DateTime(month.Year, month.Month, day);
        }

        private void DaysList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = DaysList.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            int day = index + 1;
            DateTime date = GetDay(day);

            Navigation.ChagePage(new DayInfoPage(date));
        }
    }
}
