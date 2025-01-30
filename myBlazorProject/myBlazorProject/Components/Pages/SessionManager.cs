using BlazorEventCardExample.Models;

namespace BlazorEventCardExample.Services
{
    public class SessionManager
    {
        private RegistrationModel? _currentUser;

        public event Action? OnUserChanged;

        // Get the current user
        public RegistrationModel? CurrentUser => _currentUser;

        // Set the user in session (in-memory)
        public async Task SetUserAsync(RegistrationModel user)
        {
            _currentUser = user;
            NotifyUserChanged();
            await Task.CompletedTask;
        }

        // Clear the user (logout scenario)
        public async Task ClearUserAsync()
        {
            _currentUser = null;
            NotifyUserChanged();
            await Task.CompletedTask;
        }

        private void NotifyUserChanged() => OnUserChanged?.Invoke();
    }
}
