using System;

namespace SwarmAthon.UI.ViewModels
{
    public class BaseViewModel
    {
        public virtual void LoadData()
        {
            OnDataLoaded();
        }

        public event EventHandler<EventArgs> DataLoaded;

        public void OnDataLoaded()
        {
            this.DataLoaded?.Invoke(this, new EventArgs());
        }
    }
}