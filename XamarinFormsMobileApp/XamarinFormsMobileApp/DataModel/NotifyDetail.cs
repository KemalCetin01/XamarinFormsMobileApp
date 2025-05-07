using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinFormsMobileApp.Enums;

namespace XamarinFormsMobileApp.DataModel
{
    public class NotifyDetail : INotifyPropertyChanged
    {
        public static ObservableCollection<NotifyDetail> List = new ObservableCollection<NotifyDetail>();

        private string _imageUrl;
        private string _name;
        private string _course;
        private string _emailAdd;
        private string _mobileNumber;
        private string _password;
        private string _remarks;
        private string _status;
        private MessageTypeEnum _messageType;
        private NotifyTypeEnum _notifyType;
        public NotifyDetail()
        {
            
        }
        public NotifyDetail(
             string imageUrl,
             string name,
             string course,
             string emailAdd,
             string mobileNumber,
             string password,
             string remarks,
             string status,
             MessageTypeEnum messageType,
             NotifyTypeEnum notifyType)
        {
            _imageUrl = imageUrl;
            _name = name;
            _course = course;
            _emailAdd = emailAdd;
            _mobileNumber = mobileNumber;
            _password = password;
            _remarks = remarks;
            _status = status;
            _messageType = messageType;
            _notifyType = notifyType;
        }


        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                if (_imageUrl != value)
                {
                    _imageUrl = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Course
        {
            get => _course;
            set
            {
                if (_course != value)
                {
                    _course = value;
                    OnPropertyChanged();
                }
            }
        }

        public string EmailAdd
        {
            get => _emailAdd;
            set
            {
                if (_emailAdd != value)
                {
                    _emailAdd = value;
                    OnPropertyChanged();
                }
            }
        }

        public string MobileNumber
        {
            get => _mobileNumber;
            set
            {
                if (_mobileNumber != value)
                {
                    _mobileNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Remarks
        {
            get => _remarks;
            set
            {
                if (_remarks != value)
                {
                    _remarks = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }
        }

        public MessageTypeEnum MessageType
        {
            get => _messageType;
            set
            {
                if (_messageType != value)
                {
                    _messageType = value;
                    OnPropertyChanged();
                }
            }
        }

        public NotifyTypeEnum NotifyType
        {
            get => _notifyType;
            set
            {
                if (_notifyType != value)
                {
                    _notifyType = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
