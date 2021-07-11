namespace FEControlsSample
{
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FreeEcho.FEControls.MessageBoxWindow.UseStyle = new System.Uri("pack://application:,,,/ControlsStyle;component/MessageBoxStyle.xaml");

            ImageButton.Click += ImageButton_Click;
            ListBoxItemValidStateButton.Click += ListBoxItemValidStateButton_Click;
            FreeEcho.FEControls.CheckListBoxItem newCheckListBoxItem;
            newCheckListBoxItem = new FreeEcho.FEControls.CheckListBoxItem
            {
                Text = "aaa"
            };
            CheckListBox.Items.Add(newCheckListBoxItem);
            newCheckListBoxItem = new FreeEcho.FEControls.CheckListBoxItem
            {
                Text = "bbb"
            };
            CheckListBox.Items.Add(newCheckListBoxItem);
            CheckListBox.CheckStateChanged += CheckListBox_CheckStateChanged;
            FreeEcho.FEControls.ListBoxItemValidState newListBoxItem;
            newListBoxItem = new FreeEcho.FEControls.ListBoxItemValidState
            {
                Text = "aabb",
                IsValidState = true
            };
            ListBoxItemValidityState.Items.Add(newListBoxItem);
            newListBoxItem = new FreeEcho.FEControls.ListBoxItemValidState
            {
                Text = "aabbcc",
                IsValidState = false
            };
            ListBoxItemValidityState.Items.Add(newListBoxItem);
            NumericUpDown1.ChangeValue += NumericUpDown1_ChangeValue;
            NumericUpDown2.ChangeValue += NumericUpDown2_ChangeValue;
            NumericUpDown3.ChangeValue += NumericUpDown3_ChangeValue;
            ToggleSwitch1.IsOnChange += ToggleSwitch1_ChangeValidity;
            ToggleSwitch2.IsOnChange += ToggleSwitch2_ChangeValidity;
            MessageBoxButton.Click += MessageBoxButton_Click;
        }

        private void ListBoxItemValidStateButton_Click(
            object sender,
            System.Windows.RoutedEventArgs e
            )
        {
            try
            {
                FreeEcho.FEControls.ListBoxItemValidState item = (FreeEcho.FEControls.ListBoxItemValidState)ListBoxItemValidityState.SelectedItem;
                item.IsValidState = !item.IsValidState;
            }
            catch
            {
            }
        }

        private void ImageButton_Click(
            object sender,
            System.Windows.RoutedEventArgs e
            )
        {
            System.Diagnostics.Debug.WriteLine("ImageButtonのClickイベント");
        }

        private void CheckListBox_CheckStateChanged(
            object sender,
            FreeEcho.FEControls.CheckListBoxItemEventArgs eventData
            )
        {
            System.Diagnostics.Debug.WriteLine("CheckedListBoxのチェックが変更された項目：" + eventData.Item.Text);
        }

        private void NumericUpDown1_ChangeValue(
            object sender,
            FreeEcho.FEControls.NumericUpDownChangeValueArgs e
            )
        {
            System.Diagnostics.Debug.WriteLine("NumericUpDown1の値：" + NumericUpDown1.ValueInt);
        }

        private void NumericUpDown2_ChangeValue(
            object sender,
            FreeEcho.FEControls.NumericUpDownChangeValueArgs e
            )
        {
            System.Diagnostics.Debug.WriteLine("NumericUpDown2の値：" + NumericUpDown2.Value);
        }

        private void NumericUpDown3_ChangeValue(
            object sender,
            FreeEcho.FEControls.NumericUpDownChangeValueArgs e
            )
        {
            System.Diagnostics.Debug.WriteLine("NumericUpDown3の値：" + NumericUpDown3.Value);
        }

        private void ToggleSwitch1_ChangeValidity(
            object sender,
            FreeEcho.FEControls.ToggleSwitchEventArgs eventDataArgsSwitchButton
            )
        {
            System.Diagnostics.Debug.WriteLine("SwitchButtonのOn/Off状態：" + (ToggleSwitch1.IsOn ? "On" : "Off"));
            ToggleSwitch2.IsOnDoNotEvent = ToggleSwitch1.IsOn;
        }

        private void ToggleSwitch2_ChangeValidity(
            object sender,
            FreeEcho.FEControls.ToggleSwitchEventArgs e
            )
        {
            System.Diagnostics.Debug.WriteLine("SwitchButton2のOn/Off状態：" + (ToggleSwitch2.IsOn ? "On" : "Off"));
        }

        private void MessageBoxButton_Click(
            object sender,
            System.Windows.RoutedEventArgs e
            )
        {
            FreeEcho.FEControls.MessageBox.Show("タイトル", "メッセージ", FreeEcho.FEControls.MessageBoxButton.YesNo, this);
        }
    }
}
