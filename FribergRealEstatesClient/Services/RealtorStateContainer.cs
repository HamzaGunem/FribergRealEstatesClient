using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    //Auth Hamza
    public class RealtorStateContainer
    {
        public RealtorFullProfileDto CurrentRealtor { get; private set; }
        public event Action OnChange;

        public void SetRealtor(RealtorFullProfileDto realtor)
        {
            CurrentRealtor = realtor;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
