using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EDPCalculatorApp
{
    /// <summary>
    /// Interaction logic for Smiley.xaml
    /// </summary>
    public partial class Smiley : Window
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer(); 
        public Smiley()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(lbl_Clock_TextChanged);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    TextBox2.Text = TextBox1.Text;
                    e.Handled = false;
                    break;
            }
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbl_Slider.Content = Math.Floor(e.NewValue).ToString();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Thing 1 is the first thing");
                    break;
                case 1:
                    MessageBox.Show("Thing 2 is the second thing, it is different but not in any meaningful way");
                    break;
                case 2:
                    MessageBox.Show("Thing 3 is also different in no meaningful way, but it show's there's at least two other things!");
                    break;
                case 3:
                    MessageBox.Show("Thing 4 is the final thing, it is similarly different to the previous 3 but is also most likely the longest, this is due to how meta the whole thing is, just a simple developer trying his hardest to be somewhat funny in these trying times.");
                    break;
            }
        }

        private void lbl_Clock_TextChanged(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            lbl_Clock.Content = d.Hour + " : " + d.Minute + " : " + d.Second;
        }
    }
}
