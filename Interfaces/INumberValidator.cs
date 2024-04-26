namespace Otus_HW10_SOLID.Interfaces
{
    public interface INumberValidator
    {
        bool IsValid();
        bool CompareNumber(int checkNumber);
        void SetNumber(int randomNumber);
    }
}
