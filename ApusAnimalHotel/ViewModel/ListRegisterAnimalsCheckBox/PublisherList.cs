using ApusAnimalHotel.ViewModel.GroupListBoxIO;
/// <summary>
///
///
/// Date 2019-03-11  
/// </summary>
namespace ApusAnimalHotel.ViewModel.ListRegisterAnimalsCheckBox
    {
    interface PublisherList
        {
        void Attach(Observer observer);
        AnimalSubscription GetState();
        void NotifyAllObservers();
        }
    }
