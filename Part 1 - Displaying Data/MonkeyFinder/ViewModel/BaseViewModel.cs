namespace MonkeyFinder.ViewModel;

[INotifyPropertyChanged]
public partial class BaseViewModel 
{
    bool isBusy;
    string title;

    //public bool IsNotBusy => !IsBusy;
}
