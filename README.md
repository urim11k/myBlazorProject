# myBlazorProject

How Copilot Assisted Each Step
Scaffolding the Project

Copilot suggested boilerplate code for creating a new Blazor project and typical folder structures (e.g., Pages, Shared, Services, Models).
Registration Form & Validation

Copilot auto-completed RegistrationModel properties and Data Annotations (e.g., [Required], [EmailAddress]) as soon as you typed public string? Email { get; set; } and started adding attributes.
When building the RegistrationForm.razor page, Copilot offered snippet suggestions for <EditForm> usage with <DataAnnotationsValidator>.
Session Manager / State Management

Copilot suggested typical patterns for an in-memory store, including a private field (_currentUser), a public read-only property (CurrentUser), and event handling (OnUserChanged) as soon as you typed “in-memory user session.”
It also completed the SetUserAsync and ClearUserAsync methods with simple await Task.CompletedTask.
Attendance Tracker

Copilot recognized the pattern for “Add attendee” from typed code hints—offering a pre-written AddAttendee() method that checks for non-empty input.
It also suggested using <input type="checkbox" @bind="..." /> inside the @foreach loop for the IsPresent property, streamlining the markup.
Putting It All Together

Throughout the process, Copilot provided inline suggestions for navigating between pages (NavigationManager.NavigateTo(...)), structuring <ul> and <li> lists, and writing typical console or comment placeholders (e.g., “// Example only: typically call a backend to store in a DB”).
