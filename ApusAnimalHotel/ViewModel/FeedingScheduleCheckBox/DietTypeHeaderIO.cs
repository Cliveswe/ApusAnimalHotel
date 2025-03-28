using ApusAnimalHotel.ViewModel.LabelTextBoxIO;
/// <summary>
/// Clive Leddy (6710232551)
///
/// Date 2019-03-15
/// </summary>
namespace ApusAnimalHotel.ViewModel.FeedingScheduleCheckBox
{
    /// <summary>
    /// This class displays an animal diet type by genus.
    /// </summary>
    /// <seealso cref="ApusAnimalHotel.ViewModel.LabelTextBoxIO.TextInputOutput" />
    public class DietTypeHeaderIO : TextInputOutput
    {
        
        public DietTypeHeaderIO(): base(ContentEnumToText.GetContentText(ContentTextEnum.Diet_type))
        {

        }
    }
}
