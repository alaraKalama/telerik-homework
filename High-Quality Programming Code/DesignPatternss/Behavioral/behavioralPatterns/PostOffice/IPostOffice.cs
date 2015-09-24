namespace PostOfficeObserver
{
    public interface IPostOffice
    {
        void addMailBox(IObserver o);
        void removeMailBox(IObserver o);
        void notifyMailBox();
    }
}