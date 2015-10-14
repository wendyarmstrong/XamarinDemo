using Xamarin;
using Xamarin.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XamarinDemo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
			messageText = "Hello World MVVM";

			ButtonClickCommand = new RelayCommand( 
				ExecuteButtonCommand, 
				CanExecuteCommand); 
            
        }
		/// <summary>
		/// Relay Command is a type which implements the ICommand Interface. It is a wrapper for an action.
		/// 
		/// Very useful when binding to views which depend on state e.g IsVisible and IsEnabled
		/// </summary>
		/// <value>The button click.</value>

		public RelayCommand ButtonClickCommand
		{

			get; 
			private set; 
		}

		private bool CanExecuteCommand()
		{
			return true;
		}

		private async void ExecuteButtonCommand() 
		{
			if(messageText  == "Hello World MVVM")
			{
				MessageText = "Hoorah! Button Pressed! ";
			}
			else
			{
				MessageText  = "Hello World MVVM";	
			}
		}

		private string messageText;
		public string MessageText 
		{
			get{ return messageText;}
			set
			{
				if(messageText != value)
				{
					messageText = value;
					RaisePropertyChanged("MessageText");
				}
			}
		}
    }
}