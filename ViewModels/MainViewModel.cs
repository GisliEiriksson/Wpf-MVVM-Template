using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Wpf_MVVM_Template.Models;

namespace Wpf_MVVM_Template.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public IRelayCommand ShowMessageCommand { get; }

        // No dependency injection - directly create the model instance
        public MainViewModel()
        {
            var messageModel = new MessageModel();
            Message = messageModel.Text;

            ShowMessageCommand = new RelayCommand(ShowMessage);
        }

        private void ShowMessage()
        {
            Message = "You clicked the button!";
        }
    }
}
