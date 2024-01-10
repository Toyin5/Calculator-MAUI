using System;
using System.Data;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            var buttonText = ((Button)sender).Text;
            entry.Text += buttonText;
        }

        private void Submit(object sender, EventArgs e)
        {
            Solve();
        }

        private void Solve()
        {
            var text = entry.Text;
            var ans = Convert.ToDecimal(new DataTable().Compute(text, null));
            entry.Text = ans.ToString();

        }

        private void Delete(object sender, EventArgs e)
        {
            if (entry.Text.Length == 0)
            {
                return;
            }
            entry.Text = entry.Text.Substring(0, entry.Text.Length - 1);
        }
        private void OnEntryCompleted(object sender, EventArgs e)
        {
            Solve();
        }

    }
}